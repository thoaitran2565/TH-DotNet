namespace Bai1_CacPhepToanCoBan
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtSon = new System.Windows.Forms.TextBox();
            this.txtSom = new System.Windows.Forms.TextBox();
            this.txtn = new System.Windows.Forms.Label();
            this.txtm = new System.Windows.Forms.Label();
            this.txtket = new System.Windows.Forms.Label();
            this.txtKetqua = new System.Windows.Forms.TextBox();
            this.btCong = new System.Windows.Forms.Button();
            this.btTru = new System.Windows.Forms.Button();
            this.btNhan = new System.Windows.Forms.Button();
            this.btChia = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(47, 22);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(411, 43);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "THỰC HIỆN CÁC PHÉP TÍNH";
            // 
            // txtSon
            // 
            this.txtSon.Location = new System.Drawing.Point(189, 83);
            this.txtSon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSon.Name = "txtSon";
            this.txtSon.Size = new System.Drawing.Size(251, 26);
            this.txtSon.TabIndex = 1;
            // 
            // txtSom
            // 
            this.txtSom.Location = new System.Drawing.Point(189, 117);
            this.txtSom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSom.Name = "txtSom";
            this.txtSom.Size = new System.Drawing.Size(251, 26);
            this.txtSom.TabIndex = 2;
            // 
            // txtn
            // 
            this.txtn.AutoSize = true;
            this.txtn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtn.Location = new System.Drawing.Point(67, 91);
            this.txtn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtn.Name = "txtn";
            this.txtn.Size = new System.Drawing.Size(86, 18);
            this.txtn.TabIndex = 4;
            this.txtn.Text = "Nhập số n:";
            // 
            // txtm
            // 
            this.txtm.AutoSize = true;
            this.txtm.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtm.Location = new System.Drawing.Point(67, 125);
            this.txtm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtm.Name = "txtm";
            this.txtm.Size = new System.Drawing.Size(90, 18);
            this.txtm.TabIndex = 5;
            this.txtm.Text = "Nhập số m:";
            // 
            // txtket
            // 
            this.txtket.AutoSize = true;
            this.txtket.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtket.Location = new System.Drawing.Point(67, 159);
            this.txtket.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtket.Name = "txtket";
            this.txtket.Size = new System.Drawing.Size(69, 18);
            this.txtket.TabIndex = 6;
            this.txtket.Text = "Kết quả:";
            // 
            // txtKetqua
            // 
            this.txtKetqua.BackColor = System.Drawing.Color.Khaki;
            this.txtKetqua.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtKetqua.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtKetqua.Location = new System.Drawing.Point(189, 151);
            this.txtKetqua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKetqua.Name = "txtKetqua";
            this.txtKetqua.Size = new System.Drawing.Size(251, 26);
            this.txtKetqua.TabIndex = 7;
            // 
            // btCong
            // 
            this.btCong.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCong.Location = new System.Drawing.Point(23, 191);
            this.btCong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btCong.Name = "btCong";
            this.btCong.Size = new System.Drawing.Size(79, 35);
            this.btCong.TabIndex = 8;
            this.btCong.Text = "+";
            this.btCong.UseVisualStyleBackColor = true;
            this.btCong.Click += new System.EventHandler(this.btCong_Click);
            // 
            // btTru
            // 
            this.btTru.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTru.Location = new System.Drawing.Point(110, 191);
            this.btTru.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btTru.Name = "btTru";
            this.btTru.Size = new System.Drawing.Size(79, 35);
            this.btTru.TabIndex = 9;
            this.btTru.Text = "-";
            this.btTru.UseVisualStyleBackColor = true;
            this.btTru.Click += new System.EventHandler(this.btTru_Click);
            // 
            // btNhan
            // 
            this.btNhan.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNhan.Location = new System.Drawing.Point(197, 191);
            this.btNhan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btNhan.Name = "btNhan";
            this.btNhan.Size = new System.Drawing.Size(79, 35);
            this.btNhan.TabIndex = 10;
            this.btNhan.Text = "*";
            this.btNhan.UseVisualStyleBackColor = true;
            this.btNhan.Click += new System.EventHandler(this.btNhan_Click);
            // 
            // btChia
            // 
            this.btChia.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChia.Location = new System.Drawing.Point(284, 191);
            this.btChia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btChia.Name = "btChia";
            this.btChia.Size = new System.Drawing.Size(79, 35);
            this.btChia.TabIndex = 11;
            this.btChia.Text = "/";
            this.btChia.UseVisualStyleBackColor = true;
            this.btChia.Click += new System.EventHandler(this.btChia_Click);
            // 
            // btXoa
            // 
            this.btXoa.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Location = new System.Drawing.Point(371, 191);
            this.btXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(79, 35);
            this.btXoa.TabIndex = 12;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Location = new System.Drawing.Point(458, 191);
            this.btThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(79, 35);
            this.btThoat.TabIndex = 13;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 242);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btChia);
            this.Controls.Add(this.btNhan);
            this.Controls.Add(this.btTru);
            this.Controls.Add(this.btCong);
            this.Controls.Add(this.txtKetqua);
            this.Controls.Add(this.txtket);
            this.Controls.Add(this.txtm);
            this.Controls.Add(this.txtn);
            this.Controls.Add(this.txtSom);
            this.Controls.Add(this.txtSon);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Tính Toán";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtSon;
        private System.Windows.Forms.TextBox txtSom;
        private System.Windows.Forms.Label txtn;
        private System.Windows.Forms.Label txtm;
        private System.Windows.Forms.Label txtket;
        private System.Windows.Forms.TextBox txtKetqua;
        private System.Windows.Forms.Button btCong;
        private System.Windows.Forms.Button btTru;
        private System.Windows.Forms.Button btNhan;
        private System.Windows.Forms.Button btChia;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThoat;

    }
}

