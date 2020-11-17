using System;
using System.Collections.Generic;
using System.IO;
using NLog;

namespace UnitTestingApp
{
    class Program
    {
        public static Logger logger = LogManager.GetCurrentClassLogger();
        public static List<string> Words;
        static void Main(string[] args)
        {
            logger.Trace("The program started");
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
                using(var sr=new StreamReader(@"/Users/alanpuglisi/linked_in_c#/UnitTestingProject/test.txt"))
                {
                    string contents = sr.ReadToEnd();
                    Console.WriteLine(contents);
                }
            }
            catch(System.IO.DirectoryNotFoundException ex)
            {
                Console.WriteLine("Could not find the directory.");
                logger.Error(ex.Message);
            }
            catch(System.IO.FileNotFoundException ex)
            {
                Console.WriteLine("Could not find the file.");
                logger.Error(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unknown error occured " + ex.Message);
                logger.Error(ex.Message);
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
