using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore_geekbrains.Models;

namespace WebStore_geekbrains.Controllers
{
    public class PCController : Controller
    {
        List<PersonalComputerViewModel> _personalComputers;

        public PCController()
        {
            _personalComputers = new List<PersonalComputerViewModel>
            {
                new PersonalComputerViewModel
                {
                   Name = "Asus",
                   Processor = "Intel",
                   Id = 1,
                   Ram  = 512,
                   Сapacity = 1024
                },
                new PersonalComputerViewModel
                {
                   Name = "Alienware",
                   Processor = "AMD",
                   Id = 2,
                   Ram  = 1024,
                   Сapacity = 2048
                }
            };
        }
        public IActionResult Index()
        {
            return View(_personalComputers);
        }
        public IActionResult Details(int id)
        {
            return View(_personalComputers.FirstOrDefault(x => x.Id == id));
        }
    }
}