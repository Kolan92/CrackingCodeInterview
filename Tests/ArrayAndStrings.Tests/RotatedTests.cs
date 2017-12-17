using ArraysAndStrings;
using NUnit.Framework;
using FluentAssertions;
using System;

namespace ArrayAndStrings.Tests
{
    public class RotatedTests
    {
        [Test]
        public void Should_Throw_Argument_Exception_Given_First_Argument_Null()
        {
            Assert.Throws<ArgumentException>(() => ArrayTasks.IsRotated(null, string.Empty));
        }

        [Test]
        public void Should_Throw_Argument_Exception_Given_Second_Argument_Null()
        {
            Assert.Throws<ArgumentException>(() => ArrayTasks.IsRotated(string.Empty, null));
        }

        [Test]
        public void Should_Return_False_Given_String_That_Is_Not_Equal_To_First()
        {
            var result = ArrayTasks.IsRotated("1234", "abc");
            result.Should().BeFalse();
        }

        [Test]
        public void Should_Return_True_Given_String_That_Is_Equal_To_First()
        {
            var result = ArrayTasks.IsRotated("1234", "1234");
            result.Should().BeTrue();
        }

        [Test]
        public void Should_Return_True_Given_String_That_Is_Part_Of_Rotated_First()
        {
            var result = ArrayTasks.IsRotated("3412", "123");
            result.Should().BeTrue();
        }

        [Test]
        public void Should_Return_True_Given_String_That_Is_Equal_To_Rotated_First()
        {
            var result = ArrayTasks.IsRotated("3412", "1234");
            result.Should().BeTrue();
        }

    }
}