namespace StringIsNullOrEmpty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine($"Your name is {name}");

            //if (name != "")
            //{
            //    Console.WriteLine("0");
            //}

            //if (!name.Equals(""))
            //{
            //    Console.WriteLine("1");
            //}

            if (!string.IsNullOrEmpty(name)) 
            {
                if (name.Equals("Junho"))
                {
                    Console.WriteLine("Correct");
                }
            }

            Console.ReadLine();
        }
    }
}
