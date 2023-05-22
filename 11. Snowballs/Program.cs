using System.Numerics;

namespace _11._Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfSnowballs = int.Parse(Console.ReadLine());

            BigInteger  bestSnowballValue = 0;
            int snowballSnow = 0;
            int snowballTime = 0;
            int snowballQuality = 0;
           
            for (int i = 0; i < numberOfSnowballs; i++)
            {
                int snow = int.Parse(Console.ReadLine());
                int time= int.Parse(Console.ReadLine());
                int quality = int.Parse(Console.ReadLine());


                BigInteger value = BigInteger.Pow((snow / time), quality);
                if (bestSnowballValue < value)
                {
                    bestSnowballValue = value;
                    snowballSnow = snow;
                    snowballTime = time;
                    snowballQuality = quality;
                }
            }
            Console.WriteLine($"{snowballSnow} : {snowballTime} = {bestSnowballValue} ({snowballQuality})");

        }
    }
}