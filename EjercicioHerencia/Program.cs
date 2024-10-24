using System;

namespace EjercicioHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
           
            CalculosGeometricos calculos = new CalculosGeometricos();

            double radio = 10.0;
            double lado = 4.0;

            calculos.Imprimir(radio, lado);
            Console.ReadLine();
        }
    }
}
