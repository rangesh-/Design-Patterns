using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Design_Patterns.StratergyPattern.After
{
    interface IOperationStratergy
    {
         int calculateOperation(Arithemetic objArithemetic);
    }
}
