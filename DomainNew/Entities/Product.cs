using System;
using System.Collections.Generic;
using System.Text;
using WebStore_geekbrains.Domain.Entities.Base.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebStore_geekbrains.Domain.Entities.Base
{
    [Table("Products")]
    public class Product : NamedEntity, IOrderedEntity
    {
        public int Order { get; set; }
        public int CategoryId { get; set; }
        public int? BrandId { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category ParentCategory { get; set; }

        [ForeignKey("BrandId")]
        public virtual Brand ParentBrand { get; set; }
    }
}
