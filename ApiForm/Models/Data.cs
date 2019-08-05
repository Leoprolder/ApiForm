using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiForm.Models
{
    public class Data
    {
        internal string id;

        public int Id { get; set; }
        public Dictionary<String, Object> Fields { get; set; }

        public Data()
        {
            Fields = new Dictionary<String, Object>();
        }

        public Data(Dictionary<String, Object> fields)
        {
            Fields = fields;
        }
    }
}