using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
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
        [RegularExpression(@"([А-Я][а-я]+[\-\s]?)",
                   ErrorMessage = "Имя может содержать только буквы и тире")]
        [Required(ErrorMessage = "Поле не заполнено!")]
        public string name { get; set; }

        [Display(Name = "Фамилия")]
        [RegularExpression(@"([А-Я][а-я]+[\-\s]?)",
                   ErrorMessage = "Фамилия может содержать только буквы и тире")]
        [StringLength(25)]
        [Required(ErrorMessage = "Поле не заполнено!")]
        public string surname { get; set; }

        [Display(Name = "Дата")]
        [Required(ErrorMessage = "Поле не заполнено!")]
        public DateTime date { get; set; } = DateTime.Today;

        [Display(Name = "Количество человек")]
        [StringLength(1)]
        [RegularExpression(@"[0-9]{1}$",
                   ErrorMessage = "Поле должно содержать число не больше 9-ти, состоящее только из цифр")]
        [Required(ErrorMessage = "Поле не заполнено!")]
        public string people { get; set; }

        [Display(Name = "Количество часов")]
        [StringLength(1)]
        [RegularExpression(@"[0-9]{1}$",
                   ErrorMessage = "Поле должно содержать число не больше 9-ти, состоящее только из цифр")]
        [Required(ErrorMessage = "Поле не заполнено!")]
        public string hours { get; set; }

        [Display(Name = "Номер телефона")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(16)]
        [RegularExpression(@"(\+7|8|\b)[\(\s-]*(\d)[\s-]*(\d)[\s-]*(\d)[)\s-]*(\d)[\s-]*(\d)[\s-]*(\d)[\s-]*(\d)[\s-]*(\d)[\s-]*(\d)[\s-]*(\d)",
                   ErrorMessage = "Номер не должен содержать букв, символов помимо тире и плюса. \n" +
                "Длина номера должна быть 7 цифр. Примеры: 89278461839, +7-816-738-52-78")]
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
