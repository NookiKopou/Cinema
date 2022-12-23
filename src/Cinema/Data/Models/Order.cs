﻿using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Cinema.Data.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }

        [Display(Name = "Имя")]
        [StringLength(25)]
        [RegularExpression(@"([А-ЯЁ][а-яё]+[\-\s]?)",
                   ErrorMessage = "Введите правильно! Пример: Анна")]
        [Required(ErrorMessage = "Поле не заполнено!")]
        public string name { get; set; }

        [Display(Name = "Фамилия")]
        [RegularExpression(@"([А-ЯЁ][а-яё]+[\-\s]?)",
                   ErrorMessage = "Введите правильно! Пример: Иванова")]
        [StringLength(25)]
        [Required(ErrorMessage = "Поле не заполнено!")]
        public string surname { get; set; }

        [Display(Name = "Адрес")]       
        [StringLength(35)]
        [Required(ErrorMessage = "Поле не заполнено!")]
        public string adress { get; set; }

        [Display(Name = "Номер телефона")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(16)]
        [RegularExpression(@"\+?\d+([\(\s\-]?\d+[\)\s\-]?[\d\s\-]+)?",
                   ErrorMessage = "Введите правильно! Примеры: 89278461839, +7-816-738-52-78")]
        [Required(ErrorMessage = "Поле не заполнено!")]
        public string phone { get; set; }
        
        [Display(Name = "E-mail")]
        [DataType(DataType.EmailAddress)]
        [StringLength(25)]
        [Required(ErrorMessage = "Поле не заполнено!")]
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }

        [BindNever]
        public List<OrderDetail> orderDetails { get; set; }
    }
}
