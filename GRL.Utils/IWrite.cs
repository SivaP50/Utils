using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRL.Utils
{
    public interface IWrite
    {
        void Write(string path, string contents);
    }
}
