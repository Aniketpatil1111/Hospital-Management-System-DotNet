namespace HospitalMS
{
    partial class DoctorForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorForm));
            this.txtdfnm = new System.Windows.Forms.TextBox();
            this.txtdfph = new System.Windows.Forms.TextBox();
            this.txtspec = new System.Windows.Forms.TextBox();
            this.lbldfph = new System.Windows.Forms.Label();
            this.btndfadd = new System.Windows.Forms.Button();
            this.lblspe = new System.Windows.Forms.Label();
            this.btndfUpt = new System.Windows.Forms.Button();
            this.lbldfnm = new System.Windows.Forms.Label();
            this.lbldctid = new System.Windows.Forms.Label();
            this.txtdfdid = new System.Windows.Forms.TextBox();
            this.btndfdlt = new System.Windows.Forms.Button();
            this.btndfclr = new System.Windows.Forms.Button();
            this.dgvdf = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnllf = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdf)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnllf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtdfnm
            // 
            this.txtdfnm.Location = new System.Drawing.Point(705, 147);
            this.txtdfnm.Margin = new System.Windows.Forms.Padding(4);
            this.txtdfnm.Name = "txtdfnm";
            this.txtdfnm.Size = new System.Drawing.Size(236, 28);
            this.txtdfnm.TabIndex = 4;
            // 
            // txtdfph
            // 
            this.txtdfph.Location = new System.Drawing.Point(705, 267);
            this.txtdfph.Margin = new System.Windows.Forms.Padding(4);
            this.txtdfph.Name = "txtdfph";
            this.txtdfph.Size = new System.Drawing.Size(236, 28);
            this.txtdfph.TabIndex = 8;
            // 
            // txtspec
            // 
            this.txtspec.Location = new System.Drawing.Point(705, 208);
            this.txtspec.Margin = new System.Windows.Forms.Padding(4);
            this.txtspec.Name = "txtspec";
            this.txtspec.Size = new System.Drawing.Size(236, 28);
            this.txtspec.TabIndex = 6;
            // 
            // lbldfph
            // 
            this.lbldfph.AutoSize = true;
            this.lbldfph.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldfph.Location = new System.Drawing.Point(511, 270);
            this.lbldfph.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldfph.Name = "lbldfph";
            this.lbldfph.Size = new System.Drawing.Size(88, 29);
            this.lbldfph.TabIndex = 7;
            this.lbldfph.Text = "Phone";
            // 
            // btndfadd
            // 
            this.btndfadd.BackColor = System.Drawing.Color.Gray;
            this.btndfadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndfadd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndfadd.Location = new System.Drawing.Point(431, 340);
            this.btndfadd.Margin = new System.Windows.Forms.Padding(4);
            this.btndfadd.Name = "btndfadd";
            this.btndfadd.Size = new System.Drawing.Size(126, 54);
            this.btndfadd.TabIndex = 9;
            this.btndfadd.Text = "Add";
            this.btndfadd.UseVisualStyleBackColor = false;
            this.btndfadd.Click += new System.EventHandler(this.btndfadd_Click);
            // 
            // lblspe
            // 
            this.lblspe.AutoSize = true;
            this.lblspe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblspe.Location = new System.Drawing.Point(511, 209);
            this.lblspe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblspe.Name = "lblspe";
            this.lblspe.Size = new System.Drawing.Size(177, 29);
            this.lblspe.TabIndex = 5;
            this.lblspe.Text = "Specialization";
            // 
            // btndfUpt
            // 
            this.btndfUpt.BackColor = System.Drawing.Color.Gray;
            this.btndfUpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndfUpt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndfUpt.Location = new System.Drawing.Point(592, 340);
            this.btndfUpt.Margin = new System.Windows.Forms.Padding(4);
            this.btndfUpt.Name = "btndfUpt";
            this.btndfUpt.Size = new System.Drawing.Size(119, 54);
            this.btndfUpt.TabIndex = 10;
            this.btndfUpt.Text = "Update";
            this.btndfUpt.UseVisualStyleBackColor = false;
            this.btndfUpt.Click += new System.EventHandler(this.btndfUpt_Click);
            // 
            // lbldfnm
            // 
            this.lbldfnm.AutoSize = true;
            this.lbldfnm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldfnm.Location = new System.Drawing.Point(511, 150);
            this.lbldfnm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldfnm.Name = "lbldfnm";
            this.lbldfnm.Size = new System.Drawing.Size(82, 29);
            this.lbldfnm.TabIndex = 3;
            this.lbldfnm.Text = "Name";
            // 
            // lbldctid
            // 
            this.lbldctid.AutoSize = true;
            this.lbldctid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldctid.Location = new System.Drawing.Point(511, 91);
            this.lbldctid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldctid.Name = "lbldctid";
            this.lbldctid.Size = new System.Drawing.Size(119, 29);
            this.lbldctid.TabIndex = 1;
            this.lbldctid.Text = "Doctor Id";
            // 
            // txtdfdid
            // 
            this.txtdfdid.Location = new System.Drawing.Point(705, 88);
            this.txtdfdid.Margin = new System.Windows.Forms.Padding(4);
            this.txtdfdid.Name = "txtdfdid";
            this.txtdfdid.ReadOnly = true;
            this.txtdfdid.Size = new System.Drawing.Size(236, 28);
            this.txtdfdid.TabIndex = 2;
            // 
            // btndfdlt
            // 
            this.btndfdlt.BackColor = System.Drawing.Color.Gray;
            this.btndfdlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndfdlt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndfdlt.Location = new System.Drawing.Point(749, 340);
            this.btndfdlt.Margin = new System.Windows.Forms.Padding(4);
            this.btndfdlt.Name = "btndfdlt";
            this.btndfdlt.Size = new System.Drawing.Size(126, 54);
            this.btndfdlt.TabIndex = 11;
            this.btndfdlt.Text = "Delete";
            this.btndfdlt.UseVisualStyleBackColor = false;
            this.btndfdlt.Click += new System.EventHandler(this.btndfdlt_Click);
            // 
            // btndfclr
            // 
            this.btndfclr.BackColor = System.Drawing.Color.Gray;
            this.btndfclr.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndfclr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndfclr.Location = new System.Drawing.Point(909, 340);
            this.btndfclr.Margin = new System.Windows.Forms.Padding(4);
            this.btndfclr.Name = "btndfclr";
            this.btndfclr.Size = new System.Drawing.Size(126, 54);
            this.btndfclr.TabIndex = 12;
            this.btndfclr.Text = "Clear";
            this.btndfclr.UseVisualStyleBackColor = false;
            this.btndfclr.Click += new System.EventHandler(this.btndfclr_Click);
            // 
            // dgvdf
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvdf.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdf.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvdf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvdf.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvdf.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvdf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdf.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvdf.EnableHeadersVisualStyles = false;
            this.dgvdf.GridColor = System.Drawing.Color.Silver;
            this.dgvdf.Location = new System.Drawing.Point(469, 443);
            this.dgvdf.Name = "dgvdf";
            this.dgvdf.RowHeadersWidth = 51;
            this.dgvdf.RowTemplate.Height = 24;
            this.dgvdf.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdf.Size = new System.Drawing.Size(472, 168);
            this.dgvdf.TabIndex = 13;
            this.dgvdf.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdf_CellClick);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1381, 121);
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
            this.pnllf.Location = new System.Drawing.Point(177, 25);
            this.pnllf.Name = "pnllf";
            this.pnllf.Size = new System.Drawing.Size(1165, 71);
            this.pnllf.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(396, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 50);
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
            this.label2.Size = new System.Drawing.Size(141, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "DOCTOR";
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
            this.panel1.Controls.Add(this.txtdfdid);
            this.panel1.Controls.Add(this.lbldctid);
            this.panel1.Controls.Add(this.dgvdf);
            this.panel1.Controls.Add(this.txtdfnm);
            this.panel1.Controls.Add(this.btndfadd);
            this.panel1.Controls.Add(this.btndfUpt);
            this.panel1.Controls.Add(this.btndfdlt);
            this.panel1.Controls.Add(this.btndfclr);
            this.panel1.Controls.Add(this.lbldfnm);
            this.panel1.Controls.Add(this.txtspec);
            this.panel1.Controls.Add(this.txtdfph);
            this.panel1.Controls.Add(this.lblspe);
            this.panel1.Controls.Add(this.lbldfph);
            this.panel1.Location = new System.Drawing.Point(0, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1369, 696);
            this.panel1.TabIndex = 20;
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 803);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DoctorForm";
            this.Text = "DoctorForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DoctorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdf)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnllf.ResumeLayout(false);
            this.pnllf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtdfnm;
        private System.Windows.Forms.TextBox txtdfph;
        private System.Windows.Forms.TextBox txtspec;
        private System.Windows.Forms.Label lbldfph;
        private System.Windows.Forms.Button btndfadd;
        private System.Windows.Forms.Label lblspe;
        private System.Windows.Forms.Button btndfUpt;
        private System.Windows.Forms.Label lbldfnm;
        private System.Windows.Forms.Label lbldctid;
        private System.Windows.Forms.TextBox txtdfdid;
        private System.Windows.Forms.Button btndfdlt;
        private System.Windows.Forms.Button btndfclr;
        private System.Windows.Forms.DataGridView dgvdf;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnllf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}