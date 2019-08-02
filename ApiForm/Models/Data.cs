using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiForm.Models
{
    public class Data
    {
        public int Id { get; set; }
        public Dictionary<String, Object> Fields { get; set; }

        public Data()
        {
            Fields = new Dictionary<string, object>();
        }

        public Data(Dictionary<string, object> fields)
        {
            Fields = fields;
        }
    }
}