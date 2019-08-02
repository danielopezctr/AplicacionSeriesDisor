using System;
using Gtk;

namespace AplicacionSeries.Controles
{
    public class PanelVertical : Gtk.VBox
    {
        public void AgregarControlVertical(Widget control)
        {
            PackStart(control, false, false, 5);
        }
    }
}
