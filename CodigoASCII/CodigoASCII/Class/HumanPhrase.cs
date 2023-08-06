using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoASCII.Class
{
    public class HumanPhrase
    {
        public int Code { get; set; }
        public string Phrase { get; set; }

        public HumanPhrase(int code, string phrase)
        {
            Code = code;
            Phrase = phrase;
        }
    }
}
