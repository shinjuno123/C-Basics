namespace StrnigEqual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "Hello";
            string compare = "Hello";


            if (message.Equals(compare)) {
                Console.WriteLine("Same");
            } else
            {
                Console.WriteLine("Diff");
            }

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            // == : Compare the reference in the memory
            //if (name != "")
            if (!name.Equals(""))
            {
                Console.WriteLine($"Your name is {name}");
            } else
            {
                Console.WriteLine("Invalid name input");
            }

            char[] chars = new char[] { 'H', 'e', 'l', 'l', 'o' };
            object newCompare = new string(chars);


            // It is comparing literal value
            // if (message.Equals(newCompare))
            // This compares the reference of the memory 
            // It comapares the Memory address location, value
            if (message == newCompare){
                Console.WriteLine("Same");
            } else
            {
                Console.WriteLine("Different");
            }

            Console.ReadLine();
        }
    }
}
