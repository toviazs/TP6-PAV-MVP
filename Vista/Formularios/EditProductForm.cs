using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TP6.Modelo;
using TP6.Presentador;
using TP6.Vista.Interfaces;

namespace TP6.Vista.Formularios
{
    public partial class EditProductForm : Form, IEditProduct
    {
        private Producto _prodTemporal;
        private Producto _prodOriginal;
        private EditProductPresentador _presentador;
        public delegate void Cargar();
        public event Cargar Cargado;
        public EditProductForm(IRepositorio repositorio)
        {
            InitializeComponent();
            _presentador = new EditProductPresentador(this, repositorio);

            EstadoCB.DataSource = Enum.GetNames(typeof(Estado));
        }
        public void Cerrar()
        {
            Dispose();
            InvocarCargado();
        }
        public void Mostrar()
        {
            Show();
        }
        public void InicializarEnlaceControles(int codigo)
        {
            _prodOriginal = _presentador.ObtenerProducto(codigo);
            _prodTemporal = (Producto)_prodOriginal.Clone();
            bsProducto.DataSource = _prodTemporal;

            CodigoTxt.DataBindings.Add(new Binding("Text", bsProducto, "Codigo", true, DataSourceUpdateMode.OnPropertyChanged));
            DescripcionTxt.DataBindings.Add(new Binding("Text", bsProducto, "Descripcion"));
            CostoSITxt.DataBindings.Add(new Binding("Text", bsProducto, "CSI", true, DataSourceUpdateMode.OnPropertyChanged));
            IvaTxt.DataBindings.Add(new Binding("Text", bsProducto, "PI"));
            CostoCITxt.DataBindings.Add(new Binding("Text", bsProducto, "CCI", true, DataSourceUpdateMode.OnPropertyChanged));
            MargenGnciaTxt.DataBindings.Add(new Binding("Text", bsProducto, "MG", true, DataSourceUpdateMode.OnPropertyChanged));
            PrecioFinalTxt.DataBindings.Add(new Binding("Text", bsProducto, "PF", true, DataSourceUpdateMode.OnPropertyChanged));
            StockTxt.DataBindings.Add(new Binding("Text", bsProducto, "Stock"));
            EstadoCB.DataBindings.Add(new Binding("Text", bsProducto, "Estado", true, DataSourceUpdateMode.OnPropertyChanged));
        }
        public void EnlazarControles(int codigo)
        {
            bsProducto.DataSource = _presentador.ObtenerProducto(codigo);
            bsProducto.ResetBindings(true);
        }
        private void ModificarBtn_Click(object sender, EventArgs e)
        {
            _presentador.ModificarProducto(_prodTemporal, _prodOriginal);
        }
        public void MostrarMensaje(string mensaje, string titulo, tipoMensaje tipo)
        { 
            MessageBoxIcon icono;
            if(tipo == tipoMensaje.aviso)
            {
                icono = MessageBoxIcon.Information;
            } else
            {
                icono = MessageBoxIcon.Error;
            }
            _ = MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, icono);
        }
        private void EditProductForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            InvocarCargado();
        }
        private void VolverBtn_Click(object sender, EventArgs e)
        {
            InvocarCargado();
            Cerrar();
        }
        public void InvocarCargado()
        {
            Cargado.Invoke();
        }
        public void setCostoCITxt(string texto)
        {
            CostoCITxt.Text = texto;
        }
        public void setMargenGnancia(string texto)
        {
            MargenGnciaTxt.Text = texto;
        }
        public void setPrecioFinalTxt(string texto)
        {
            PrecioFinalTxt.Text = texto;
        }
        private void CostoSITxt_Leave(object sender, EventArgs e)
        {
            _presentador.ActualizarPrecioCI(CostoSITxt.Text, IvaTxt.Text);
        }
        private void MargenGnciaTxt_Leave(object sender, EventArgs e)
        {
            _presentador.ActualizarPrecioFinal(CostoCITxt.Text, MargenGnciaTxt.Text);
        }
        private void PrecioFinalTxt_Leave(object sender, EventArgs e)
        {
            _presentador.ActualizarMargenGnancia(CostoCITxt.Text, PrecioFinalTxt.Text);
        }
    }
}
