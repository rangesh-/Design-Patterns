using System;
using System.Runtime.Serialization;

namespace Design_Patterns
{
    public abstract class  manuscript
    {
        protected readonly Iformatter formatter;

        public  manuscript(Iformatter formIformatter)
        {
            this.formatter = formIformatter;


        }
        abstract public  void Print();
    }
}