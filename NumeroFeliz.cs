using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Series_Numericos{
    class NumeroFeliz    {

        public ulong ElevarCuadrado(ulong numero)        {
            ulong x = numero * numero;
            return x;
        }


        private ulong SumaCuadrados(ulong numero, ulong aux)        {
            String num = numero + "";
            for (int i = 0; i < num.Length; i++)
            {
                aux += ElevarCuadrado(ulong.Parse(num.Substring(i) + ""));
            }
            return aux;
        }

        public Boolean Operacion(ulong numero, ulong oportunidades)
        {

            if (numero == 1)
                return true;
            else if (oportunidades < 10)
                return Operacion(SumaCuadrados(numero, 0), ++oportunidades);
            else
                return false;
        }


        public String EsFeliz(ulong numero)
        {
            Boolean esfeliz = false;
            String mensaje = "";
            esfeliz = Operacion(numero, 1);

            if (esfeliz == true)
            {
                mensaje= "si";
            }
            else
            {
                mensaje ="no";
            }

            return mensaje;
        }
    }
}
