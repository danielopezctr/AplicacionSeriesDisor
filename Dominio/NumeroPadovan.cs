using System;
using System.Text;
using Dominio.Interfaces;

namespace Dominio
{
    public class NumeroPadovan : ISerie
    {
        private long PrimerTermino;
        private long SegundoTermino;
        private long TercerTermino;

        public NumeroPadovan()
        {
            PrimerTermino = 0;
            SegundoTermino = 1;
            TercerTermino = 1;
        }

        public void Avanzar()
        {
            long TerminoNuevo = PrimerTermino + SegundoTermino;
            PrimerTermino = SegundoTermino;
            SegundoTermino = TercerTermino;
            TercerTermino = TerminoNuevo;
        }

        public void Retroceder()
        {
            if (PrimerTermino == 0)
            {
                PrimerTermino = 0;
                SegundoTermino = 1;
                TercerTermino = 1;
            }
            if (PrimerTermino != 0)
            {
                long TerminoAnterio = TercerTermino - PrimerTermino;
                TercerTermino = SegundoTermino;
                SegundoTermino = PrimerTermino;
                PrimerTermino = TerminoAnterio;

            }
            

            

        }

        public void MostarEnCajas(ICajaTexto[] cajas)
        {
            foreach (ICajaTexto caja in cajas)
            {
                caja.MostrarTexto(PrimerTermino);
            }
        }

        public long getTermino()
        {
            return PrimerTermino;
        }
    }
}
