using System.Security.Cryptography.X509Certificates;

namespace EspacioCalculadora
{
    public class Calculadora
    {
        private double dato;

        public void Sumar(double termino)
        {
            dato += termino;
        }
        public double getResultado()
        {
            return dato;
        }
        public void Restar(double termino)
        {
            dato -= termino;
        }

        public void Multiplicar(double termino)
        {
            dato *= termino;
        }
        public void Dividir(double termino)
        {
            if (termino != 0)
            {
                dato /= termino;
            }
            else
            {
                Console.WriteLine("NOSE PUEDE DIVIDIR EN 0 .");
            }
        }
        public void Limpiar()
        {
            dato = 0;
        }

        public double Resultado
        {
            get { return dato; }
        }

        
    }
}