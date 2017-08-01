using System;
using System.Collections.Generic;
using System.Linq;

namespace Bowling
{
    public class Scorer
    {
        public int Calculate(string[] turns) {
            int[] pins = new int[turns.Length];

            // get the pins for all the turns:
            for (int i = 0; i < turns.Length; i++)
            {
                int current;
                if (int.TryParse(turns[i], out current))
                    pins[i]= current;
                else if (turns[i] == "/")
                    pins[i] = 10 - pins[i-1];
            }

            // parse into frame scores:
            List<int> frames = new List<int>();
            for (int i = 0; i < pins.Length; i+=2)
            {
                var score = pins[i] + pins [i+1];
                // bonus for a spare:
                if (score == 10)
                    score += pins[i+2];
                
                frames.Add(score);
            }

            return frames.Sum();
        }

        // class Frame {
        //     public int FirstPins { get; set; }
        //     public int SecondPins { get; set; }
        //     public Frame(string first, string second) {

        //     }

        //     private ParsePins()
        // }
    }
}
