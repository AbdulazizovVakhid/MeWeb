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
        [Display(Name = "Например Иван")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Наапример Иванов")]
        public string Surname { get; set; }
        [Required]
        [Display(Name = "Наапример Иванович")]
        public string Patronymic { get; set; }
        [Required]
        [Display(Name = "Например ivanIvanov@mail.ru")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Сумму займа в рублях")]
        public string LoanAmount { get; set; }
        [Required]
        [Display(Name = "Наапример +7(920)-345-37-41")]
        public string NumberPhone { get; set; }
        public override string ToString()
        {
            return string.Format(" Имя {0}, Фамилия {1}, Отчество {2}, Мэйл {3} Сумма желаемого займа {4}, " +
                "Номер телефона {5}" , Name ,Surname , Patronymic , Email , LoanAmount , NumberPhone);
        }
         
    }
}