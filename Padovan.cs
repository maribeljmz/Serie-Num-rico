using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Series_Numericos{
    class Padovan    {
        private ulong terminoAnterior;
        private ulong terminoActual;
        private ulong numeroVecesLlamado;
        private ulong terminomenos2;
        private ulong terminomenos3;

        public Padovan()         {
            this.terminoAnterior = 0;
            this.terminoActual = 0;
            this.numeroVecesLlamado = 0;
            this.terminomenos2 = 0;
            this.terminomenos3 = 0;
        }

        public ulong siguiente()        {
            this.actualizarTerminoSiguiente();
            this.numeroVecesLlamado += 1;
            return this.terminoActual;
        }
        public void actualizarTerminoSiguiente()        {
            if (this.numeroVecesLlamado >=0 && this.numeroVecesLlamado<=2){
                this.terminoActual =1;
                this.terminomenos2 = 0;
                this.terminomenos3 = 0;
                this.terminoAnterior = 0;
            }
            
            if (this.numeroVecesLlamado == 3)        {
                this.terminoActual = 2;
                this.terminomenos2  =1;
                this.terminomenos3 = 1;
                this.terminoAnterior = 1;
            }

            if (this.numeroVecesLlamado > 3) {
                this.terminomenos3 = this.terminomenos2;
                this.terminomenos2 = this.terminoAnterior;
                this.terminoAnterior = this.terminoActual;

                this.terminoActual = this.terminomenos2 + this.terminomenos3;
            }
        }

        public ulong anterior()        {
            this.actualizarTerminoAnterior();
            this.numeroVecesLlamado -= 1;
            return terminoActual;
        }
        public void actualizarTerminoAnterior()        {
            if (this.numeroVecesLlamado >=0 && this.numeroVecesLlamado<=2 ) {
                this.terminoActual = 1;
                this.terminomenos3 = 1;
                this.terminomenos2 = 1;
                this.terminoAnterior =1;
            }
            
            if (this.numeroVecesLlamado==3)            {
                this.terminoActual = 2;
                this.terminomenos3 = 1;
                this.terminomenos2 = 1;
                this.terminoAnterior = 1;
            }
            if (this.numeroVecesLlamado > 3)  {
                ulong respaldoTerminoAnterior = this.terminoAnterior;
                this.terminoActual = this.terminoAnterior;
                this.terminoAnterior = this.terminomenos2;
                this.terminomenos2 = this.terminomenos3;
                this.terminomenos3 = +respaldoTerminoAnterior - this.terminomenos3;
            }

        }
        public ulong TerminoActual()
        {
            return terminoActual;
        }

    }
}

