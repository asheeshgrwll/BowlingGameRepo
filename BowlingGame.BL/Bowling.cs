using System;
using System.Collections.Generic;
using System.Linq;

namespace BowlingGame.BL
{
    public class Bowling
    {
        private int[] rolls = new int[21];
        private int currentRoll = 0;
        public int Score 
        { 
            get
            {
                var score = 0;
                var rollIndex = 0;
                for(var frame=0;frame<10;frame++)
                {
                    //check for strike
                    if (rolls[rollIndex]==10)
                    {
                        //get strike score
                        score += rolls[rollIndex] + rolls[rollIndex + 1] + rolls[rollIndex + 2];
                        rollIndex++;
                    }
                    //check for spare
                   else if (rolls[rollIndex] + rolls[rollIndex + 1] == 10)
                    {
                        //get spare score
                        score += rolls[rollIndex] + rolls[rollIndex + 1]+ rolls[rollIndex + 2];
                        rollIndex += 2;
                    }
                    // check for non spare, non strike
                    else
                    {
                        // get non spare, non strike score
                        score += rolls[rollIndex] + rolls[rollIndex + 1];
                        rollIndex += 2;
                    }
                    
                }
                
                return score;
            }
        }
        public void Roll (int pins)
        {
            rolls[currentRoll++] = pins;
        }
    }
}
