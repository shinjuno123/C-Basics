namespace ConstKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int vat = 20;
            const double percentVAT = vat / 100D;

            Console.WriteLine(vat);
            int balance = 1000;


            Console.WriteLine(balance * (vat / 100D));
            Console.WriteLine(balance * percentVAT);

            const string version = "v1.0";
            
            // vat = 10; // You can't reassign the const value

            Console.ReadLine();
        }
    }
}
