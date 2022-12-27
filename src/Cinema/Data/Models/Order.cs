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
        [RegularExpression(@"([А-ЯЁ][а-яё]+[\-\s]?)",
                   ErrorMessage = "Имя может содержать только буквы и тире")]
        [Required(ErrorMessage = "Поле не заполнено!")]
        public string name { get; set; }

        [Display(Name = "Фамилия")]
        [RegularExpression(@"([А-ЯЁ][а-яё]+[\-\s]?)",
                   ErrorMessage = "Фамилия может содержать только буквы и тире")]
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
