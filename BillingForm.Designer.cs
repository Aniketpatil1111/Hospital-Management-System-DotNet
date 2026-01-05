namespace HospitalMS
{
    partial class BillingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillingForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnbfup = new System.Windows.Forms.Button();
            this.btngpdf = new System.Windows.Forms.Button();
            this.txtbfbid = new System.Windows.Forms.TextBox();
            this.lblbid = new System.Windows.Forms.Label();
            this.dgvbf = new System.Windows.Forms.DataGridView();
            this.btnbfdlt = new System.Windows.Forms.Button();
            this.dtpbf = new System.Windows.Forms.DateTimePicker();
            this.txtbfta = new System.Windows.Forms.TextBox();
            this.txtbftc = new System.Windows.Forms.TextBox();
            this.txtbfmc = new System.Windows.Forms.TextBox();
            this.txtbfcf = new System.Windows.Forms.TextBox();
            this.cmbbfap = new System.Windows.Forms.ComboBox();
            this.cmbbfdc = new System.Windows.Forms.ComboBox();
            this.cmbbfpt = new System.Windows.Forms.ComboBox();
            this.lblbfbd = new System.Windows.Forms.Label();
            this.lblbfta = new System.Windows.Forms.Label();
            this.lblbftc = new System.Windows.Forms.Label();
            this.lblbfmc = new System.Windows.Forms.Label();
            this.lblbfcf = new System.Windows.Forms.Label();
            this.lblbfap = new System.Windows.Forms.Label();
            this.lblbfdc = new System.Windows.Forms.Label();
            this.lblbfpt = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnllf = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbf)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnllf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.btnbfup);
            this.panel1.Controls.Add(this.btngpdf);
            this.panel1.Controls.Add(this.txtbfbid);
            this.panel1.Controls.Add(this.lblbid);
            this.panel1.Controls.Add(this.dgvbf);
            this.panel1.Controls.Add(this.btnbfdlt);
            this.panel1.Controls.Add(this.dtpbf);
            this.panel1.Controls.Add(this.txtbfta);
            this.panel1.Controls.Add(this.txtbftc);
            this.panel1.Controls.Add(this.txtbfmc);
            this.panel1.Controls.Add(this.txtbfcf);
            this.panel1.Controls.Add(this.cmbbfap);
            this.panel1.Controls.Add(this.cmbbfdc);
            this.panel1.Controls.Add(this.cmbbfpt);
            this.panel1.Controls.Add(this.lblbfbd);
            this.panel1.Controls.Add(this.lblbfta);
            this.panel1.Controls.Add(this.lblbftc);
            this.panel1.Controls.Add(this.lblbfmc);
            this.panel1.Controls.Add(this.lblbfcf);
            this.panel1.Controls.Add(this.lblbfap);
            this.panel1.Controls.Add(this.lblbfdc);
            this.panel1.Controls.Add(this.lblbfpt);
            this.panel1.Location = new System.Drawing.Point(2, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1629, 659);
            this.panel1.TabIndex = 0;
            // 
            // btnbfup
            // 
            this.btnbfup.BackColor = System.Drawing.Color.Gray;
            this.btnbfup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbfup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnbfup.Location = new System.Drawing.Point(728, 375);
            this.btnbfup.Name = "btnbfup";
            this.btnbfup.Size = new System.Drawing.Size(144, 47);
            this.btnbfup.TabIndex = 47;
            this.btnbfup.Text = "Update Bill";
            this.btnbfup.UseVisualStyleBackColor = false;
            this.btnbfup.Click += new System.EventHandler(this.btnbfup_Click);
            // 
            // btngpdf
            // 
            this.btngpdf.BackColor = System.Drawing.Color.Gray;
            this.btngpdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngpdf.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btngpdf.Location = new System.Drawing.Point(544, 375);
            this.btngpdf.Name = "btngpdf";
            this.btngpdf.Size = new System.Drawing.Size(156, 47);
            this.btngpdf.TabIndex = 46;
            this.btngpdf.Text = "Generate Bill";
            this.btngpdf.UseVisualStyleBackColor = false;
            this.btngpdf.Click += new System.EventHandler(this.btngpdf_Click);
            // 
            // txtbfbid
            // 
            this.txtbfbid.Location = new System.Drawing.Point(728, 25);
            this.txtbfbid.Name = "txtbfbid";
            this.txtbfbid.ReadOnly = true;
            this.txtbfbid.Size = new System.Drawing.Size(182, 22);
            this.txtbfbid.TabIndex = 45;
            // 
            // lblbid
            // 
            this.lblbid.AutoSize = true;
            this.lblbid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbid.Location = new System.Drawing.Point(540, 25);
            this.lblbid.Name = "lblbid";
            this.lblbid.Size = new System.Drawing.Size(56, 20);
            this.lblbid.TabIndex = 24;
            this.lblbid.Text = "BillID";
            // 
            // dgvbf
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.LightGray;
            this.dgvbf.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvbf.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvbf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvbf.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvbf.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvbf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvbf.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvbf.EnableHeadersVisualStyles = false;
            this.dgvbf.GridColor = System.Drawing.Color.Silver;
            this.dgvbf.Location = new System.Drawing.Point(161, 487);
            this.dgvbf.Name = "dgvbf";
            this.dgvbf.RowHeadersWidth = 51;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            this.dgvbf.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvbf.RowTemplate.Height = 24;
            this.dgvbf.Size = new System.Drawing.Size(1250, 196);
            this.dgvbf.TabIndex = 44;
            this.dgvbf.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbf_CellClick_1);
            // 
            // btnbfdlt
            // 
            this.btnbfdlt.BackColor = System.Drawing.Color.Gray;
            this.btnbfdlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbfdlt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnbfdlt.Location = new System.Drawing.Point(901, 375);
            this.btnbfdlt.Name = "btnbfdlt";
            this.btnbfdlt.Size = new System.Drawing.Size(141, 47);
            this.btnbfdlt.TabIndex = 42;
            this.btnbfdlt.Text = "Delete";
            this.btnbfdlt.UseVisualStyleBackColor = false;
            this.btnbfdlt.Click += new System.EventHandler(this.btnbfdlt_Click);
            // 
            // dtpbf
            // 
            this.dtpbf.Location = new System.Drawing.Point(728, 326);
            this.dtpbf.Name = "dtpbf";
            this.dtpbf.Size = new System.Drawing.Size(182, 22);
            this.dtpbf.TabIndex = 39;
            // 
            // txtbfta
            // 
            this.txtbfta.Location = new System.Drawing.Point(728, 284);
            this.txtbfta.Name = "txtbfta";
            this.txtbfta.ReadOnly = true;
            this.txtbfta.Size = new System.Drawing.Size(182, 22);
            this.txtbfta.TabIndex = 37;
            // 
            // txtbftc
            // 
            this.txtbftc.Location = new System.Drawing.Point(728, 245);
            this.txtbftc.Name = "txtbftc";
            this.txtbftc.Size = new System.Drawing.Size(182, 22);
            this.txtbftc.TabIndex = 35;
            this.txtbftc.TextChanged += new System.EventHandler(this.txtbftc_TextChanged);
            // 
            // txtbfmc
            // 
            this.txtbfmc.Location = new System.Drawing.Point(728, 204);
            this.txtbfmc.Name = "txtbfmc";
            this.txtbfmc.Size = new System.Drawing.Size(182, 22);
            this.txtbfmc.TabIndex = 33;
            this.txtbfmc.TextChanged += new System.EventHandler(this.txtbfmc_TextChanged);
            // 
            // txtbfcf
            // 
            this.txtbfcf.Location = new System.Drawing.Point(728, 171);
            this.txtbfcf.Name = "txtbfcf";
            this.txtbfcf.Size = new System.Drawing.Size(182, 22);
            this.txtbfcf.TabIndex = 31;
            this.txtbfcf.TextChanged += new System.EventHandler(this.txtbfcf_TextChanged_1);
            // 
            // cmbbfap
            // 
            this.cmbbfap.FormattingEnabled = true;
            this.cmbbfap.Location = new System.Drawing.Point(728, 128);
            this.cmbbfap.Name = "cmbbfap";
            this.cmbbfap.Size = new System.Drawing.Size(182, 24);
            this.cmbbfap.TabIndex = 29;
            // 
            // cmbbfdc
            // 
            this.cmbbfdc.FormattingEnabled = true;
            this.cmbbfdc.Location = new System.Drawing.Point(728, 95);
            this.cmbbfdc.Name = "cmbbfdc";
            this.cmbbfdc.Size = new System.Drawing.Size(182, 24);
            this.cmbbfdc.TabIndex = 27;
            // 
            // cmbbfpt
            // 
            this.cmbbfpt.FormattingEnabled = true;
            this.cmbbfpt.Location = new System.Drawing.Point(728, 61);
            this.cmbbfpt.Name = "cmbbfpt";
            this.cmbbfpt.Size = new System.Drawing.Size(182, 24);
            this.cmbbfpt.TabIndex = 25;
            this.cmbbfpt.SelectedIndexChanged += new System.EventHandler(this.cmbbfpt_SelectedIndexChanged);
            this.cmbbfpt.SelectionChangeCommitted += new System.EventHandler(this.cmbbfpt_SelectionChangeCommitted);
            // 
            // lblbfbd
            // 
            this.lblbfbd.AutoSize = true;
            this.lblbfbd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbfbd.Location = new System.Drawing.Point(542, 328);
            this.lblbfbd.Name = "lblbfbd";
            this.lblbfbd.Size = new System.Drawing.Size(83, 20);
            this.lblbfbd.TabIndex = 38;
            this.lblbfbd.Text = "Bill Date";
            // 
            // lblbfta
            // 
            this.lblbfta.AutoSize = true;
            this.lblbfta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbfta.Location = new System.Drawing.Point(540, 286);
            this.lblbfta.Name = "lblbfta";
            this.lblbfta.Size = new System.Drawing.Size(120, 20);
            this.lblbfta.TabIndex = 36;
            this.lblbfta.Text = "Total Amount";
            // 
            // lblbftc
            // 
            this.lblbftc.AutoSize = true;
            this.lblbftc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbftc.Location = new System.Drawing.Point(540, 247);
            this.lblbftc.Name = "lblbftc";
            this.lblbftc.Size = new System.Drawing.Size(122, 20);
            this.lblbftc.TabIndex = 34;
            this.lblbftc.Text = "Test Charges";
            // 
            // lblbfmc
            // 
            this.lblbfmc.AutoSize = true;
            this.lblbfmc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbfmc.Location = new System.Drawing.Point(540, 206);
            this.lblbfmc.Name = "lblbfmc";
            this.lblbfmc.Size = new System.Drawing.Size(160, 20);
            this.lblbfmc.TabIndex = 32;
            this.lblbfmc.Text = "Medicine Charges";
            // 
            // lblbfcf
            // 
            this.lblbfcf.AutoSize = true;
            this.lblbfcf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbfcf.Location = new System.Drawing.Point(540, 171);
            this.lblbfcf.Name = "lblbfcf";
            this.lblbfcf.Size = new System.Drawing.Size(135, 20);
            this.lblbfcf.TabIndex = 30;
            this.lblbfcf.Text = "Consultion Fee";
            // 
            // lblbfap
            // 
            this.lblbfap.AutoSize = true;
            this.lblbfap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbfap.Location = new System.Drawing.Point(542, 132);
            this.lblbfap.Name = "lblbfap";
            this.lblbfap.Size = new System.Drawing.Size(159, 20);
            this.lblbfap.TabIndex = 28;
            this.lblbfap.Text = "Appointment Date";
            // 
            // lblbfdc
            // 
            this.lblbfdc.AutoSize = true;
            this.lblbfdc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbfdc.Location = new System.Drawing.Point(540, 99);
            this.lblbfdc.Name = "lblbfdc";
            this.lblbfdc.Size = new System.Drawing.Size(120, 20);
            this.lblbfdc.TabIndex = 26;
            this.lblbfdc.Text = "Doctor Name";
            // 
            // lblbfpt
            // 
            this.lblbfpt.AutoSize = true;
            this.lblbfpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbfpt.Location = new System.Drawing.Point(540, 65);
            this.lblbfpt.Name = "lblbfpt";
            this.lblbfpt.Size = new System.Drawing.Size(122, 20);
            this.lblbfpt.TabIndex = 23;
            this.lblbfpt.Text = "Patient Name";
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1631, 115);
            this.tableLayoutPanel1.TabIndex = 20;
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
            this.pnllf.Location = new System.Drawing.Point(233, 22);
            this.pnllf.Name = "pnllf";
            this.pnllf.Size = new System.Drawing.Size(1165, 71);
            this.pnllf.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(399, 35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 40);
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
            this.label2.Size = new System.Drawing.Size(128, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "BILLING";
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
            // BillingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1631, 784);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "BillingForm";
            this.Text = "BillingForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BillingForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbf)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnllf.ResumeLayout(false);
            this.pnllf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtbfbid;
        private System.Windows.Forms.Label lblbid;
        private System.Windows.Forms.DataGridView dgvbf;
        private System.Windows.Forms.Button btnbfdlt;
        private System.Windows.Forms.DateTimePicker dtpbf;
        private System.Windows.Forms.TextBox txtbfta;
        private System.Windows.Forms.TextBox txtbftc;
        private System.Windows.Forms.TextBox txtbfmc;
        private System.Windows.Forms.TextBox txtbfcf;
        private System.Windows.Forms.ComboBox cmbbfap;
        private System.Windows.Forms.ComboBox cmbbfdc;
        private System.Windows.Forms.ComboBox cmbbfpt;
        private System.Windows.Forms.Label lblbfbd;
        private System.Windows.Forms.Label lblbfta;
        private System.Windows.Forms.Label lblbftc;
        private System.Windows.Forms.Label lblbfmc;
        private System.Windows.Forms.Label lblbfcf;
        private System.Windows.Forms.Label lblbfap;
        private System.Windows.Forms.Label lblbfdc;
        private System.Windows.Forms.Label lblbfpt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnllf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btngpdf;
        private System.Windows.Forms.Button btnbfup;
    }
}