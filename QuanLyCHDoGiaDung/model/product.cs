using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCHDoGiaDung.model
{
    class product
    {
		private String maSp;
		private String tenSp;
		private category danhMuc;
		private String image;
		private int sl;
		private float gia;

		public String getMaSp()
		{
			return maSp;
		}
		public void setMaSp(String maSp)
		{
			this.maSp = maSp;
		}
		public String getTenSp()
		{
			return tenSp;
		}
		public void setTenSp(String tenSp)
		{
			this.tenSp = tenSp;
		}
		public category getDanhMuc()
		{
			return danhMuc;
		}
		public void setDanhMuc(category danhMuc)
		{
			this.danhMuc = danhMuc;
		}
		public String getImage()
		{
			return image;
		}
		public void setImage(String image)
		{
			this.image = image;
		}
		public float getGia()
		{
			return gia;
		}
		public void setGia(float gia)
		{
			this.gia = gia;
		}
		public int getSl()
		{
			return sl;
		}
		public void setSl(int sl)
		{
			this.sl = sl;
		}
		public product(String maSp, String tenSp, category danhMuc, String image, int sl, float gia)
		{
			this.maSp = maSp;
			this.tenSp = tenSp;
			this.danhMuc = danhMuc;
			this.image = image;
			this.sl = sl;
			this.gia = gia;
		}

        internal void updateSl(int sl)
        {
			this.sl -= sl;
        }
    }
}
