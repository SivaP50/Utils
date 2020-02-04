using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRL.Utils
{
    public class ConvertCollectionToJson : IConvertCollectionToJson
    {
        public string Convert<T>(T collec)
        {
            string jsonContents = string.Empty;
            try
            {
                if (collec != null)
                {
                    jsonContents = JsonConvert.SerializeObject(collec);
                }
            }
            catch (Exception ex)
            {

            }
            return jsonContents;
        }
    }
}
