using System.Collections.Generic;

namespace Factory.Before
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var server = new Server(Currency.Dollars);

            server.PrintDetailedInvoice(new List<LineItem>
            {
                new LineItem {Product = "Peas", Price = 10},
                new LineItem {Product = "Rice", Price = 5},
            });

            server.PrintInvoiceTotal(new List<LineItem>
            {
                new LineItem {Product = "Beans", Price = 10},
                new LineItem {Product = "Tomatoes", Price = 5},
            });
        }
    }
}