namespace Code_Challenges_CSharp
{
    /// <summary>
    /// IUrlProcessor defines the actions for retrieving html content and stores that content and process that content.</summary>
    public interface IUrlProcessor
    {
        string HtmlData { get; } // Alternative of static variable I think and renamed it from _htmlContent to HtmlData.
        string Url { get; }

        string ProcessUrl();
        string ProcessUrlWithoutWhitespace();
    }
}