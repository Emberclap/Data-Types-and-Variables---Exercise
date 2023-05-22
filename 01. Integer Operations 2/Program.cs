namespace _01._Integer_Operations_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourthNumber = int.Parse(Console.ReadLine());

            int sum = firstNumber + secondNumber;
            sum /= thirdNumber;
            sum *= fourthNumber;
            Console.WriteLine(sum);
        }
    }
}