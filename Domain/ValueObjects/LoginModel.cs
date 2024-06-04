using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ValueObjects
{
    public class LoginModel : User
    {
        [Required]
        [MinLength(6, ErrorMessage = "the password must contain at least 6 characters")]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
        //TODO: CONVERT lOGIN TO USER
    }
}
