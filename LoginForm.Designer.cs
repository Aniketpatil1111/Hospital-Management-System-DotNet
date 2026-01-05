namespace HospitalMS
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.txtlfUn = new System.Windows.Forms.TextBox();
            this.lbllfUn = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblps = new System.Windows.Forms.Label();
            this.txtps = new System.Windows.Forms.TextBox();
            this.btnlg = new System.Windows.Forms.Button();
            this.pnllf = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnllogin = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnllf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnllogin.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtlfUn
            // 
            this.txtlfUn.Location = new System.Drawing.Point(206, 51);
            this.txtlfUn.Name = "txtlfUn";
            this.txtlfUn.Size = new System.Drawing.Size(205, 22);
            this.txtlfUn.TabIndex = 2;
            // 
            // lbllfUn
            // 
            this.lbllfUn.AutoSize = true;
            this.lbllfUn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllfUn.Location = new System.Drawing.Point(29, 41);
            this.lbllfUn.Name = "lbllfUn";
            this.lbllfUn.Size = new System.Drawing.Size(152, 32);
            this.lbllfUn.TabIndex = 1;
            this.lbllfUn.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 2;
            // 
            // lblps
            // 
            this.lblps.AutoSize = true;
            this.lblps.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblps.Location = new System.Drawing.Point(29, 105);
            this.lblps.Name = "lblps";
            this.lblps.Size = new System.Drawing.Size(146, 32);
            this.lblps.TabIndex = 3;
            this.lblps.Text = "Password";
            // 
            // txtps
            // 
            this.txtps.Location = new System.Drawing.Point(206, 115);
            this.txtps.Name = "txtps";
            this.txtps.PasswordChar = '*';
            this.txtps.Size = new System.Drawing.Size(205, 22);
            this.txtps.TabIndex = 4;
            // 
            // btnlg
            // 
            this.btnlg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnlg.BackColor = System.Drawing.Color.DimGray;
            this.btnlg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlg.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlg.ForeColor = System.Drawing.Color.White;
            this.btnlg.Location = new System.Drawing.Point(183, 181);
            this.btnlg.Name = "btnlg";
            this.btnlg.Size = new System.Drawing.Size(136, 58);
            this.btnlg.TabIndex = 5;
            this.btnlg.Text = "Login";
            this.btnlg.UseVisualStyleBackColor = false;
            this.btnlg.Click += new System.EventHandler(this.btnlg_Click);
            // 
            // pnllf
            // 
            this.pnllf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnllf.BackColor = System.Drawing.Color.Black;
            this.pnllf.Controls.Add(this.pictureBox1);
            this.pnllf.Controls.Add(this.label1);
            this.pnllf.ForeColor = System.Drawing.Color.White;
            this.pnllf.Location = new System.Drawing.Point(133, 6);
            this.pnllf.Name = "pnllf";
            this.pnllf.Size = new System.Drawing.Size(1165, 71);
            this.pnllf.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(240, 18);
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
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 41);
            this.label1.TabIndex = 7;
            this.label1.Text = "HOSPITAL MANAGEMENT SYSTEM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnllogin
            // 
            this.pnllogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnllogin.BackColor = System.Drawing.Color.Gray;
            this.pnllogin.Controls.Add(this.lbllfUn);
            this.pnllogin.Controls.Add(this.txtlfUn);
            this.pnllogin.Controls.Add(this.btnlg);
            this.pnllogin.Controls.Add(this.lblps);
            this.pnllogin.Controls.Add(this.txtps);
            this.pnllogin.Location = new System.Drawing.Point(373, 199);
            this.pnllogin.Name = "pnllogin";
            this.pnllogin.Size = new System.Drawing.Size(513, 258);
            this.pnllogin.TabIndex = 7;
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1301, 84);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1301, 594);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pnllogin);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnllf.ResumeLayout(false);
            this.pnllf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnllogin.ResumeLayout(false);
            this.pnllogin.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtlfUn;
        private System.Windows.Forms.Label lbllfUn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblps;
        private System.Windows.Forms.TextBox txtps;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnllf;
        private System.Windows.Forms.Button btnlg;
        private System.Windows.Forms.Panel pnllogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}