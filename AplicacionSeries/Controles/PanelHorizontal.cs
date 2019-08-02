using System;
using Gtk;

namespace AplicacionSeries.Controles
{
    public class PanelHorizontal : Gtk.HBox
    {
        public void AgregarControlHorizontal(Widget control)
        {
            PackStart(control, true, true, 10);
        }

    }
}
