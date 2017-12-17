using ArraysAndStrings;
using NUnit.Framework;
using FluentAssertions;
using System;

namespace ArrayAndStrings.Tests
{
    public class CompressStringTests
    {
        [Test]
        public void Should_Throw_Argument_Exception_Given_Null()
        {
            Assert.Throws<ArgumentException>(() => ArrayTasks.Compress(null));
        }

        [Test]
        public void Should_Return_Input_String_When_Compress_Is_Inefficient()
        {
            var result = ArrayTasks.Compress("abcde");
            result.Should().Be("abcde");
        }

        [Test]
        public void Should_Return_Compressed_String_When_Compress_Is_Efficient()
        {
            var result = ArrayTasks.Compress("aabcccccaaa");
            result.Should().Be("a2b1c5a3");
        }
    }
}