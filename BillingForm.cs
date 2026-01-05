using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;


namespace HospitalMS
{
    public partial class BillingForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-26A9125\SQLEXPRESS;Initial Catalog=dotnetnov;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        public BillingForm()
        {
            InitializeComponent();
        }

        private void CalculateTotal()
        {
            decimal c = string.IsNullOrEmpty(txtbfcf.Text) ? 0 : Convert.ToDecimal(txtbfcf.Text);
            decimal m = string.IsNullOrEmpty(txtbfmc.Text) ? 0 : Convert.ToDecimal(txtbfmc.Text);
            decimal t = string.IsNullOrEmpty(txtbftc.Text) ? 0 : Convert.ToDecimal(txtbftc.Text);

            txtbfta.Text = (c + m + t).ToString();
        }

        private void LoadPatients()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT PatientID, Name FROM Patients", con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbbfpt.DataSource = dt;
            cmbbfpt.DisplayMember = "Name";
            cmbbfpt.ValueMember = "PatientID";
        }

        private void LoadDoctors()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT DoctorId, Name FROM Doctors", con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbbfdc.DataSource = dt;
            cmbbfdc.DisplayMember = "Name";
            cmbbfdc.ValueMember = "DoctorId";

            con.Close();
        }

       

        private void LoadBilling()
        {
            con.Open();

            SqlDataAdapter da = new SqlDataAdapter("pr_Billing", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@Action", "SELECT");

            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvbf.AutoGenerateColumns = true;
            dgvbf.DataSource = dt;

            con.Close();
        }

        private void btnbfclr_Click(object sender, EventArgs e)
        {
            txtbfbid.Clear();
            cmbbfpt.SelectedIndex = -1;
            cmbbfdc.SelectedIndex = -1;
            cmbbfap.SelectedIndex = -1;
            txtbfcf.Clear();
            txtbfmc.Clear();
            txtbftc.Clear();
            txtbfta.Clear();
        }

        private void dgvbf_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txtbfbid.Text = dgvbf.Rows[e.RowIndex].Cells["BillID"].Value.ToString();

            int patientId = Convert.ToInt32(dgvbf.Rows[e.RowIndex].Cells["PatientID"].Value);
            int doctorId = Convert.ToInt32(dgvbf.Rows[e.RowIndex].Cells["DoctorID"].Value);
            int appointmentId = Convert.ToInt32(dgvbf.Rows[e.RowIndex].Cells["AppointmentID"].Value);

            cmbbfpt.SelectedValue = patientId;
            cmbbfdc.SelectedValue = doctorId;
            LoadAppointmentsByPatient(patientId);
            cmbbfap.SelectedValue = appointmentId;

            txtbfcf.Text = dgvbf.Rows[e.RowIndex].Cells["ConsultationFee"].Value.ToString();
            txtbfmc.Text = dgvbf.Rows[e.RowIndex].Cells["MedicineCharges"].Value.ToString();
            txtbftc.Text = dgvbf.Rows[e.RowIndex].Cells["TestCharges"].Value.ToString();
            txtbfta.Text = dgvbf.Rows[e.RowIndex].Cells["TotalAmount"].Value.ToString();
        }

        private void LoadAppointmentsByPatient(int patientId)
        {
            SqlCommand cmd = new SqlCommand("sp_Get_Appointments_By_Patient", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PatientID", patientId);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbbfap.DataSource = dt;
            cmbbfap.DisplayMember = "AppointmentDate";
            cmbbfap.ValueMember = "AppID";
        }

        private void BillingForm_Load(object sender, EventArgs e)
        {
            LoadPatients();
            LoadDoctors();
            LoadBilling();
        }

        private void btngpdf_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbbfpt.SelectedIndex == -1 ||
                    cmbbfdc.SelectedIndex == -1 ||
                    cmbbfap.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select Patient, Doctor and Appointment");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtbfta.Text))
                {
                    MessageBox.Show("Total Amount is empty");
                    return;
                }
                string patientName = cmbbfpt.Text;
                string doctorName = cmbbfdc.Text;
                string appointmentDate = cmbbfap.Text;

                decimal consultationFee = Convert.ToDecimal(txtbfcf.Text);
                decimal medicineCharges = Convert.ToDecimal(txtbfmc.Text);
                decimal testCharges = Convert.ToDecimal(txtbftc.Text);
                decimal totalAmount = Convert.ToDecimal(txtbfta.Text);

                DateTime billDate = dtpbf.Value;

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF Files (*.pdf)|*.pdf";
                sfd.FileName = $"Bill_{patientName}_{DateTime.Now:yyyyMMddHHmmss}.pdf";

                if (sfd.ShowDialog() != DialogResult.OK)
                    return;

                Document doc = new Document(PageSize.A4, 40, 40, 40, 40);
                PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
                doc.Open();

                iTextSharp.text.Font titleFont =
                    FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18);

                iTextSharp.text.Font headerFont =
                    FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);

                iTextSharp.text.Font textFont =
                    FontFactory.GetFont(FontFactory.HELVETICA, 11);

                Paragraph title = new Paragraph("HOSPITAL MANAGEMENT SYSTEM\n\n", titleFont);
                title.Alignment = Element.ALIGN_CENTER;
                doc.Add(title);

                doc.Add(new Paragraph($"Patient Name : {patientName}", textFont));
                doc.Add(new Paragraph($"Doctor Name  : {doctorName}", textFont));
                doc.Add(new Paragraph($"Appointment Date  : {appointmentDate}", textFont));
                doc.Add(new Paragraph($"Bill Date    : {billDate:dd-MM-yyyy}", textFont));
                doc.Add(new Paragraph("\n"));

                PdfPTable table = new PdfPTable(2);
                table.WidthPercentage = 100;
                table.SetWidths(new float[] { 70f, 30f });

                table.AddCell(new PdfPCell(new Phrase("Description", headerFont)));
                table.AddCell(new PdfPCell(new Phrase("Amount", headerFont)));

                table.AddCell("Consultation Fee");
                table.AddCell(consultationFee.ToString("0.00"));

                table.AddCell("Medicine Charges");
                table.AddCell(medicineCharges.ToString("0.00"));

                table.AddCell("Test Charges");
                table.AddCell(testCharges.ToString("0.00"));

                table.AddCell(new PdfPCell(new Phrase("Total Amount", headerFont)));
                table.AddCell(new PdfPCell(new Phrase(totalAmount.ToString("0.00"), headerFont)));

                doc.Add(table);

                // 🙏 Footer
                Paragraph footer = new Paragraph("\nThank you for visiting!", textFont);
                footer.Alignment = Element.ALIGN_CENTER;
                doc.Add(footer);

                doc.Close();

                // ✅ Success
                MessageBox.Show("Bill generated and saved successfully!", "PDF Created");

                // 📂 Open PDF
                System.Diagnostics.Process.Start(sfd.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("PDF Error: " + ex.Message);
            }
        }

        private void cmbbfpt_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbbfpt.SelectedValue == null) return;

            int patientId = Convert.ToInt32(cmbbfpt.SelectedValue);

            SqlCommand cmd = new SqlCommand(
                "sp_Get_Appointments_By_Patient", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PatientID", patientId);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbbfap.DataSource = dt;
            cmbbfap.DisplayMember = "AppointmentDate";
            cmbbfap.ValueMember = "AppID";
        }

        private void btnbfdlt_Click(object sender, EventArgs e)
        {
            if (txtbfbid.Text == "") return;

            SqlCommand cmd = new SqlCommand("pr_Billing", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Action", "DELETE");
            cmd.Parameters.AddWithValue("@BillID", txtbfbid.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            LoadBilling();
            MessageBox.Show("Bill Deleted!");
        }

        private void txtbfcf_TextChanged_1(object sender, EventArgs e)
        {
            CalculateTotal();

        }

        private void txtbfmc_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void txtbftc_TextChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void btnbfup_Click(object sender, EventArgs e)
        {
            if (txtbfbid.Text == "") return;

            SqlCommand cmd = new SqlCommand("pr_Billing", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Action", "UPDATE");
            cmd.Parameters.AddWithValue("@BillID", txtbfbid.Text);
            cmd.Parameters.AddWithValue("@PatientID", cmbbfpt.SelectedValue);
            cmd.Parameters.AddWithValue("@DoctorID", cmbbfdc.SelectedValue);
            cmd.Parameters.AddWithValue("@AppointmentID", cmbbfap.SelectedValue);
            cmd.Parameters.AddWithValue("@ConsultationFee", Convert.ToDecimal(txtbfcf.Text));
            cmd.Parameters.AddWithValue("@MedicineCharges", Convert.ToDecimal(txtbfmc.Text));
            cmd.Parameters.AddWithValue("@TestCharges", Convert.ToDecimal(txtbftc.Text));
            cmd.Parameters.AddWithValue("@BillDate", dtpbf.Value);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            LoadBilling();
            MessageBox.Show("Bill Updated!");
        }

        private void dgvbf_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txtbfbid.Text = dgvbf.Rows[e.RowIndex].Cells["BillID"].Value.ToString();

            int patientId = Convert.ToInt32(dgvbf.Rows[e.RowIndex].Cells["PatientID"].Value);
            int doctorId = Convert.ToInt32(dgvbf.Rows[e.RowIndex].Cells["DoctorID"].Value);
            int appointmentId = Convert.ToInt32(dgvbf.Rows[e.RowIndex].Cells["AppointmentID"].Value);

            cmbbfpt.SelectedValue = patientId;
            cmbbfdc.SelectedValue = doctorId;
            LoadAppointmentsByPatient(patientId);
            cmbbfap.SelectedValue = appointmentId;

            txtbfcf.Text = dgvbf.Rows[e.RowIndex].Cells["ConsultationFee"].Value.ToString();
            txtbfmc.Text = dgvbf.Rows[e.RowIndex].Cells["MedicineCharges"].Value.ToString();
            txtbftc.Text = dgvbf.Rows[e.RowIndex].Cells["TestCharges"].Value.ToString();
            txtbfta.Text = dgvbf.Rows[e.RowIndex].Cells["TotalAmount"].Value.ToString();

        }

        private void cmbbfpt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbbfpt.SelectedValue == null)
                return;
            if (cmbbfpt.SelectedValue is DataRowView)
                return;

            int patientId = Convert.ToInt32(cmbbfpt.SelectedValue);
            LoadAppointmentsByPatient(patientId);
        }
    }
}

