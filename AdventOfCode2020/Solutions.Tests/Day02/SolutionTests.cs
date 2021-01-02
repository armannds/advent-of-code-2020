// -----------------------------------------------------------------------
// <copyright file="SolutionTests.cs" company="Marel hf.">
// Copyright (c) Marel hf. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace Solutions.Tests.Day02
{
    using Shouldly;
    using Xunit;
    using Day02 = Solutions.Day02;

    public class SolutionTests
    {
        private const string TestInput = @"1-3 a: abcde
1-3 b: cdefg
2-9 c: ccccccccc";

        [Fact]
        public void Part1_Should_Return_2_For_Given_Input()
        {
            // Arrange
            var day02 = new Day02(TestInput);
            
            // Act
            var result = day02.Solve_1();

            // Assert
            result.ShouldBe("2");
        }

        [Fact]
        public void Part2_Should_Return_1_For_Given_Input()
        {
            // Arrange
            var day02 = new Day02(TestInput);
            
            // Act
            var result = day02.Solve_2();

            // Assert
            result.ShouldBe("1");
        }
    }
}
