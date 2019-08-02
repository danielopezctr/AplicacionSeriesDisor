using System;
using Dominio.Interfaces;

namespace AplicacionSeries.Controles
{
    public class CajaBinario : Gtk.Entry , ICajaTexto
    {
        const int VALOR_CONVERSOR_BINARIO = 2;
        const string CAJA_INICIO = "0";

        public CajaBinario()
        {
            Text = CAJA_INICIO;
        }

        public void MostrarTexto(long valor)
        {
            Text = Convert.ToString(valor, VALOR_CONVERSOR_BINARIO);
        }
    }
}
