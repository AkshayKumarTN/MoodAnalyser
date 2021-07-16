using System;

namespace MoodAnalyser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n ***************** Mood Analyser ****************");

            try
            {
                Console.Write(" Enter the Message : ");
                string message = Console.ReadLine();
                MoodAnalyse moodAnalyse = new MoodAnalyse(message);
                string mood = moodAnalyse.AnalyseMood();
                Console.WriteLine(" Mood : " + mood);
            }
            catch(MoodAnalysisException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
