using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa una mesa en el restaurante.
    /// </summary>
    public class Table
    {
        public Order currentOrder
        {
            get; set;
        }
        private int number;
        public int Number
        {
            get {return number;}
            set {number = value;}
        }
        private bool occupied;
        public bool IsOccupied
        {
            get {return occupied;}
            set {occupied = value;}
        }
        public void Occupy()
        {
            if (!occupied)
            {
              occupied = true;
              currentOrder = new Order(); 
            }
        }
        public void Free()
        {
            if (occupied)
            {
                occupied = false;
                currentOrder = null;
            }
        }
        public void AddToOrder(Dish dish)
        {
            currentOrder.AddToOrder(dish);
        }
        public Table (int number)
        {
            this.Number = number;
        }

        public double GetTotal()
        {
            if (currentOrder != null)
            {
                return currentOrder.GetTotal();
            }
            return 0;
        }
    }
}