using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Series_Numericos;

namespace Series_Numericos{
    public partial class Interfaz : Form    {
        Fibonacci fibonacci = new Fibonacci();
        Conversor conversor = new Conversor();
        Padovan padovan = new Padovan();
        Ulam ulam = new Ulam();
        NumeroCapicua numeroCapicua = new NumeroCapicua();
        NumeroFeliz numeroFeliz = new NumeroFeliz();


        public Interfaz()      {
            InitializeComponent();
        }

        private void BtnAvanzaPadovan_Click(object sender, EventArgs e)        {
            ulong numero = padovan.siguiente();
            EtiquetaDecimalPadovan.Text = "" + numero;
            EtiquetaBinarioPadovan.Text = conversor.convertirABinario(numero);
            EtiquetaHexadecimalPadovan.Text = conversor.convertirAHexadecimal(numero);
            capicuaPadovan.Text= numeroCapicua.esCapicua(numero);
            felizPadovan.Text = numeroFeliz.EsFeliz(numero);
        }

        private void BtnAvanzaFibonacci_Click(object sender, EventArgs e)        {
            ulong numero = fibonacci.siguiente();
            EtiquetaDecimalFibonacci.Text = "" + numero;
            EtiquetaBinarioFibonacci.Text = conversor.convertirABinario(numero);
            EtiquetaHexadecimalFibonacci.Text = conversor.convertirAHexadecimal(numero);
            capicuaFibonacci.Text= numeroCapicua.esCapicua(numero);
            felizFibonacci.Text = numeroFeliz.EsFeliz(numero);
        }

       

        private void BtnRetrocerTodos_Click(object sender, EventArgs e)        {
            ulong numero = fibonacci.TerminoActual();

            if (numero != 0)  {
                fibonacci.anterior();
                EtiquetaDecimalFibonacci.Text = "" + numero;
                EtiquetaBinarioFibonacci.Text = conversor.convertirABinario(numero);
                EtiquetaHexadecimalFibonacci.Text = conversor.convertirAHexadecimal(numero);
                capicuaFibonacci.Text = numeroCapicua.esCapicua(numero);
                felizFibonacci.Text = numeroFeliz.EsFeliz(numero);

            } else {
                EtiquetaDecimalFibonacci.Text = "" + numero;
                EtiquetaBinarioFibonacci.Text = conversor.convertirABinario(numero);
                EtiquetaHexadecimalFibonacci.Text = conversor.convertirAHexadecimal(numero);
                capicuaFibonacci.Text = numeroCapicua.esCapicua(numero);
                felizFibonacci.Text = numeroFeliz.EsFeliz(numero);
            }

            ulong numero1 = padovan.TerminoActual();
            if (numero1!=1) {
                padovan.anterior();
                EtiquetaDecimalPadovan.Text = "" + numero1;
                EtiquetaBinarioPadovan.Text = conversor.convertirABinario(numero1);
                EtiquetaHexadecimalPadovan.Text = conversor.convertirAHexadecimal(numero1);
                capicuaPadovan.Text = numeroCapicua.esCapicua(numero1);
                felizPadovan.Text = numeroFeliz.EsFeliz(numero1);
            } else{
                EtiquetaDecimalPadovan.Text = "" ;
                EtiquetaBinarioPadovan.Text = conversor.convertirABinario(numero1);
                EtiquetaHexadecimalPadovan.Text = conversor.convertirAHexadecimal(numero1);
                capicuaPadovan.Text = numeroCapicua.esCapicua(numero1);
                felizPadovan.Text = numeroFeliz.EsFeliz(numero1);
            }

        }

       
    }
}
