using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Series_Numericos
{
    class Conversor
    {
        public String convertirABinario(ulong numero)
        {
            String resultado = "";
            while (numero != 0)
            {
                resultado = (numero % 2) + "" + resultado;
                numero = numero / 2;
            }
            resultado = '0' + resultado;
            return resultado;
        }

        public String convertirAHexadecimal(ulong numero)
        {
            String respuesta = "";
            char[] residuosHexa = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            while (numero != 0)
            {
                respuesta = (residuosHexa[numero % 16]) + respuesta;
                numero = numero / 16;
            }
            respuesta = '0' + respuesta;
            return respuesta;
        }

    }
}
