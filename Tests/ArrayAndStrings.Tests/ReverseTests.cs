using ArraysAndStrings;
using NUnit.Framework;
using FluentAssertions;
using System;

namespace ArrayAndStrings.Tests
{
    public class ReverseTests
    {
        [Test]
        public void Should_Throw_Argument_Exception_Given_Null()
        {
            Assert.Throws<ArgumentException>(() => ArrayTasks.Reverse(null));
        }

        [Test]
        public void Should_Return_Empty_String_Given_Empty_String()
        {
            var result = ArrayTasks.Reverse(string.Empty);
            result.Should().Be(string.Empty);
        }

        [Test]
        public void Should_Reverse_Input_With_Even_Number_Of_Characters()
        {
            var result = ArrayTasks.Reverse("abcd");
            result.Should().Be("dcba");
        }

        [Test]
        public void Should_Reverse_Input_With_Not_Even_Number_Of_Characters()
        {
            var result = ArrayTasks.Reverse("abcde");
            result.Should().Be("edcba");
        }
    }
}