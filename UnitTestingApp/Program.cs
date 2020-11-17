using System;
using System.Collections.Generic;
using System.IO;

namespace UnitTestingApp
{
    class Program
    {
        public static List<string> Words;
        static void Main(string[] args)
        {
            Words = new List<string>();
            Words.Add("Bread");
            Words.Add("Milk");
            Words.Add("Cheese");

            CrazyMathProblem();
            ReadTextFile();
        }

        private static void ReadTextFile()
        {
            try
            {
                using(var sr=new StreamReader(@"c:test.txt"))
                {
                    string contents = sr.ReadToEnd();
                    Console.WriteLine(contents);
                }
            }
            catch(System.IO.DirectoryNotFoundException ex)
            {
                Console.WriteLine("Could not find the directory.");
            }
            catch(System.IO.FileNotFoundException ex)
            {
                Console.WriteLine("Could not find the file.");
            }
            catch(Exception ex)
            {
                Console.WriteLine("An unknown error occured " + ex.Message);
            }
            finally
            {
                Console.WriteLine("The finally runs all the time");
            }
        }

        private static int CrazyMathProblem()
        {
            var income = 1000;
            for(var i = 10; i>0; i--)
            {
                income /= i;
            }
            return income;
        }
    }
}
