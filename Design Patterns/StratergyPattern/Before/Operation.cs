using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Design_Patterns.StratergyPattern.Before
{
    class Operation
    {
        public int CalculateMetrics(Arithemetic objArithemetic)
        {
            switch (objArithemetic.OpertionType)
            {
                case Arithemetic.Options.Add:
                {
                    return Add(objArithemetic);
                }
                case Arithemetic.Options.Sub:
                {
                    return Sub(objArithemetic);
                }
                case Arithemetic.Options.Mul:
                {
                    return Mul(objArithemetic);
                }
                default:
                    return 0;
            }
        }

        private int Mul(Arithemetic objArithemetic)
        {
            return objArithemetic.Operand1*objArithemetic.Operand2;
        }

        private int Sub(Arithemetic objArithemetic)
        {
            return objArithemetic.Operand1 - objArithemetic.Operand2;
        }

        private int Add(Arithemetic objArithemetic)
        {
            return objArithemetic.Operand1 + objArithemetic.Operand2;
        }
    }
}
