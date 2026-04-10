namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa un platillo individual en el menú del restaurante.
    /// </summary>
    public class Dish
    {
        // Solo contiene datos del plato

        private string name;
        public string Name
        {
            get {return name;}
            set {name = value;}
        }

        // Solo dish conoce su precio pero lo hace accesible a modificar
        private double price;
        public double Price
        {
            get {return price;}
            set {price = value;}
        }

        // Propiedad booleana para saber si el plato es vegetariano o no, respetando encapsulación
        private bool vegetarian;
        public bool IsVegetarian
        {
            get {return vegetarian;}
            set {vegetarian = value;}
        }

        // Permite inicializar todo en una sola operación
        public Dish(string name, double price, bool vegetarian)
        {
            this.Name = name;
            this.Price = price;
            this.IsVegetarian = vegetarian;
        }
    }
}