using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Design_Patterns.Bridge_Pattern;
using Design_Patterns.Decorartor_Pattern.Component;
using Design_Patterns.Decorartor_Pattern.ConcreteComponent;
using Design_Patterns.Decorartor_Pattern.ConcreteDecorator;
using Design_Patterns.Factory_Patterns.Before;
using Design_Patterns.State_Pattern.After;
using Design_Patterns.State_Pattern.Before;
using Design_Patterns.StratergyPattern.After;
using CardReader = Design_Patterns.State_Pattern.After.CardReader;

namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //InvokeBridgePattern();
            //InvokeStratergyPattern();
            //InvokeFactoryPattern();
            //InvokeStatePattern();
            InvokeDecoratorPattern();
        }

        private static void InvokeDecoratorPattern()
        {
       Pizza LargePizza=new LargePizza();
            var cheesepizza = new Cheese(LargePizza);
            Console.WriteLine(cheesepizza.getCost());

        }

        private static void InvokeStatePattern()
        {
            CardReader c=new CardReader();
  c.PerformOperation(); //Instance will point to CardInsert
c.PerformOperation();//Instance will point to CardHold
c.PerformOperation();//Instance will point to CardDiscard
        }

        private static void InvokeFactoryPattern()
        {
            var obj = new ListCar();
            var icar = obj.getCar("Audi");
           icar.CarName();

        }

        private static void InvokeStratergyPattern()
        {
            var op=new MulOperation();
            var result = new Operation(op);
            var output = result.CalculateMetrics(new Arithemetic(){Operand1 =2,Operand2 =3,OpertionType = Arithemetic.Options.Add});
            Console.WriteLine(output);
        }

        private static void InvokeBridgePattern()
        {
            List <manuscript> docList= new List<manuscript>();
            var sf = new StandardFormatter();
            var Book = new Book(sf) {Author = "Ran", Title = "lol"};
            docList.Add(Book);
            var Faq = new FAQ(sf) {faq = "Who should use this book ?", Title = "Any Body can use"};
            docList.Add(Faq);
            var Terms = new Terms(sf) {condition = "Should not copy", Term = "6 years"};
            docList.Add(Terms);
            foreach (manuscript manuscript in docList)
            {
            manuscript.Print();
            }
        }
    }
}
