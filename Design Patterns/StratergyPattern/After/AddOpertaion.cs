namespace Design_Patterns.StratergyPattern.After
{
    class AddOpertaion:IOperationStratergy
    {
        public int calculateOperation(Arithemetic objArithemetic)
        {
            return objArithemetic.Operand1 + objArithemetic.Operand2;
        }

    }
    class MulOperation : IOperationStratergy
    {
        public int calculateOperation(Arithemetic objArithemetic)
        {
            return objArithemetic.Operand1 * objArithemetic.Operand2;
        }

    }
}