namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 23;

            age++;
            age = age + 1;
            age += 10;
            Console.WriteLine(age);
            age--;
            age = age - 1;
            age -= 10;
            Console.WriteLine(age);


            double age1 = 23;
            age1 /= 10; // 2.3 -> 2
            Console.WriteLine(age1);

            string name = "Junho";
            name += " is Programming!";
            Console.WriteLine(name); ;

            char ch = 'a';
            ch += 'b';
            Console.WriteLine(ch);

            int i = 0;
            Console.WriteLine(i++); // return the value first and increment it next
            Console.WriteLine(i);

            int j = 0;
            Console.WriteLine(++j); // Increment first and return the value
            Console.WriteLine(j);
            Console.ReadLine();
        }
    }
}
