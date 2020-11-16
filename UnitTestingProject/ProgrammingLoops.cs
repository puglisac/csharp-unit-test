using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestingProject
{
    public class ProgrammingLoops
    {

        //For loop
        public int ForLoop()
        {
            var sum = 0;
            for (var i = 0; i < 100; i++)
            {
                sum += i;
            }
            return sum;
        }

        //foreach loop
        public int ForEachLoop()
        {
            var sum = 0;
            var numbers = new List<int> { 1, 3, 5, 7, 9 };
            foreach (var num in numbers)
            {
                sum += num;
            }
            return sum;
        }

        //while loop
        public int WhileLoop()
        {
            var sum = 0;
            var counter = 0;

            //checks condition before running code
            while (counter < 100)
            {
                sum += counter;
                counter++;
            }
            return sum;
        }

        //do-while loop
        public int DoWhileLoop()
        {
            var sum = 0;
            var counter = 0;

            //will execute at least once before condition is checked
            do
            {
                sum += counter;
                counter++;
            } while (counter < 100);
            return sum;
        }

        public string BreakandContinue()
        {
            var sb = new StringBuilder();
            var words = new List<string>() { "Bread", "Milk", "Eggs", "Cheese", "Apples" };

            foreach(var word in words)
            {
                //does not run append if word starts with M but loop will continue
                if (word.StartsWith("M")) continue;

                //does not run append if word starts with C and also exits loop
                if (word.StartsWith("C")) break;

                sb.AppendLine(word);
            }
            return sb.ToString();
        }
    }

}
