namespace Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int numbersCount = int.Parse(Console.ReadLine());
            int nums2 = 0;
            int nums3 = 0;
            int nums5 = 0;
            for (int i = 1; i <= numbersCount; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber % 2 == 0)
                {
                    nums2++;
                }
                if (currentNumber % 3 == 0)
                {
                    nums3++;
                }
                if (currentNumber % 5 == 0)
                {
                    nums5++;
                }
            }
            Console.WriteLine($"{nums2}");
            Console.WriteLine($"{nums3}");
            Console.WriteLine($"{nums5}");
        }
    }
}