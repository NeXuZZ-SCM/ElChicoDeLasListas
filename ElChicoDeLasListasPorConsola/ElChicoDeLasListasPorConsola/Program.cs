using System;
using System.Collections.Generic;

namespace ElChicoDeLasListasPorConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Productos> listado = new List<Productos>();
            int opcion = 1;
            while (opcion == 1)
            {
                Console.WriteLine("Ingrese:\n(1)nombre\n(2)precio\n(3)cantidad\nde producto comprado en ese orden, al finalizar cada uno, presione enter.\n");
                listado.Add(new Productos()
                {
                    _Nombre = Console.ReadLine(),
                    _Precio = Convert.ToDecimal(Console.ReadLine()),
                    _Cantidad = Convert.ToDecimal(Console.ReadLine()),

                });
                Console.WriteLine("Salir = 0 , Seguir agregando productos = 1");
                opcion = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("============================\n============================");
            foreach (var producto in listado)
            {
                Console.Write("Nombre: [" + producto._Nombre + "] ");
                Console.Write("Precio: [" + producto._Precio + "] ");
                Console.Write("Cantidad: [" + producto._Cantidad + "] \n");
                Console.WriteLine("Precio total por cantidad consumida: [" + producto._Precio * producto._Cantidad + "]");
            }
            Console.ReadKey();

        }
    }
    
    class Productos
    {
        public string _Nombre { get; set; }
        public decimal _Cantidad { get; set; }
        public decimal _Precio { get; set; }
    }
}
