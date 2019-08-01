using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiForm.Models
{
    public class Contact
    {
        string Name { get; set; } //textbox
        string Gender { get; set; } //radio
        DateTime Birthday { get; set; } //date
        bool Favourite { get; set; } // checkbox
        ContactCategory Category { get; set; } //dropdown list
    }
}