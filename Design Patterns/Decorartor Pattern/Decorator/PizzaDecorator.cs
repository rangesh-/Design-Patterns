using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Design_Patterns.Decorartor_Pattern.Component;

namespace Design_Patterns.Decorartor_Pattern.Decorator
{
    class PizzaDecorator:Pizza
    {
        protected Pizza _pizza;

        public  PizzaDecorator(Pizza pizza)
        {
            _pizza = pizza;
        }

        public override string getDescription()
        {
            return _pizza.Description;
        }

        public override double getCost()
        {
            return _pizza.getCost();
        }
    }
}
