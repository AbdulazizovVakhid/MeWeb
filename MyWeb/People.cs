using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWeb
{
    public class People
    {
        public string Name;
        public string surname;
        public string Email;
        public string patronymic; 
        public string LoanAmount;
        public string NumberPhone;
        public override string ToString()
        {
            return string.Format(" Имя {0}, Фамилия {1}, Отчество {2}, Мэйл {3} Сумма желаемого займа {4}, " +
                "Номер телефона {5}" , Name ,surname , patronymic , Email , LoanAmount , NumberPhone);
        }
    }
}