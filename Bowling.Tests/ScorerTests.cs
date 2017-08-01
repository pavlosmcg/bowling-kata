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
            var input = new string[] {
                "-", "-",
                "-", "-",
                "-", "-",
                "-", "-",
                "-", "-",
                "-", "-",
                "-", "-",
                "-", "-",
                "-", "-",
                "-", "-",
            };

            int score = unit.Calculate(input);

            Assert.Equal(0, score);
        }

        [Fact]
        public void Calculate_Returns50_WhenAllFramesAddUpTo5()
        {
            var unit = new Scorer();
            var input = new string[]{
                "5", "-",
                "5", "-",
                "5", "-",
                "2", "3",
                "3", "2",
                "4", "1",
                "-", "5",
                "-", "5",
                "-", "5",
                "-", "5",
            };

            int score = unit.Calculate(input);

            Assert.Equal(50, score);
        }

        [Fact]
        public void Calculate_Returns130_When9FramesAre5AndASpare()
        {
            var unit = new Scorer();
            var input = new string[]{
                "5", "/",
                "5", "/",
                "5", "/",
                "5", "/",
                "5", "/",
                "5", "/",
                "5", "/",
                "5", "/",
                "5", "/",
                "-", "-",
            };

            int score = unit.Calculate(input);

            Assert.Equal(130, score);
        }
    }
}
