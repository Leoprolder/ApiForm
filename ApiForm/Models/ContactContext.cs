using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ApiForm.Models
{
    public class ContactContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
    }
}