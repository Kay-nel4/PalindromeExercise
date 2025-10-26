using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("tacocat", true)]
        [InlineData("mom", true)]
        [InlineData("kittiesrock", false)]
        [InlineData("12344321",true)]
        [InlineData("789654326789865",false)]
        [InlineData("wasitacatisaw", true)]
        [InlineData("truecoders", false)]
        //Arrange
        
        
        public void IsPalendrome(string s, bool expected)
        {
            //Arrange
            var challenger = new WordSmith();
            
            //Act
            bool actual = challenger.IsPalindrome(s);
            
            Assert.Equal(expected, actual);
        }
        
    }
}
