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
        // Table contiene una Order 
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

        // Table cambia su estado a "occupied" y crea una nueva Order
        public void Occupy()
        {
            if (!occupied)
            {
              occupied = true;
              currentOrder = new Order(); 
            }
        }

        // Table se libera ("occupied" vuelve a false) y se descarta la Order actual
        public void Free()
        {
            if (occupied)
            {
                occupied = false;
                currentOrder = null;
            }
        }

        // Table NO gestiona la lista, lo hace order
        public void AddToOrder(Dish dish)
        {
            currentOrder.AddToOrder(dish);
        }

        // Builder de la mesa, asignándole un numero
        public Table (int number)
        {
            this.Number = number;
        }

        // Obtiene el calculo total de la orden, pero el calculo lo realiza Order
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