using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Series_Numericos;

namespace Series_Numericos{
     class Fibonacci    {
        private ulong terminoAnterior;
        private ulong terminoActual;
        private ulong numeroVecesLlamado;

        public Fibonacci()  {
            this.terminoAnterior = 0;
            this.terminoActual = 0;
            this.numeroVecesLlamado = 0;
        }

        public ulong siguiente()
        {
            this.actualizarTerminoSiguiente();
            this.numeroVecesLlamado += 1;
            return this.terminoActual;
        }


        public void actualizarTerminoSiguiente()
        {
            if (this.numeroVecesLlamado == 0 || this.numeroVecesLlamado == 1)  {
                this.terminoActual = numeroVecesLlamado;
            }
            if (this.numeroVecesLlamado >= 2) {
                ulong respaldoTerminoAnterior = this.terminoAnterior;
                this.terminoAnterior = this.terminoActual;
                this.terminoActual = this.terminoAnterior + respaldoTerminoAnterior;
            }
        }


        public ulong anterior()
        {
            this.actualizarTerminoAnterior();
            this.numeroVecesLlamado -= 1;
            return terminoActual;
        }


        public void actualizarTerminoAnterior()
        {
            if (this.numeroVecesLlamado == 0 || this.numeroVecesLlamado == 1)   {
                this.terminoAnterior = 0;
            }
            if (this.numeroVecesLlamado >= 2) {
                ulong respaldoTerminoActual = this.terminoActual;
                this.terminoActual = this.terminoAnterior;
                this.terminoAnterior = +respaldoTerminoActual - this.terminoActual;
            }
        }


        public ulong TerminoActual()
        {
            return terminoActual;
        }

        public ulong TerminoAnterior()
        {
            return terminoAnterior;
        }






    }
}


