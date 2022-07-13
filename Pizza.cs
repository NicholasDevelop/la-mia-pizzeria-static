namespace la_mia_pizzeria_static
{
    public class Pizza
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }
        public double Price { get; set; }

        public Pizza(string name, string description, string img, double price)
        {
            Name = name;
            Description = description;
            Img = img;
            Price = price;
        }
    }
}
