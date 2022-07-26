using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar",true)]
        [InlineData("daycare",false)]
        [InlineData("Abba", true)]
        [InlineData("Detartrated", true)]
        [InlineData("building", false)]
        public void Test1(string str, bool expected)
        {
            var word = new WordSmith();

            var actual = word.IsAPalindrome(str);

            Assert.Equal(expected, actual);

        }
    }
}
