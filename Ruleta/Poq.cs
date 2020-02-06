using System;
using System.Collections.Generic;
using Ruleta;

public class Poq : Program
{
    public Poq()
    {
    }
    public List<int> apuestas = new List<int>();
    public List<int> aos(int numero)
        {
            
              while(numero<37 & numero >=0) 
                        {
                        apuestas.Add(numero);
                        numero = Convert.ToInt16(Console.ReadLine());
                        }

             return apuestas;

        }
    
}