namespace Practise
{
    public class RoadRegister
    {
        public bool newRoadSystem(bool[][] roadRegister)
        {
            int len = roadRegister.Length;
            int[] incoming = new int[len];
            int[] outgoing = new int[len];

            


            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    if (roadRegister[i][j] == true)
                    {
                        incoming[j] += 1;
                        outgoing[i] += 1;
                    }
                        
                }
            }

            for (int i = 0; i < len; i++)
            {
                if (incoming[i] != outgoing[i])
                    return false;
            }



            return true;
        }
    }
}