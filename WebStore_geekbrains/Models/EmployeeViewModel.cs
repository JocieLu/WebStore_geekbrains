using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore_geekbrains.Models
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        
        [Required(AllowEmptyStrings = false, ErrorMessage = "Имя обязательно для заполнения")]
        [Display(Name = "Имя")]
        public string FirstName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Фамилия обязательна для заполнения")]
        [Display(Name = "Фамилия")]
        public string SurName { get; set; }

        [Display(Name = "Отчество")]
        public string Patronymic { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Должность обязательна для заполнения")]
        [Display(Name = "Должность")]
        public string Position { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Возврат обязателен для заполнения")]
        [Display(Name = "Возраcт")]
        public int Age { get; set; }
    }
}
