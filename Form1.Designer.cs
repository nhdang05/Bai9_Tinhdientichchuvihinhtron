namespace Bai9_Tinhdientichchuvihinhtron
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBanKInh = new System.Windows.Forms.Label();
            this.txtBK = new System.Windows.Forms.TextBox();
            this.txtDT = new System.Windows.Forms.TextBox();
            this.txtCV = new System.Windows.Forms.TextBox();
            this.txtKQ = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbDT = new System.Windows.Forms.RadioButton();
            this.rdbCV = new System.Windows.Forms.RadioButton();
            this.btnTinh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ỨNG DỤNG TÍNH DIỆN TÍCH VÀ CHU VI HÌNH TRÒN\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBanKInh
            // 
            this.txtBanKInh.AutoSize = true;
            this.txtBanKInh.Location = new System.Drawing.Point(85, 113);
            this.txtBanKInh.Name = "txtBanKInh";
            this.txtBanKInh.Size = new System.Drawing.Size(58, 13);
            this.txtBanKInh.TabIndex = 1;
            this.txtBanKInh.Text = "BÁN KÍNH";
            this.txtBanKInh.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtBK
            // 
            this.txtBK.Location = new System.Drawing.Point(200, 110);
            this.txtBK.Name = "txtBK";
            this.txtBK.Size = new System.Drawing.Size(161, 20);
            this.txtBK.TabIndex = 2;
            // 
            // txtDT
            // 
            this.txtDT.Location = new System.Drawing.Point(55, 174);
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(88, 20);
            this.txtDT.TabIndex = 3;
            this.txtDT.Text = "DIỆN TÍCH";
            // 
            // txtCV
            // 
            this.txtCV.Location = new System.Drawing.Point(160, 174);
            this.txtCV.Name = "txtCV";
            this.txtCV.Size = new System.Drawing.Size(92, 20);
            this.txtCV.TabIndex = 3;
            this.txtCV.Text = "CHU VI";
            // 
            // txtKQ
            // 
            this.txtKQ.AutoSize = true;
            this.txtKQ.Location = new System.Drawing.Point(85, 225);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(54, 13);
            this.txtKQ.TabIndex = 4;
            this.txtKQ.Text = "KẾT QUẢ";
            this.txtKQ.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(467, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "KẾT QUẢ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbCV);
            this.groupBox1.Controls.Add(this.rdbDT);
            this.groupBox1.Location = new System.Drawing.Point(552, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 161);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rdbDT
            // 
            this.rdbDT.AutoSize = true;
            this.rdbDT.Location = new System.Drawing.Point(18, 39);
            this.rdbDT.Name = "rdbDT";
            this.rdbDT.Size = new System.Drawing.Size(73, 17);
            this.rdbDT.TabIndex = 0;
            this.rdbDT.TabStop = true;
            this.rdbDT.Text = "Diện Tích";
            this.rdbDT.UseVisualStyleBackColor = true;
            // 
            // rdbCV
            // 
            this.rdbCV.AutoSize = true;
            this.rdbCV.Location = new System.Drawing.Point(18, 91);
            this.rdbCV.Name = "rdbCV";
            this.rdbCV.Size = new System.Drawing.Size(56, 17);
            this.rdbCV.TabIndex = 0;
            this.rdbCV.TabStop = true;
            this.rdbCV.Text = "Chu Vi";
            this.rdbCV.UseVisualStyleBackColor = true;
            this.rdbCV.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(208, 252);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(75, 23);
            this.btnTinh.TabIndex = 7;
            this.btnTinh.Text = "button1";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.txtCV);
            this.Controls.Add(this.txtDT);
            this.Controls.Add(this.txtBK);
            this.Controls.Add(this.txtBanKInh);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtBanKInh;
        private System.Windows.Forms.TextBox txtBK;
        private System.Windows.Forms.TextBox txtDT;
        private System.Windows.Forms.TextBox txtCV;
        private System.Windows.Forms.Label txtKQ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbCV;
        private System.Windows.Forms.RadioButton rdbDT;
        private System.Windows.Forms.Button btnTinh;
    }
}

