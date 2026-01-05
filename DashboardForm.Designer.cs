namespace HospitalMS
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.btnpm = new System.Windows.Forms.Button();
            this.btndm = new System.Windows.Forms.Button();
            this.btnap = new System.Windows.Forms.Button();
            this.btnbill = new System.Windows.Forms.Button();
            this.lblwhms = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnlo = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnllf = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnllf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnpm
            // 
            this.btnpm.BackColor = System.Drawing.Color.Gray;
            this.btnpm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnpm.Location = new System.Drawing.Point(496, 127);
            this.btnpm.Name = "btnpm";
            this.btnpm.Size = new System.Drawing.Size(381, 48);
            this.btnpm.TabIndex = 0;
            this.btnpm.Text = "Patient Management";
            this.btnpm.UseVisualStyleBackColor = false;
            this.btnpm.Click += new System.EventHandler(this.btnpm_Click);
            // 
            // btndm
            // 
            this.btndm.BackColor = System.Drawing.Color.Gray;
            this.btndm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndm.Location = new System.Drawing.Point(496, 198);
            this.btndm.Name = "btndm";
            this.btndm.Size = new System.Drawing.Size(381, 48);
            this.btndm.TabIndex = 1;
            this.btndm.Text = "Doctor Management";
            this.btndm.UseVisualStyleBackColor = false;
            this.btndm.Click += new System.EventHandler(this.btndm_Click);
            // 
            // btnap
            // 
            this.btnap.BackColor = System.Drawing.Color.Gray;
            this.btnap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnap.Location = new System.Drawing.Point(496, 271);
            this.btnap.Name = "btnap";
            this.btnap.Size = new System.Drawing.Size(381, 47);
            this.btnap.TabIndex = 2;
            this.btnap.Text = "Appointment";
            this.btnap.UseVisualStyleBackColor = false;
            this.btnap.Click += new System.EventHandler(this.btnap_Click);
            // 
            // btnbill
            // 
            this.btnbill.BackColor = System.Drawing.Color.Gray;
            this.btnbill.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbill.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnbill.Location = new System.Drawing.Point(496, 343);
            this.btnbill.Name = "btnbill";
            this.btnbill.Size = new System.Drawing.Size(381, 46);
            this.btnbill.TabIndex = 3;
            this.btnbill.Text = "Billing";
            this.btnbill.UseVisualStyleBackColor = false;
            this.btnbill.Click += new System.EventHandler(this.btnbill_Click);
            // 
            // lblwhms
            // 
            this.lblwhms.AutoSize = true;
            this.lblwhms.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwhms.Location = new System.Drawing.Point(335, 45);
            this.lblwhms.Name = "lblwhms";
            this.lblwhms.Size = new System.Drawing.Size(608, 36);
            this.lblwhms.TabIndex = 4;
            this.lblwhms.Text = "Welcome to Hospital Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 5;
            // 
            // btnlo
            // 
            this.btnlo.BackColor = System.Drawing.Color.DimGray;
            this.btnlo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnlo.Location = new System.Drawing.Point(621, 418);
            this.btnlo.Name = "btnlo";
            this.btnlo.Size = new System.Drawing.Size(127, 53);
            this.btnlo.TabIndex = 6;
            this.btnlo.Text = "Logout";
            this.btnlo.UseVisualStyleBackColor = false;
            this.btnlo.Click += new System.EventHandler(this.btnlo_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Controls.Add(this.pnllf, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1367, 115);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // pnllf
            // 
            this.pnllf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnllf.BackColor = System.Drawing.Color.Black;
            this.pnllf.Controls.Add(this.label1);
            this.pnllf.Controls.Add(this.pictureBox1);
            this.pnllf.Controls.Add(this.label3);
            this.pnllf.ForeColor = System.Drawing.Color.White;
            this.pnllf.Location = new System.Drawing.Point(169, 22);
            this.pnllf.Name = "pnllf";
            this.pnllf.Size = new System.Drawing.Size(1165, 71);
            this.pnllf.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(458, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "DASHBOARD";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(240, -8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(286, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(510, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "HOSPITAL MANAGEMENT SYSTEM";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.btnpm);
            this.panel1.Controls.Add(this.lblwhms);
            this.panel1.Controls.Add(this.btnlo);
            this.panel1.Controls.Add(this.btndm);
            this.panel1.Controls.Add(this.btnap);
            this.panel1.Controls.Add(this.btnbill);
            this.panel1.Location = new System.Drawing.Point(22, 134);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1312, 662);
            this.panel1.TabIndex = 20;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1367, 816);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnllf.ResumeLayout(false);
            this.pnllf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnpm;
        private System.Windows.Forms.Button btndm;
        private System.Windows.Forms.Button btnap;
        private System.Windows.Forms.Button btnbill;
        private System.Windows.Forms.Label lblwhms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnlo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnllf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
    }
}