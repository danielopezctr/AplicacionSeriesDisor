using System;
using System.Collections.Generic;
using AplicacionSeries.Interfaces;
using Dominio.Interfaces;

namespace AplicacionSeries.Controles
{
    public class Boton : Gtk.Button
    {
        const string ETIQUETA_BOTON_RETROCEDER = "Retroceder";
        const string ETIQUETA_BOTON_AVANZAR = "Avanzar";
        private AccionadorRetroceder acionadorRetroceder;
        private ISerie[] series;
        private ICajaTexto[][] cajas;

        public Boton(AccionadorAvanzar accionador, ISerie[] series, ICajaTexto[][] cajas)
        {
            Label = ETIQUETA_BOTON_AVANZAR;
            AsignacionAccion(accionador, series, cajas);
        }
        

        public Boton(AccionadorRetroceder accionador, ISerie[] series, ICajaTexto[][] cajas)
        {
            Label = ETIQUETA_BOTON_RETROCEDER;
            AsignacionAccion(accionador, series, cajas);
        }

        public void AsignacionAccion(IAccionador accionador, ISerie[] series, ICajaTexto[][] cajas)
        {
            Clicked += (sender, args) =>
            {
                accionador.Accion(this, series, cajas);
            };
        }
    }
}
