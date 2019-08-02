using System;
using Dominio.Interfaces;

namespace AplicacionSeries.Controles
{
    public class CajaDecimal : Gtk.Entry , ICajaTexto
    {
        const string CAJA_INICIO = "0";

        public CajaDecimal()
        {
            Text = CAJA_INICIO;
        }

        public void MostrarTexto(long valor)
        {
            Text = valor.ToString();
        }
    }
    
}
