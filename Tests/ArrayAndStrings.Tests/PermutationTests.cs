using ArraysAndStrings;
using NUnit.Framework;
using FluentAssertions;
using System;

namespace ArrayAndStrings.Tests
{
    public class PermutationTests
    {
        [Test]
        public void Should_Throw_Argument_Exception_Given_First_Argument_Null()
        {
            Assert.Throws<ArgumentException>(() => ArrayTasks.IsPermutation(null, string.Empty));
        }

        [Test]
        public void Should_Throw_Argument_Exception_Given_Second_Argument_Null()
        {
            Assert.Throws<ArgumentException>(() => ArrayTasks.IsPermutation(string.Empty, null));
        }

        [Test]
        public void Should_Return_True_For_Two_Empty_String()
        {
            var result = ArrayTasks.IsPermutation(string.Empty, string.Empty);
            result.Should().BeTrue();
        }

        [Test]
        public void Should_Return_False_For_Two_Strings_Which_Are_Not_Permutation()
        {
            var result = ArrayTasks.IsPermutation("abc", "qwx");
            result.Should().BeFalse();
        }

        [Test]
        public void Should_Return_True_For_Two_Strings_Which_Are_Permutation()
        {
            var result = ArrayTasks.IsPermutation("abc", "bac");
            result.Should().BeTrue();
        }
    }
}