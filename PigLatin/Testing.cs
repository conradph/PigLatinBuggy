using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PigLatin
{
    public class Testing
    {
        [Fact]
        public void TestApple()
        {
            PigLatin pig = new PigLatin();
            string actual = pig.ToPigLatin("apple");
            Assert.Equal("appleway", actual);
        }
        [Theory]
        [InlineData("apple", "appleway")]
        [InlineData("heck", "eckhay")]
        [InlineData("strong", "ongstray")]
        [InlineData("tommy@email.com", "tommy@email.com")]
        [InlineData("aardvark", "aardvarkway")]
        [InlineData("Tommy", "ommytay")]
        [InlineData("gym", "gym")]
        [InlineData("apple joy gym tommy@email.com strong", "appleway oyjay gym tommy@email.com ongstray")]
        public void TestAll(string input, string expected)
        {
            PigLatin pig = new PigLatin();
            string actual = pig.ToPigLatin(input);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestVowel()
        {
            PigLatin pig = new PigLatin();
            bool expected = true;
            bool actual = pig.IsVowel('a');
            Assert.Equal(expected, actual);
        }
    }
}
