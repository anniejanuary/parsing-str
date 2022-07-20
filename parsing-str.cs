//Parse the string variables from below into the correct datatypes:



//public static void Main(string[] args)
//{
//    string stringForFloat = "0.85"; // datatype should be float
//    string stringForInt = "12345"; // datatype should be int
//} 


using System;

namespace Assignment1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string stringForFloat = "0.85"; // datatype should be float
            string stringForInt = "12345"; // datatype should be int

            float float1 = float.Parse(stringForFloat);

            int int1 = Int32.Parse(stringForInt);

            Console.WriteLine("Int = {0}, Float = {1}", int1, float1);
            Console.Read();
        }
    }
}
