
internal class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string biggestKegModel = "";
        double biggestKegVolume = 0;
        for (int i = 0; i < n; i++)
        {
            string kegModel = Console.ReadLine();
            double kegRadius = double.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            double kegVolume = Math.PI * kegRadius * kegRadius * height;
            if (kegVolume > biggestKegVolume)
            {
                biggestKegVolume = kegVolume;
                biggestKegModel = kegModel;
            }
        }
        Console.WriteLine($"{biggestKegModel}");
    }
}
