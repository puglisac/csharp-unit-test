﻿using System;
namespace Tests
{
    public class SimpleArray
    {
        public string[] GroceryList;

        public SimpleArray()
        {
            GroceryList = new string[4] { "Bread", "Milk", "Eggs", "Cheese" };
        }

        public override string ToString()
        {
            return "There are " + GroceryList.Length + " and they are " + GroceryList.ToString();
        }
    }
}
