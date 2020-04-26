using System;
using System.Collections.Generic;
using System.Text;
using WebStore_geekbrains.Domain.Entities.Base.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebStore_geekbrains.Domain.Entities.Base
{
    [Table("Categories")]
    public class Category : NamedEntity, IOrderedEntity
    {
        /// <summary>
        /// Родительская секция (при наличии)
        /// </summary>
        public int? ParentId { get; set; }

        public int Order { get; set; }

        [ForeignKey("ParentId")]
        public virtual Category ParentCategory { get; set; }

        public virtual ICollection<Product> Products { get; set; }

    }
}
