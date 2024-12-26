namespace VerbatismStringLiteral
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string speech = "He said \"something\"";
            string path = "C:\\Users\\Junho Shin\\Desktop\\job management\nNew Line Test";
            Console.WriteLine(path);
            Console.WriteLine(speech);
            // $ + 
            // $"Your name is {name}"
            // "Your name is " + name

            path = @"C:\Users\Junho Shin\Desktop\job management" + "\nNew Line Test";
            Console.WriteLine(path);
            
            string name = @"Hello ""someone""";
            Console.WriteLine(name);

            name = @"Hello 'someone'";
            Console.WriteLine(name);

            Console.ReadLine();

        }
    }
}
