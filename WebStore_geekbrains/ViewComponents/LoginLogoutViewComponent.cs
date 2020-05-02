using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore_geekbrains.Infrastructure.Interfaces;
using WebStore_geekbrains.Models;

namespace WebStore_geekbrains.ViewComponents
{

    public class LoginLogoutViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
