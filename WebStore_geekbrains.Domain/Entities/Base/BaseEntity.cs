using System;
using System.Collections.Generic;
using System.Text;
using WebStore_geekbrains.Domain.Entities.Base.Interfaces;

namespace WebStore_geekbrains.Domain.Entities.Base
{
    public abstract class BaseEntity : IBaseEntity
    {
        public int Id { get; set; }
    }
}
