using ArraysAndStrings;
using NUnit.Framework;
using FluentAssertions;
using System;

namespace ArrayAndStrings.Tests
{
    public class UniqueCharactersTest
    {
        [Test]
        public void Should_Throw_Argument_Exception_Given_Null()
        {
            Assert.Throws<ArgumentException>(() => ArrayTasks.ContainsOnlyUniqueCharacters(null));
        }

        [Test]
        public void Should_Return_True_Given_Empty_String()
        {
            var result = ArrayTasks.ContainsOnlyUniqueCharacters(string.Empty);
            result.Should().BeTrue();
        }

        [Test]
        public void Should_Return_False_Given_String_With_Not_Unique_Charactesr()
        {
            var result = ArrayTasks.ContainsOnlyUniqueCharacters("AA");
            result.Should().BeFalse();
        }

        [Test]
        public void Should_Return_True_Given_String_With_Unique_Characters()
        {
            var result = ArrayTasks.ContainsOnlyUniqueCharacters("abc");
            result.Should().BeTrue();
        }

        [Test]
        public void Should_Return_True_Given_String_With_Character_In_UpperCase_And_Lower_Case()
        {
            var result = ArrayTasks.ContainsOnlyUniqueCharacters("Aa");
            result.Should().BeTrue();
        }
    }
}