using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ApiForm.Models
{
    public class DataDbInitializer : DropCreateDatabaseAlways<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            //var person = new Data();
            //person.Fields.Add("Name", "Hugo Weaving");
            //person.Fields.Add("Gender", "male");
            //person.Fields.Add("Birthday", new DateTime(1960, 4, 4));
            //context.DataTable.Add(person);

            //var plant = new Data();
            //plant.Fields.Add("Type", "Flower");
            //plant.Fields.Add("IsTree", false);
            //context.DataTable.Add(plant);

            base.Seed(context);
        }
    }
}