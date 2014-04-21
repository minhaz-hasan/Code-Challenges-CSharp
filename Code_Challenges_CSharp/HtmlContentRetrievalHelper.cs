using System;
using Code_Challenges_CSharp.Interfaces;

namespace Code_Challenges_CSharp
{
    class HtmlContentRetrievalHelper : HtmlContentHelper
    {
        public HtmlContentRetrievalHelper(IUrlProcessor uriProcessor, IHtmlContentProcessor htmlContentProcessor, IPrinter printer)
            : base(uriProcessor, htmlContentProcessor, printer)
        {

        }

        //Part 1 Answer
        public override void PrintNumberOfCharactersFromUrl()
        {
            base.PrintNumberOfCharactersFromUrl();
            Console.WriteLine("\n");
        }

        //Part 2 Answer 
        public override void ProcessAverageRating()
        {
            base.ProcessAverageRating();
            Console.Write(" ");
        }
    }
}