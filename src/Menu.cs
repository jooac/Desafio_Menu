using System;
using System.Collections.Generic;

namespace Ucu.Poo.Restaurant
{
    /// <summary>
    /// Representa el conjunto de platillos <see cref="Dish"/> disponibles en el
    /// restaurante.
    /// </summary>
    public class Menu
    {
        // Menu gestiona la colección de platillos
        private List<Dish> dishes = new List<Dish>();

        // Agrega platos a la lista "dishes" (menu)
        public void AddDish(Dish dish)
        {
            dishes.Add(dish);
        }

        // Elimina platillos del menú
        public void RemoveDish(Dish dish)
        {
            dishes.Remove(dish);
        }

        // Busca platos por nombre
        public Dish GetDishByName(string name)
        {
            foreach(Dish dish in dishes)
            {
                if (dish.Name == name)
                {
                    return dish;
                }
            }
            return null;
        }
    }
}