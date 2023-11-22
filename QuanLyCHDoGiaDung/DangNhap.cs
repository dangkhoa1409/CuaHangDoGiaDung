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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            button1.Cursor = Cursors.Hand;
        }

        private void button1_Click(object sender, EventArgs e)
        {  if(textBox1.Text != "" && textBox2.Text != "")
            {
                Boolean login = component.model.login(textBox1.Text, textBox2.Text);
                if (login)
                {
                    this.Close();
                    return;
                }
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
                this.textBox1.Clear();
                this.textBox2.Clear();
                this.textBox1.Focus();
                return;
            }
            else
            {
                check(errorProvider1, textBox1);
                check(errorProvider2, textBox2);
            }
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            DangKy form = new DangKy();
            form.ShowDialog();
        }
        private void check(ErrorProvider errorProvider, TextBox textBox)
        {
            if (textBox.Text == "")
            {
                errorProvider.SetError(textBox, "Không để được trống dữ liệu ");
            }
        }
    }
}
