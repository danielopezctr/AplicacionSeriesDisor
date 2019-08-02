using System;
using Dominio.Interfaces;

namespace AplicacionSeries.Controles
{
    public class CajaHexadecimal : Gtk.Entry , ICajaTexto
    {
        const int VALOR_CONVERSOR_HEXAGECIMAL = 16;
        const string CAJA_INICIO = "0";

        public CajaHexadecimal()
        {
            Text = CAJA_INICIO;
        }

        public void MostrarTexto(long valor)
        {
            Text = Convert.ToString(valor, VALOR_CONVERSOR_HEXAGECIMAL);
        }
    }
}
