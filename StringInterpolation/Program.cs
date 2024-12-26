namespace StringInterpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Junho";
            int age = 23;

            Console.WriteLine("Your name is " + name + " your age is " + age);
            Console.WriteLine($"Your name is {name} your age is {age}");
            Console.WriteLine($"Your name is {name} your age is {age}");
            Console.ReadLine();
        }
    }
}
