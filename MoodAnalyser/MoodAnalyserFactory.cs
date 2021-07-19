using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace MoodAnalyser
{
    public class MoodAnalyserFactory
    {
        public static object MoodAnalyserObject(string className, string constructorName)
        {
            string pattern = @"." + constructorName + "$";
            Match result = Regex.Match(className, pattern);
            if (result.Success)
            {
                try
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type moodAnalyseType = executing.GetType(className);
                    return Activator.CreateInstance(moodAnalyseType);
                }
                catch (ArgumentNullException)
                {
                    // Throws custom Exception if No Such Class Name is found........
                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_CLASS, "class not found");
                }
            }
            else
            {
                // Throws custom Exception if No Such constructor with Class Name is found........
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_METHOD, "constructor not found");
            }
        }

        public static object MoodAnalyserObjectParametzisedConstructor(string className, string constructorName, string message)
        {
            // type gets the class type........
            Type type = typeof(MoodAnalyse);
            // checking for className is right..........
            if (type.Name.Equals(className) || type.FullName.Equals(className))
            {
                if (type.Name.Equals(constructorName))
                {
                    ConstructorInfo ctor = type.GetConstructor(new[] { typeof(string) });
                    // Creating object with a message......
                    object instance = ctor.Invoke(new object[] { message });
                    // returns the object with message.........
                    return instance;
                }
                else
                {
                    // Throws custom Exception if No Such constructor with Class Name is found........
                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_METHOD, "constructor not found");
                }
            }
            else
            {
                // Throws custom Exception if No Such Class Name is found........
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_CLASS, "class not found");
            }
        }
        public static string InvokeAnalyseMood(string message, string methodName)
        {
            try
            {
                string className = "MoodAnalyser.MoodAnalyse";
                Type type = Type.GetType(className);
                // Object creation is done by calling MoodAnalyserObjectParametzisedConstructor method......
                object moodAnalyserObj = MoodAnalyserObjectParametzisedConstructor(className, "MoodAnalyse", message);
                MethodInfo methodInfo = type.GetMethod(methodName);
                object mood = methodInfo.Invoke(moodAnalyserObj, null);
                return mood.ToString();
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_METHOD, "no such method");
            }
        }
    }
}
