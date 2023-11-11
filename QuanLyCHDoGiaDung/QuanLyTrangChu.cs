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
    public partial class QuanLyTrangChu : Form
    {
        public QuanLyTrangChu()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void QuanLyTrangChu_Load(object sender, EventArgs e)
        {
            TabPage tabPage = tabControl1.SelectedTab;
            if(tabPage.Text.Equals("TRANG CHỦ"))
            {
                lblSPTatCa.Text = totalProductSold() + "";
                label30.Text = productSoldToday() + "";
                lblKHTatCa.Text = totalCustomer() + "";
                label29.Text = customerToday() + "";
                lblDTTatCa.Text = revenueAllTime() + "";
                label22.Text = revenueTotalToday() + "";
                label8.Text = "SẢN PHẨM HIỆN CÓ \n" + totalProduct() ; 
            }


        }
        private int totalProduct()
        {
            return component.model.getProducts().Count;
        }
        private int totalCustomer()
        {
            return component.model.getUsers().Count;
        }
        private int customerToday()
        {
            int total = 0;
            DateTime today = DateTime.Now;
            String formatToday = today.ToString().Substring(0, today.ToString().IndexOf(" "));
            List<user> users = component.model.getUsers();
            for (int i = 0; i < users.Count; i++)
            {
                String formatDate = users[i].getCreateDate().ToString().Substring(0, users[i].getCreateDate().ToString().IndexOf(" "));
                if (formatToday.Equals(formatDate))
                {
                    total++;
                }
            }
            return total;
        }
        private float revenueTotalToday()
        {
            float total = 0;
            List<bill> bills = component.model.getBills();
            for (int i = 0; i < bills.Count; i++)
            {

                List<billItem> billItems = bills[i].getBillItems();
                for (int j = 0; j < billItems.Count; j++)
                {
                    total += billItems[j].getTotal();
                }
            }
            return total;
        }
        private float revenueAllTime()
        {
            float total = 0;
            DateTime today = DateTime.Now;
            String formatToday = today.ToString().Substring(0, today.ToString().IndexOf(" "));
            List<bill> bills = component.model.getBills();
            for (int i = 0; i < bills.Count; i++)
            {
                String formatDate = bills[i].getCreateDate().ToString().Substring(0, bills[i].getCreateDate().ToString().IndexOf(" "));
                if (formatToday.Equals(formatDate))
                {
                    List<billItem> billItems = bills[i].getBillItems();
                    for (int j = 0; j < billItems.Count; j++)
                    {
                        total += billItems[j].getTotal();
                    }
                }
            }
            return total;
        }
        private int totalProductSold()

        {
            int total = 0;
            List<bill> bills = component.model.getBills();
            for (int i = 0; i < bills.Count; i++)
            {
                List<billItem> billItems = bills[i].getBillItems();
                for(int j=0; j <billItems.Count; j++)
                {
                    total += billItems[j].getSl();
                }
            }
            return total;
        }
        private int productSoldToday()
        {
            int total = 0;
            DateTime today = DateTime.Now;
            String formatToday = today.ToString().Substring(0, today.ToString().IndexOf(" "));
            Console.WriteLine(formatToday);
            List<bill> bills = component.model.getBills();
            for(int i=0; i < bills.Count; i++)
            {
                String formatDate = bills[i].getCreateDate().ToString().Substring(0, bills[i].getCreateDate().ToString().IndexOf(" "));
                if (formatToday.Equals(formatDate)){
                    List<billItem> billItems = bills[i].getBillItems();
                    for (int j = 0; j < billItems.Count; j++)
                    {

                        total += billItems[j].getSl();
                    }
                }
                    
            }
            return total;
        }
        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void lblKHTatCa_Click(object sender, EventArgs e)
        {

        }

        private void lblKHThangNay_Click(object sender, EventArgs e)
        {

        }

        private void lblKHHomNay_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            DetailProduct form = new DetailProduct();
            form.ShowDialog();
            clearData(listView3);
            List<product> products = component.model.getProducts();
            renderProduct(products);
            
        }
        
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabPage tabPage = tabControl1.SelectedTab;
            if(tabPage.Text.Equals("SẢN PHẨM"))
            {
                clearData(listView3);
                List<product> products = component.model.getProducts();
                label19.Text = "TỔNG SẢN PHẨM \n" + products.Count;
                renderProduct(products);
            }
            else if(tabPage.Text.Equals("HOÁ ĐƠN"))
            {
                clearData(listView4);
                List<bill> bills = component.model.getBills();
                label26.Text = "TỔNG HÓA ĐƠN \n" + bills.Count;
                renderBill(bills);
            }
            else if (tabPage.Text.Equals("KHÁCH HÀNG"))
            {
                
                clearData(listView2);
                List<user> users = component.model.getUsers();
                label15.Text = "TỔNG KHÁCH HÀNG \n" + users.Count; 
                renderUser(users);
            }
        }
        private void clearData(ListView view)
        {
            view.Items.Clear();
        }
        private void renderItemUser(user user)
        {
            ListViewItem newItem = new ListViewItem(user.getMa());
            newItem.SubItems.Add(user.getTen());
            newItem.SubItems.Add(user.getDiaChi());
            listView2.Items.Add(newItem);
        }
        private void renderUser(List<user> users)
        {
            foreach(user user in users)
            {
                renderItemUser(user);
            }
        }
        private void renderBill(List<bill> bills)
        {
            foreach (bill bill in bills)
            {
                renderItemBill(bill);
            }

        }
        private void tabControl3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void renderItemProduct(product product)
        {
            ListViewItem newItem = new ListViewItem(product.getMaSp());
            newItem.SubItems.Add(product.getTenSp());
            newItem.SubItems.Add(product.getDanhMuc().getName());
            newItem.SubItems.Add(product.getImage());
            newItem.SubItems.Add(product.getSl() + "");
            newItem.SubItems.Add(product.getGia() + "");
            listView3.Items.Add(newItem);
        }
        private void renderProduct(List<product> products)
        {
            foreach (product product in products)
            {
                renderItemProduct(product);
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if(listView4.SelectedItems.Count > 0)
            {
                String maHd = listView4.SelectedItems[0].SubItems[0].Text;
                bill bill = component.model.findBillByMaHd(maHd);
                Bill form = new Bill();
                form.Show();
                form.renderData(bill);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {

            if (listView3.SelectedItems.Count > 0)
            {
                String maSp = listView3.SelectedItems[0].SubItems[0].Text;
                product product = component.model.findProductByMaSp(maSp);

                DetailProduct form = new DetailProduct();
                form.Show();
                form.renderData(product);
            }
        }

        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {
            String data = textBox3.Text;
            List<product> products = component.model.getProducts();
            foreach(product product in products)
            {
                if(product.getMaSp().Contains(data) || product.getTenSp().Contains(data))
                {
                    renderItemProduct(product);
                }
            }
        }
        private void renderItemBill(bill bill)
        {
            ListViewItem newItem = new ListViewItem(bill.getMaHd());
            newItem.SubItems.Add(bill.getKh().getTen());
            newItem.SubItems.Add(bill.getCreateDate().ToString());
            newItem.SubItems.Add(bill.getTotal() + "");
            listView4.Items.Add(newItem);
        }
        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            clearData(listView3);
        }

        private void textBox4_KeyUp(object sender, KeyEventArgs e)
        {
            String data = textBox4.Text;
            List<bill> bills= component.model.getBills();
            foreach (bill bill in bills)
            {
                if (bill.getKh().getTen().Contains(data) || bill.getMaHd().Contains(data))
                {
                    renderItemBill(bill);
                }
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            clearData(listView4);
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            clearData(listView2);
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            String data = textBox2.Text;
            List<user> users = component.model.getUsers();
            foreach (user user in users)
            {
                if (user.getTen().Contains(data) || user.getMa().Contains(data))
                {
                    renderItemUser(user);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
