namespace ConsoleInputOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");

            string name = Console.ReadLine();
            //Console.WriteLine(name);

            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine(age);

            Console.WriteLine();
            Console.WriteLine("Your name is " + name + " and your age is " + age);

            Console.ReadLine();
        }
    }
}
