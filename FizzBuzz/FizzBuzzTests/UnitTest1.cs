using System;
using Xunit;
using FizzBuzz;

namespace FizzBuzzTests
{
public class NumberCheckTests
    {
        [Fact]
        public void Fizz_If_Divisible_By_3()
        {
            Assert.Equal("Fizz", Fizzbuzz.NumberCheck(3));
            Assert.Equal("Fizz", Fizzbuzz.NumberCheck(6));
            Assert.Equal("Fizz", Fizzbuzz.NumberCheck(9));
        }
        [Fact]
        public void Buzz_If_Divisible_By_5()
        {
            Assert.Equal("Buzz", Fizzbuzz.NumberCheck(5));
            Assert.Equal("Buzz", Fizzbuzz.NumberCheck(10));
            Assert.Equal("Buzz", Fizzbuzz.NumberCheck(20));
        }
        [Fact]
        public void FizzBuzz_If_Divisible_By_3_and_5()
        {
            Assert.Equal("FizzBuzz", Fizzbuzz.NumberCheck(15));
            Assert.Equal("FizzBuzz", Fizzbuzz.NumberCheck(30));
            Assert.Equal("FizzBuzz", Fizzbuzz.NumberCheck(45));
        }
        [Fact]
        public void Number_If_Not_Divisible_By_3_Or_5()
        {
            Assert.Equal("11", Fizzbuzz.NumberCheck(11));
            Assert.Equal("43", Fizzbuzz.NumberCheck(43));
            Assert.Equal("98", Fizzbuzz.NumberCheck(98));
        }
    }

    public class DivisibleByTests
    {
        [Fact]
        public void Number_Is_Divisible_By()
        {
            Assert.True(Fizzbuzz.DivisibleBy(3, 3));
            Assert.True(Fizzbuzz.DivisibleBy(33, 3));
            Assert.True(Fizzbuzz.DivisibleBy(99, 3));

            Assert.True(Fizzbuzz.DivisibleBy(5, 5));
            Assert.True(Fizzbuzz.DivisibleBy(50, 5));
            Assert.True(Fizzbuzz.DivisibleBy(100, 5));

            Assert.True(Fizzbuzz.DivisibleBy(15, 15));
            Assert.True(Fizzbuzz.DivisibleBy(30, 15));
            Assert.True(Fizzbuzz.DivisibleBy(45, 15));
        }

        [Fact]
        public void Number_Is_Not_Divisible_By()
        {
            Assert.False(Fizzbuzz.DivisibleBy(7, 3));
            Assert.False(Fizzbuzz.DivisibleBy(41, 3));
            Assert.False(Fizzbuzz.DivisibleBy(73, 3));

            Assert.False(Fizzbuzz.DivisibleBy(11, 5));
            Assert.False(Fizzbuzz.DivisibleBy(44, 5));
            Assert.False(Fizzbuzz.DivisibleBy(96, 5));

            Assert.False(Fizzbuzz.DivisibleBy(14, 15));
            Assert.False(Fizzbuzz.DivisibleBy(49, 15));
            Assert.False(Fizzbuzz.DivisibleBy(100, 15));
        }
    }

}
