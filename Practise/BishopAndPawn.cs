using System;

namespace Practise
{
    public class BishopAndPawn
    {
        public bool bishopAndPawn(String bishop, String pawn)
        {
            char[] b = bishop.ToCharArray();
            char[] p = pawn.ToCharArray();
            int bpos = (int)b[0];
            int ppos = (int)p[0];
            int temp = Math.Abs(bpos - ppos);

            if (p[1] == b[1] + temp)
                return true;
            else if (p[1] == Math.Abs(b[1] - temp))
                return true;
            else
                return false;

        }

    }
}