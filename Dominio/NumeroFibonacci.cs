using System;
using Dominio.Interfaces;

namespace Dominio
{
    public class NumeroFibonacci : ISerie
    {
        private long TerminoActual;
        private long TerminoAnterior;

        public NumeroFibonacci()
        {
            TerminoActual = 0;
            TerminoAnterior = 0;
        }

        public long getTermino()
        {
            return TerminoActual;
        }

        public void Avanzar()
        {
            if (TerminoActual > 0)
            {
                long respaldoTeminoActual = TerminoActual;
                TerminoActual = TerminoAnterior + TerminoActual;
                TerminoAnterior = respaldoTeminoActual;
            }

            if (TerminoActual == 0)
            {
                TerminoActual = 1;
                TerminoAnterior = 0;
            }
        }

        public void Retroceder()
        {
            if (TerminoActual > 0)
            {
                long respaldoTeminoActual = TerminoActual;
                TerminoActual = TerminoAnterior;
                TerminoAnterior = respaldoTeminoActual - TerminoAnterior;
            }
            if (TerminoActual == 0)
            {
                TerminoActual = 0;
                TerminoAnterior = 0;
            }

        }

        public void MostarEnCajas(ICajaTexto[] cajas)
        {
            foreach (ICajaTexto caja in cajas)
            {
                caja.MostrarTexto(TerminoActual);
            }
        }

        

    }
}
