using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Adapter
{
    class ReaderAdapter : Reader{
        public ReaderAdapter() { }
        public void Read(string DocName){
            string[] splitDoc = DocName.Split('.');
            
            if (splitDoc[1] == "pdf"){
                PdfReader reader = new PdfReader();
                reader.Read(DocName);
            }

            if (splitDoc[1] == "doc"){
                DocReader reader = new DocReader();
                reader.Read(DocName);
            }
        }
    }
}
