namespace SOLID_Example.LSP.After
{
    public abstract class FruitForLsp : IFruit, IPrice
    {
        public abstract string Name { get; }
        public abstract decimal Price { get; }

        public abstract decimal GetSpecialPrice();

        public override string ToString()
        {
            return $"{Name}: Price:{Price}, SpecialPrice:{GetSpecialPrice()}";
        }
    }
}