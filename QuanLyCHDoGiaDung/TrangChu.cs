using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using QuanLyCHDoGiaDung.model;
namespace QuanLyCHDoGiaDung
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void TrangChu_Load(object sender, EventArgs e)
            
        {
            
            // Thêm menu con **Home** vào MenuStrip
            /*MenuStrip menuStrip = new MenuStrip();
            menuStrip.Items.Add("Home");*/

            // Thêm menu item **About** vào menu **Home**
          /*  MenuItem menuItemAbout = new MenuItem("About");
            menuStrip.Items.Add("About");*/

            // Thêm lệnh **ClickAbout** vào menu item **About**
            /*this.Controls.Add(menuStrip);*/
            /* FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
             Panel panel1 = new Panel();
             Panel panel2 = new Panel();
             Panel panel3 = new Panel();
             Label label1 = new Label();
             Label label2 = new Label();
             Label label3 = new Label();
             PictureBox picture1 = new PictureBox();
             PictureBox picture2 = new PictureBox();
             PictureBox picture3 = new PictureBox();
             setImage(picture1);
             setImage(picture2);
             setImage(picture3);
             label1.Text = "Sản phẩm 1";
             label2.Text = "Sản phẩm 2";
             label3.Text = "Sản phẩm 3";
             label1.Location = new Point(10, 160);
             label2.Location = new Point(10, 160);
             label3.Location = new Point(10, 160);
             // Thiết lập thuộc tính cho các controls
             flowLayoutPanel.Location = new Point(10, 10);
             flowLayoutPanel.Size = new Size(1000, 1000);
             flowLayoutPanel.FlowDirection = FlowDirection.LeftToRight;

             panel1.Location = new Point(0, 0);
             panel1.Size = new Size(300, 200);
             panel1.Controls.Add(label1);
             panel1.Controls.Add(picture1);
             panel2.Location = new Point(0, 100);
             panel2.Size = new Size(300, 200);
             panel2.Controls.Add(label2);
             panel2.Controls.Add(picture2);
             panel3.Location = new Point(0, 200);
             panel3.Size = new Size(300, 200);
             panel3.Controls.Add(label3);
             panel3.Controls.Add(picture3);
             // Thêm các controls vào FlowLayoutPanel
             flowLayoutPanel.Controls.Add(panel1);
             flowLayoutPanel.Controls.Add(panel2);
             flowLayoutPanel.Controls.Add(panel3);

             // Thêm FlowLayoutPanel vào Form
             this.Controls.Add(flowLayoutPanel);*/
        }
        private void setImage(PictureBox picture)
        {
            picture.Width = 300;
            picture.Height = 150;
            picture.Dock = DockStyle.None;
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            
            picture.Location = new Point(10, 0);
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*MenuStrip menuStrip = new MenuStrip();
            menuStrip.Items.Add("Home");

            // Thêm menu item **About** vào menu **Home**
            MenuItem menuItemAbout = new MenuItem("About");
            menuStrip.Items.Add("About");
*/
            // Thêm lệnh **ClickAbout** vào menu item **About**
           
           
        }

        private void label5_MouseClick(object sender, MouseEventArgs e)
        {
            FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
            flowLayoutPanel.Location = new Point(10, 80);
            flowLayoutPanel.Size = new Size(1000, 1000);
            flowLayoutPanel.FlowDirection = FlowDirection.LeftToRight;
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.WrapContents = true;
            List<product> products = component.model.getProducts();
            int locationPanel = 0;
           
            for (int i = 0; i < products.Count; i++)
            {
                locationPanel += 100;
                Panel panel1 = new Panel();
                Label label1 = new Label();
                panel1.Size = new Size(300, 200);
                label1.Text = products[i].getTenSp();
                panel1.Location = new Point(0, locationPanel);
                label1.Location = new Point(10, 160);
                PictureBox picture1 = new PictureBox();
                setImage(picture1);
                picture1.Image = GetImage(products[i].getImage());
                panel1.Controls.Add(label1);
                panel1.Controls.Add(picture1);
                flowLayoutPanel.Controls.Add(panel1);
            }
            
            
            /*  Panel panel2 = new Panel();
              Panel panel3 = new Panel();

              Label label2 = new Label();
              Label label3 = new Label();

              PictureBox picture2 = new PictureBox();
              PictureBox picture3 = new PictureBox();

              setImage(picture2);
              setImage(picture3);
              label1.Text = "Sản phẩm 1";
              label2.Text = "Sản phẩm 2";
              label3.Text = "Sản phẩm 3";*/

            /*  label2.Location = new Point(10, 160);
              label3.Location = new Point(10, 160);
              // Thiết lập thuộc tính cho các controls


              panel1.Location = new Point(0, 0);
              panel1.Size = new Size(300, 200);

              panel2.Location = new Point(0, 100);
              panel2.Size = new Size(300, 200);
              panel2.Controls.Add(label2);
              panel2.Controls.Add(picture2);
              panel3.Location = new Point(0, 200);
              panel3.Size = new Size(300, 200);
              panel3.Controls.Add(label3);
              panel3.Controls.Add(picture3);
              // Thêm các controls vào FlowLayoutPanel

              flowLayoutPanel.Controls.Add(panel2);
              flowLayoutPanel.Controls.Add(panel3);*/

            // Thêm FlowLayoutPanel vào Form
            this.Controls.Add(flowLayoutPanel);
            foreach (Control ctrl in flowLayoutPanel.Controls)
            {
                if (ctrl is Panel)
                {
                    ctrl.Click += MyClickHandler;
                }
            }
        }
        private Image GetImage(String fileName)
        {
            string imagePath = Path.Combine(Application.StartupPath, "..\\..\\images",fileName);
            return Image.FromFile(imagePath);
        }
        private void MyClickHandler(object sender, EventArgs e)
        {
            Panel clickedPanel = sender as Panel;
            if (clickedPanel != null)
            {
                // Thực hiện hành động tại đây khi panel được nhấp vào
                foreach (Control childCtrl in clickedPanel.Controls)
                {
                    if (childCtrl is Label)
                    {
                        Label label = childCtrl as Label;
                        if (label != null)
                        {
                            showProduct form = new showProduct();
                            form.Show();
                            form.renderData(label.Text);
                        }
                    }
                }
                

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            String button = this.label1.Text;
            if (!button.Equals("Logout"))
            {
                DangNhap form = new DangNhap();
                form.ShowDialog();
                if (session.user != null)
                {
                    if (session.user.getRole().Equals("ADMIN"))
                    {
                        QuanLyTrangChu quanLyTrangChu = new QuanLyTrangChu();
                        quanLyTrangChu.ShowDialog();

                    }

                    this.label1.Text = "Logout";
                    this.label6.Text = "Xin chào," + session.user.getTen() + "| ";


                }
            }
            else
            {
                this.label6.Text = "";
                session.user = null;
                this.label1.Text = "Log in";
            }
            
        }

        private void label8_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }
    }
}
