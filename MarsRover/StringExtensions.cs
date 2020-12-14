using System;
using System.Collections.Generic;

namespace MarsRover
{
    public static class StringExtensions
    {
        public static List<char> ConvertToCharList(this string input)
        {
            var charList = new List<char>();
            input = input.Replace(",", "");
            charList.AddRange(input);
            return charList;
        }
    }
}