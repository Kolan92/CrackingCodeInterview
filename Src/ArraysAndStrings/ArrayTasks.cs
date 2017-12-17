using System;
using System.Linq;
using System.Text;

namespace ArraysAndStrings
{
    public class ArrayTasks
    {
        public static bool ContainsOnlyUniqueCharacters(string @string)
        {
            ValidateInput(@string);
            for (int outerIndex = 0; outerIndex < @string.Length; outerIndex++)
            {
                for (int innerIndex = outerIndex + 1; innerIndex < @string.Length; innerIndex++)
                {
                    if(@string[outerIndex] == @string[innerIndex])
                        return false;
                }
            }

            return true;
        }

        public static string Reverse(string @string)
        {
            ValidateInput(@string);

            var stringArray = @string.ToCharArray();
            var rightIndex = @string.Length - 1;

            for (var leftIndex = 0; leftIndex < @string.Length / 2; leftIndex++, rightIndex--)
            {
                var leftChar =  stringArray[leftIndex];
                stringArray[leftIndex] = stringArray[rightIndex];
                stringArray[rightIndex] = leftChar;
            }

            return new string(stringArray);
        }

        public static bool IsPermutation(string @string, string other)
        {
            ValidateInput(@string);
            ValidateInput(other);
            
            var stringArray = @string.ToCharArray()
                                .OrderBy(c => c);
            
            var otherStringArray = other.ToCharArray()
                                .OrderBy(c => c);

            return stringArray.SequenceEqual(otherStringArray);
        }

        public static string Compress(string @string)
        {
            ValidateInput(@string);

            var stringArray = @string.ToCharArray();
            if(!stringArray.Any())
                return @string;

            var currentChar = stringArray[0];
            var compressedBuilder = new StringBuilder();
            var counter = 0;
            foreach (var @char in stringArray)
            {
                if(@char == currentChar)
                    counter ++;
                else
                {
                    compressedBuilder.Append($"{currentChar}{counter}");
                    currentChar = @char;
                    counter = 1;
                }
            }
            compressedBuilder.Append($"{currentChar}{counter}");
            
            var compressedString = compressedBuilder.ToString();
            return compressedString.Length < @string.Length
                    ? compressedString
                    : @string;
        }

        public static bool IsRotated(string rotated, string toCompare)
        {
            ValidateInput(rotated);
            ValidateInput(toCompare);

            var concatenatedRotatedString =rotated + rotated;
            return concatenatedRotatedString.Contains(toCompare);
        }

        private static void ValidateInput(string @string)
        {
            if(@string == null)
                throw new ArgumentException("Given string is null");
        }
    }
}
