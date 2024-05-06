using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public struct Coche
{
    public string Modelo;
    public int AñodeFabricacion;
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese la cantidad de coches:");
        int cantidadCoches = int.Parse(Console.ReadLine());

        Coche[] coches = new Coche[cantidadCoches];


        for (int i = 0; i < cantidadCoches; i++)
        {
            Console.WriteLine($"Coche {i + 1}:");
            Console.Write("Modelo: ");
            string modelo = Console.ReadLine();
            Console.Write("Año de Fabricación: ");
            int anyoFabricacion = int.Parse(Console.ReadLine());

            coches[i] = new Coche { Modelo = modelo, AñodeFabricacion = anyoFabricacion };
        }


        Array.Sort(coches, (x, y) => x.AñodeFabricacion.CompareTo(y.AñodeFabricacion));


        Console.WriteLine("\nCoches ordenados por año de fabricación:");
        foreach (Coche coche in coches)
        {
            Console.WriteLine($"Modelo: {coche.Modelo}, Año de Fabricación: {coche.AñodeFabricacion}");
        }
    }
}
