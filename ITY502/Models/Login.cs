using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ITY502.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Please Enter UserName")]
        public string UserID { get; set; }
        [Required(ErrorMessage = "Please Enter Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string UserType { get; set; }
    }
}