using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace TP6.Vista.Interfaces
{
    interface IAddProduct
    {
        void EnlazarControles();
        void Mostrar();
        void Cerrar();
        void MostrarMensaje(string mensaje, string titulo, tipoMensaje tipo);
        void setCostoCITxt(string texto);
        void setPrecioFinalTxt(string texto);
        void setMargenGnancia(string texto);
    }

    public enum tipoMensaje
    {
        error, 
        aviso
    }
}
