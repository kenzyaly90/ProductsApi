namespace ProductsApi
{
    public class Product
    {

        public string Name { get; internal set; }
        public int Id { get; internal set; }
        public string Category { get; internal set; }
        public decimal Price { get; internal set; }
    }
}