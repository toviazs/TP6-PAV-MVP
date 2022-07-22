using System;
using System.Collections.Generic;
using System.Text;
using TP6.Modelo;
using TP6.Persistencia;
using TP6.Vista.Interfaces;

namespace TP6.Presentador
{
    class EditProductPresentador
    {
        private IEditProduct _vista;
        private IRepositorio _repositorio;
        public EditProductPresentador(IEditProduct vista, IRepositorio repositorio)
        {
            _vista = vista;
            _repositorio = repositorio;
        }
        public Producto ObtenerProducto(int codigo)
        {
            return _repositorio.ObtenerProductoPorCodigo(codigo);
        }
        public void ModificarProducto(Producto temporal, Producto original)
        {
            if(ValidarCampos(temporal, original))
            {
                temporal.CopiarEn(original);
                _vista.EnlazarControles(original.Codigo);
                _vista.MostrarMensaje("Producto modificado correctamente", "Modificación Exitosa", tipoMensaje.aviso);
                _vista.Cerrar();
            }
            else
            {
                _vista.MostrarMensaje("Datos inválidos o incoherentes", "Error", tipoMensaje.error);
            }
        }
        public bool ValidarCampos(Producto temporal, Producto original)
        {
            if((_repositorio.VerificarCodigo(temporal.Codigo) || temporal.Codigo == original.Codigo) &&
               temporal.Descripcion != "" &&
               temporal.Stock >= 0 &&
               temporal.CSI > 0) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void ActualizarPrecioCI(string costoSITxt, string ivaTxt)
        {
            if (Double.TryParse(costoSITxt, out double costoSI) &&
                Double.TryParse(ivaTxt, out double iva) &&
                iva >= 0 && costoSI >= 0)
            {
                double costoCI = new Producto().CalcularCostoCI(costoSI, iva);
                _vista.setCostoCITxt($"{costoCI}");
            }
        }
        public void ActualizarMargenGnancia(string costoCITxt, string precioFinalTxt)
        {
            if (Double.TryParse(costoCITxt, out double costoCI) &&
                Double.TryParse(precioFinalTxt, out double precioFinal) &&
                costoCI > 0 && precioFinal >= 0)
            {
                double margenGnancia = new Producto().CalcularMargenGanancia(precioFinal, costoCI);
                _vista.setMargenGnancia($"{margenGnancia}");
            }
        }
        public void ActualizarPrecioFinal(string costoCITxt, string margenGnanciaTxt)
        {
            if (Double.TryParse(costoCITxt, out double costoCI) &&
                Double.TryParse(margenGnanciaTxt, out double margenGnancia) &&
                costoCI >= 0 && margenGnancia >= 0)
            {
                double precioFinal = new Producto().CalcularPrecioFinal(costoCI, margenGnancia);
                _vista.setPrecioFinalTxt($"{precioFinal}");
            }
        }
    }
}
