﻿namespace DrinksApp
{
    class Tea : Drink
    {
        public Tea(char size)
        {
            _type = "Tea";
            _size = size;
        }
        public override string GetSummary()
        {
            return "Tea - " + _size;
        }
    }
}