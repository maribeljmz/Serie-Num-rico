using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Series_Numericos
{
    public class NumeroCapicua    {
         String capicua = "";
       
        public  String esCapicua(ulong numero)    {
            ulong respaldonumero = numero;
            ulong cifra = 0, inverso = 0;

            while (numero != 0)   {
                cifra = numero % 10;
                inverso = (inverso * 10) + cifra;
                numero /= 10;
            }

            if (inverso==respaldonumero) {
                capicua = "Si";
            } else    {
                capicua = "No";
            }

            return capicua;
        }
              

    }
}
