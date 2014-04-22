using System.Collections.Generic;
using System.Linq;
using Code_Challenges_CSharp.Interfaces;

namespace Code_Challenges_CSharp
{
    /// <summary>
    /// This abstract class defines basic mechanism of printing the html characters and average reviews.
    /// </summary>
    public abstract class HtmlContentHelper
    {
        private readonly IUrlProcessor _uriProcessor;
        private readonly IHtmlContentProcessor _htmlContentProcessor;
        private readonly IPrinter _printer;

        protected HtmlContentHelper(IUrlProcessor uriProcessor, IHtmlContentProcessor htmlContentProcessor, IPrinter printer)
        {
            _printer = printer;
            _htmlContentProcessor = htmlContentProcessor;
            _uriProcessor = uriProcessor;
        }

        public virtual void ProcessAverageRating()
        {
            var averageRating = _htmlContentProcessor.GetReviews(_uriProcessor.ProcessUrlWithoutWhitespace());
            _printer.Print("Average rating from the reviews on the first page of reviews", averageRating.Average().ToString("F1"));
        }

        public virtual void PrintNumberOfCharactersFromUrl()
        {
            var htmlString = _uriProcessor.HtmlData;
            var htmlStringWithoutSpace = _uriProcessor.ProcessUrlWithoutWhitespace();

            var listOfHtmlContents = new Dictionary<string, int>
            {
                {"Total number of chars with whitespace", htmlString.Length},
                {"Total number of chars without whitespace", htmlStringWithoutSpace.Length}
            };

            foreach (var listOfHtmlContent in listOfHtmlContents)
            {
                _printer.Print(listOfHtmlContent.Key, listOfHtmlContent.Value.ToString());
            }
        }
    }
}