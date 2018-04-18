namespace Practise
{
    public class ChessKnight
    {
        public int chessKnight(string cell)
        {
            int x  = (int)cell[0];
            int y = int.Parse(cell[1].ToString());
            int count = 0;

            //1
            if ((int) x - 2 >= 65 && (int) x - 2 <= 72)
            {
                if (y + 1 >= 1 && y + 1 <= 8)
                    count++;
            }
            //2
            if ((int)x - 1 >= 65 && (int)x - 1 <= 72)
            {
                if (y + 2 >= 1 && y + 2 <= 8)
                    count++;
            }
            //3
            if ((int)x + 1 >= 65 && (int)x + 1 <= 72)
            {
                if (y + 2 >= 1 && y + 2 <= 8)
                    count++;
            }



            //4
            if ((int)x + 2 >= 65 && (int)x + 2 <= 72)
            {
                if (y + 1 >= 1 && y + 1 <= 8)
                    count++;
            }

            //5
            if ((int)x -2 >= 65 && (int)x -2 <= 72)
            {
                if (y - 1 >= 1 && y - 1 <= 8)
                    count++;
            }
            //6
            if ((int)x - 1 >= 65 && (int)x - 1 <= 72)
            {
                if (y - 2 >= 1 && y - 2 <= 8)
                    count++;
            }
            //7
            if ((int)x + 1 >= 65 && (int)x + 1 <= 72)
            {
                if (y - 2 >= 1 && y - 2 <= 8)
                    count++;
            }
            //8
            if ((int)x + 2 >= 65 && (int)x + 2 <= 72)
            {
                if (y - 1 >= 1 && y - 1 <= 8)
                    count++;
            }

            return count;
        }

    }
}