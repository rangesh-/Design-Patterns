using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Design_Patterns.Bridge_Pattern
{
    public  class FAQ:manuscript
    {
        public FAQ(Iformatter formIformatter) : base(formIformatter)
        {

        }

        public  string Title { get; set; }
        public String faq { get; set; }

       public override void Print()
        {
            Console.WriteLine(formatter.Format("Tiltle-Faq",Title));
            Console.WriteLine("FAQ Question"+faq);
        }
    }

    public class Terms : manuscript
    {
        public Terms(Iformatter formIformatter) : base(formIformatter)
        {
        }

        public string Term { get; set; }
        public string condition { get; set; }
       public  override  void Print()
        {
            Console.WriteLine("Terms" + Term);
            Console.WriteLine("Condition" + condition);
        }
    }

    public class Book :manuscript
    {
        public Book(Iformatter formIformatter) : base(formIformatter)
        {
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public override void Print()
        {
            Console.WriteLine("Tiltle-Book" + Title);
            Console.WriteLine("Author" + Author);
        }
    }

}
