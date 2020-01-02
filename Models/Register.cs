using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web_UI.Models
{
    public class Register
    {
        [Required]
        [DisplayName("Adınız")]
        public string Name { get; set; }
        [Required]
        [DisplayName("Soyadınız")]
        public string SurName { get; set; }
        [Required]
        [DisplayName("Kullanıcı Adınız")]
        public string UserName { get; set; }
        [Required]
        [DisplayName("Email Adresiniz")]
        [EmailAddress(ErrorMessage ="E-posta adresi geçerli değil.")]
        public string Email { get; set; }
        [Required]
        [DisplayName("Şifreniz")]
        public string Password { get; set; }
        [Required]
        [DisplayName("Yeniden Şifreniz")]
        [Compare("Password",ErrorMessage ="Şifreler eşleşmedi.")]
        public string RePassword { get; set; }

    }
}