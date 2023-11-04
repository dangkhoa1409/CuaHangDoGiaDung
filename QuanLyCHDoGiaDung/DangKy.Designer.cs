
namespace QuanLyCHDoGiaDung
{
    partial class DangKy
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
            this.lblTKDangKy = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMKDangKy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblXNDangKy = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXacNhanDangKy = new System.Windows.Forms.Button();
            this.btnTroLaiDangKy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Firebrick;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 83);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng ký";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTKDangKy
            // 
            this.lblTKDangKy.Location = new System.Drawing.Point(299, 120);
            this.lblTKDangKy.Name = "lblTKDangKy";
            this.lblTKDangKy.Size = new System.Drawing.Size(384, 31);
            this.lblTKDangKy.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(47, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 31);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tài khoản";
            // 
            // lblMKDangKy
            // 
            this.lblMKDangKy.Location = new System.Drawing.Point(299, 183);
            this.lblMKDangKy.Name = "lblMKDangKy";
            this.lblMKDangKy.Size = new System.Drawing.Size(384, 31);
            this.lblMKDangKy.TabIndex = 6;
            this.lblMKDangKy.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(47, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mật khẩu";
            // 
            // lblXNDangKy
            // 
            this.lblXNDangKy.Location = new System.Drawing.Point(299, 252);
            this.lblXNDangKy.Name = "lblXNDangKy";
            this.lblXNDangKy.Size = new System.Drawing.Size(384, 31);
            this.lblXNDangKy.TabIndex = 8;
            this.lblXNDangKy.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(47, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Xác nhận mật khẩu";
            // 
            // btnXacNhanDangKy
            // 
            this.btnXacNhanDangKy.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnXacNhanDangKy.Location = new System.Drawing.Point(63, 329);
            this.btnXacNhanDangKy.Name = "btnXacNhanDangKy";
            this.btnXacNhanDangKy.Size = new System.Drawing.Size(215, 72);
            this.btnXacNhanDangKy.TabIndex = 9;
            this.btnXacNhanDangKy.Text = "Xác nhận";
            this.btnXacNhanDangKy.UseVisualStyleBackColor = false;
            // 
            // btnTroLaiDangKy
            // 
            this.btnTroLaiDangKy.BackColor = System.Drawing.Color.White;
            this.btnTroLaiDangKy.Location = new System.Drawing.Point(468, 329);
            this.btnTroLaiDangKy.Name = "btnTroLaiDangKy";
            this.btnTroLaiDangKy.Size = new System.Drawing.Size(215, 72);
            this.btnTroLaiDangKy.TabIndex = 10;
            this.btnTroLaiDangKy.Text = "Trở lại";
            this.btnTroLaiDangKy.UseVisualStyleBackColor = false;
            // 
            // DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTroLaiDangKy);
            this.Controls.Add(this.btnXacNhanDangKy);
            this.Controls.Add(this.lblXNDangKy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMKDangKy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTKDangKy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "DangKy";
            this.Text = "DangKy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lblTKDangKy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lblMKDangKy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lblXNDangKy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnXacNhanDangKy;
        private System.Windows.Forms.Button btnTroLaiDangKy;
    }
}