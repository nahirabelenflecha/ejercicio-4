using System;
using System.Collections.Generic;
using Ruleta;
public class Ganador : Poq
{
   public Ganador()
    {

    }
    public static int CantGanadores;
    public static int Perdedores;
    public static Random random = new Random();
    public static int ran = random.Next(0,37);
    public int ganador(List<int> lista)
    
        {
            foreach (var li in lista)
            {
                if(li == ran)
                    {
                     CantGanadores++;
                    }
            }
            return CantGanadores;
        }
    public static int calcperd(List<int> listados,int n)
        {
           int total = listados.Count;
           Perdedores = total-n;
           return Perdedores;
        }
}