using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing.Imaging;
namespace QuanLyCHDoGiaDung.model
{
    class model
    {
        private List<bill> bills;
        private List<user> users;
        private List<category> categories;
        private List<product> products;
        public model()
        {
            this.init();
        }
        public void init()
        {
            initUser();
            initProduct();
            initBill();
            
        }

        internal product findProductByTenSp(string text)
        {
            foreach (product product in products)
            {
                if (product.getTenSp().Equals(text))
                {
                    return product;
                }
            }
            return null;
        }

        internal Boolean login(string text1, string text2)
        {
            foreach(user user in users)
            {
                Console.WriteLine(user.getUserName() + "|| " + text1);
                if (user.getUserName().Equals(text1.Trim()))
                {
                    if (user.getPassword().Equals(text2.Trim()))
                    {
                        session.user = user;
                        return true;
                    }
                }
            }
            return false;
        }

        internal List<user> getUsers()
        {
            return users;
        }

        private void initProduct()
        {
            products = new List<product>();
            categories = new List<category>();
            category category1 = new category("Chảo", "chao");
            category category2 = new category("Nồi", "noi");
            category category3 = new category("Dao", "chao");
            category category4 = new category("Tô chén dĩa", "to-chen-dia");
            category category5 = new category("Khác", "khac");
            categories.Add(category1);
            categories.Add(category2);
            categories.Add(category3);
            categories.Add(category4);
            categories.Add(category5);
            product product1 = new product("SP001", "Chảo không dính", category1, "chao-khong-dinh.jpg", 50, 100000);
            product product2 = new product("SP002", "Nồi ", category2, "noi-inox.jpg", 100, 50000);
            product product3 = new product("SP003", "Dao thái lan", category3, "dao-thai-lan.png", 400, 80000);
            product product4 = new product("SP004", "Chén sành", category4, "noi-inox.jpg", 50, 30000);
            product product5 = new product("SP005", "Thớt", category5, "thot.jpg", 50, 120000);
            products.Add(product1);
            products.Add(product2);
            products.Add(product3);
            products.Add(product4);
            products.Add(product5);
        }

        internal void addUser(user user)
        {
            this.users.Add(user);
        }

        internal void addBill(bill bill)
        {
            this.bills.Add(bill);
        }

        private void initBill()
        {
            bills = new List<bill>();
            billItem billItem = new billItem(products[0], 2, products[0].getGia() * 2);
            billItem billItem1 = new billItem(products[1], 3, products[1].getGia() * 3);
            List<billItem> bills1 = new List<billItem>();
            bills1.Add(billItem);
            bills1.Add(billItem1);
            bill bill1 = new bill("HD01", users[2], bills1, totalBill(bills1), DateTime.Now);
            billItem billItem2 = new billItem(products[0], 2, products[0].getGia() * 2);
            List<billItem> bills2 = new List<billItem>();
            bills2.Add(billItem2);
            bill bill2 = new bill("HD02", users[1], bills2, totalBill(bills2), DateTime.Now);
            bills.Add(bill1);
            bills.Add(bill2);
            Console.WriteLine("success");

        }
        public float totalBill(List<billItem> billItems)
        {
            float total = 0;
            foreach(billItem billItem in billItems)
            {
                total += billItem.getTotal();
            }
            return total;
                
        }
        private void initUser()
        {
            users = new List<user>();
            user user1 = new user("admin", "admin", "U01", "Admin", "bien hoa", "ADMIN", DateTime.Now);
            user user2 = new user("ntk", "123", "U02", "Tuan Kiet", "bien hoa", "USER", DateTime.Now);
            user user3 = new user("messi", "123", "U03", "Lionel Messi", "bien hoa", "USER", DateTime.Now);
            user user4 = new user("bathello", "123", "U04", "Yasou", "bien hoa", "USER", DateTime.Now);
            users.Add(user1);
            users.Add(user2);
            users.Add(user3);
            users.Add(user4);
        }
        public List<product> getProducts()
        {
            return products;
        }
        public category findCategory(String category)
        {
            foreach(category cate in categories)
            {
                if (cate.getName().Equals(category))
                {
                    return cate;
                }
            }
            return null;
        }

        internal void updateProductById(product product)
        {
            for (int i =0; i < products.Count;i ++)
            {
                if (products[i].getMaSp().Equals(product.getMaSp()))
                {
                     products[i] = product;
                    
                }
            }

        }
       public product getProductById(String maSp)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].getMaSp().Equals(maSp))
                {

                    return products[i];

                }
            }
            return null;
        }
        

        public void addProduct(product product)
        {
            this.products.Add(product);
        }
        public List<category> getCategories()
        {
            return this.categories;
        }
        public List<bill> getBills()
        {
            return this.bills;
        }

        public bill findBillByMaHd(string maHd)
        {
           foreach(bill bill in bills)
            {
                if (bill.getMaHd().Equals(maHd))
                {
                    return bill;
                }
            }
            return null;
        }

        internal product findProductByMaSp(string maSp)
        {
            foreach (product product in products)
            {
                if (product.getMaSp().Equals(maSp))
                {
                    return product;
                }
            }
            return null;
        }
    }
}
