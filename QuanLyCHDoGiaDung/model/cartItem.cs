using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCHDoGiaDung.model
{
    class cartItem
    {
		private long id;
		private product product;
		private int sl;
		private float total;
		public product getProduct()
		{
			return product;
		}
		public void setProduct(product product)
		{
			this.product = product;
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
		public cartItem(long id,product product, int sl, float total)
		{
			this.id = id;
			this.product = product;
			this.sl = sl;
			this.total = total;
		}
		public long getId()
        {
			return id;
        }
		public void setId(long id)
        {
			this.id = id;
        }
	}
}
