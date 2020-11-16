using System;
using System.Collections.Generic;

namespace UnitTestingProject
{
    public class FlowControl
    
    {

        public string IsYourNameNotBruce(string yourName)
        {
            if(yourName.ToLower()!= "bruce")
            {
                return "Can we call you Bruce for the sake of simplicity?";
            }
            else
            {
                return "G'day Bruce";
            }
        }

        //using &&
        public string GradeLetter(int score)
        {
            if (score > 89) return "A";
            else if (score > 79 && score < 90) return "B";
            else if (score > 69 && score < 80) return "C";
            else return "F";
        }

        //if, else, else if
        public string PrimaryOrSecondary(string color)
        {
            var result = "";
            if (color.ToLower() == "red")
            {
                result = "Primary";
            }
            else if (color.ToLower() == "blue")
            {
                result = "Primary";
            }
            else if (color.ToLower() == "yellow")
            {
                result = "Primary";
            }
            else
            {
                result = "Secondary";
            }
            return result;
        }

        //same as above but using switch statement
        public string PrimaryOrSecondarySwitch(String color)
        {
            var result = "";
            switch (color.ToLower())
            {
                case "red":
                    result = "Primary";
                    //could have more statements here
                    break;
                case "blue":
                    result = "Primary";
                    break;
                case "yello":
                    result = "Primary";
                    break;
                default:
                    result = "Secondary";
                    break;
            }
            return result;
        }

        //using or within conditional
        public string PrimaryOrSecondaryCompound(string color)
        {
            var input = color.ToLower();
            if (input == "red" || input == "blue" || input == "yellow") return "Primary";
            return "Secondary";
        }

        //different ways of using conditionals
        public bool IsYourFavoriteColorYellow(string color)
        {
            return color.ToLower() == "yellow";
        }

        public bool IsYourFavoriteColorGreen(string color)
        {
            return (color.ToLower() == "green") ? true : false;
        }

        public bool IsYourFavoriteColorRed(string color)
        {
            if (color.ToLower() == "red") return true;
            return false;        
        }

        public bool IsYourFavoriteColorBlue(string color)
        {
            if (color.ToLower() == "blue")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public FlowControl()
        {
        }
    }
}
