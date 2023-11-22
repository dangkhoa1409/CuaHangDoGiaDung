using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCHDoGiaDung.model;
namespace QuanLyCHDoGiaDung
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }

        private void btnTroLaiDangKy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblXNDangKy_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void lblXNDangKy_KeyUp(object sender, KeyEventArgs e)
        {
            String confirmPass = lblXNDangKy.Text;
            String password = lblMKDangKy.Text;
            Console.WriteLine(password + "|| " + confirmPass);
            if (!confirmPass.Equals(password))
            {
                errorProvider1.SetError(lblXNDangKy, "Mật khẩu không trùng khớp");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void btnXacNhanDangKy_Click(object sender, EventArgs e)
        {
            String ma = "U" + (component.model.getUsers().Count + 1);
            String userName = lblTKDangKy.Text;
            String password = lblMKDangKy.Text;
            String ten = textBox1.Text;
            String diaChi = textBox2.Text;
            if(ma != "" && userName != "" && password != "" && ten != "" && diaChi != "")
            {
                user user = new user(userName, password, ma, ten, diaChi, "USER", DateTime.Now);
                component.model.addUser(user);
                this.Close();
            }
            else
            {
                check(errorProvider2, lblTKDangKy);
                check(errorProvider3, lblMKDangKy);
                check(errorProvider1, lblXNDangKy);
                check(errorProvider4, textBox1);
                check(errorProvider5, textBox2);

            }
           
        }
        private void check(ErrorProvider errorProvider, TextBox textBox)
        {
            if(textBox.Text == "")
            {
                errorProvider.SetError(textBox, "Không để được trống dữ liệu ");
            }
        }
        private void DangKy_Load(object sender, EventArgs e)
        {
            btnXacNhanDangKy.Cursor = Cursors.Hand;
            btnTroLaiDangKy.Cursor = Cursors.Hand;
        }
    }
}
