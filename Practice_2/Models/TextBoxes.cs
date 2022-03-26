using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Practice_2.Models
{
    public class TextBoxes
    {
        [Required(ErrorMessage = "Пожалуйста, введите логин")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите пароль")]
        public string Password_1 { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите пароль")]
        public string Password_2 { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите email")]
        [RegularExpression(@"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$", ErrorMessage = "Вы ввели некорректный email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите возраст")]
        [RegularExpression("[0-9]{2}", ErrorMessage = "Вы ввели некорректный возраст")]
        public string Age { get; set; }
    }
}