namespace Ucu.Poo.Restaurant
{

    /// <summary>
    /// Representa un platillo individual en el menú del restaurante.
    /// </summary>
    public class Dish
    {
        private string name;
        public string Name
        {
            get {return name;}
            set {name = value;}
        }

        private double price;
        public double Price
        {
            get {return price;}
            set {price = value;}
        }

        private bool vegetarian;
        public bool IsVegetarian
        {
            get {return vegetarian;}
            set {vegetarian = value;}
        }

        public Dish(string name, double price, bool vegetarian)
        {
            this.Name = name;
            this.Price = price;
            this.IsVegetarian = vegetarian;
        }
    }
}