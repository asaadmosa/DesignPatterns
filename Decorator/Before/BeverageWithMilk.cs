using System;

namespace Decorator.Before
{
    internal class BeverageWithMilk : IBeverage
    {
        IBeverage iBeverage;

        public BeverageWithMilk(IBeverage iBeverage)
        {
            this.iBeverage = iBeverage;
        }

        public void Prepare()
        {
            iBeverage.Prepare();
            Console.Write(" + milk");
        }
    }
}