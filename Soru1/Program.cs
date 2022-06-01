using System;

namespace Soru1
{
    class Program
    {
        public static void BirthdayCakeCandles(int n)
        {
             int[] candles = new int[n];
            

            Random rnd = new Random();            
            for (int i = 0; i < candles.Length; i++)
            {
                candles[i] = rnd.Next(1, n);
            }

            for (int i = 0; i < candles.Length; i++)
            {
                Console.Write(candles[i] + " ");
            }

            int max = candles[0];
            int tallesCandle = 1;
            for (int i = 1; i < candles.Length; i++) // 8 6 1 0 7
            {
                if (max < candles[i])
                {
                    max = candles[i];
                    tallesCandle = 1;
                }

                else if (max == candles[i])
                    tallesCandle += 1;

            }
            Console.WriteLine("\n" + "Yanacak mum sayısı: " + tallesCandle);
        }

        static void Main(string[] args)
        {
            BirthdayCakeCandles(7);
        }
    }
}
