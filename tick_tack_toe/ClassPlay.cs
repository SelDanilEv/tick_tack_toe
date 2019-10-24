using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tick_tack_toe
{
    static class ClassPlay
    {
        public static int[] startValue = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public static int[] startScore = new int[] { 0, 0 };

        public static int[] currentValue = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public static int[] currentScore = new int[] { 0, 0 };

        public static int n;
        public static bool game = true;
        public static int toGame = 0;
        public static bool restartRights = false;
    }
}
