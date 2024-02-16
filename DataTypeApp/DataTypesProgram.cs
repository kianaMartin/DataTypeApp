using System;
namespace DataTypeApp
{
    internal class DataTypesProgram
    {
        static void Main(string[] args)  {
            Console.Write("Enter the pieces of apple: ");
            int pieces = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter total price of " + pieces +  " apple(s): ");
            double price = Convert.ToDouble(Console.ReadLine());
          
            Console.WriteLine("The total price of "+ pieces +  " apple(s) is " + price);
            Console.WriteLine("The value of original price is " + price);
            int total = (int)price;
            Console.WriteLine("The value of converted price is " + total);
            Console.WriteLine("Press any key to exit..."    );
            Console.ReadKey();
        }
    }
}
