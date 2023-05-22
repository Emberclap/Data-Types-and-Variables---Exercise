namespace _09._Spice_Must_Flow
{
    internal class Program
    {
        static void Main()
        {
            int yield = int.Parse(Console.ReadLine());
            int spice = 0;
            int days = 0;
            while (yield >= 100)
            {
                spice += yield;
                spice -= 26;
                days++;
                yield -= 10;
            }
            if (spice > 0 && yield < 100)
            {
                spice -= 26;
            }
            
            Console.WriteLine($"{days}");
            Console.WriteLine($"{spice}");
        }
    }
}