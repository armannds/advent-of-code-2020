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
        private const int SumTargetNumber = 2020;
        private readonly int[] numbers;


        public Day01()
        {
            this.numbers = GetNumbersFromInput(File.ReadAllText(this.InputFilePath));
        }

        public Day01(string input)
        {
            this.numbers = GetNumbersFromInput(input);
        }

        public override string Solve_1()
        {
            for (var i = 0; i < this.numbers.Length - 1; i++)
            {
                for (var j = i + 1; j < this.numbers.Length; j++)
                {
                    var sumOfValues = this.numbers[i] + this.numbers[j];
                    if (sumOfValues == SumTargetNumber)
                    {
                        return (this.numbers[i] * this.numbers[j]).ToString();
                    }
                }
            }

            return "0";
        }

        public override string Solve_2()
        {
            // var numbers = this.GetNumbersFromInput();

            for (var i = 0; i < this.numbers.Length - 2; i++)
            {
                for (var j = i + 1; j < this.numbers.Length - 1; j++)
                {
                    for (var k = j + 2; k < this.numbers.Length; k++)
                    {
                        var sumOfValues = this.numbers[i] + this.numbers[j] + this.numbers[k];
                        if (sumOfValues == SumTargetNumber)
                        {
                            return (this.numbers[i] * this.numbers[j] * this.numbers[k]).ToString();
                        }
                        
                    }
                }
            }

            return "0";
        }
        
        private static int[] GetNumbersFromInput(string input) => input
            .Split("\n")
            .Select(_ => _.Trim())
            .Select(int.Parse)
            .ToArray();
    }
}
