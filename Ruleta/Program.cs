using System;
using System.Collections.Generic;

namespace Ruleta
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su apuesta de 0 a 36");
            Poq var1 = new Poq();
            Ganador var2 = new Ganador();
            var1.aos(Convert.ToInt16(Console.ReadLine()));
            List<int> listapuestas = var1.apuestas;
            int ganad = var2.ganador(listapuestas);

            Console.WriteLine("Cantidad de ganadores: {0}",ganad);
            Console.WriteLine("Cantidad de perdedores: {0}", Ganador.calcperd(listapuestas,ganad));
            Console.WriteLine("El numero ganador es: {0}", Ganador.ran);
        }
    }
}
