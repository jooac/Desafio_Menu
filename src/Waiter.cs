using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa un mozo en el restaurante, encargado de atender mesas.
    /// </summary>
    public class Waiter
    {
        // Waiter gestiona las mesas que atiende
        private List<Table> assignedTables = new List<Table>();

        private string name;
        public string Name
        {
            get {return name;}
            set {name = value;}
        }

        // Waiter asigna las mesas porque él las conoce
        public void AssignTable(Table table)
        {
            assignedTables.Add(table);
        }

        // Waiter no maneja pedidos directamente, usa Table
        public void TakeOrder(Table table, Dish dish)
        {
            table.AddToOrder(dish);
        }

        public Waiter(string name)
        {
            this.Name = name;
        }
    }
}