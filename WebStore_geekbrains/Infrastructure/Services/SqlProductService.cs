using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore_geekbrains.DAL;
using WebStore_geekbrains.Domain;
using WebStore_geekbrains.Domain.Entities.Base;
using WebStore_geekbrains.Infrastructure.Interfaces;

namespace WebStore_geekbrains.Infrastructure.Services
{
    public class SqlProductService : IProductService
    {
        readonly WebStoreContext _context;
        public SqlProductService(WebStoreContext context )
        {
            _context = context;
        }

        public IEnumerable<Brand> GetBrands()
        {
            return _context.Brands.ToList();
        }

        public IEnumerable<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }

        public IEnumerable<Product> GetProducts(ProductFilter productFilter)
        {
            var query = _context.Products.AsQueryable();
            if (productFilter.BrandID.HasValue)
                query = query.Where(c => c.BrandId.HasValue && c.BrandId.Value.Equals(productFilter.BrandID.Value));
            if (productFilter.CategoryID.HasValue)
                query = query.Where(c => c.CategoryId.Equals(productFilter.CategoryID.Value));

            return query.ToList();
        }
    }
}
