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
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            abc clazz = new abc();
            clazz.setImage("b7456707e25834066d49");
            Bitmap bmp = (Bitmap)Properties.Resources.ResourceManager.GetObject(clazz.getImage());

            this.BackgroundImage = bmp;
        }
    }
}
