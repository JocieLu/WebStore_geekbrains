using System;
using System.Collections.Generic;
using System.Text;

namespace WebStore_geekbrains.Domain
{
    public class ProductFilter
    {
        public int? CategoryID { get; set; }
        public int? BrandID { get; set; }
    }
}
