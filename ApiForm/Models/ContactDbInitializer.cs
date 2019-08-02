using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ApiForm.Models
{
    public class ContactDbInitializer : DropCreateDatabaseAlways<ContactContext>
    {
        protected override void Seed(ContactContext db)
        {
            db.Contacts.Add(new Contact("Hugo Weaving", ContactGender.Male, new DateTime(1960, 4, 4), true, ContactCategory.Common));
            db.Contacts.Add(new Contact("Dave", ContactGender.Male, new DateTime(1990, 9, 14), false, ContactCategory.Friends));
            db.Contacts.Add(new Contact("Carrie-Ann Moss", ContactGender.Female, new DateTime(1967, 8, 21), true, ContactCategory.Common));

            base.Seed(db);
        }
    }
}