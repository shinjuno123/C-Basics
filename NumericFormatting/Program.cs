using System.Globalization;

namespace NumericFormatting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double value = 1000D / 12.34D;

            Console.WriteLine(value);
            Console.WriteLine(string.Format("{0:0}", value, 1000));
            Console.WriteLine(string.Format("{0:0.#}", value, 1000));
            Console.WriteLine(string.Format("{0:0.00}", value, 1000));

            double money = -10D / 3D; // 3.333333;

            Console.WriteLine(money);
            Console.WriteLine(string.Format("-$10 / $3 = {0:0.00}", money.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))));
            Console.WriteLine(money.ToString("C2", CultureInfo.CreateSpecificCulture("en-US")));
            Console.WriteLine(money.ToString("C1", CultureInfo.CreateSpecificCulture("en-US")));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));


            Console.ReadLine();
        }
    }
}
