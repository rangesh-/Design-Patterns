namespace Design_Patterns.StratergyPattern.Before
{
    public  class Arithemetic
    {
        public  enum Options
        {
            Add,
            Sub,
            Mul

        }

        public Options OpertionType { get; set; }
        public int Operand1 { get; set; }
        public int Operand2 { get; set; }
    }
}