using System;

namespace MoodAnalyser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n ***************** Mood Analyser ****************");

            MoodAnalyse moodAnalyse = new MoodAnalyse("I am in Sad Mood");
            string mood= moodAnalyse.AnalyseMood();
            Console.WriteLine(" Mood : " + mood);
        }
    }
}
