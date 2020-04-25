using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore_geekbrains.Infrastructure.Interfaces;
using WebStore_geekbrains.Models;

namespace WebStore_geekbrains.ViewComponents
{

    [ViewComponent(Name = "Brands")]
    public class BrandsViewComponent : ViewComponent
    {
        private readonly IProductService _productService;
        public BrandsViewComponent(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var _brands = GetBrands();
            return View(_brands);
        }

        private List<BrandViewModel> GetBrands()
        {
            List<BrandViewModel> brandsList = new List<BrandViewModel>();

            var brands = _productService.GetBrands();
            
            foreach(var brand in brands)
            {
                brandsList.Add(new BrandViewModel()
                {
                    Id = brand.Id,
                    Name = brand.Name,
                    Order = brand.Order
                });
            }

            return brandsList;
        }
    }
}
