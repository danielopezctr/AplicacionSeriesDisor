using System.Collections.Generic;
using Dominio.Interfaces;
using Gtk;

namespace AplicacionSeries.Interfaces
{
    public interface IAccionador
    {
        void Accion(Button boton, ISerie[] series, ICajaTexto[][] cajas);
    }
}
