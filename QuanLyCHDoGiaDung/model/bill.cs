using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCHDoGiaDung.model
{
    class bill
    {
		private String maHd;
		private user kh;
		private List<billItem> billItems;
		private float total;
		private DateTime createDate;

		public String getMaHd()
		{
			return maHd;
		}

		public void setMaHd(String maHd)
		{
			this.maHd = maHd;
		}

		public user getKh()
		{
			return kh;
		}

		public void setKh(user kh)
		{
			this.kh = kh;
		}

		public List<billItem> getBillItems()
		{
			return billItems;
		}

		public void setBillItems(List<billItem> billItems)
		{
			this.billItems = billItems;
		}

		public float getTotal()
		{
			return total;
		}

		public void setTotal(float total)
		{
			this.total = total;
		}

		public DateTime getCreateDate()
		{
			return createDate;
		}

		public void setCreateDate(DateTime createDate)
		{
			this.createDate = createDate;
		}

		public bill(String maHd, user kh, List<billItem> billItems, float total, DateTime createDate)
		{
			this.maHd = maHd;
			this.kh = kh;
			this.billItems = billItems;
			this.total = total;
			this.createDate = createDate;
		}
	}
}
