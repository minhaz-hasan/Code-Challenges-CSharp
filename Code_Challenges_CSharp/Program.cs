using System;

namespace Code_Challenges_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                 Q: Part 1
                    Build a C# Console Application that retrieves the HTML content from http://
                    www.trustpilot.co.uk/review/www.ryanair.comand prints out the number of 
                    characters in the markup.
             */
            
            HtmlContentRetrievalHelper.PrintNumberOfCharactersFromUrl();


            /*
             Q: Part 2
                Extract the star ratings from the reviews on the first page of reviews. Calculate the 
                average and print out a score between 0.0 and 10.0.
             */
            HtmlContentRetrievalHelper.ProcessAverageRating();


            Console.ReadLine();

        }
    }
}
