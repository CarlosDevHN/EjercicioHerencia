using System;

namespace EjercicioHerencia
{
	public class Operaciones
    {
       
        public double CalculaAreaCirculo(double radio)
        {
            return Math.PI * Math.Pow(radio, 2);
        }

        public double CalculaVolumenCubo(double lado)
        {
            return Math.Pow(lado, 3);
        }

        public double CalculaLongitudCircunferencia(double radio)
        {
            return 2 * Math.PI * radio;
        }
    }
}

