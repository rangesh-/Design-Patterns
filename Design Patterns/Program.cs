using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Design_Patterns.Bridge_Pattern;

namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            InvokeBridgePattern();

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
