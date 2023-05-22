namespace _04._Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            

            int sum = 0;
            for (int i = 0; i < numberOfLines; i++)
            {
                char letters = char.Parse(Console.ReadLine());
                sum += letters;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}