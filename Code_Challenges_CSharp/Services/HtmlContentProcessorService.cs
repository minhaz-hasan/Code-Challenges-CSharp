using System;
using System.Collections.Generic;
using Code_Challenges_CSharp.Interfaces;

namespace Code_Challenges_CSharp.Services
{
    public class HtmlContentProcessorService : IHtmlContentProcessor
    {

        public int StartPos { get; private set; }
        public int StartIdx { get; private set; }
        public string SubStringValue { get; private set; }

        public HtmlContentProcessorService(int startPos, int startIdx, string subStringValue)
        {
            StartPos = startPos;
            StartIdx = startIdx;
            SubStringValue = subStringValue;
        }

        public List<double> GetReviews(string html)
        {
            var extractListOfRatings = new List<double>();
            while (StartPos < html.Length)
            {
                StartPos = html.IndexOf(SubStringValue, StartPos, StringComparison.Ordinal);

                if (StartPos == -1)
                {
                    break;
                }

                var tempStr = html.Substring(StartPos + StartIdx, 1);
                extractListOfRatings.Add(double.Parse(tempStr));
                StartPos += StartIdx;
            }
            return extractListOfRatings;
        }
    }
}