using System;
using System.Collections.Generic;
using System.Text;

namespace TP6.Vista.Interfaces
{
    interface IEditProduct
    {
        void Mostrar();
        void Cerrar();
        void EnlazarControles(int codigo);
        void InicializarEnlaceControles(int codigo);
        void MostrarMensaje(string mensaje, string titulo, tipoMensaje tipo);
        void setCostoCITxt(string texto);
        void setPrecioFinalTxt(string texto);
        void setMargenGnancia(string texto);
    }
}
