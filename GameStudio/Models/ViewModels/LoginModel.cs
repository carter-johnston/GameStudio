using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GameStudio.Models.ViewModels
{
    public class LoginModel
    {
            public string UserName { get; set; }
            [Required]
            [EmailAddress]
            public string Email { get; set; }
            [Required]
            [UIHint("password")]
            public string Password { get; set; }
            public string ReturnUrl { get; set; } = "/";
        
    }
}
