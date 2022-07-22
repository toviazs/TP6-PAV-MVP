using System;
using System.Collections.Generic;
using System.Text;
using TP6.Modelo;

namespace TP6.Vista.Interfaces
{
    interface IProducts
    {
        void ActualizarTabla(List<Producto> productos);
        void MostrarMensaje(string mensaje, string titulo, tipoMensaje tipo);
        bool MostrarMensajeConfirmar(string mensaje, string titulo);
    }
}
