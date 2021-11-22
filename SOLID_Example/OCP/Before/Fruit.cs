namespace SOLID_Example.OCP.Before
{
    public class Fruit
    {
        private readonly string _name;
        private readonly decimal _price;
        private readonly ProductCategory _productCategory;

        public Fruit(string name, decimal price, ProductCategory productCategory)
        {
            _name = name;
            _price = price;
            _productCategory = productCategory;
        }

        public decimal GetPrice()
        {
            return _price * 0.9M;

            //if (_productCategory == ProductCategory.OnSale)
            //{
            //    return _price * 0.8M;
            //}

            //return _price * 0.9M;
        }
    }

    public enum ProductCategory
    {
        General,
        OnSale
    }
}