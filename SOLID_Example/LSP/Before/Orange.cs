using SOLID_Example.OCP.After;
using System;

namespace SOLID_Example.LSP.Before
{
    public class Orange : Fruit
    {
        public override string Name => "orange";
        public override decimal Price => 10;

        public override decimal GetSpecialPrice()
        {
            throw new NotImplementedException();
        }
    }
}