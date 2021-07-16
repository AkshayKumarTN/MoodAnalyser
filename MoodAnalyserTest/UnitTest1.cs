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
            string message = "I am in Sad Mood";
            MoodAnalyse moodAnalyse = new MoodAnalyse(message);
            string result = moodAnalyse.AnalyseMood();
            Assert.AreEqual(result, "SAD");
        }

        [TestMethod]
        public void MoodAnalyserTestForHappy()
        {
            string message = "I am in Any Mood";
            MoodAnalyse moodAnalyse = new MoodAnalyse(message);
            string result = moodAnalyse.AnalyseMood();
            Assert.AreEqual(result, "HAPPY");
        }
    }
}
