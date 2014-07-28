using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Design_Patterns.State_Pattern.Before
{
    public enum CardReaderState
    {
        Insert,
        Discard,
        Hold

    }
    class CardReader
    {
        private CardReaderState state=CardReaderState.Insert;
        public void PerformCardOperation()
        {
            switch (state)
            {
                   case CardReaderState.Discard:
                       IdleState();

                    break;
                    case CardReaderState.Insert:
                    state = CardReaderState.Hold;
                        InsertCard();


                    break;
                    case CardReaderState.Hold:
                    state = CardReaderState.Discard;
                    CardTasks();
                    break;
            }
         
        }

        private void CardTasks()
        {
            Console.WriteLine("CardReader Holding the Card For Processing");
            PerformCardOperation();
        }

        private void IdleState()
        {
            Console.WriteLine("CardReader is Idle");
        }

        private void InsertCard()
        {
            Console.WriteLine("Card Inserted");
            PerformCardOperation();
   
        }
    }
}
