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
            double priceWhitTax;
            switch (stateCode)
            {
                case "NV":
                    Console.WriteLine("Nevada the tax is 8%");
                    priceWhitTax= totalPrice+totalPrice*0.08;
                    Console.WriteLine("price whit tax" +priceWhitTax);
                    return;

            }

        }
        

    }
}
