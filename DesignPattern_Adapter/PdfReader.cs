using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Adapter
{
    class PdfReader : Reader
    {
        public PdfReader() { }
        public void Read(string DocName) {
            base.Read(DocName);
            Console.WriteLine("Lendo arquivo pdf");
        }
    }

    class DocReader : Reader
    {
        public DocReader() { }

        public void Read(string DocName)
        {
            base.Read(DocName);
            Console.WriteLine("Lendo arquivo doc");
        }
    }
}
