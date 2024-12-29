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

            // String concatenation
            string test = string.Concat("Your name is ", name, " and your age is ", age);
            Console.WriteLine(test);

            string[] names = new string[] { "Junho", " Mackie", " Hay" };
            Console.WriteLine(string.Concat(names));

            Console.ReadLine();
        }
    }
}
