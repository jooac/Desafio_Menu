using System;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Programa principal.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto del entrada al programa.
        /// </summary>
        public static void Main()
        {
            // Se crean instancias de Dish con sus respectivos datos
            Dish burger = new Dish("Burger", 5.99, false);
            Dish salad = new Dish("Salad", 4.99, true);

            // Se crea un menu y se agregan al mismo los platos previamente creados
            Menu menu = new Menu();
            menu.AddDish(burger);
            menu.AddDish(salad);

            // Se crea una mesa (oneTable) con numero "1" y un mozo (John)
            Table oneTable = new Table(1);
            Waiter waiter = new Waiter("John");

            // Se le asigna la mesa al mozo y la misma se establece ocupada
            waiter.AssignTable(oneTable);
            oneTable.Occupy();

            // El mozo toma el pedido "burger" haciendo referencia al platillo perteneciente al menu
            waiter.TakeOrder(oneTable, burger);

            // Mensajes para corroborar que todo funciona correctamente
            Console.WriteLine(
                $"La mesa {oneTable.Number} está ocupada: {oneTable.IsOccupied} " +
                $"y la atiende: {waiter.Name}");
            Console.WriteLine(
                $"La mesa {oneTable.Number} está ocupada: {oneTable.IsOccupied}");
            Console.WriteLine($"Comida: {burger.Name}, Precio: {burger.Price}, Es vegetariana?: {burger.IsVegetarian}");

            // Se obtiene el total del pedido y se libera la mesa
            Console.WriteLine(oneTable.GetTotal());
            oneTable.Free();
        }
    }
}