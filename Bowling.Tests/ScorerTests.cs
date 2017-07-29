using System;
using Xunit;

namespace Bowling.Tests
{
    public class ScorerTests
    {
        [Fact]
        public void Calculate_ReturnsZero_WhenAllFramesAreMisses()
        {
            var unit = new Scorer();
            var input = new string[,] {
                {"-", "-"},
                {"-", "-"},
                {"-", "-"},
                {"-", "-"},
                {"-", "-"},
                {"-", "-"},
                {"-", "-"},
                {"-", "-"},
                {"-", "-"},
                {"-", "-"},
            };

            int score = unit.Calculate(input);

            Assert.Equal(0, score);
        }
    }
}
