using ArraysAndStrings;
using NUnit.Framework;
using System;

namespace Tests
{
    public class ArrayTests
    {
        [Test]
        public void Should_Throw_Argument_Exception_Given_Null()
        {
            Assert.Throws<ArgumentException>(() => ArrayTasks.ContainsOnlyUniqueCharacters(null));
        }
    }
}