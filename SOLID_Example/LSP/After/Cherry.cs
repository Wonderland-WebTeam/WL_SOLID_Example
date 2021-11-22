namespace SOLID_Example.LSP.After
{
    public class Cherry : FruitForLsp
    {
        public override string Name => "Cherry";
        public override decimal Price => 10;

        public override decimal GetSpecialPrice()
        {
            return Price * 0.9M;
        }
    }
}