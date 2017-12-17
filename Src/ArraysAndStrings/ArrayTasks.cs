using System;

namespace ArraysAndStrings
{
    public class ArrayTasks
    {
        public static bool ContainsOnlyUniqueCharacters(string @string)
        {
            if(@string == null)
                throw new ArgumentException("Given string is null");

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
    }
}
