using System;

namespace EjercicioHerencia
{
    public class CalculosGeometricos : Operaciones
    {
        public void Imprimir(double radio, double lado)
        {

            double areaCirculo = CalculaAreaCirculo(radio);
            double volumenCubo = CalculaVolumenCubo(lado);
            double longitudCircunferencia = CalculaLongitudCircunferencia(radio);

            Console.WriteLine($"Area del Circulo: {areaCirculo}");
            Console.WriteLine($"Volumen del Cubo: {volumenCubo}");
            Console.WriteLine($"Longitud del Circunferencia: {longitudCircunferencia}");
        }
    }
}

