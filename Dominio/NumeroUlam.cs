using System.Collections.Generic;
using Dominio.Interfaces;

namespace Dominio
{
    public class NumeroUlam : ISerie
    {
        const int PRIMER_NUMERO_ULAM = 1;
        const int SEGUNDO_NUMERO_ULAM = 2;
        const int UNA_SUMA_DE_DOS_TERMINOS_DIFERENTE = 1;
        private long TerminoActual;

        public NumeroUlam()
        {
            TerminoActual = 0;
        }

        private List<long> NumerosUlams(long max)
        {
            List<long> ListaNumeroUlam = new List<long>();

            ListaNumeroUlam.Add(PRIMER_NUMERO_ULAM);
            ListaNumeroUlam.Add(SEGUNDO_NUMERO_ULAM);

            for (long i = 3; i < max + 100; i++)
            {
                int Contador = 0;

                for (int j = 0; j < ListaNumeroUlam.Count - 1; j++)
                {

                    for (int k = j + 1; k < ListaNumeroUlam.Count; k++)
                    {
                        if (ListaNumeroUlam[j] + ListaNumeroUlam[k] == i)
                        {
                            Contador++;
                        }
                        if (Contador > UNA_SUMA_DE_DOS_TERMINOS_DIFERENTE)
                            break;
                    }
                    if (Contador > UNA_SUMA_DE_DOS_TERMINOS_DIFERENTE)
                        break;
                }

                if (Contador == UNA_SUMA_DE_DOS_TERMINOS_DIFERENTE)
                {  
                    ListaNumeroUlam.Add(i);
                }
            }
            return ListaNumeroUlam;
        }

        public void Avanzar()
        {
            List<long> ListaNumeros = NumerosUlams(TerminoActual);
            int PosicionNumeroUlam = ListaNumeros.IndexOf(TerminoActual);
            TerminoActual = ListaNumeros[PosicionNumeroUlam + 1];
        }
        public void Retroceder()
        {
            if (TerminoActual == 1)
            {
                TerminoActual = 0;
            }
            if (TerminoActual > 1)
            {
                List<long> ListaNumeros = NumerosUlams(TerminoActual);
                int PosicionNumeroUlam = ListaNumeros.IndexOf(TerminoActual);
                TerminoActual = ListaNumeros[PosicionNumeroUlam - 1];
            }
            
        }

        public long getTermino()
        {
            return TerminoActual;
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
