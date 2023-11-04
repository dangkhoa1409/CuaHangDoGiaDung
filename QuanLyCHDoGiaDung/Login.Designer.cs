
namespace QuanLyCHDoGiaDung
{
    partial class Login
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTKDangNhap = new System.Windows.Forms.TextBox();
            this.lblMKDangNhap = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnXacNhanDangNhap = new System.Windows.Forms.Button();
            this.btnTroLaiDangNhap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Firebrick;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(783, 89);
            this.label4.TabIndex = 0;
            this.label4.Text = "ĐĂNG NHẬP";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(123, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 31);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tài khoản";
            // 
            // lblTKDangNhap
            // 
            this.lblTKDangNhap.Location = new System.Drawing.Point(276, 127);
            this.lblTKDangNhap.Name = "lblTKDangNhap";
            this.lblTKDangNhap.Size = new System.Drawing.Size(384, 31);
            this.lblTKDangNhap.TabIndex = 2;
            // 
            // lblMKDangNhap
            // 
            this.lblMKDangNhap.Location = new System.Drawing.Point(276, 188);
            this.lblMKDangNhap.Name = "lblMKDangNhap";
            this.lblMKDangNhap.Size = new System.Drawing.Size(384, 31);
            this.lblMKDangNhap.TabIndex = 4;
            this.lblMKDangNhap.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(123, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 31);
            this.label6.TabIndex = 3;
            this.label6.Text = "Mật khẩu";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnXacNhanDangNhap
            // 
            this.btnXacNhanDangNhap.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnXacNhanDangNhap.Location = new System.Drawing.Point(129, 263);
            this.btnXacNhanDangNhap.Name = "btnXacNhanDangNhap";
            this.btnXacNhanDangNhap.Size = new System.Drawing.Size(181, 57);
            this.btnXacNhanDangNhap.TabIndex = 5;
            this.btnXacNhanDangNhap.Text = "Xác nhận";
            this.btnXacNhanDangNhap.UseVisualStyleBackColor = false;
            this.btnXacNhanDangNhap.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnTroLaiDangNhap
            // 
            this.btnTroLaiDangNhap.BackColor = System.Drawing.Color.White;
            this.btnTroLaiDangNhap.Location = new System.Drawing.Point(479, 263);
            this.btnTroLaiDangNhap.Name = "btnTroLaiDangNhap";
            this.btnTroLaiDangNhap.Size = new System.Drawing.Size(181, 57);
            this.btnTroLaiDangNhap.TabIndex = 6;
            this.btnTroLaiDangNhap.Text = "Trở lại";
            this.btnTroLaiDangNhap.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            this.ClientSize = new System.Drawing.Size(783, 392);
            this.Controls.Add(this.btnTroLaiDangNhap);
            this.Controls.Add(this.btnXacNhanDangNhap);
            this.Controls.Add(this.lblMKDangNhap);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTKDangNhap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "Login";
            this.Text = "Đăng nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lblTKDangNhap;
        private System.Windows.Forms.TextBox lblMKDangNhap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnXacNhanDangNhap;
        private System.Windows.Forms.Button btnTroLaiDangNhap;
    }
}