using QuanLyCHDoGiaDung.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCHDoGiaDung
{
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        internal void renderData(bill bill)
        {
            label8.Text = bill.getMaHd();
            label9.Text = bill.getCreateDate().ToString();
            label11.Text = bill.getKh().getTen();
            label12.Text = bill.getKh().getMa();
            label13.Text = bill.getKh().getDiaChi();
            renderBillItem(bill.getBillItems());
        }
        private void renderBillItem(List<billItem> billItems)
        {
            foreach(billItem billItem in billItems)
            {
                ListViewItem newItem = new ListViewItem(billItem.getSp().getMaSp());
                newItem.SubItems.Add(billItem.getSp().getTenSp());
                newItem.SubItems.Add(billItem.getSl()+"");
                newItem.SubItems.Add(billItem.getTotal() + "");
                listView1.Items.Add(newItem);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
