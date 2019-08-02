using System;
using Dominio.Interfaces;

namespace Dominio
{
    public class NumeroSuerte : ISerie
    {
        private long TerminoActual;


        public NumeroSuerte()
        {
            TerminoActual = 0;
        }

        public long getTermino()
        {
            return TerminoActual;
        }

        private bool EsNumeroDeLaSuerte(long numero)
        {
            
            return RecurcionNumeroDeLaSuerte(numero, 2);
        }

        private bool RecurcionNumeroDeLaSuerte(long numero, long contraresta)
        {
            if(contraresta > numero)
            {
                return true;
            }

            if(numero % contraresta == 0)
            {
                return false;
            }

            numero -= numero / contraresta;
            contraresta++;
            return RecurcionNumeroDeLaSuerte(numero, contraresta);
        }

        public void Avanzar()
        {
            long RespaldoTerminoActual = TerminoActual+1;
            while (!EsNumeroDeLaSuerte(RespaldoTerminoActual))
            {
                RespaldoTerminoActual++;
            }
            TerminoActual = RespaldoTerminoActual;
        }

        public void Retroceder()
        {
            long RespaldoTerminoActual = TerminoActual - 1;

            if (RespaldoTerminoActual < 0)
            {
                RespaldoTerminoActual = 0;
            }

            while (!EsNumeroDeLaSuerte(RespaldoTerminoActual)&& RespaldoTerminoActual > 0)
            {
                RespaldoTerminoActual--;
            }
            TerminoActual = RespaldoTerminoActual;
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
