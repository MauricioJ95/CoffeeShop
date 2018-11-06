using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CoffeeShop.Models
{
    public class UserInfo
    {
        [Required] // attributes 
        [RegularExpression("^[a-zA-Z]{2,}$")]
        public string FirstName { set; get; }

        [Required]
        [RegularExpression("^[a-zA-Z]{2,}$")]
        public string LastName { set; get; }

        [Required]
        [RegularExpression("^[a-zA-Z][0-9]+@[a-zA-Z]+.[a-z]{2,}$")]
        public string Email { set; get; }

        [Required]
        [RegularExpression("^[0-9]")]
        public string PhoneNumber { set; get; }

        [Required]
        [RegularExpression("^[a-zA-Z]{2,}$")]
        public string Password { set; get; }
        public UserInfo()
        {
        }
        public UserInfo(string fn, string ln, string email, string pn, string pw)
        {
            FirstName = fn;
            LastName = ln;
            Email = email;
            PhoneNumber = pn;
            Password = pw;
        }
    }
}