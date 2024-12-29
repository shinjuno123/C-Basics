namespace Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[]
            {
                1, 100, 20, 40, 50,10, 20, 30
            };


            Array.Sort(numbers);
            Array.Reverse(numbers);

            foreach (int number in numbers) {
                Console.Write($"{number} ");
            }
    
            Console.ReadLine();
        }
    }
}
