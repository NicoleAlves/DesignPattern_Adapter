using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Adapter
{
    class Reader
    {
        public virtual void Read(string DocName)
        {
            Console.WriteLine(DocName);
        }
    }
}
