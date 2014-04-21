using System;
using Code_Challenges_CSharp.Interfaces;
using Code_Challenges_CSharp.Services;
using Microsoft.Practices.Unity;

namespace Code_Challenges_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new UnityContainer();

            container.RegisterType<IUrlProcessor, UrlProcessorService>(new InjectionConstructor("http://www.trustpilot.co.uk/review/www.ryanair.com"));

            const string subStringValue = "star-ratingsize-mediumcount-";
            container.RegisterType<IHtmlContentProcessor, HtmlContentProcessorService>(new InjectionConstructor(0, subStringValue.Length, subStringValue));

            container.RegisterType<IPrinter, PrinterService>();

            var htmlContentObj = container.Resolve<HtmlContentRetrievalHelper>();

            /*
                 Q: Part 1
                    Build a C# Console Application that retrieves the HTML content from http://
                    www.trustpilot.co.uk/review/www.ryanair.comand prints out the number of 
                    characters in the markup.
             */
            htmlContentObj.PrintNumberOfCharactersFromUrl();

            /*
              Q: Part 2
                 Extract the star ratings from the reviews on the first page of reviews. Calculate the 
                 average and print out a score between 0.0 and 10.0.
            */
            htmlContentObj.ProcessAverageRating();

            Console.ReadLine();

        }
    }
}
