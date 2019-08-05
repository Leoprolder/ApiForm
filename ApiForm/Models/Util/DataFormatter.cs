using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace ApiForm.Models.Util
{
    public class DataFormatter : MediaTypeFormatter
    {
        public DataFormatter()
        {
            SupportedMediaTypes.Add(new MediaTypeHeaderValue("application/x-data"));
        }

        public override bool CanReadType(Type type)
        {
            return type == typeof(Data) || type == typeof(IEnumerable<Data>);
        }

        public override bool CanWriteType(Type type)
        {
            return type == typeof(Data) || type == typeof(IEnumerable<Data>);
        }

        public override async Task WriteToStreamAsync(Type type, object value, Stream writeStream, HttpContent content, TransportContext transportContext)
        {
            List<string> dataString = new List<string>();
            IEnumerable<Data> dataList = value is Data ? new Data[] { (Data)value } : (IEnumerable<Data>)value;
            foreach (Data data in dataList)
            {
                dataString.Add($"Id:{data.id}; Data: ");
                foreach(var field in data.Fields)
                {
                    dataString.Add($"{field.ToString()}; ");
                }
            }

            StreamWriter writer = new StreamWriter(writeStream);
            await writer.WriteAsync(string.Join(",", dataString));
            writer.Flush();
            //return base.WriteToStreamAsync(type, value, writeStream, content, transportContext);
        }
    }
}