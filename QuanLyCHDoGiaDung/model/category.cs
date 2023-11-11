using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCHDoGiaDung.model
{
    class category
    {
		private String name;
		private String code;
		public String getName()
		{
			return name;
		}
		public void setName(String name)
		{
			this.name = name;
		}
		public String getCode()
		{
			return code;
		}
		public void setCode(String code)
		{
			this.code = code;
		}
		public category(String name, String code)
		{
			
			this.name = name;
			this.code = code;
		}
		public category()
        {


        }
	}
}
