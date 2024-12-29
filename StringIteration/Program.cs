namespace StringIteration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "C# is awesome";
            // char[]
            /* Console.WriteLine(message[0]);
            Console.WriteLine(message[1]); 
            Console.WriteLine(message[2]);
            Console.WriteLine(message[3]); */

            for (int i=0; i< message.Length; i++)
            {
                Console.Write(message[i]);
                Task.Delay(140).Wait();
            }

            Console.WriteLine();
            Console.WriteLine(message.Contains("C")); // True

            bool contains = false;

            for (int i = 0; i < message.Length; i++)
            {
                if (message[i].Equals('a'))
                {
                    contains = true; break;
                }
            }

            Console.WriteLine(contains);

            Console.ReadLine();
        }
    }
}
