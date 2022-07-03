namespace quanlyLTS3
{
    partial class BanDanhGiaNhanSu
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
            this.dtgvPhatTrienBanThan = new System.Windows.Forms.DataGridView();
            this.dtgvDiemDanhLab = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhatTrienBanThan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDiemDanhLab)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvPhatTrienBanThan
            // 
            this.dtgvPhatTrienBanThan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPhatTrienBanThan.Location = new System.Drawing.Point(292, 107);
            this.dtgvPhatTrienBanThan.Name = "dtgvPhatTrienBanThan";
            this.dtgvPhatTrienBanThan.RowHeadersWidth = 51;
            this.dtgvPhatTrienBanThan.RowTemplate.Height = 24;
            this.dtgvPhatTrienBanThan.Size = new System.Drawing.Size(349, 86);
            this.dtgvPhatTrienBanThan.TabIndex = 0;
            // 
            // dtgvDiemDanhLab
            // 
            this.dtgvDiemDanhLab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDiemDanhLab.Location = new System.Drawing.Point(292, 212);
            this.dtgvDiemDanhLab.Name = "dtgvDiemDanhLab";
            this.dtgvDiemDanhLab.RowHeadersWidth = 51;
            this.dtgvDiemDanhLab.RowTemplate.Height = 24;
            this.dtgvDiemDanhLab.Size = new System.Drawing.Size(349, 88);
            this.dtgvDiemDanhLab.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "ĐIỂM DANH HỌP LAB ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "ĐIỂM NHÂN SỰ ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "ĐIỂM DANH NHÓM PTBT ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(292, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 22);
            this.textBox1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "MÃ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(292, 316);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(208, 22);
            this.textBox2.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(556, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BanDanhGiaNhanSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvDiemDanhLab);
            this.Controls.Add(this.dtgvPhatTrienBanThan);
            this.Name = "BanDanhGiaNhanSu";
            this.Text = "BanDanhGiaNhanSu";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhatTrienBanThan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDiemDanhLab)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvPhatTrienBanThan;
        private System.Windows.Forms.DataGridView dtgvDiemDanhLab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
    }
}