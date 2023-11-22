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
    public partial class cart : Form
    {
        private FlowLayoutPanel flowLayoutPanel;

        public cart()
        {
            InitializeComponent();
        }

        private void cart_Load(object sender, EventArgs e)
        {   
            if(session.user != null)
            {
                flowLayoutPanel = new FlowLayoutPanel();
                flowLayoutPanel.Location = new Point(10, 80);
                flowLayoutPanel.Size = new Size(800, 400);
                flowLayoutPanel.FlowDirection = FlowDirection.TopDown;
                flowLayoutPanel.AutoScroll = true;
                flowLayoutPanel.WrapContents = false;
                user user = session.user;
                carts cart = user.getCart();
                List<cartItem> cartItems = cart.getCartItems();
                int locationPanel = 0;

                for (int i = 0; i < cartItems.Count; i++)
                {
                    Console.WriteLine(cartItems[i].getSl());
                    CheckBox checkBox = new CheckBox();
                    checkBox.Location = new Point(0, 80);
                    locationPanel += 100;
                    Panel panel1 = new Panel();
                    Label label1 = new Label();
                    Label label2 = new Label();
                    Label label3 = new Label();
                    Label label4 = new Label();
                    label4.Name = "id";
                    label4.Text = cartItems[i].getId() + "";
                    label4.Visible = false;
                    panel1.Size = new Size(600, 200);
                    label1.Text = cartItems[i].getProduct().getTenSp();
                    label2.Text = cartItems[i].getProduct().getGia() + "";
                    label3.Text = "x" + cartItems[i].getSl();
                    panel1.Location = new Point(0, locationPanel);
                    label1.Location = new Point(330, 50);
                    label2.Location = new Point(330, 80);
                    label3.Location = new Point(330, 100);
                    PictureBox picture1 = new PictureBox();
                    setImage(picture1);
                    picture1.Image = GetImage(cartItems[i].getProduct().getImage());
                    panel1.Controls.Add(label1);
                    panel1.Controls.Add(picture1);
                    panel1.Controls.Add(label2);
                    panel1.Controls.Add(label3);
                    panel1.Controls.Add(checkBox);
                    panel1.Controls.Add(label4);
                    flowLayoutPanel.Controls.Add(panel1);

                }
                this.Controls.Add(flowLayoutPanel);
            }

            button1.Cursor = Cursors.Hand;
        }
        private Image GetImage(String fileName)
        {
            string imagePath = Path.Combine(Application.StartupPath, "..\\..\\images", fileName);
            return Image.FromFile(imagePath);
        }
        private void setImage(PictureBox picture)
        {
            picture.Location = new Point(20, 10);
            picture.Width = 300;
            picture.Height = 150;
            picture.Dock = DockStyle.None;
            picture.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(session.user == null)
            {
                DangNhap dangNhap = new DangNhap();
                dangNhap.ShowDialog();
                return;
            }
            carts cart = session.user.getCart();
            if(cart.getCartItems().Count <= 0)
            {
                MessageBox.Show("giỏ hàng hiện không có sản phẩm");
                return;
            }
            List<cartItem> cartItems = new List<cartItem>();
            List<billItem> billItems = new List<billItem>();
            foreach (Control c in flowLayoutPanel.Controls)
            {
                if (c is Panel)
                {
                    Panel panel = (Panel)c;
                    foreach (Control ctrl in panel.Controls)
                    {
                       
                        if (ctrl is CheckBox)
                        {
                            CheckBox checkbox = (CheckBox)ctrl;
                            if (checkbox.Checked)
                            {

                                foreach (Control label in panel.Controls)
                                {
                                    if(label is Label)
                                    {
                                        
                                        Label labelCtrl = (Label)label;
                                        switch (labelCtrl.Name)
                                        {
                                            case "id":
                                                cartItem cartItem = cart.findById(long.Parse(labelCtrl.Text));
                                                cartItems.Add(cartItem);
                                                billItem bill = new billItem(cartItem.getProduct(), cartItem.getSl(), cartItem.getProduct().getGia() * cartItem.getSl());
                                                billItems.Add(bill);
                                                break;
                                            
                                        }
                                       
                                    }
                                   
                                }


                            }
                        }
                    }
                   
                }
               
            }
            String maHd = "HD" + (component.model.getBills().Count + 1);
            bill bill1 = new bill(maHd, session.user, billItems, component.model.totalBill(billItems), DateTime.Now);
            component.model.addBill(bill1);
            cart.removeItems(cartItems);
            MessageBox.Show("Mua hàng thành công");
            this.Dispose();
        }
    }
}
