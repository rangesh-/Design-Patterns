using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Design_Patterns
{
    class StandardFormatter:Iformatter
    {
        public string Format(string Key, string Value)
        {
            return Key + ":" + Value;
        }
    }
}
