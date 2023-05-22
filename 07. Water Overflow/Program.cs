namespace _07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLine = int.Parse(Console.ReadLine());
            int waterTank = 0;

            for (int i = 0; i < numberOfLine; i++)
            {
                
                int quantitiesOfWater = int.Parse(Console.ReadLine());
                if (waterTank + quantitiesOfWater <= 255)
                {
                    waterTank += quantitiesOfWater;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
            }
            Console.WriteLine(waterTank);
        }
    }
}