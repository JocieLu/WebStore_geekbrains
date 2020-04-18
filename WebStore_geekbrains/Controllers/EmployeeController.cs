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

        [Route("edit/{id?}")]
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            EmployeeViewModel model;

            if (!id.HasValue) model = new EmployeeViewModel();
            else model = _employeesService.GetById(id.Value);

            if (model is null) return NotFound();

            return View(model);
        }

        [Route("edit/{id?}")]
        [HttpPost]
        public IActionResult Edit(EmployeeViewModel model)
        {
            if (model.Id > 0)
            {
                var dbItem = _employeesService.GetById(model.Id);

                if (ReferenceEquals(dbItem, null))
                    return NotFound();

                dbItem.FirstName = model.FirstName;
                dbItem.SurName = model.SurName;
                dbItem.Age = model.Age;
                dbItem.Patronymic = model.Patronymic;
                dbItem.Position = model.Position;
            }
            else
            {
                _employeesService.AddNew(model);
            }
            _employeesService.Commit();

            return RedirectToAction(nameof(Index));
        }
    }
}
