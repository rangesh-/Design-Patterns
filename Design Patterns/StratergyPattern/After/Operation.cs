using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Design_Patterns.StratergyPattern.After
{
    class Operation
    {
        protected IOperationStratergy _Stratergy;

        public Operation(IOperationStratergy stratergy)
        {

            this._Stratergy = stratergy;
        }

        public int CalculateMetrics(Arithemetic objArithemetic)
        {
            return _Stratergy.calculateOperation(objArithemetic);
        }
    }
}
