using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Design_Patterns
{
    public interface Iformatter
    {
        String Format(String Key,string Value);
    }


}
