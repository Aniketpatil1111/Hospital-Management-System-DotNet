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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnlg_Click(object sender, EventArgs e)
        {
            if (txtlfUn.Text == "" || txtps.Text == "")
            {
                MessageBox.Show("Please enter username and password");
                return;
            }

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-26A9125\SQLEXPRESS;Initial Catalog=dotnetnov;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            SqlCommand cmd = new SqlCommand("pr_Login", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Username", txtlfUn.Text);
            cmd.Parameters.AddWithValue("@Password", txtps.Text);

            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Login Successful!");

                // Open Dashboard Form
                DashboardForm df = new DashboardForm();
                df.Show();
                df.LoggedUser = txtlfUn.Text;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Login!");
            }

            con.Close();
        }
    }
}
