namespace Remainder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = 13;
            int secondNum = 2;

            // 3 x 3 = 9, 1 left over to get to 10
            // 10 % 2 = 0
            // 11 % 2 = 1
            // 12 % 2 = 0
            // 13 % 2 = 1

            Console.WriteLine(firstNum % secondNum);


            Console.ReadLine();
        }
    }
}
