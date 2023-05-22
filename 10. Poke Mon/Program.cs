using System.Reflection.Metadata.Ecma335;

namespace _10._Poke_Mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int pokeTargets = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            double percent = pokePower * 0.50;
            int targetPoked = 0;
            while (pokePower >= pokeTargets)
            {
                targetPoked++;
                pokePower -= pokeTargets;
               
                if (percent == pokePower && exhaustionFactor!=0) 
                {
                    pokePower /= exhaustionFactor;

                }
            }
            
            
            Console.WriteLine($"{pokePower}");
            Console.WriteLine($"{targetPoked}");
        }
    }
}