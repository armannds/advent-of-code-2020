// -----------------------------------------------------------------------
// <copyright file="Day01.cs" company="Marel hf.">
// Copyright (c) Marel hf. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace Solutions
{
    using System.IO;
    using System.Linq;
    using AoCHelper;

    public class Day01 : BaseDay
    {
        private readonly string input;
        private const int SumTargetNumber = 2020;


        public Day01()
        {
            this.input = File.ReadAllText(InputFilePath);
        }

        public Day01(string input)
        {
            this.input = input;
        }

        public override string Solve_1()
        {
            var numbers = this.GetNumbersFromInput();

            for (var i = 0; i < numbers.Length - 1; i++)
            {
                for (var j = i + 1; j < numbers.Length; j++)
                {
                    var sumOfValues = numbers[i] + numbers[j];
                    if (sumOfValues == SumTargetNumber)
                    {
                        return (numbers[i] * numbers[j]).ToString();
                    }
                }
            }

            return "0";
        }

        public override string Solve_2()
        {
            var numbers = this.GetNumbersFromInput();

            for (var i = 0; i < numbers.Length - 2; i++)
            {
                for (var j = i + 1; j < numbers.Length - 1; j++)
                {
                    for (var k = j + 2; k < numbers.Length; k++)
                    {
                        var sumOfValues = numbers[i] + numbers[j] + numbers[k];
                        if (sumOfValues == SumTargetNumber)
                        {
                            return (numbers[i] * numbers[j] * numbers[k]).ToString();
                        }
                        
                    }
                }
            }

            return "0";
        }
        
        private int[] GetNumbersFromInput() => this.input
            .Split("\n")
            .Select(_ => _.Trim())
            .Select(int.Parse)
            .ToArray();
    }
}
