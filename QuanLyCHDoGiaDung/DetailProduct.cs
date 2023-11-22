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
using System.Resources;
using QuanLyCHDoGiaDung.Properties;
using System.IO;
using System.Drawing.Imaging;
namespace QuanLyCHDoGiaDung
{
    public partial class DetailProduct : Form
    {
        private String image = null;
        public DetailProduct()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DetailProduct_Load(object sender, EventArgs e)
        {
            List<category> categories = component.model.getCategories();

            foreach(category category in categories)
            {
                Console.WriteLine(category.getName());
                comboBox1.Items.Add(category.getName());
            }
            List<product> products = component.model.getProducts();
            renderProduct(products);
        }
        private void renderProduct(List<product> products)
        {
            Console.WriteLine("render");
            foreach (product product in products)
            {
                ListViewItem newItem = new ListViewItem(product.getMaSp());
                newItem.SubItems.Add(product.getTenSp());
                newItem.SubItems.Add(product.getDanhMuc().getName());
                newItem.SubItems.Add(product.getImage());
                newItem.SubItems.Add(product.getSl() + "");
                newItem.SubItems.Add(product.getGia() + "");
                listView1.Items.Add(newItem);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Thiết lập các thuộc tính của OpenFileDialog
            openFileDialog.Filter = "Ảnh (*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            openFileDialog.Title = "Chọn ảnh";

            // Mở hộp thoại mở file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn đến file ảnh đã chọn
                string filePath = openFileDialog.FileName;
                image = filePath;
                textBox3.Text = filePath;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            product product = getProduct();
            component.model.addProduct(product);
            ListViewItem newItem = new ListViewItem(product.getMaSp());
            newItem.SubItems.Add(product.getTenSp());
            newItem.SubItems.Add(product.getDanhMuc().getName());
            newItem.SubItems.Add(product.getImage());
            newItem.SubItems.Add(product.getSl() + "");
            newItem.SubItems.Add(product.getGia() + "");
            listView1.Items.Add(newItem);
            addImage(product.getImage(), image);
            resetForm();
            image = null;
        }
        private void resetForm()
        {
            this.textBox1.Clear();
            this.textBox2.Clear();
            this.textBox3.Clear();
            this.textBox4.Clear();
            this.textBox5.Clear();
            this.comboBox1.SelectedIndex = 0;
        }
        private void addImage(String fileName, String filePath)
        {
            string imagePath = Path.Combine(Application.StartupPath, "..\\..\\images",fileName);
            Image image = Image.FromFile(filePath);
            image.Save(imagePath, ImageFormat.Png);

        }

        internal void renderData(product product)
        {
            textBox1.Text = product.getMaSp();
            textBox1.Enabled = false;
            textBox2.Text = product.getTenSp();
            comboBox1.SelectedItem = product.getDanhMuc().getName();
            textBox3.Text = product.getImage();
            textBox4.Text = product.getSl()+"";
            textBox5.Text = product.getGia() + "";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            product newProduct = getProduct();
            product product = component.model.getProductById(newProduct.getMaSp());
            if (!(newProduct.getImage().Equals(product.getImage())))
            {
                addImage(newProduct.getImage(), image);
            }
            component.model.updateProductById(newProduct);
            clearListView();
            List<product> products = component.model.getProducts();
            renderProduct(products);
            resetForm();
        }
        private void clearListView()
        {
            this.listView1.Items.Clear();
        }
        private product getProduct()
        {
            String maSp = textBox1.Text;

            String tenSp = textBox2.Text;
            category category = component.model.findCategory(comboBox1.SelectedItem.ToString());
            int index = 0;
            String textBoxImage = textBox3.Text;
            for (int i = textBoxImage.Length - 1; i >= 0; i--)
            {
                if (textBoxImage[i] == '\\')
                {
                    index = i;
                    break;
                }
            }

            String img = index > 0 ? textBoxImage.Substring(index + 1) : textBoxImage;
            int sl = Int32.Parse(textBox4.Text);
            float gia = float.Parse(textBox5.Text);
            product product = new product(maSp, tenSp, category, img, sl, gia);
            return product;
        }
    }
}
