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

namespace HospitalMS
{
    public partial class AppointmentForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-26A9125\SQLEXPRESS;Initial Catalog=dotnetnov;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        private void ClearFields()
        {
            cmbafpt.SelectedIndex = -1;
            cmbafdc.SelectedIndex = -1;
            txtafr.Clear();
        }

        public AppointmentForm()
        {
            InitializeComponent();
        }

        private void LoadPatients()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT PatientID, Name FROM Patients", con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            cmbafpt.DataSource = dt;
            cmbafpt.DisplayMember = "Name";
            cmbafpt.ValueMember = "PatientID";

            con.Close();
        }

        private void LoadDoctors()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT DoctorId, Name from Doctors", con);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            cmbafdc.DataSource = dt;
            cmbafdc.DisplayMember = "Name";
            cmbafdc.ValueMember = "DoctorId";

            con.Close();
        }

        private void LoadAppointments()
        {
            SqlDataAdapter da = new SqlDataAdapter("pr_Appointments", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@Action", "SELECT");

            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvaf.DataSource = dt;
        }


        private void AppointmentForm_Load(object sender, EventArgs e)
        {
            LoadPatients();
            LoadDoctors();
            LoadAppointments();
        }

        private void btnafsv_Click(object sender, EventArgs e)
        {
            if (cmbafpt.SelectedIndex == -1 || cmbafdc.SelectedIndex == -1 || txtafr.Text == "")
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            SqlCommand cmd = new SqlCommand("pr_Appointments", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Action", "INSERT");
            cmd.Parameters.AddWithValue("@PatientID", cmbafpt.SelectedValue);
            cmd.Parameters.AddWithValue("@DoctorID", cmbafdc.SelectedValue);
            cmd.Parameters.AddWithValue("@AppointmentDate", dtpafad.Value);
            cmd.Parameters.AddWithValue("@Reason", txtafr.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            LoadAppointments();
            ClearFields();
            MessageBox.Show("Appointment Saved!");
        }

        private void btnafup_Click(object sender, EventArgs e)
        {
            if (txtAppID.Text == "")
            {
                MessageBox.Show("Select a record to update!");
                return;
            }

            SqlCommand cmd = new SqlCommand("pr_Appointments", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Action", "UPDATE");
            cmd.Parameters.AddWithValue("@AppID", txtAppID.Text);
            cmd.Parameters.AddWithValue("@PatientID", cmbafpt.SelectedValue);
            cmd.Parameters.AddWithValue("@DoctorID", cmbafdc.SelectedValue);
            cmd.Parameters.AddWithValue("@AppointmentDate", dtpafad.Value);
            cmd.Parameters.AddWithValue("@Reason", txtafr.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            LoadAppointments();
            ClearFields();
            MessageBox.Show("Appointment Updated!");
        }

        private void btnafdlt_Click(object sender, EventArgs e)
        {
            if (txtAppID.Text == "")
            {
                MessageBox.Show("Select a record to delete!");
                return;
            }

            SqlCommand cmd = new SqlCommand("pr_Appointments", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Action", "DELETE");
            cmd.Parameters.AddWithValue("@AppID", txtAppID.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            LoadAppointments();
            ClearFields();
            MessageBox.Show("Appointment Deleted!");

        }

        private void dgvaf_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvaf.Rows[e.RowIndex];

                txtAppID.Text = row.Cells["AppID"].Value.ToString();
                cmbafpt.Text = row.Cells["PatientID"].Value.ToString();
                cmbafdc.Text = row.Cells["DoctorID"].Value.ToString();
                dtpafad.Value = Convert.ToDateTime(row.Cells["AppointmentDate"].Value);
                txtafr.Text = row.Cells["Reason"].Value.ToString();
            }
        }

        private void btnafclr_Click(object sender, EventArgs e)
        {
            txtAppID.Clear();
            cmbafpt.SelectedIndex = -1;
            cmbafdc.SelectedIndex = -1;
            txtafr.Clear();
        }
    }
}
