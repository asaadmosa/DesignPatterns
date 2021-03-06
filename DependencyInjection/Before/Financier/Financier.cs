using System;

namespace DI.Before
{
    public class Financier : IFinancier
    {
        private readonly Secretary _secretary;

        public Financier()
        {
            _secretary = new Secretary();
        }
        
        public void CollectTaxes()
        {
            Console.WriteLine("Collecting Taxes");
            _secretary.WriteEveryThingDown();
        }
    }
}