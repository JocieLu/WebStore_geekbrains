using System;
using System.Collections.Generic;
using System.Text;
using WebStore_geekbrains.Domain.Entities.Base.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebStore_geekbrains.Domain.Entities.Base
{
    [Table("Brands")]
    public class Brand : NamedEntity, IOrderedEntity
    {
        public int Order { get; set; }

        public virtual ICollection<Product> Products { get; set; }

    }
}
