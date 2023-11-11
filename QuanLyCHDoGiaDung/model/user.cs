using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCHDoGiaDung.model
{
    class user
    {
		private String userName;
		private String password;
		private String ma;
		private String ten;
		private String diaChi;
		private String role;
		private carts cart = new carts();
		private DateTime createDate;
		public DateTime getCreateDate()
        {
			return this.createDate;
        }
		public void setCreateDate(DateTime time)
        {
			this.createDate = time;
        }
		public String getUserName()
		{
			return userName;
		}
		public void setUserName(String userName)
		{
			this.userName = userName;
		}
		public String getPassword()
		{
			return password;
		}
		public void setPassword(String password)
		{
			this.password = password;
		}
		public String getMa()
		{
			return ma;
		}
		public void setMa(String ma)
		{
			this.ma = ma;
		}
		public String getTen()
		{
			return ten;
		}
		public void setTen(String ten)
		{
			this.ten = ten;
		}
		public String getDiaChi()
		{
			return diaChi;
		}
		public void setDiaChi(String diaChi)
		{
			this.diaChi = diaChi;
		}
		public String getRole()
		{
			return role;
		}
		public void setRole(String role)
		{
			this.role = role;
		}
		public user(String userName, String password, String ma, String ten, String diaChi, String role,DateTime create)
		{
			this.userName = userName;
			this.password = password;
			this.ma = ma;
			this.ten = ten;
			this.diaChi = diaChi;
			this.role = role;
			this.createDate = create;
		}
		public carts getCart()
		{
			return this.cart;
		}
		public void setCart(carts carts)
		{
			this.cart = carts;
		}
	}
}
