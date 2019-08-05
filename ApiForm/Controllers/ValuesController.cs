using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
using ApiForm.Models;
using System.Web.Http.ModelBinding.Binders;
using System.Web.Http.ModelBinding;

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
        [Route("api/values/setdata")]
        public Data GetData([ModelBinder] Dictionary<String, Object> inputData)
        {
            //Data data = new Data();
            //DictionaryModelBinder<String, Object> binder = new DictionaryModelBinder<string, object>();
            //binder.BindModel(this.ActionContext, new System.Web.Http.ModelBinding.ModelBindingContext());
            //Data data = db.DataTable.Find(inputData);
            return new Data(inputData);
        }

        // POST api/values
        [HttpPost]
        public void CreateData([FromBody]Data data)
        {
            db.DataTable.Add(data);
            db.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut]
        public void EditData(int id, [FromBody]Data data)
        {
            //if(id == data.Id)
            //{
            //    db.Entry(data).State = EntityState.Modified;
            //    db.SaveChanges();
            //}
        }

        // DELETE api/values/5
        public void DeleteData(int id)
        {
            Data data = db.DataTable.Find(id);
            if(data != null)
            {
                db.DataTable.Remove(data);
                db.SaveChanges();
            }
        }
    }
}
