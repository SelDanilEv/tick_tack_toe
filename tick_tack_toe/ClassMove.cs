using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tick_tack_toe
{
    static class ClassMove
    {
        public static bool move = false;
        public static bool numOfGame = false;
        public static void Invertmove()
        {
            move = !move;
        }
    }
}
