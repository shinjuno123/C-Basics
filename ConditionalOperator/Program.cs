namespace ConditionalOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 10;

            if (age >= 0)
            {
                Console.WriteLine("Valid");
            } else
            {
                Console.WriteLine("Invalid");
            }

            string result = age >= 0? "Valid" : "Invalid";
            Console.WriteLine(result);


            Console.ReadLine();
        }
    }
}
