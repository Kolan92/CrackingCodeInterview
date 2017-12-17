using System;

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

        private static void ValidateInput(string @string)
        {
            if(@string == null)
                throw new ArgumentException("Given string is null");
        }
    }
}
