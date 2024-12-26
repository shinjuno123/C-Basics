namespace For
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("How many times do you want to say hi?: ");
            int loopCounter = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < loopCounter; i++) {
                Console.WriteLine("Hi");
            }

            //for (int i=0; i<=10; i +=2)
            //{
            //    Console.WriteLine(i);
            //}

            Console.ReadLine();
        }
    }
}
