using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace Code_Challenges_CSharp
{
    class HtmlContentRetrievalHelper
    {
        private static string _htmlContent = ProcessUrl("http://www.trustpilot.co.uk/review/www.ryanair.com");

        //Part 2 Answer 
        public static void ProcessAverageRating()
        {
            var html = GetHtmlStringWithoutSpace(_htmlContent);


            string strValue = "star-ratingsize-mediumcount-";
            int startPos = 0;
            int startIdx = strValue.Length;
            List<double> extractListOfRatings = new List<double>();

            var averageRating = GetAverage(html, strValue, startPos, startIdx, extractListOfRatings);
            Print("Average rating from the reviews on the first page of reviews", averageRating);
        }


        
        private static string GetAverage(string html, string strValue, int startPos, int startIdx,
            List<double> extractListOfRatings)
        {
            while (startPos < html.Length)
            {
                startPos = html.IndexOf(strValue, startPos, StringComparison.Ordinal);
                if (startPos == -1)
                {
                    break;
                }
                else
                {
                    var tempStr = html.Substring(startPos + startIdx, 1);
                    extractListOfRatings.Add(Double.Parse(tempStr));
                    startPos += startIdx;
                }
            }
            var averageRating = extractListOfRatings.Average().ToString("F1");
            return averageRating;
        }

        //Part 1 Answer 
        public static void PrintNumberOfCharactersFromUrl()
        {
            var htmlString = _htmlContent;
            var htmlStringWithoutSpace = GetHtmlStringWithoutSpace(htmlString);

            var listOfHtmlContents = new Dictionary<string, int>();
            listOfHtmlContents.Add("Total number of chars with whitespace", htmlString.Length);
            listOfHtmlContents.Add("Total number of chars without whitespace", htmlStringWithoutSpace.Length);

            foreach (var listOfHtmlContent in listOfHtmlContents)
            {
                Print(listOfHtmlContent.Key, listOfHtmlContent.Value.ToString());
            }

        }

        private static string GetHtmlStringWithoutSpace(string htmlString)
        {
            return new string(htmlString.Where(s => !char.IsWhiteSpace(s)).ToArray());
        }

        private static void Print(string message, string data)
        {
            Console.WriteLine("{0}: {1}\n", message, data);
        }

        private static string ProcessUrl(string url)
        {
            var wcClient = new WebClient();
            _htmlContent = wcClient.DownloadString(new Uri(url));
            return _htmlContent;
        }
    }
}