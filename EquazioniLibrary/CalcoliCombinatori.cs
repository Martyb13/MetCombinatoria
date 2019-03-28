using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquazioniLibrary
{
    public class CalcoliCombinatori
    {
     public static long Fattoriale(long numero)
        {
            long risultato = 1;

            if(numero<20)
            {
                for (int i = 1; i <= numero; i++)
                {
                    risultato = risultato * i;
                }
            }
            else
            {
                risultato = 0;
            }
            return risultato;

        }
    }
}

