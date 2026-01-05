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
    public partial class PatientForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-26A9125\SQLEXPRESS;Initial Catalog=dotnetnov;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        public PatientForm()
        {
            InitializeComponent();
        }

    private void LoadPatients()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("pr_Patients", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Action", "SELECT");

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvPatients.DataSource = dt;
                dgvPatients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading patients: " + ex.Message);
            }
        }
        private void btnpfsv_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("pr_Patients", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Action", "INSERT");
                cmd.Parameters.AddWithValue("@Name", txtnm.Text);
                cmd.Parameters.AddWithValue("@Age", txtage.Text);
                cmd.Parameters.AddWithValue("@Gender", cmbGn.Text);
                cmd.Parameters.AddWithValue("@Address", txtadrs.Text);
                cmd.Parameters.AddWithValue("@Phone", txtph.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

            MessageBox.Show("Patient Added Successfully!");
            LoadPatients();
            ClearFields();
        }

        private void btnpfUpt_Click(object sender, EventArgs e)
        {
            using(SqlCommand cmd = new SqlCommand("pr_Patients", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Action", "UPDATE");
                cmd.Parameters.AddWithValue("@PatientID", txtpid.Text);
                cmd.Parameters.AddWithValue("@Name", txtnm.Text);
                cmd.Parameters.AddWithValue("@Age", txtage.Text);
                cmd.Parameters.AddWithValue("@Gender", cmbGn.Text);
                cmd.Parameters.AddWithValue("@Address", txtadrs.Text);
                cmd.Parameters.AddWithValue("@Phone", txtph.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

            MessageBox.Show("Patient Updated Successfully!");
            LoadPatients();
            ClearFields();
        }

        private void btnpfdlt_Click(object sender, EventArgs e)
        {
            if (txtpid.Text == "")
            {
                MessageBox.Show("Please select a patient first.");
                return;
            }

            DialogResult dr = MessageBox.Show(
                "Are you sure you want to delete this patient?",
                "Confirm",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                using (SqlCommand cmd = new SqlCommand("pr_Patients", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action", "DELETE");
                    cmd.Parameters.AddWithValue("@PatientID", txtpid.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }

                MessageBox.Show("Patient Deleted!");
                LoadPatients();
                ClearFields();
            }
        }

        private void btnpfclr_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dgvPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPatients.Rows[e.RowIndex];
                txtpid.Text = row.Cells["PatientID"].Value.ToString();
                txtnm.Text = row.Cells["Name"].Value.ToString();
                txtage.Text = row.Cells["Age"].Value.ToString();
                cmbGn.Text = row.Cells["Gender"].Value.ToString();
                txtadrs.Text = row.Cells["Address"].Value.ToString();
                txtph.Text = row.Cells["Phone"].Value.ToString();
            }
        }

        private void ClearFields()
        {
            txtpid.Clear();
            txtnm.Clear();
            txtage.Clear();
            cmbGn.SelectedIndex = -1;
            txtadrs.Clear();
            txtph.Clear();
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {
            LoadPatients();
        }
    }
}
