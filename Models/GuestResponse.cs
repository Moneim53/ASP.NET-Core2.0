using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; //Applying Validation in the GuestResponse.cs File in the Models Folder

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage ="please Enter Your Name")]
        public string Name { get; set; }

        [Required(ErrorMessage ="please Enter Your Email Address")]
        [RegularExpression( ".+\\@.+\\..+",
           ErrorMessage ="Please Enter a Valid Email") ]
        public string Email { get; set; }

        [Required(ErrorMessage ="Please Enter Your Phone Number")]
        public string phone { get; set; }

        [Required(ErrorMessage = "Please specify whether you'll attend")]
        public bool? willAttend { get; set; }
    }
}
