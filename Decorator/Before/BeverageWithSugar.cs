using System;

namespace Decorator.Before
{
    internal class BeverageWithSugar : IBeverage
    {
         IBeverage iBeverage;

         public BeverageWithSugar(IBeverage iBeverage)
        {
            this.iBeverage = iBeverage;
        }
        public override void Prepare()
        {
            iBeverage.Prepare();
            Console.WriteLine(" + sugar");
        }
    }
}