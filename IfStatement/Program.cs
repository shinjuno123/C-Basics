namespace IfStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");

            string name = Console.ReadLine();
            //Console.WriteLine(name);

            Console.Write("Enter your age: ");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);
            // Console.WriteLine(age);

            Console.WriteLine();
            Console.WriteLine("Your name is " + name + " and your age is " + age);

            //if (18 <= age && age < 25)
            //{
            //    Console.WriteLine("You are between 18 and 25");
            //} else if (age >= 25)
            //{
            //    Console.WriteLine("You are 25 or older");
            //}

            if (age < 0 || age > 150)
            {
                Console.WriteLine("Invalid age!");
            }
            else
            {
                Console.WriteLine("Valid age!");
            }
            
            Console.ReadLine();
        }
    }
}
