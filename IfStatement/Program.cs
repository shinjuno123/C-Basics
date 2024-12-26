namespace IfStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("Enter your name: ");

            string name = Console.ReadLine();
            //Console.WriteLine(name);

            Console.Write("Enter your age: ");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);
            // Console.WriteLine(age);

            Console.WriteLine();
            Console.WriteLine("Your name is " + name + " and your age is " + age);

            if (age < 0 || age > 150)
            {
                Console.WriteLine("Invalid age!");
            }
            else
            {
                if (18 <= age && age < 25)
                {
                    Console.WriteLine("You are between 18 and 25");
                }
                else if (age >= 25)
                {
                    Console.WriteLine("You are 25 or older");
                }
            }*/

            Console.Write("Enter the first number: ");
            int numberA  = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int numberB = Convert.ToInt32(Console.ReadLine());

            int answer = numberA * numberB;

            Console.Write("Value of " + numberA + " x " + numberB + ": ");
            int actualAnswer = Convert.ToInt32(Console.ReadLine());

            if (answer == actualAnswer)
            {
                Console.WriteLine("Well done!");
            } else if (answer != actualAnswer)
            {
                Console.WriteLine("Close but it was wrong!");
            }

            Console.ReadLine();
        }
    }
}
