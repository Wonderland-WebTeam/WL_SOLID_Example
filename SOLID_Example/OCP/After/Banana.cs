namespace SOLID_Example.OCP.After
{
    public class Banana : Fruit
    {
        public override string Name => "Banana";
        public override decimal Price => 10;

        public override decimal GetSpecialPrice()
        {
            return Price * 0.8M;
        }
    }
}