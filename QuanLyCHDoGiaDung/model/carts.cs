using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCHDoGiaDung.model
{
    class carts
    {
		private List<cartItem> cartItems = new List<cartItem>();
		private float total;
		public List<cartItem> getCartItems()
		{
			return cartItems;
		}
		public void setCartItems(List<cartItem> cartItems)
		{
			this.cartItems = cartItems;
		}
		public float getTotal()
		{
			return total;
		}
		public void setTotal(float total)
		{
			this.total = total;
		}
		public void addItem(cartItem cartItem)
		{
			this.cartItems.Add(cartItem);
		}
		public void removeItems(List<cartItem> cartItems)
		{
			foreach (cartItem cartItem in cartItems)
			{
				this.cartItems.Remove(cartItem);
			}
		}
		public cartItem findById(long id)
        {
			foreach(cartItem cartItem in cartItems)
            {
				if (cartItem.getId() == id)
                {
					return cartItem;
                }
            }
			return null;
        }
	}
}
