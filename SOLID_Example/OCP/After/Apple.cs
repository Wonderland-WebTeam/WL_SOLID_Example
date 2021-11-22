namespace SOLID_Example.OCP.After
{
    public class Apple : Fruit
    {
        public override string Name => "Apple";
        public override decimal Price => 10;

        public override decimal GetSpecialPrice()
        {
            return Price * 0.9M;
        }
    }
}