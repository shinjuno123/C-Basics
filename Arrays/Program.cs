namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 10;
            int num3 = 15;
            // angles?
            int[] numbers = new int[3];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Enter a number: ");
                numbers[i] = int.TryParse(Console.ReadLine(), out numbers[i])? numbers[i] : 0;
            }         

          
            //Console.WriteLine($"{num1} {num2} {num3}");
            //Console.WriteLine($"{numbers[0]} {numbers[1]} {numbers[2]}");


            for (int i = 0; i < numbers.Length; i++) {
                Console.Write($"{numbers[i]} ");   
            }

            Console.WriteLine();
            
            foreach (int num in numbers) {
                Console.Write($"{num} ");
            }

            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
