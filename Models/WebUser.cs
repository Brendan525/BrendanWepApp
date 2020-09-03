using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BrendanWepApp.Models
{
    public class WebUser // WebUser is in a namespace called Models which is another namespace in BrendanWebApp
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Gender { get; set; }

        public DateTime Birthday { get; set; }

        public string State { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Password { get; set; }

        public string Starter { get; set; }
    }
}