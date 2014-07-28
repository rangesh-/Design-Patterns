using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Design_Patterns.Decorartor_Pattern.Component;
using Design_Patterns.Decorartor_Pattern.Decorator;

namespace Design_Patterns.Decorartor_Pattern.ConcreteDecorator
{
    class Cheese:PizzaDecorator
    {
        public Cheese(Pizza pizza) : base(pizza)
        {
            Description = "Cheese";
        }

        public override string getDescription()
        {
            return _pizza.getDescription()+","+Description;
        }

        public override double getCost()
        {
            return _pizza.getCost() + 1.25;
        }
    }
}
