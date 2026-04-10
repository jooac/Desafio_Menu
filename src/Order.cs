using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    public class Order
    {
        private List<Dish> order = new List<Dish>();
        public double GetTotal()
        {
            double result = 0;
            foreach(Dish dish in this.order)
            {
                result += dish.Price;
            }
            return result;
        }
        public void AddToOrder(Dish dish)
        {
            order.Add(dish);
        }
        public bool HasOrders()
        {
            return this.order.Count > 0;
        }

    }
}