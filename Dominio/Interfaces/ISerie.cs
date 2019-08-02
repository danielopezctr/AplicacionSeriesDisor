using System;
namespace Dominio.Interfaces
{
    public interface ISerie
    {
        void Avanzar();
        void Retroceder();
        void MostarEnCajas(ICajaTexto[] cajas);
    }
}
