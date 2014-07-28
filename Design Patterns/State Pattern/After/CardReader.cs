using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Design_Patterns.State_Pattern.After
{
   public  class CardReader
    {
        public CardState CurrenState { get; set; }

       public CardReader()
       {
           if(CurrenState==null)
               CurrenState=new CardInsert(this);
       }


       public void PerformOperation()
       {
           CurrenState.PerformCardOperation();
       }
    }

    public abstract class CardState
     {
         protected CardReader _reader;

         public virtual void PerformCardOperation()
         {

         }
     }

    public class CardInsert : CardState
     {
         
         public CardInsert(CardReader Reader)
         {
             _reader = Reader;
         }

         public override void PerformCardOperation()
         {
             Console.WriteLine("Card Inserted");
            _reader.CurrenState=new CardHold(_reader);//Chaining the next States
         }
        
    }

    public class CardHold : CardState

    {
        public CardHold(CardReader reader)
        {
            _reader = reader;
        }
        public override void PerformCardOperation()
        {
            Console.WriteLine("Card Holded For Performing Operation");
            _reader.CurrenState=new CardDiscard(_reader);//Chaining the next state

        }

    }

    public class CardDiscard : CardState
    {
        public CardDiscard(CardReader reader)
        {
            _reader = reader;
        }
        public override void PerformCardOperation()
        {
            Console.WriteLine("Card discarded");
        }
    }
}
