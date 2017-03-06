// GetData() method accepts order number and quantity
// that are used in the Main() method
// Price is $3.99 each
using System;
using System.Security.Cryptography;
using static System.Console;
class DebugEight1
{
    static void Main()
    {
        int orderNum, quantity;
        const double PRICE_EACH = 3.99;
        GetData(out orderNum, out quantity);
        double total = quantity * PRICE_EACH;
        WriteLine("Order #{0}. Quantity ordered = {1}",
            orderNum, quantity);
        WriteLine("Total is {0}", total.ToString("C"));
    }
    private static void GetData(out int order, out int amount)
    {
        try
        {
            Write("Enter order number ");
            order = Convert.ToInt32(ReadLine());
            Write("Enter quantity ");
            amount = Convert.ToInt32(ReadLine());
        }
        catch (SystemException)
        {
            order = 0;
            amount = 0;
            Console.WriteLine("Error. Invalid value. Exiting program.");
            Environment.Exit(0);
        }
       
    }
}

