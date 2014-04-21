using System.Collections.Generic;

namespace Code_Challenges_CSharp.Interfaces
{
    /// <summary>
    /// IHtmlContentProcessor defines the actions for processing the html content and returns list of reviews from the page.
    /// </summary>
    public interface IHtmlContentProcessor
    {
        List<double> GetReviews(string html); // Renames it to GetReviews() from GetAverage()
    }
}