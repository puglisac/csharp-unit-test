using System;
namespace UnitTestingProject
{
    public class FlowControl
    {
        public bool IsYourFavoriteColorRed(string color)
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
