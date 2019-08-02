using System;
using AplicacionSeries.LibreriaNumerosEspañol;
using Dominio.Interfaces;

namespace AplicacionSeries.Controles
{
    public class CajaEspañol : Gtk.Entry, ICajaTexto
    {
        const string CAJA_INICIO = "0";

        public CajaEspañol()
        {
            Text = CAJA_INICIO;
        }

        public void MostrarTexto(long valor)
        {
            Text = Numalet.ToCardinal(unchecked((int)valor));
        }
    }
}
