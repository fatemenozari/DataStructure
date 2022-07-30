using Xunit;
using DataStructure;
using System.IO;
using System;

namespace TestDataStructure
{
    public class Tests
    {
        [Fact]
        public void Should_Create_New_File()
        {
            var path = @"..\file.txt";

            CreateFile.Creator(path);

            Assert.True(File.Exists(path));
        }

       
        [Fact]
        public void Should_Calculate_Power() => Assert.Equal(243, CalcuOfPower.CalcuPower(3, 5));

    }
}