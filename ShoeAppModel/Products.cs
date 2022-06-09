namespace ShoeAppModel
{
    public class Product
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public int Quantity { get; set; }

        public Product()
        {
            Id = 0;
            Brand = "Yeezy";
            Name = "Boost 350";
            Size = "12";
            Quantity = 0;
        }
    }
}