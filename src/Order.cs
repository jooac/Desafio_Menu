using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    public class Order
    {
        // Order gestiona los pedidos (lista de Dish)
        private List<Dish> order = new List<Dish>();

        // Calcula el precio total del pedido
        public double GetTotal()
        {
            double result = 0;
            foreach(Dish dish in this.order)
            {
                result += dish.Price;
            }
            return result;
        }

        // Agrega platos a su propia lista
        public void AddToOrder(Dish dish)
        {
            order.Add(dish);
        }

        // Permite saber si Order tiene pedidos
        public bool HasOrders()
        {
            return this.order.Count > 0;
        }
    }
}