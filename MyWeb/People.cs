using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyWeb
{
    public class People
    {

        [Required]
        [Display(Name = "Имя")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Фамилия")]
        public string Surname { get; set; }
        [Required]
        [Display(Name = "Отчество")]
        public string Patronymic { get; set; }
        [Required]
        [Display(Name = "Mail")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Сумму займа в рублях")]
        public string LoanAmount { get; set; }
        [Required]
        [Display(Name = "Номер телефона")]
        public string NumberPhone { get; set; }
        public override string ToString()
        {
            return string.Format(" Имя {0}, Фамилия {1}, Отчество {2}, Мэйл {3} Сумма желаемого займа {4}, " +
                "Номер телефона {5}" , Name ,Surname , Patronymic , Email , LoanAmount , NumberPhone);
        }
         
    }
}