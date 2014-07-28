using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Design_Patterns.Factory_Patterns.Before
{
    class ListCar
    {
        public ICar getCar(String CarName)
        {
            switch (CarName)
            {
                case "Audi":
                   return new Audi();
                case "BMW":
                    return new BMW();
                default:
                    throw new Exception();
            }
        }
    }
}
