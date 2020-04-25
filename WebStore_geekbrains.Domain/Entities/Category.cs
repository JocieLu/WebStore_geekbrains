using System;
using System.Collections.Generic;
using System.Text;
using WebStore_geekbrains.Domain.Entities.Base.Interfaces;

namespace WebStore_geekbrains.Domain.Entities.Base
{
    public class Category : NamedEntity, IOrderedEntity
    {
        /// <summary>
        /// Родительская секция (при наличии)
        /// </summary>
        public int? ParentId { get; set; }

        public int Order { get; set; }
    }
}
