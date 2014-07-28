using Design_Patterns.Decorartor_Pattern.Component;

namespace Design_Patterns.Decorartor_Pattern.ConcreteComponent
{
    class SmallPizza:Pizza
    {
        public SmallPizza()
        {
            Description = "Small Pizza";
        }
        
        public override string getDescription()
        {
            return Description;
        }
        public override double getCost ()
        {
            return 2.00;
        }
    }
}