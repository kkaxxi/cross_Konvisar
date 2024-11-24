﻿using System.ComponentModel.DataAnnotations;

namespace Lab5.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Поле обов'язкове.")]
        [MaxLength(50)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Поле обов'язкове.")]
        [MaxLength(100)]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Поле обов'язкове.")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Поле обов'язкове.")]
        [Phone]
        [RegularExpression(
            @"^\+380\d{9}$", 
            ErrorMessage = "Невірний формат телефону. Формат має бути: +380XXXXXXXXX."
        )]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Поле обов'язкове.")]
        [DataType(DataType.Password)]
        [StringLength(16, MinimumLength = 8, ErrorMessage = "Пароль має бути від 8 до 16 символів.")]
        [RegularExpression(@"^(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,16}$", ErrorMessage = "Пароль має містити хоча б одну велику літеру, цифру та спеціальний символ.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Поле обов'язкове.")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Паролі не співпадають.")]
        public string ConfirmPassword { get; set; }
    }
}