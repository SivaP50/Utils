using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRL.Utils
{
    public interface IRead
    {
        T Read<T>(string path);
    }
}
