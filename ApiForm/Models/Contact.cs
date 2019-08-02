using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiForm.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; } //textbox
        public ContactGender Gender { get; set; } //radio
        public DateTime Birthday { get; set; } //date
        public bool Favourite { get; set; } // checkbox
        public ContactCategory Category { get; set; } //dropdown list

        public Contact(string name, ContactGender gender, DateTime birthday, bool favourite, ContactCategory category)
        {
            Name = name;
            Gender = gender;
            Birthday = birthday;
            Favourite = favourite;
            Category = category;
        }

        public Contact()
        {

        }
    }
}