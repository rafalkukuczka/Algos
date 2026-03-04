namespace MaxNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Max number iterative:");
            var max = MinMax.MinMax.MaxValueInArrayIterative();
            if (max != int.MinValue)
                Console.WriteLine($"Max number is {max}");
            else
                Console.WriteLine("No numbers found.");

            Console.WriteLine("Max number recursive:");
            max = MinMax.MinMax.MaxValueInArrayRecursive();
            if (max != int.MinValue)
                Console.WriteLine($"Max number is {max}");
            else
                Console.WriteLine("No numbers found.");
        }


    }
}
