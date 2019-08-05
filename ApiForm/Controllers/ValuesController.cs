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
            //DictionaryModelBinder<string, object> binder = new DictionaryModelBinder<string, object>();
            //ModelBindingContext modelContext = new ModelBindingContext();
            //modelContext.ModelMetadata = new System.Web.Http.Metadata.ModelMetadata()
            //modelContext.Model = new Data();
            //binder.BindModel(this.ActionContext, modelContext);
            //return db.DataTable;
            IEnumerable<Data> data = new List<Data>
            {
                new Data {Id=1, Fields={ {"Война и мир", 1863 } } },
                new Data {Id=2, Fields={ {"Отцы и дети", 1862 } } },
                new Data {Id=3, Fields= { {"Евгений Онегин", 1831 } } },
            };
            //IEnumerable<Data> data = db.DataTable;
            return data;
        }

        public Data GetData(int id)
        {
            Data data = db.DataTable.Find(id);
            return data;
        }
        
        // GET api/values/5
        [Route("api/values/setdata")]
        public Data GetData([ModelBinder] Data inputData)
        {
            //Data data = new Data();
            //DictionaryModelBinder<String, Object> binder = new DictionaryModelBinder<string, object>();
            //binder.BindModel(this.ActionContext, new System.Web.Http.ModelBinding.ModelBindingContext());
            //Data data = db.DataTable.Find(inputData);
            return new Data();
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
