using System;
using System.Collections.Generic;
using System.Text;

namespace TP6.Modelo
{
    public interface IRepositorio
    {
        List<Producto> ObtenerProductos();
        Producto ObtenerProductoPorCodigo(int codigo);
        void AgregarProducto(Producto p);
        bool EliminarProducto(int codigo);
        bool VerificarCodigo(int codigo);
        List<Producto> ObtenerProductosPrecargados(); 
    }
}
