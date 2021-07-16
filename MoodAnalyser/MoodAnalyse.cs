using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser
{
    public class MoodAnalyse
    {
        public string moodMessage;
        public MoodAnalyse(string message)
        {
            this.moodMessage = message;
        }
        public String AnalyseMood()
        {
            if (moodMessage.ToLower().Contains("sad"))
                return "SAD";
            else
                return "HAPPY";
        }
    }
}
