namespace EmptyString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();


            // This gives you better readability
            if (name != String.Empty){ // ""
                Console.WriteLine($"Your name is {name}");

            } else
            {
                Console.WriteLine("Name is empty");
            }

       

            Console.ReadLine();
        }
    }
}
