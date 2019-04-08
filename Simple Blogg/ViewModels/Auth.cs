using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Simple_Blogg.ViewModels
{
    public class AuthLogin
    {
        [MinLength(5)]
        [MaxLength(10)]
        [Required(ErrorMessage ="Username alanı için bilgi giriniz")]
        public string Username { get; set; }
        [MinLength(5)]
        [MaxLength(10)]
        [Required(ErrorMessage ="Password alanını doldurunuz")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string Test { get; set; }
    }
}