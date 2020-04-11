﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore_geekbrains.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebStore_geekbrains.Controllers
{
    public class HomeController : Controller
    {

        List<EmployeeViewModel> _employees = new List<EmployeeViewModel> 
        {
            new EmployeeViewModel
            {
                Id = 1,
                FirstName = "Иван",
                SurName = "Иванов",
                Patronymic = "Иванович",
                Age = 22
            },
            new EmployeeViewModel
            {
                Id = 2,
                FirstName = "Владислав",
                SurName = "Петров",
                Patronymic = "Иванович",
                Age = 35
            }
        };

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(_employees);
        }
    }
}
