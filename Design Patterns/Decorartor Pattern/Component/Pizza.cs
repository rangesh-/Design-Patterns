using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Design_Patterns.Decorartor_Pattern.Component
{
    abstract public class Pizza
    {
        public string Description { get; set; }
        public abstract string getDescription();
        public abstract double getCost();
    }
}
