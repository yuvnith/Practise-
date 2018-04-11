namespace Practise
{
    public class GrowingPlant
    {
        public int growingPlant(int upSpeed, int downSpeed, int desiredHeight)
        {

            int day = 0;
            int height = 0;

            while (height <= desiredHeight)
            {
                day++;
                height += upSpeed;
                if (height >= desiredHeight)
                    return day;
                height -= downSpeed;
            }
            return day;
        }

    }
}