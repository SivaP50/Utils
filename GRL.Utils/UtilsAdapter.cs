using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRL.Utils
{
    public class UtilsAdapter
    {
        private IConvertCollectionToJson collecToJson;
        private IConvertJsonToCollection jsonToCollec;
        private IRead read;
        private IWrite write;

        public UtilsAdapter()
        {
            collecToJson = new ConvertCollectionToJson();
            jsonToCollec = new ConvertJsonToCollection();
            read = new ReadJsonFromFile();
            write = new WriteJsonToFile();
        }

        public T ReadDataFromFile<T>(string path)
        {
            dynamic result = null;
            try
            {
                if (!string.IsNullOrEmpty(path))
                {
                    if (File.Exists(path))
                    {
                        string contents = read.Read<string>(path);
                        result = jsonToCollec.Convert<T>(contents);
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return (T)Convert.ChangeType(result, typeof(T));
        }
        public void WriteDataToFile<T>(string path, T collec)
        {
            try
            {
                if (!string.IsNullOrEmpty(path))
                {
                    if (File.Exists(path))
                    {
                        File.Delete(path);
                    }
                    string contents = string.Empty;
                    using (FileStream fs = File.Create(path))
                    {
                        contents = collecToJson.Convert<T>(collec);
                    }
                    write.Write(path, contents);
                }
            }
            catch (Exception ex)
            {

            }
        }

    }
}
