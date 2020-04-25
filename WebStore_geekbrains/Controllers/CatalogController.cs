using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore_geekbrains.Domain;
using WebStore_geekbrains.Infrastructure.Interfaces;
using WebStore_geekbrains.Models;

namespace WebStore_geekbrains.Controllers
{
    public class CatalogController : Controller
    {
        private readonly IProductService _productService;
        public CatalogController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult ProductDetails()
        {
            return View();
        }

        public IActionResult Shop(int? categoryID, int? brandID)
        {
            var products = _productService.GetProducts(
                new ProductFilter {CategoryID = categoryID, BrandID = brandID });

            var model = new CatalogViewModel()
            {
                BrandId = brandID,
                CategoryId = categoryID,
                Products = products.Select(p => new ProductViewModel()
                {
                    Id = p.Id,
                    ImageUrl = p.ImageUrl,
                    Name = p.Name,
                    Order = p.Order,
                    Price = p.Price
                }).OrderBy(p => p.Order).ToList()
            };

            return View(model);
        }
    }
}