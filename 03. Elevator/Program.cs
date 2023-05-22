namespace _03._Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pplToElevate = int.Parse(Console.ReadLine());
            int capacityOfElevetor = int.Parse(Console.ReadLine());

            int coursesNeed = (int) Math.Ceiling((double) pplToElevate / capacityOfElevetor);
            Console.WriteLine(coursesNeed);
        }
    }
}