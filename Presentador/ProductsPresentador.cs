using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TP6.Modelo;
using TP6.Persistencia;
using TP6.Vista.Formularios;
using TP6.Vista.Interfaces;

namespace TP6.Presentador
{
    class ProductsPresentador
    {
        private IProducts _vista;
        private IRepositorio _repositorio;
        public ProductsPresentador(IProducts vistaProducts)
        {
            _vista = vistaProducts;
            _repositorio = new Repositorio();
        }
        public void AbrirAgregarProducto()
        {
            AddProductForm vistaAddProduct = new AddProductForm(_repositorio);
            vistaAddProduct.Cargado += CargarTabla;
            vistaAddProduct.Mostrar();
        }
        public void CargarTabla()
        {
            List<Producto> productos = _repositorio.ObtenerProductos();
            _vista.ActualizarTabla(productos);
        }
        public void AbrirEditarProducto(int codigoProd)
        {
            EditProductForm vistaEditProduct = new EditProductForm(_repositorio);
            vistaEditProduct.Cargado += CargarTabla;
            vistaEditProduct.Mostrar();
            vistaEditProduct.InicializarEnlaceControles(codigoProd);
        }
        public void BorrarProducto(int codigo)
        {
            Producto p = _repositorio.ObtenerProductoPorCodigo(codigo);
            if (p != null)
            {
                if (_vista.MostrarMensajeConfirmar($"Está seguro que desea eliminar:\n{p.Descripcion}?", "Confirmar Borrado"))
                {
                    if(_repositorio.EliminarProducto(codigo))
                    {
                        _vista.MostrarMensaje($"{p.Descripcion}, cod: {p.Codigo}\nBorrado correctamente", "¡Borrado!", tipoMensaje.aviso);
                    }
                }
            }
            else
            {
                _vista.MostrarMensaje("No se encontró ningún producto", "Error", tipoMensaje.error);
            }
            CargarTabla();
        }
        public void BuscadorTabla(string textoIngresado)
        {
            List<Producto> productos = _repositorio.ObtenerProductos();
            List<Producto> productosFiltrados = productos.Where(x => x.Descripcion.Contains(textoIngresado)).ToList();
            _vista.ActualizarTabla(productosFiltrados);
        }
    }
}
