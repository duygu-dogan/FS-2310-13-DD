using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Shared.ViewModels.IdentityModels
{
    public class RegisterViewModel
    {
        [DisplayName("Ad")]
        [Required(ErrorMessage ="Lütfen ad alanını boş bırakmayınız!")]
        public string FirstName { get; set; }
        [DisplayName("Soyad")]
        [Required(ErrorMessage = "Lütfen soyad alanını boş bırakmayınız!")]
        public string LastName { get; set; }

        [DisplayName("Kullanıcı Adı")]
        [Required(ErrorMessage = "Lütfen kullanıcı alanını boş bırakmayınız!")]
        public string UserName { get; set; }

        [DisplayName("E-mail")]
        [Required(ErrorMessage = "Lütfen e-mail alanını boş bırakmayınız!")]
        [DataType(DataType.EmailAddress, ErrorMessage ="Lütfen geçerli bir e-mail adresi giriniz!")]
        public string Email { get; set; }

        [DisplayName("Parola")]
        [Required(ErrorMessage = "Lütfen parola alanını boş bırakmayınız!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DisplayName("Parola Tekrar")]
        [Required(ErrorMessage = "Lütfen parola tekrar alanını boş bırakmayınız!")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage ="Parolalar eşleşmiyor, lütfen kontrol ediniz.")]
        public string RePassword { get; set; }
    }
}
