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
using QuanLyCHDoGiaDung;
using System.IO;
 namespace QuanLyCHDoGiaDung
{
    public partial class showProduct : Form
    {
        private product product = null;
        public showProduct()
        {
            InitializeComponent();
        }

        internal void renderData(string text)
        {
            product =  component.model.findProductByTenSp(text);
            pictureBox1.Image = GetImage(product.getImage());
            setImage(pictureBox1);
            label1.Text = product.getTenSp();
            label2.Text = product.getGia()+"";
        }
        private Image GetImage(String fileName)
        {
            string imagePath = Path.Combine(Application.StartupPath, "..\\..\\images", fileName);
            return Image.FromFile(imagePath);
        }
        private void setImage(PictureBox picture)
        {
            picture.Dock = DockStyle.None;
            picture.SizeMode = PictureBoxSizeMode.StretchImage;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            int index = Int32.Parse(textBox1.Text);
            this.textBox1.Text = ++index > product.getSl() ? --index + "" : index+"";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = Int32.Parse(textBox1.Text);
            this.textBox1.Text = index >= 1 ? --index + "" : index+"";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!checkUser())
            {
                DangNhap form = new DangNhap();
                form.ShowDialog();
                return;
            }
            user user = session.user;
            int sl = Int32.Parse(textBox1.Text);
            float total = product.getGia() * sl;
            product.updateSl(sl);
            billItem billItem = new billItem(product, sl, total);
            List<billItem> billItems = new List<billItem>();
            billItems.Add(billItem);
            String maHd = "HD" + ((component.model.getBills().Count) + 1);
            bill bill = new bill(maHd, user, billItems, component.model.totalBill(billItems), DateTime.Now);
            component.model.addBill(bill);


        }
        private Boolean checkUser()
        {
            user user = session.user;
            return user != null ? true : false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!checkUser())
            {
                DangNhap form = new DangNhap();
                form.ShowDialog();
                return;
            }
            user user = session.user;
            int sl = Int32.Parse(textBox1.Text);
            float total = product.getGia() * sl;
            cartItem cartItem = new cartItem(++indentityId.id, product, sl, total);
            user.getCart().addItem(cartItem);
            MessageBox.Show("Đặt hàng thành công");
            this.Close();
        }

        private void showProduct_Load(object sender, EventArgs e)
        {
            if(session.user != null)
            {
                this.label4.Text = "Xin chào," + session.user.getTen();
                this.label4.Image = null;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
                String button = this.label1.Text;
           
                DangNhap form = new DangNhap();
                form.ShowDialog();
                if (session.user != null)
                {
                    this.label4.Text = "Xin chào," + session.user.getTen();
                    this.label4.Image = null;
            }
           
        }

        private void label3_Click(object sender, EventArgs e)
        {
            cart form = new cart();
            form.ShowDialog();
        }
    }
}
