using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore_geekbrains.Domain.Entities.Base;

namespace WebStore_geekbrains.Infrastructure.Interfaces
{
    public interface IProductService
    {
        IEnumerable<Category> GetCategories();
        IEnumerable<Brand> GetBrands();
    }
}
