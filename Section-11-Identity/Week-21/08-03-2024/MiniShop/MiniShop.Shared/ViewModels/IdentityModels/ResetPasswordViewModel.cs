﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MiniShop.Shared.ViewModels.IdentityModels
{
    public class ResetPasswordViewModel
    {
        public string UserId { get; set; }
        public string Token { get; set; }

        [DisplayName("Parola")]
        [Required(ErrorMessage = "{0} alanı boş bırakılamaz!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DisplayName("Parola Tekrar")]
        [Required(ErrorMessage = "{0} alanı boş bırakılamaz!")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Parolalar uyuşmuyor!")]
        public string RePassword { get; set; }
    }
}
