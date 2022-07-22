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
    public partial class AddProductForm : Form, IAddProduct
    {
        private AddProductPresentador _presentador;
        private Producto _prodTemporal;
        public delegate void Cargar();
        public event Cargar Cargado;
        public AddProductForm(IRepositorio repositorio)
        {
            InitializeComponent();
            _presentador = new AddProductPresentador(this, repositorio);
            _presentador.IniciarVista();

            EstadoCB.DataSource = Enum.GetNames(typeof(Estado));
        }
        public void Cerrar()
        {
            Dispose();
            InvocarCargado();
        }

        public void EnlazarControles()
        {
            _prodTemporal = new Producto();
            bsProducto.DataSource = _prodTemporal;

            CodigoTxt.DataBindings.Add(new Binding("Text", bsProducto, "Codigo"));
            DescripcionTxt.DataBindings.Add(new Binding("Text", bsProducto, "Descripcion"));
            CostoSITxt.DataBindings.Add(new Binding("Text", bsProducto, "CSI", true, DataSourceUpdateMode.OnPropertyChanged));
            IvaTxt.DataBindings.Add(new Binding("Text", bsProducto, "PI"));
            CostoCITxt.DataBindings.Add(new Binding("Text", bsProducto, "CCI", true, DataSourceUpdateMode.OnPropertyChanged));
            MargenGnciaTxt.DataBindings.Add(new Binding("Text", bsProducto, "MG", true, DataSourceUpdateMode.OnPropertyChanged));
            PrecioFinalTxt.DataBindings.Add(new Binding("Text", bsProducto, "PF", true, DataSourceUpdateMode.OnPropertyChanged));
            StockTxt.DataBindings.Add(new Binding("Text", bsProducto, "Stock"));
            EstadoCB.DataBindings.Add(new Binding("Text", bsProducto, "Estado", true, DataSourceUpdateMode.OnPropertyChanged));
        }

        public void Mostrar()
        {
            Show();
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

        private void AgregarBtn_Click(object sender, EventArgs e)
        {
            _presentador.AgregarProducto(_prodTemporal);
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

        private void VolverBtn_Click(object sender, EventArgs e)
        {
            InvocarCargado();
            Cerrar();
        }
        public void InvocarCargado()
        {
            Cargado.Invoke();
        }

        private void AddProductForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            InvocarCargado();
        }
    }
}
