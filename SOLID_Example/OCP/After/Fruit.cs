namespace SOLID_Example.OCP.After
{
    public abstract class Fruit
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