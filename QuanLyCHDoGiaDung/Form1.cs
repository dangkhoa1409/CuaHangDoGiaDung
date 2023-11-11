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
using System.IO;
using System.Drawing.Imaging;
namespace QuanLyCHDoGiaDung
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
            string imagePath = Path.Combine(Application.StartupPath, "..\\..\\images");
            Image image = Image.FromFile("C:\\Users\\MSI PC\\Desktop\\C7_KietNgoTuan.png");
            Image newImage = new Bitmap(image);
            image.Save("C:\\Users\\MSI PC\\source\\repos\\CuaHangDoGiaDung\\CuaHangDoGiaDung\\QuanLyCHDoGiaDung\\images\\C7_KietNgoTuan.png",ImageFormat.Png);
            string imagePath2 = Path.Combine(Application.StartupPath, "..\\..\\images", "C7_KietNgoTuan.png");
            pictureBox1.Image = Image.FromFile(imagePath2);


        }
    }
}
