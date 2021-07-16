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
            string message = "I am in Happy Mood";
            MoodAnalyse moodAnalyse = new MoodAnalyse(message);
            string result = moodAnalyse.AnalyseMood();
            Assert.AreEqual(result, "HAPPY");
        }

        [TestMethod]
        public void MoodAnalyserTestReturnsCustomNullException()
        {
            // TC 3.1
            try
            {
                string message = null;
                MoodAnalyse mood = new MoodAnalyse(message);

                mood.AnalyseMood();
            }
            catch (MoodAnalysisException ex)
            {
                Assert.AreEqual("Message should not be Null", ex.Message);
            }
        }
        [TestMethod]
        public void MoodAnalyserTestReturnsCustomEmptyException()
        {
            // TC 3.2
            try
            {
                string message = "";
                MoodAnalyse mood = new MoodAnalyse(message);

                mood.AnalyseMood();
            }
            catch (MoodAnalysisException ex)
            {
                Assert.AreEqual("Message should not be Empty", ex.Message);
            }
        }
    }
}
