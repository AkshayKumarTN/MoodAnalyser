using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;

namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MoodAnalyserTestForSad()
        {
            //TC 1.1
            string message = "I am in Sad Mood";
            MoodAnalyse moodAnalyse = new MoodAnalyse(message);
            string result = moodAnalyse.AnalyseMood();
            Assert.AreEqual(result, "SAD");
        }

        [TestMethod]
        public void MoodAnalyserTestForHappy()
        {
            //TC 2.1
            string message = null;
            MoodAnalyse moodAnalyse = new MoodAnalyse(message);
            string result = moodAnalyse.AnalyseMood();
            Assert.AreEqual(result, "HAPPY");
        }
    }
}
