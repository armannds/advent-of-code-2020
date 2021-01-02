// -----------------------------------------------------------------------
// <copyright file="Day02.cs" company="Marel hf.">
// Copyright (c) Marel hf. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace Solutions
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using AoCHelper;

    public class Day02 : BaseDay
    {
        private readonly List<string> passwords;

        public Day02()
        {
            this.passwords = GetPasswordsFromInput(File.ReadAllText(InputFilePath));
        }

        public Day02(string input)
        {
            this.passwords = GetPasswordsFromInput(input);
        }

        public override string Solve_1()
        {
            var validPasswords = 0;
            foreach (var row in this.passwords)
            {
                var splitRow = row.Split(":");
                var password = splitRow[1].Trim();

                var policy = splitRow[0].Split(" ");
                var minMax = policy[0].Split("-").Select(_ => int.Parse(_.Trim())).ToArray();
                var min = minMax[0];
                var max = minMax[1];
                var code = policy[1].Trim();

                var count = 0;
                foreach (var @char in password)
                {
                    if (@char.ToString() == code)
                    {
                        count++;
                    }
                }

                if (min <= count && count <= max)
                {
                    validPasswords++;
                }
            }

            return validPasswords.ToString();
        }

        public override string Solve_2()
        {
            var validPasswords = 0;
            foreach (var row in this.passwords)
            {
                var splitRow = row.Split(":");
                var password = splitRow[1].Trim();

                var policy = splitRow[0].Split(" ");
                var positions = policy[0].Split("-").Select(_ => int.Parse(_.Trim())).ToArray();

                var min = positions[0] - 1;
                var max = positions[1] - 1;
                var code = policy[1].Trim();

                var first = password[min].ToString();
                var second = password[max].ToString();
                if ((code == first) != (code == second))
                {
                    validPasswords++;
                }
            }

            return validPasswords.ToString();
        }

        private static List<string> GetPasswordsFromInput(string input) => input
            .Split("\n")
            .ToList();
    }
}
