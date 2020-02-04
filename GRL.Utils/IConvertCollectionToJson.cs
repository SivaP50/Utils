using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRL.Utils
{
    public interface IConvertCollectionToJson
    {
        string Convert<T>(T collec);
    }
}
