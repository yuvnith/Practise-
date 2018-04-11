﻿namespace Practise
{
    public class KnapsackLight
    {
        public int knapsackLight(int value1, int weight1, int value2, int weight2, int maxW)
        {
            if (weight1 + weight2 <= maxW)
                return value1 + value2;

             if (weight1 <= maxW)
            {
                if (value1 > value2 || weight2 >maxW)
                    return value1;
            }

             if (weight2 <= maxW)
            {
                
                if (value1 < value2 || weight1 > maxW)
                    return value2;
            }

            return 0;
        }
    }
}