using System;
using System.Collections.Generic;
using System.Linq;

namespace Practise
{
    public class Sudoku
    {
        public bool sudoku(int[][] grid)
        {

            var myList = new List<int>();

            int sum = 0;
            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 3; j++)
                    sum += grid[i][j];

            }
            if (sum != 45)
                return false;
            sum = 0;

            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 3; j++)
                    sum += grid[i][j + 6];

            }
            if (sum != 45)
                return false;
            sum = 0;

            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 3; j++)
                    sum += grid[i][j + 6];

            }
            if (sum != 45)
                return false; sum = 0;


           // -------------------------------------------------------
            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 3; j++)
                    sum += grid[i + 3][j];

            }
            if (sum != 45)
                return false; sum = 0;
            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 3; j++)
                    sum += grid[i + 3][j + 6];

            }
            if (sum != 45)
                return false; sum = 0;

            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 3; j++)
                    sum += grid[i + 3][j + 6];

            }
            if (sum != 45)
                return false; sum = 0;
            //-------------------------------------------------------------


            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 3; j++)
                    sum += grid[i + 6][j];

            }
            if (sum != 45)
                return false; sum = 0;

            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 3; j++)
                    sum += grid[i][j + 6];

            }

            if (sum != 45)
                return false; sum = 0;

            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 3; j++)
                    sum += grid[i + 6][j + 6];

            }

            if (sum != 45)
                return false; sum = 0;

            for (int i = 0; i < 9; i++)
            {

                for (int j = 0; j < 9; j++)
                {
                    sum += grid[i][j];

                    myList.Add(grid[i][j]);
                }


                bool isUnique = myList.Distinct().Count() == myList.Count();


                if (isUnique)
                    myList.Clear();

                else
                    return false;


                if (sum != 45)
                    return false;
                sum = 0;
            }


            for (int i = 0; i < 9; i++)
            {

                for (int j = 0; j < 9; j++)
                {
                    myList.Add(grid[i][j]);
                    sum += grid[j][i];
                }


                bool isUnique = myList.Distinct().Count() == myList.Count();


                if (isUnique)
                    myList.Clear();

                else
                    return false;

                if (sum != 45)
                    return false;
                sum = 0;
            }
            

            return true;
        }

    }
}