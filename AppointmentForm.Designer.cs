namespace HospitalMS
{
    partial class AppointmentForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentForm));
            this.lblafpt = new System.Windows.Forms.Label();
            this.cmbafpt = new System.Windows.Forms.ComboBox();
            this.lblafdc = new System.Windows.Forms.Label();
            this.cmbafdc = new System.Windows.Forms.ComboBox();
            this.lblafdt = new System.Windows.Forms.Label();
            this.btnafsv = new System.Windows.Forms.Button();
            this.dtpafad = new System.Windows.Forms.DateTimePicker();
            this.lblafr = new System.Windows.Forms.Label();
            this.txtafr = new System.Windows.Forms.TextBox();
            this.btnafup = new System.Windows.Forms.Button();
            this.btnafdlt = new System.Windows.Forms.Button();
            this.btnafclr = new System.Windows.Forms.Button();
            this.dgvaf = new System.Windows.Forms.DataGridView();
            this.lblaid = new System.Windows.Forms.Label();
            this.txtAppID = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnllf = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvaf)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnllf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblafpt
            // 
            this.lblafpt.AutoSize = true;
            this.lblafpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblafpt.Location = new System.Drawing.Point(485, 88);
            this.lblafpt.Name = "lblafpt";
            this.lblafpt.Size = new System.Drawing.Size(79, 25);
            this.lblafpt.TabIndex = 3;
            this.lblafpt.Text = "Patient";
            // 
            // cmbafpt
            // 
            this.cmbafpt.FormattingEnabled = true;
            this.cmbafpt.Location = new System.Drawing.Point(676, 92);
            this.cmbafpt.Name = "cmbafpt";
            this.cmbafpt.Size = new System.Drawing.Size(203, 24);
            this.cmbafpt.TabIndex = 4;
            // 
            // lblafdc
            // 
            this.lblafdc.AutoSize = true;
            this.lblafdc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblafdc.Location = new System.Drawing.Point(485, 138);
            this.lblafdc.Name = "lblafdc";
            this.lblafdc.Size = new System.Drawing.Size(75, 25);
            this.lblafdc.TabIndex = 5;
            this.lblafdc.Text = "Doctor";
            // 
            // cmbafdc
            // 
            this.cmbafdc.FormattingEnabled = true;
            this.cmbafdc.Location = new System.Drawing.Point(676, 139);
            this.cmbafdc.Name = "cmbafdc";
            this.cmbafdc.Size = new System.Drawing.Size(203, 24);
            this.cmbafdc.TabIndex = 6;
            // 
            // lblafdt
            // 
            this.lblafdt.AutoSize = true;
            this.lblafdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblafdt.Location = new System.Drawing.Point(485, 192);
            this.lblafdt.Name = "lblafdt";
            this.lblafdt.Size = new System.Drawing.Size(184, 25);
            this.lblafdt.TabIndex = 7;
            this.lblafdt.Text = "Appointment Date";
            // 
            // btnafsv
            // 
            this.btnafsv.BackColor = System.Drawing.Color.Gray;
            this.btnafsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnafsv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnafsv.Location = new System.Drawing.Point(465, 326);
            this.btnafsv.Name = "btnafsv";
            this.btnafsv.Size = new System.Drawing.Size(99, 48);
            this.btnafsv.TabIndex = 11;
            this.btnafsv.Text = "Save";
            this.btnafsv.UseVisualStyleBackColor = false;
            this.btnafsv.Click += new System.EventHandler(this.btnafsv_Click);
            // 
            // dtpafad
            // 
            this.dtpafad.Location = new System.Drawing.Point(676, 195);
            this.dtpafad.Name = "dtpafad";
            this.dtpafad.Size = new System.Drawing.Size(203, 22);
            this.dtpafad.TabIndex = 8;
            // 
            // lblafr
            // 
            this.lblafr.AutoSize = true;
            this.lblafr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblafr.Location = new System.Drawing.Point(485, 248);
            this.lblafr.Name = "lblafr";
            this.lblafr.Size = new System.Drawing.Size(85, 25);
            this.lblafr.TabIndex = 9;
            this.lblafr.Text = "Reason";
            // 
            // txtafr
            // 
            this.txtafr.Location = new System.Drawing.Point(676, 248);
            this.txtafr.Margin = new System.Windows.Forms.Padding(4);
            this.txtafr.Multiline = true;
            this.txtafr.Name = "txtafr";
            this.txtafr.Size = new System.Drawing.Size(203, 28);
            this.txtafr.TabIndex = 10;
            // 
            // btnafup
            // 
            this.btnafup.BackColor = System.Drawing.Color.Gray;
            this.btnafup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnafup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnafup.Location = new System.Drawing.Point(617, 326);
            this.btnafup.Name = "btnafup";
            this.btnafup.Size = new System.Drawing.Size(99, 48);
            this.btnafup.TabIndex = 12;
            this.btnafup.Text = "Update";
            this.btnafup.UseVisualStyleBackColor = false;
            this.btnafup.Click += new System.EventHandler(this.btnafup_Click);
            // 
            // btnafdlt
            // 
            this.btnafdlt.BackColor = System.Drawing.Color.Gray;
            this.btnafdlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnafdlt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnafdlt.Location = new System.Drawing.Point(767, 326);
            this.btnafdlt.Name = "btnafdlt";
            this.btnafdlt.Size = new System.Drawing.Size(99, 48);
            this.btnafdlt.TabIndex = 13;
            this.btnafdlt.Text = "Delete";
            this.btnafdlt.UseVisualStyleBackColor = false;
            this.btnafdlt.Click += new System.EventHandler(this.btnafdlt_Click);
            // 
            // btnafclr
            // 
            this.btnafclr.BackColor = System.Drawing.Color.Gray;
            this.btnafclr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnafclr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnafclr.Location = new System.Drawing.Point(917, 326);
            this.btnafclr.Name = "btnafclr";
            this.btnafclr.Size = new System.Drawing.Size(99, 48);
            this.btnafclr.TabIndex = 14;
            this.btnafclr.Text = "Clear";
            this.btnafclr.UseVisualStyleBackColor = false;
            this.btnafclr.Click += new System.EventHandler(this.btnafclr_Click);
            // 
            // dgvaf
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightGray;
            this.dgvaf.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvaf.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvaf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvaf.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvaf.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvaf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvaf.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvaf.EnableHeadersVisualStyles = false;
            this.dgvaf.GridColor = System.Drawing.Color.Silver;
            this.dgvaf.Location = new System.Drawing.Point(368, 408);
            this.dgvaf.Name = "dgvaf";
            this.dgvaf.RowHeadersWidth = 51;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.dgvaf.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvaf.RowTemplate.Height = 24;
            this.dgvaf.Size = new System.Drawing.Size(736, 246);
            this.dgvaf.TabIndex = 15;
            this.dgvaf.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvaf_CellClick);
            // 
            // lblaid
            // 
            this.lblaid.AutoSize = true;
            this.lblaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaid.Location = new System.Drawing.Point(485, 40);
            this.lblaid.Name = "lblaid";
            this.lblaid.Size = new System.Drawing.Size(69, 25);
            this.lblaid.TabIndex = 1;
            this.lblaid.Text = "AppId";
            // 
            // txtAppID
            // 
            this.txtAppID.Location = new System.Drawing.Point(676, 44);
            this.txtAppID.Name = "txtAppID";
            this.txtAppID.ReadOnly = true;
            this.txtAppID.Size = new System.Drawing.Size(203, 22);
            this.txtAppID.TabIndex = 2;
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1376, 115);
            this.tableLayoutPanel1.TabIndex = 19;
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
            this.pnllf.Location = new System.Drawing.Point(174, 22);
            this.pnllf.Name = "pnllf";
            this.pnllf.Size = new System.Drawing.Size(1165, 71);
            this.pnllf.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(458, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "APPOINTMENTS";
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
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.lblaid);
            this.panel1.Controls.Add(this.txtAppID);
            this.panel1.Controls.Add(this.dgvaf);
            this.panel1.Controls.Add(this.lblafpt);
            this.panel1.Controls.Add(this.btnafsv);
            this.panel1.Controls.Add(this.btnafup);
            this.panel1.Controls.Add(this.btnafclr);
            this.panel1.Controls.Add(this.txtafr);
            this.panel1.Controls.Add(this.btnafdlt);
            this.panel1.Controls.Add(this.cmbafpt);
            this.panel1.Controls.Add(this.cmbafdc);
            this.panel1.Controls.Add(this.lblafr);
            this.panel1.Controls.Add(this.lblafdc);
            this.panel1.Controls.Add(this.dtpafad);
            this.panel1.Controls.Add(this.lblafdt);
            this.panel1.Location = new System.Drawing.Point(0, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1376, 688);
            this.panel1.TabIndex = 20;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(412, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1376, 802);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AppointmentForm";
            this.Text = "AppointmentForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AppointmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvaf)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnllf.ResumeLayout(false);
            this.pnllf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblafpt;
        private System.Windows.Forms.ComboBox cmbafpt;
        private System.Windows.Forms.Label lblafdc;
        private System.Windows.Forms.ComboBox cmbafdc;
        private System.Windows.Forms.Label lblafdt;
        private System.Windows.Forms.Button btnafsv;
        private System.Windows.Forms.DateTimePicker dtpafad;
        private System.Windows.Forms.Label lblafr;
        private System.Windows.Forms.TextBox txtafr;
        private System.Windows.Forms.Button btnafup;
        private System.Windows.Forms.Button btnafdlt;
        private System.Windows.Forms.Button btnafclr;
        private System.Windows.Forms.DataGridView dgvaf;
        private System.Windows.Forms.Label lblaid;
        private System.Windows.Forms.TextBox txtAppID;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnllf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}