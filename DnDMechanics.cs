using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CONSOLE_The_Game
{
    class DnDMechanics
    {
        public int d4()
        {
            int dice;
            Random rand = new Random();
            dice = rand.Next(1, 5);
            return dice;
        }
        public int d4(int diceCount)
        {
            int dice=0;
            Random rand = new Random();
            for (int i = 0; i < diceCount; i++)
            {
                dice += rand.Next(1, 5);
            }
            return dice;
        }
        public int d6()
        {
            int dice;
            Random rand = new Random();
            dice = rand.Next(1, 7);
            return dice;
        }
        public int d6(int diceCount)
        {
            int dice = 0;
            Random rand = new Random();
            for (int i = 0; i < diceCount; i++)
            {
                dice += rand.Next(1, 7);
            }
            return dice;
        }
        public int d8()
        {
            int dice;
            Random rand = new Random();
            dice = rand.Next(1, 9);
            return dice;
        }
        public int d8(int diceCount)
        {
            int dice = 0;
            Random rand = new Random();
            for (int i = 0; i < diceCount; i++)
            {
                dice += rand.Next(1, 9);
            }
            return dice;
        }
        public int d10()
        {
            int dice;
            Random rand = new Random();
            dice = rand.Next(1, 11);
            return dice;
        }
        public int d10(int diceCount)
        {
            int dice = 0;
            Random rand = new Random();
            for (int i = 0; i < diceCount; i++)
            {
                dice += rand.Next(1, 11);
            }
            return dice;
        }
        public int d12()
        {
            int dice;
            Random rand = new Random();
            dice = rand.Next(1, 13);
            return dice;
        }
        public int d12(int diceCount)
        {
            int dice = 0;
            Random rand = new Random();
            for (int i = 0; i < diceCount; i++)
            {
                dice += rand.Next(1, 13);
            }
            return dice;
        }
        public int d20()
        {
            int dice;
            Random rand = new Random();
            dice = rand.Next(1, 21);
            return dice;
        }
        public int d20(int diceCount)
        {
            int dice = 0;
            Random rand = new Random();
            for (int i = 0; i < diceCount; i++)
            {
                dice += rand.Next(1, 21);
            }
            return dice;
        }



    }
}
