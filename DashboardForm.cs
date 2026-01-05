using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalMS
{
    public partial class DashboardForm : Form
    {
        public string LoggedUser { get; set; }
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void btnpm_Click(object sender, EventArgs e)
        {
            PatientForm pf = new PatientForm();
            pf.Show();
        }

        private void btndm_Click(object sender, EventArgs e)
        {
            DoctorForm df = new DoctorForm();
            df.Show();
        }

        private void btnap_Click(object sender, EventArgs e)
        {
            AppointmentForm af = new AppointmentForm();
            af.Show();
        }

        private void btnbill_Click(object sender, EventArgs e)
        {
            BillingForm bf = new BillingForm();
            bf.Show();
        }

        private void btnlo_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lf = new LoginForm();
            lf.Show();
            MessageBox.Show("You have logged out!");
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(LoggedUser))
            {
                lblwhms.Text = "Welcome " + LoggedUser + " to Hospital Management System";
            }
            else
            {
                // Default welcome text if username not passed
                lblwhms.Text = "Welcome to Hospital Management System";
            }
        }
    }
}
