using System;

namespace HelloWorldLibrary
{
    public class Formatter
    {
        public static string FormatOutput(string str)
        {
            return DateTime.Now.ToString() + ", Hello " + str;
        }
    }
}
