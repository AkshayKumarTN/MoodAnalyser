using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser
{
    public class MoodAnalyse
    {
        public string moodMessage;
        public MoodAnalyse()
        {
            this.moodMessage = "";
        }
        public MoodAnalyse(string message)
        {
            this.moodMessage = message;
        }
        public String AnalyseMood()
        {
            try
            {
                if (this.moodMessage.Equals(""))
                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.EMPTY_MESSAGE, "Message should not be Empty");
                if (moodMessage.ToLower().Contains("sad"))
                    return "SAD";
                else
                    return "HAPPY";
            }
            catch(NullReferenceException)
            {
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NULL_MESSAGE, "Message should not be Null");
            }
        }
    }
}
