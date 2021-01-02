// -----------------------------------------------------------------------
// <copyright file="Solution1Tests.cs" company="Marel hf.">
// Copyright (c) Marel hf. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace Solutions.Tests.Day01
{
    using System.Linq;
    using Shouldly;
    using Xunit;
    using Day01 = Solutions.Day01;

    public class SolutionTests
    {
        private const string TestInput = @"1721
979
366
299
675
1456";

        [Fact]
        public void Part1_Should_Return_514579_For_Given_Input()
        {
            // Arrange
            var day01 = new Day01(TestInput);

            // Act
            var result = day01.Solve_1();

            // Assert
            result.ShouldBe("514579");
        }

        [Fact]
        public void Part2_Should_Return_241861950_For_Given_Input()
        {
            // Arrange
            var day01 = new Day01(TestInput);

            // Act
            var result = day01.Solve_2();

            // Assert
            result.ShouldBe("241861950");
        }
    }
}
