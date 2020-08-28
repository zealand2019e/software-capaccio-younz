using System;

namespace betalings_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("number of items");
            int itemNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("price?");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("the number of items"+itemNumber);
            Console.WriteLine("Your price input "+price);
            double totalPrice = price*itemNumber;
            Console.WriteLine("your total price is "+totalPrice);
            Console.WriteLine("input state code");
            string stateCode = Console.ReadLine();

            switch (stateCode)
            {
                case "NV":
                    Console.WriteLine("In Nevada the tax is 8%");
                    double priceWhitTax = totalPrice + totalPrice * 0.08;
                    Console.WriteLine("price whit tax" +priceWhitTax);
                    break;
                case "TX";
                    Console.WriteLine("In Texas the tax is 6.25%");
                    double priceWhitTax = totalPrice + (totalPrice * 0.0625);
                    Console.WriteLine("your price whit tax is "+priceWhitTax);
                    break;
                case "UT":

                    default:
                    break;
            }

        }
        

    }
}
