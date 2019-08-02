using System;
using System.Collections.Generic;
using AplicacionSeries.Interfaces;
using Dominio.Interfaces;
using Gtk;

namespace AplicacionSeries.Controles
{
    public class AccionadorRetroceder : IAccionador
    {
        public void Accion(Button boton, ISerie[] series, ICajaTexto[][] cajas)
        {
            MostrarEnCajas(cajas, series);
        }

        private void AvansarSeries(ISerie serie, ICajaTexto[] grupoCajas)
        {
            serie.Retroceder();
            serie.MostarEnCajas(grupoCajas);
        }

        private void MostrarEnCajas(ICajaTexto[][] cajas, ISerie[] series)
        {
            foreach (ICajaTexto[] grupoCajas in cajas)
            {
                foreach (ISerie serie in series)
                {
                    AvansarSeries(serie, grupoCajas);
                }
            }
        }
    }
}
