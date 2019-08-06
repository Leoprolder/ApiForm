using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ApiForm.Models
{
    public class DataContext : DbContext
    {
        public DbSet<Data> DataTable { get; set; }

        public DataContext()
            : base("DataContext")
        {
            
        }
    }
}