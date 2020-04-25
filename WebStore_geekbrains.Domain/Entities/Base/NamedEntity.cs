using System;
using System.Collections.Generic;
using System.Text;
using WebStore_geekbrains.Domain.Entities.Base.Interfaces;

namespace WebStore_geekbrains.Domain.Entities.Base
{
    public class NamedEntity : INamedEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
