using System;

namespace Practise
{
    public class TruncatablePrimes
    {
        double sum = 0;

        public void demo()
        {
            for (int i = 11; i < 1000000; i++)
            {
                
                if (left(i.ToString()))
                {
                    if (Right(i.ToString()))
                    {
                        sum += i;
                        Console.WriteLine(i);
                    }
                }
            }

            Console.WriteLine("sum: "+sum + "");
        }

        bool isPrime(int number)
        {

            if (number == 1) return false;
            if (number == 2) return true;

            for (int i = 2; i <= Math.Ceiling(Math.Sqrt(number)); ++i)
            {
                if (number % i == 0) return false;
            }

            return true;

        }

        public bool left(string orig)
        {
            if (isPrime(int.Parse(orig.ToString())))
            {



                while (orig.Length != 0)
                {
                    if (orig.Length != 1)
                    {
                        char[] temp = orig.ToCharArray();
                        temp[0] = ' ';

                        string news = new string(temp);
                        news = news.Trim();

                        if (isPrime(int.Parse(news)))
                            orig = news;
                        else
                        {
                            orig = string.Empty;
                            return false;
                        }
                    }
                    else
                    {
                        if (!isPrime(int.Parse(orig)))
                            return false;
                        else return true;
                    }


                }
            }
            else
            {
                return false;
            }
            return true;

        }

        public bool Right(string orig)
        {
            if (isPrime(int.Parse(orig.ToString())))
            {
                while (orig.Length != 0)
                {
                    if (orig.Length != 1)
                    {
                        char[] temp = orig.ToCharArray();
                        temp[orig.Length - 1] = ' ';

                        string news = new string(temp);
                        news = news.Trim();

                        if (isPrime(int.Parse(news)))
                            orig = news;
                        else
                        {
                            orig = string.Empty;
                            return false;
                        }
                    }
                    else
                    {
                        if (!isPrime(int.Parse(orig)))
                            return false;
                        else return true;
                    }
                }
            }
            else
            {
                return false;
            }
            return true;
        }
    }
}