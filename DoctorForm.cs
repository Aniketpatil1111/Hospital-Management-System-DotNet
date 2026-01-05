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
    public partial class DoctorForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-26A9125\SQLEXPRESS;Initial Catalog=dotnetnov;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        private void ClearFields()
        {
            txtdfdid.Text = "";
            txtdfnm.Text = "";
            txtspec.Text = "";
            txtdfph.Text = "";
        }
        public DoctorForm()
        {
            InitializeComponent();
        }

        private void LoadDoctors()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("pr_Doctors", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Action", "SELECT");

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvdf.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading doctors: " + ex.Message);
            }
        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {
            LoadDoctors();
        }

        private void btndfadd_Click(object sender, EventArgs e)
        {
            if (txtdfnm.Text == "" || txtspec.Text == "" || txtdfph.Text == "")
            {
                MessageBox.Show("All fields are required!");
                return;
            }

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pr_Doctors", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Action", "INSERT");
                cmd.Parameters.AddWithValue("@Name", txtdfnm.Text);
                cmd.Parameters.AddWithValue("@Specialization", txtspec.Text);
                cmd.Parameters.AddWithValue("@Phone", txtdfph.Text);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting doctor: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

            MessageBox.Show("Doctor Added Successfully!");
            LoadDoctors();
            ClearFields();
        }

        private void dgvdf_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtdfdid.Text = dgvdf.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtdfnm.Text = dgvdf.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtspec.Text = dgvdf.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtdfph.Text = dgvdf.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btndfUpt_Click(object sender, EventArgs e)
        {
            if (txtdfdid.Text == "")
            {
                MessageBox.Show("Please select a doctor to update!");
                return;
            }

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("pr_Doctors", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Action", "UPDATE");
                cmd.Parameters.AddWithValue("@DoctorID", txtdfdid.Text);
                cmd.Parameters.AddWithValue("@Name", txtdfnm.Text);
                cmd.Parameters.AddWithValue("@Specialization", txtspec.Text);
                cmd.Parameters.AddWithValue("@Phone", txtdfph.Text);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating doctor: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

            MessageBox.Show("Doctor Updated Successfully!");
            LoadDoctors();
            ClearFields();
        }

        private void btndfdlt_Click(object sender, EventArgs e)
        {
            if (txtdfdid.Text == "")
            {
                MessageBox.Show("Select a doctor to delete!");
                return;
            }

            if (MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("pr_Doctors", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Action", "DELETE");
                    cmd.Parameters.AddWithValue("@DoctorID", txtdfdid.Text);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting doctor: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }

                MessageBox.Show("Doctor Deleted Successfully!");
                LoadDoctors();
                ClearFields();

            }
        }

        private void btndfclr_Click(object sender, EventArgs e)
        {
            txtdfdid.Text = "";
            txtdfnm.Text = "";
            txtspec.Text = "";
            txtdfph.Text = "";
        }
    }
}
