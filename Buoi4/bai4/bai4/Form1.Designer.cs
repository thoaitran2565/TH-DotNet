namespace bai4
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSonguyen = new System.Windows.Forms.TextBox();
            this.btCapnhat = new System.Windows.Forms.Button();
            this.lstKetqua = new System.Windows.Forms.ListBox();
            this.btKetthuc = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btXoaphantudau = new System.Windows.Forms.Button();
            this.btXoaphantucuoi = new System.Windows.Forms.Button();
            this.btLecuoi = new System.Windows.Forms.Button();
            this.btXoaphantudangchon = new System.Windows.Forms.Button();
            this.btChonchandau = new System.Windows.Forms.Button();
            this.btTang2 = new System.Windows.Forms.Button();
            this.errSonguyen = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errSonguyen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số nguyên:";
            // 
            // txtSonguyen
            // 
            this.txtSonguyen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSonguyen.Location = new System.Drawing.Point(194, 59);
            this.txtSonguyen.Name = "txtSonguyen";
            this.txtSonguyen.Size = new System.Drawing.Size(317, 30);
            this.txtSonguyen.TabIndex = 1;
            this.txtSonguyen.TextChanged += new System.EventHandler(this.txtSonguyen_TextChanged);
            // 
            // btCapnhat
            // 
            this.btCapnhat.BackColor = System.Drawing.SystemColors.Info;
            this.btCapnhat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCapnhat.Location = new System.Drawing.Point(555, 59);
            this.btCapnhat.Name = "btCapnhat";
            this.btCapnhat.Size = new System.Drawing.Size(119, 33);
            this.btCapnhat.TabIndex = 2;
            this.btCapnhat.Text = "Cập nhật";
            this.btCapnhat.UseVisualStyleBackColor = false;
            this.btCapnhat.Click += new System.EventHandler(this.btCapnhat_Click);
            // 
            // lstKetqua
            // 
            this.lstKetqua.FormattingEnabled = true;
            this.lstKetqua.ItemHeight = 25;
            this.lstKetqua.Location = new System.Drawing.Point(31, 128);
            this.lstKetqua.Name = "lstKetqua";
            this.lstKetqua.Size = new System.Drawing.Size(311, 354);
            this.lstKetqua.TabIndex = 3;
            // 
            // btKetthuc
            // 
            this.btKetthuc.BackColor = System.Drawing.SystemColors.Info;
            this.btKetthuc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btKetthuc.Location = new System.Drawing.Point(31, 503);
            this.btKetthuc.Name = "btKetthuc";
            this.btKetthuc.Size = new System.Drawing.Size(643, 38);
            this.btKetthuc.TabIndex = 4;
            this.btKetthuc.Text = "Kết thúc";
            this.btKetthuc.UseVisualStyleBackColor = false;
            this.btKetthuc.Click += new System.EventHandler(this.btKetthuc_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btXoaphantudau);
            this.groupBox1.Controls.Add(this.btXoaphantucuoi);
            this.groupBox1.Controls.Add(this.btLecuoi);
            this.groupBox1.Controls.Add(this.btXoaphantudangchon);
            this.groupBox1.Controls.Add(this.btChonchandau);
            this.groupBox1.Controls.Add(this.btTang2);
            this.groupBox1.Location = new System.Drawing.Point(376, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 369);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btXoaphantudau
            // 
            this.btXoaphantudau.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btXoaphantudau.Location = new System.Drawing.Point(19, 253);
            this.btXoaphantudau.Name = "btXoaphantudau";
            this.btXoaphantudau.Size = new System.Drawing.Size(260, 37);
            this.btXoaphantudau.TabIndex = 0;
            this.btXoaphantudau.Text = "xóa phần tử đầu";
            this.btXoaphantudau.UseVisualStyleBackColor = true;
            this.btXoaphantudau.Click += new System.EventHandler(this.btXoaphantudau_Click);
            // 
            // btXoaphantucuoi
            // 
            this.btXoaphantucuoi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btXoaphantucuoi.Location = new System.Drawing.Point(19, 308);
            this.btXoaphantucuoi.Name = "btXoaphantucuoi";
            this.btXoaphantucuoi.Size = new System.Drawing.Size(260, 37);
            this.btXoaphantucuoi.TabIndex = 0;
            this.btXoaphantucuoi.Text = "xóa phần tử cuối";
            this.btXoaphantucuoi.UseVisualStyleBackColor = true;
            this.btXoaphantucuoi.Click += new System.EventHandler(this.btXoaphantucuoi_Click);
            // 
            // btLecuoi
            // 
            this.btLecuoi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btLecuoi.Location = new System.Drawing.Point(19, 146);
            this.btLecuoi.Name = "btLecuoi";
            this.btLecuoi.Size = new System.Drawing.Size(260, 37);
            this.btLecuoi.TabIndex = 0;
            this.btLecuoi.Text = "chọn số lẻ cuối";
            this.btLecuoi.UseVisualStyleBackColor = true;
            this.btLecuoi.Click += new System.EventHandler(this.btLecuoi_Click);
            // 
            // btXoaphantudangchon
            // 
            this.btXoaphantudangchon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btXoaphantudangchon.Location = new System.Drawing.Point(19, 199);
            this.btXoaphantudangchon.Name = "btXoaphantudangchon";
            this.btXoaphantudangchon.Size = new System.Drawing.Size(260, 37);
            this.btXoaphantudangchon.TabIndex = 0;
            this.btXoaphantudangchon.Text = "xóa phần tử đang chọn";
            this.btXoaphantudangchon.UseVisualStyleBackColor = true;
            this.btXoaphantudangchon.Click += new System.EventHandler(this.btXoaphantudangchon_Click);
            // 
            // btChonchandau
            // 
            this.btChonchandau.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btChonchandau.Location = new System.Drawing.Point(19, 94);
            this.btChonchandau.Name = "btChonchandau";
            this.btChonchandau.Size = new System.Drawing.Size(260, 37);
            this.btChonchandau.TabIndex = 0;
            this.btChonchandau.Text = "chọn số chẳn đầu";
            this.btChonchandau.UseVisualStyleBackColor = true;
            this.btChonchandau.Click += new System.EventHandler(this.btChonchandau_Click);
            // 
            // btTang2
            // 
            this.btTang2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btTang2.Location = new System.Drawing.Point(19, 41);
            this.btTang2.Name = "btTang2";
            this.btTang2.Size = new System.Drawing.Size(260, 37);
            this.btTang2.TabIndex = 0;
            this.btTang2.Text = "tăng mỗi phần từ lên 2";
            this.btTang2.UseVisualStyleBackColor = true;
            this.btTang2.Click += new System.EventHandler(this.btTang2_Click);
            // 
            // errSonguyen
            // 
            this.errSonguyen.ContainerControl = this;
            // 
            // Form1
            // 
            this.AcceptButton = this.btCapnhat;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(707, 562);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btKetthuc);
            this.Controls.Add(this.lstKetqua);
            this.Controls.Add(this.btCapnhat);
            this.Controls.Add(this.txtSonguyen);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errSonguyen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSonguyen;
        private System.Windows.Forms.Button btCapnhat;
        private System.Windows.Forms.ListBox lstKetqua;
        private System.Windows.Forms.Button btKetthuc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btXoaphantudau;
        private System.Windows.Forms.Button btXoaphantucuoi;
        private System.Windows.Forms.Button btLecuoi;
        private System.Windows.Forms.Button btXoaphantudangchon;
        private System.Windows.Forms.Button btChonchandau;
        private System.Windows.Forms.Button btTang2;
        private System.Windows.Forms.ErrorProvider errSonguyen;
    }
}

