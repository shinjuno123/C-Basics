namespace NumericDataTypes
{
    internal class NumericDataTypes
    {
        static void Main(string[] args)
        {
            int x = 10, y = 20, z = 14;

            // int age: declaring a value
            // age = 23: intializing a value
            int age = -23;

            Console.WriteLine(age);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            long bigNumber = -9000000000000L;

            Console.WriteLine(bigNumber);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);

            double negative = -55.2D;
            Console.WriteLine(negative);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);

            float precision = 5.00001F;
            Console.WriteLine(precision);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);

            decimal money = 14.99M;
            Console.WriteLine(money);
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);

            // Assigning a value
            age = 50;



            Console.ReadLine();
        }
    }
}
