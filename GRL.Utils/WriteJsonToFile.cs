using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRL.Utils
{
    public class WriteJsonToFile : IWrite
    {
        public void Write(string path, string contents)
        {
            try
            {
                if (!string.IsNullOrEmpty(path))
                {
                    using (StreamWriter sw = new StreamWriter(path))
                    {
                        sw.Write(contents);
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
