using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using TP6.Modelo;
using TP6.Persistencia;
using TP6.Vista.Interfaces;

namespace TP6.Presentador
{
    class AddProductPresentador
    {
        private IAddProduct _vista;
        private IRepositorio _repositorio;
        public AddProductPresentador(IAddProduct vistaProducts, IRepositorio repositorio)
        {
            _vista = vistaProducts;
            _repositorio = repositorio; 
        }
        public void IniciarVista()
        {
            _vista.EnlazarControles();
        }
        public void AgregarProducto(Producto producto)
        {
            if(ValidarCampos(producto))
            {
                _repositorio.AgregarProducto(producto);
                _vista.MostrarMensaje("Producto ingresado correctamente", "Alta exitosa", tipoMensaje.aviso);
                _vista.Cerrar();
            }
            else
            {
                _vista.MostrarMensaje("Valor/es inválido/s en el/los campo/s", "Error", tipoMensaje.error);
            }
        }
        public bool ComprobarDisponiblidadCodigo(int codigo)
        {
            return _repositorio.VerificarCodigo(codigo);
        }

        public void ActualizarPrecioCI(string costoSITxt, string ivaTxt)
        {
            if(Double.TryParse(costoSITxt, out double costoSI) &&
                Double.TryParse(ivaTxt, out double iva) &&
                iva >= 0 && costoSI >= 0)
            {
                double costoCI = new Producto().CalcularCostoCI(costoSI, iva);
                _vista.setCostoCITxt($"{costoCI}");
            }
        }
        public void ActualizarMargenGnancia(string costoCITxt, string precioFinalTxt)
        {
            if(Double.TryParse(costoCITxt, out double costoCI) &&
                Double.TryParse(precioFinalTxt, out double precioFinal) &&
                costoCI > 0 && precioFinal >= 0)
            {
                double margenGnancia = new Producto().CalcularMargenGanancia(precioFinal, costoCI);
                _vista.setMargenGnancia($"{margenGnancia}");
            }
        }
        public void ActualizarPrecioFinal(string costoCITxt, string margenGnanciaTxt)
        {
            if(Double.TryParse(costoCITxt, out double costoCI) &&
                Double.TryParse(margenGnanciaTxt, out double margenGnancia) &&
                costoCI >= 0 && margenGnancia >= 0)
            {
                double precioFinal = new Producto().CalcularPrecioFinal(costoCI, margenGnancia);
                _vista.setPrecioFinalTxt($"{precioFinal}");
            }
        }
        public bool ValidarCampos(Producto producto)
        {
            if (ComprobarDisponiblidadCodigo(producto.Codigo) &&
                producto.Stock >= 0 && producto.PF >= 0 &&
                producto.MG >= 0 && producto.CSI >= 0 &&
                producto.Codigo > 0
                )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
