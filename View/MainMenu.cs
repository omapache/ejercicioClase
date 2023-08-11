using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicioClase.View
{
    public class MainMenu
    {
        public int Menu()
        {
        Console.Clear();
        Console.WriteLine("WENAS, BIENVENIDO A SUPER TIENDA ABS\n");
        Console.WriteLine("1. Registrar producto.");
        Console.WriteLine("2. Registrar categoría.");
        Console.WriteLine("3. Listar categorías.");
        Console.WriteLine("4. Listar productos.");
        Console.WriteLine("5. Costo total del inventario.");
        Console.Write("\nSeleccione una opción: ");

        return int.Parse(Console.ReadLine());
        }
    }
}