using System;
using Xunit;
using static BinarySearch.Program;
namespace BinarySearchTest
{
    //test1
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //arrange
            int[] input1 = { 4, 8, 15, 16, 23, 42 };
            int input2 = 15;

            //act
            int result = BinarySearch.Program.BinarySearch(input1, input2);
            int expect = 2;

            //Assert
            Assert.Equal(expect, result);

        }

        }
    }