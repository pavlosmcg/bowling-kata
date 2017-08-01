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
                else if (turns[i] == "X")
                    pins[i] = 10;
            }

            // parse into frame scores:
            int[] frames = new int[10];
            int turnIndex = 0;
            for (int i = 0; i < frames.Length; i++)
            {
                bool isStrike = turns[turnIndex] == "X";
                
                // score this frame:
                frames[i] = pins[turnIndex] + pins[turnIndex+1];
                // bonus for a spare/strike:
                if (frames[i] == 10 || isStrike)
                    frames[i] += pins[turnIndex+2];
                
                // only move on one turn if it is a stike:
                turnIndex+= isStrike ? 1 : 2;
            }

            return frames.Sum();
        }
    }
}
