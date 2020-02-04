using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRL.Utils
{
    public class ReadJsonFromFile : IRead
    {
        public T Read<T>(string path)
        {
            dynamic result = null;
            try
            {
                if (!string.IsNullOrEmpty(path))
                {
                    using (StreamReader sr = new StreamReader(path))
                    {
                        result = sr.ReadToEnd();
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return (T)Convert.ChangeType(result, typeof(T));
        }
    }
}
