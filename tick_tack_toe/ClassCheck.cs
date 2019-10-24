using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tick_tack_toe
{
    class ClassCheck
    {
        public static int CheckForWon()
        {
            int won = 0;
            if (ClassPlay.currentValue[0] == ClassPlay.currentValue[3] && ClassPlay.currentValue[3] == ClassPlay.currentValue[6])
            {
                if (ClassPlay.currentValue[0] == 1) won = 1;
                if (ClassPlay.currentValue[0] == 2) won = 2;
            }
            if (ClassPlay.currentValue[1] == ClassPlay.currentValue[4] && ClassPlay.currentValue[4] == ClassPlay.currentValue[7])
            {
                if (ClassPlay.currentValue[1] == 1) won = 1;
                if (ClassPlay.currentValue[1] == 2) won = 2;
            }
            if (ClassPlay.currentValue[2] == ClassPlay.currentValue[5] && ClassPlay.currentValue[5] == ClassPlay.currentValue[8])
            {
                if (ClassPlay.currentValue[2] == 1) won = 1;
                if (ClassPlay.currentValue[2] == 2) won = 2;
            }

            if (ClassPlay.currentValue[0] == ClassPlay.currentValue[1] && ClassPlay.currentValue[1] == ClassPlay.currentValue[2])
            {
                if (ClassPlay.currentValue[0] == 1) won = 1;
                if (ClassPlay.currentValue[0] == 2) won = 2;
            }
            if (ClassPlay.currentValue[3] == ClassPlay.currentValue[4] && ClassPlay.currentValue[4] == ClassPlay.currentValue[5])
            {
                if (ClassPlay.currentValue[3] == 1) won = 1;
                if (ClassPlay.currentValue[3] == 2) won = 2;
            }
            if (ClassPlay.currentValue[6] == ClassPlay.currentValue[7] && ClassPlay.currentValue[7] == ClassPlay.currentValue[8])
            {
                if (ClassPlay.currentValue[6] == 1) won = 1;
                if (ClassPlay.currentValue[6] == 2) won = 2;
            }

            if (ClassPlay.currentValue[0] == ClassPlay.currentValue[4] && ClassPlay.currentValue[4] == ClassPlay.currentValue[8])
            {
                if (ClassPlay.currentValue[0] == 1) won = 1;
                if (ClassPlay.currentValue[0] == 2) won = 2;
            }
            if (ClassPlay.currentValue[2] == ClassPlay.currentValue[4] && ClassPlay.currentValue[4] == ClassPlay.currentValue[6])
            {
                if (ClassPlay.currentValue[2] == 1) won = 1;
                if (ClassPlay.currentValue[2] == 2) won = 2;
            }

            for (int i = 0; i < 9; i++)
            {
                if (ClassPlay.currentValue[i] != 0)
                {
                    ClassPlay.toGame++;
                    if (ClassPlay.toGame == 9) ClassPlay.game = false;
                }
            }
            ClassPlay.toGame = 0;
            if (won != 0)
            {
                ClassPlay.game = false;
                if (won == 1)
                {
                    ClassPlay.currentScore[0]++;
                }
                else
                {
                    ClassPlay.currentScore[1]++;
                }
                won = 0;
            }
            return 0;
        }
    }
}
