using System;
using System.Collections.Generic;

namespace insulter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] insults = {
                "You look like what morning breath smells like.",
                "If you tried to give me cpr I would probably throw myself back under water",
                "I am not a fan of you",
                "You think you're so special...and you are. The fact of your existence is nearly impossible to believe",
                "I'd rather walk than be on the same plane as you",
                "If I were given a million dollars to hang out with you...I would, but then I'd have to spend half of it on therapy",
                "Do you have to be so...like that?"
            };

            int[] indexes = {};
            while(indexes.Length < 3){
                int candidate = GetRandomInt(0, insults.Length - 1);
                if (!Array.Exists(indexes, element => element == candidate)) {
                    
                }
            }

        }
        static int GetRandomInt(int min, int max)
        {
            int dieValue = new Random().Next(min, max);
            return dieValue;
        }
    }
}
