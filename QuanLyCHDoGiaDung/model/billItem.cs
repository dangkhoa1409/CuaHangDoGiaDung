using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCHDoGiaDung.model
{
    class billItem
    {
		private product sp;
		private int sl;
		private float total;
		public product getSp()
		{
			return sp;
		}
		public void setSp(product sp)
		{
			this.sp = sp;
		}
		public int getSl()
		{
			return sl;
		}
		public void setSl(int sl)
		{
			this.sl = sl;
		}
		public float getTotal()
		{
			return total;
		}
		public void setTotal(float total)
		{
			this.total = total;
		}
		public billItem(product sp, int sl, float total)
		{
			this.sp = sp;
			this.sl = sl;
			this.total = total;
		}
	}
}
