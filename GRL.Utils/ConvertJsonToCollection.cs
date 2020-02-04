using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRL.Utils
{
    public class ConvertJsonToCollection : IConvertJsonToCollection
    {
        public T Convert<T>(string contents)
        {
            dynamic result = null;
            try
            {
                if (!string.IsNullOrEmpty(contents))
                {
                    object data = JsonConvert.DeserializeObject(contents);
                    Newtonsoft.Json.Linq.JArray jArray = (Newtonsoft.Json.Linq.JArray)data;
                    result = jArray.ToObject<T>();
                }
            }
            catch (Exception ex)
            {

            }
            return (T)System.Convert.ChangeType(result, typeof(T));
        }
    }
}
