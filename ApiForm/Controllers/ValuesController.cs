using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
using ApiForm.Models;

namespace ApiForm.Controllers
{
    public class ValuesController : ApiController
    {
        DataContext db = new DataContext();

        // GET api/values
        public IEnumerable<Data> GetDataTable()
        {
            return db.DataTable;
        }

        // GET api/values/5
        public Data GetData(int id)
        {
            Data Data = db.DataTable.Find(id);
            return Data;
        }

        // POST api/values
        [HttpPost]
        public void CreateData([FromBody]Data Data)
        {
            db.DataTable.Add(Data);
            db.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut]
        public void EditData(int id, [FromBody]Data Data)
        {
            if(id == Data.Id)
            {
                db.Entry(Data).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        // DELETE api/values/5
        public void DeleteData(int id)
        {
            Data Data = db.DataTable.Find(id);
            if(Data != null)
            {
                db.DataTable.Remove(Data);
                db.SaveChanges();
            }
        }
    }
}
