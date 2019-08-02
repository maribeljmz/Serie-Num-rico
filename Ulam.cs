using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Series_Numericos
{
    public class Ulam    {
        List<int> lista;
        public Ulam(List<int> lista) {
            this.lista = lista;
            lista.Add(1);
            lista.Add(2);
        }
        public Ulam()
        {
            lista = new List<int>();
            lista.Add(1);
            lista.Add(2);
        }
        public void sucesion(int limite)
        {
            for (int k=3; k <= limite;k++) {
                if (!MuyRepetido(k))
                    lista.Add(k);
            }
        }

        private bool MuyRepetido(int k)
        {
            int repeticiones = 0;
            for (int i=0; i < lista.Count; i++)
                for (int j = 0; j < lista.Count; j++)
                    if (k == (lista[i] + lista[j]) && lista[i] != lista[j]) 
                        repeticiones++;
            //System.Console.WriteLine("numero "+k+"--> "+repeticiones);
            if (repeticiones ==2 )
                return false;
                
            

            return true;
        }

        public String obtener() {
            String num = "";
            for (int i = 0; i == 3; i++) { 
             num = lista[3]+"" ;
        }
            return num;
        }

        public void guarda()
        {
            throw new NotImplementedException();
        }
    }
}
