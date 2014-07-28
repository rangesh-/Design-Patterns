using Design_Patterns.Decorartor_Pattern.Component;

namespace Design_Patterns.Decorartor_Pattern.ConcreteComponent
{
    class MediumPizza:Pizza
    {
         
        public MediumPizza()
        {
            Description = "Medium Pizza";
        }
        
        public override string getDescription()
        {
            return Description;
        }
        public override double getCost ()
        {
            return 3.00;
        }
    }
}