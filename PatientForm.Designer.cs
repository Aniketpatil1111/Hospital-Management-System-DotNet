namespace HospitalMS
{
    partial class PatientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnllf = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtph = new System.Windows.Forms.TextBox();
            this.lblpfph = new System.Windows.Forms.Label();
            this.txtadrs = new System.Windows.Forms.TextBox();
            this.cmbGn = new System.Windows.Forms.ComboBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtnm = new System.Windows.Forms.TextBox();
            this.lblpid = new System.Windows.Forms.Label();
            this.txtpid = new System.Windows.Forms.TextBox();
            this.dgvPatients = new System.Windows.Forms.DataGridView();
            this.lblpfnm = new System.Windows.Forms.Label();
            this.btnpfsv = new System.Windows.Forms.Button();
            this.btnpfUpt = new System.Windows.Forms.Button();
            this.btnpfclr = new System.Windows.Forms.Button();
            this.btnpfdlt = new System.Windows.Forms.Button();
            this.lblpfad = new System.Windows.Forms.Label();
            this.lblpfage = new System.Windows.Forms.Label();
            this.lblgn = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnllf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Controls.Add(this.pnllf, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1633, 123);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // pnllf
            // 
            this.pnllf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnllf.BackColor = System.Drawing.Color.Black;
            this.pnllf.Controls.Add(this.pictureBox2);
            this.pnllf.Controls.Add(this.label2);
            this.pnllf.Controls.Add(this.pictureBox1);
            this.pnllf.Controls.Add(this.label1);
            this.pnllf.ForeColor = System.Drawing.Color.White;
            this.pnllf.Location = new System.Drawing.Point(234, 26);
            this.pnllf.Name = "pnllf";
            this.pnllf.Size = new System.Drawing.Size(1165, 71);
            this.pnllf.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(412, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(458, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "PATIENT";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(510, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "HOSPITAL MANAGEMENT SYSTEM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.txtph);
            this.panel1.Controls.Add(this.lblpfph);
            this.panel1.Controls.Add(this.txtadrs);
            this.panel1.Controls.Add(this.cmbGn);
            this.panel1.Controls.Add(this.txtage);
            this.panel1.Controls.Add(this.txtnm);
            this.panel1.Controls.Add(this.lblpid);
            this.panel1.Controls.Add(this.txtpid);
            this.panel1.Controls.Add(this.dgvPatients);
            this.panel1.Controls.Add(this.lblpfnm);
            this.panel1.Controls.Add(this.btnpfsv);
            this.panel1.Controls.Add(this.btnpfUpt);
            this.panel1.Controls.Add(this.btnpfclr);
            this.panel1.Controls.Add(this.btnpfdlt);
            this.panel1.Controls.Add(this.lblpfad);
            this.panel1.Controls.Add(this.lblpfage);
            this.panel1.Controls.Add(this.lblgn);
            this.panel1.Location = new System.Drawing.Point(251, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1094, 618);
            this.panel1.TabIndex = 22;
            // 
            // txtph
            // 
            this.txtph.Location = new System.Drawing.Point(466, 275);
            this.txtph.Name = "txtph";
            this.txtph.Size = new System.Drawing.Size(203, 22);
            this.txtph.TabIndex = 36;
            // 
            // lblpfph
            // 
            this.lblpfph.AutoSize = true;
            this.lblpfph.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpfph.Location = new System.Drawing.Point(275, 271);
            this.lblpfph.Name = "lblpfph";
            this.lblpfph.Size = new System.Drawing.Size(107, 25);
            this.lblpfph.TabIndex = 35;
            this.lblpfph.Text = "Phone No";
            // 
            // txtadrs
            // 
            this.txtadrs.Location = new System.Drawing.Point(466, 221);
            this.txtadrs.Name = "txtadrs";
            this.txtadrs.Size = new System.Drawing.Size(203, 22);
            this.txtadrs.TabIndex = 34;
            // 
            // cmbGn
            // 
            this.cmbGn.FormattingEnabled = true;
            this.cmbGn.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.cmbGn.Location = new System.Drawing.Point(466, 165);
            this.cmbGn.Name = "cmbGn";
            this.cmbGn.Size = new System.Drawing.Size(203, 24);
            this.cmbGn.TabIndex = 33;
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(466, 115);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(203, 22);
            this.txtage.TabIndex = 32;
            // 
            // txtnm
            // 
            this.txtnm.Location = new System.Drawing.Point(466, 61);
            this.txtnm.Name = "txtnm";
            this.txtnm.Size = new System.Drawing.Size(203, 22);
            this.txtnm.TabIndex = 31;
            // 
            // lblpid
            // 
            this.lblpid.AutoSize = true;
            this.lblpid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpid.Location = new System.Drawing.Point(275, 14);
            this.lblpid.Name = "lblpid";
            this.lblpid.Size = new System.Drawing.Size(103, 25);
            this.lblpid.TabIndex = 16;
            this.lblpid.Text = "Patient Id";
            // 
            // txtpid
            // 
            this.txtpid.Location = new System.Drawing.Point(466, 17);
            this.txtpid.Name = "txtpid";
            this.txtpid.ReadOnly = true;
            this.txtpid.Size = new System.Drawing.Size(203, 22);
            this.txtpid.TabIndex = 17;
            // 
            // dgvPatients
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvPatients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPatients.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvPatients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPatients.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPatients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPatients.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPatients.EnableHeadersVisualStyles = false;
            this.dgvPatients.GridColor = System.Drawing.Color.Silver;
            this.dgvPatients.Location = new System.Drawing.Point(118, 381);
            this.dgvPatients.Name = "dgvPatients";
            this.dgvPatients.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvPatients.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPatients.RowTemplate.Height = 24;
            this.dgvPatients.Size = new System.Drawing.Size(866, 219);
            this.dgvPatients.TabIndex = 30;
            this.dgvPatients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPatients_CellContentClick);
            // 
            // lblpfnm
            // 
            this.lblpfnm.AutoSize = true;
            this.lblpfnm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpfnm.Location = new System.Drawing.Point(275, 61);
            this.lblpfnm.Name = "lblpfnm";
            this.lblpfnm.Size = new System.Drawing.Size(68, 25);
            this.lblpfnm.TabIndex = 18;
            this.lblpfnm.Text = "Name";
            // 
            // btnpfsv
            // 
            this.btnpfsv.BackColor = System.Drawing.Color.Gray;
            this.btnpfsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpfsv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnpfsv.Location = new System.Drawing.Point(259, 327);
            this.btnpfsv.Name = "btnpfsv";
            this.btnpfsv.Size = new System.Drawing.Size(99, 48);
            this.btnpfsv.TabIndex = 26;
            this.btnpfsv.Text = "Save";
            this.btnpfsv.UseVisualStyleBackColor = false;
            this.btnpfsv.Click += new System.EventHandler(this.btnpfsv_Click);
            // 
            // btnpfUpt
            // 
            this.btnpfUpt.BackColor = System.Drawing.Color.Gray;
            this.btnpfUpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpfUpt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnpfUpt.Location = new System.Drawing.Point(407, 327);
            this.btnpfUpt.Name = "btnpfUpt";
            this.btnpfUpt.Size = new System.Drawing.Size(99, 48);
            this.btnpfUpt.TabIndex = 27;
            this.btnpfUpt.Text = "Update";
            this.btnpfUpt.UseVisualStyleBackColor = false;
            this.btnpfUpt.Click += new System.EventHandler(this.btnpfUpt_Click);
            // 
            // btnpfclr
            // 
            this.btnpfclr.BackColor = System.Drawing.Color.Gray;
            this.btnpfclr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpfclr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnpfclr.Location = new System.Drawing.Point(705, 327);
            this.btnpfclr.Name = "btnpfclr";
            this.btnpfclr.Size = new System.Drawing.Size(99, 48);
            this.btnpfclr.TabIndex = 29;
            this.btnpfclr.Text = "Clear";
            this.btnpfclr.UseVisualStyleBackColor = false;
            this.btnpfclr.Click += new System.EventHandler(this.btnpfclr_Click);
            // 
            // btnpfdlt
            // 
            this.btnpfdlt.BackColor = System.Drawing.Color.Gray;
            this.btnpfdlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpfdlt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnpfdlt.Location = new System.Drawing.Point(556, 327);
            this.btnpfdlt.Name = "btnpfdlt";
            this.btnpfdlt.Size = new System.Drawing.Size(99, 48);
            this.btnpfdlt.TabIndex = 28;
            this.btnpfdlt.Text = "Delete";
            this.btnpfdlt.UseVisualStyleBackColor = false;
            this.btnpfdlt.Click += new System.EventHandler(this.btnpfdlt_Click);
            // 
            // lblpfad
            // 
            this.lblpfad.AutoSize = true;
            this.lblpfad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpfad.Location = new System.Drawing.Point(275, 221);
            this.lblpfad.Name = "lblpfad";
            this.lblpfad.Size = new System.Drawing.Size(92, 25);
            this.lblpfad.TabIndex = 24;
            this.lblpfad.Text = "Address";
            // 
            // lblpfage
            // 
            this.lblpfage.AutoSize = true;
            this.lblpfage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpfage.Location = new System.Drawing.Point(275, 111);
            this.lblpfage.Name = "lblpfage";
            this.lblpfage.Size = new System.Drawing.Size(51, 25);
            this.lblpfage.TabIndex = 20;
            this.lblpfage.Text = "Age";
            // 
            // lblgn
            // 
            this.lblgn.AutoSize = true;
            this.lblgn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgn.Location = new System.Drawing.Point(275, 165);
            this.lblgn.Name = "lblgn";
            this.lblgn.Size = new System.Drawing.Size(83, 25);
            this.lblgn.TabIndex = 22;
            this.lblgn.Text = "Gender";
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1633, 759);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PatientForm";
            this.Text = "PatientForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PatientForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnllf.ResumeLayout(false);
            this.pnllf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnllf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblpid;
        private System.Windows.Forms.TextBox txtpid;
        private System.Windows.Forms.DataGridView dgvPatients;
        private System.Windows.Forms.Label lblpfnm;
        private System.Windows.Forms.Button btnpfsv;
        private System.Windows.Forms.Button btnpfUpt;
        private System.Windows.Forms.Button btnpfclr;
        private System.Windows.Forms.Button btnpfdlt;
        private System.Windows.Forms.Label lblpfad;
        private System.Windows.Forms.Label lblpfage;
        private System.Windows.Forms.Label lblgn;
        private System.Windows.Forms.TextBox txtnm;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.ComboBox cmbGn;
        private System.Windows.Forms.TextBox txtadrs;
        private System.Windows.Forms.Label lblpfph;
        private System.Windows.Forms.TextBox txtph;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}