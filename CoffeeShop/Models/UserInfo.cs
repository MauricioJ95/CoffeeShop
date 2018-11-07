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
        [RegularExpression(@"^[A-z]{2,}$")]
        public string FirstName { set; get; }

        [Required]
        [RegularExpression(@"^[A-z]{2,}$")]
        public string LastName { set; get; }
        
        [Required]
        [RegularExpression(@"^[A-z0-9]{5,30}@+[a-z0-9]{5,10}.+[a-z0-9]{2,3}$")]
        public string Email { set; get; }

        [Required]
        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$")]
        public string PhoneNumber { set; get; }

        [Required]
        [RegularExpression(@"^[A-z0-9]{2,}$")]
        public string Password { set; get; }

        public string Gender { get; set; }

        public bool SubscribeToNewsletter { get; set; }

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