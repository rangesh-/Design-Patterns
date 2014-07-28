using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Design_Patterns.Decorartor_Pattern.Component;

namespace Design_Patterns.Decorartor_Pattern.ConcreteComponent
{
    class LargePizza:Pizza
    {
        public LargePizza()
        {
            Description = "Large Pizza";
        }
        
        public override string getDescription()
        {
            return Description;
        }
        public override double getCost ()
        {
            return 5.00;
        }
        
    }
}
