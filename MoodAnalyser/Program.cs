using System;

namespace MoodAnalyser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n ***************** Mood Analyser ****************");

            MoodAnalyse moodAnalyse = new MoodAnalyse();
            string mood= moodAnalyse.AnalyseMood();
            Console.WriteLine(" Mood : " + mood);
        }
    }
}
