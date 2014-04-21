using System;
using System.Linq;
using System.Net;
using Code_Challenges_CSharp.Interfaces;

namespace Code_Challenges_CSharp.Services
{

    public class UrlProcessorService : IUrlProcessor
    {
        public string Url { get; private set; }

        public UrlProcessorService(string url)
        {
            Url = url;
        }

        public string ProcessUrl()
        {
            return new WebClient().DownloadString(new Uri(Url));
        }

        public string ProcessUrlWithoutWhitespace()
        {
            return new string(HtmlData.Where(s => !char.IsWhiteSpace(s)).ToArray());
        }

        public string HtmlData
        {
            get { return ProcessUrl(); }
        }
 
    }
}