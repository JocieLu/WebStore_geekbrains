using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebStore_geekbrains.Models;
using WebStore_2020.Infrastructure.Interfaces;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebStore_geekbrains.Controllers
{
    [Route("users")]
    public class EmployeeController : Controller
    {
        private readonly IEmployeesService _employeesService;

        public EmployeeController(IEmployeesService employeesService)
        {
            _employeesService = employeesService;
        }

        // GET: /<controller>/
        [Route("all")]
        public IActionResult Index()
        {
            return View(_employeesService.GetAll());
        }

        [Route("{id}")]
        public IActionResult Details(int id)
        {
            return View(_employeesService.GetById(id));
        }
    }
}
