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
    public partial class ProductsForm : Form, IProducts
    {
        private ProductsPresentador _presentador;
        public ProductsForm()
        {
            InitializeComponent();
            _presentador = new ProductsPresentador(this);
            _presentador.CargarTabla();
        }

        public void ActualizarTabla(List<Producto> productos)
        {
            bsProducto.Clear();
            TablaProductos.AutoGenerateColumns = true;
            TablaProductos.DataSource = null;

            foreach(Producto p in productos)
            {
                bsProducto.Add(p);
            }

            TablaProductos.DataSource = bsProducto;
        }

        private void AgregarTS_Click(object sender, EventArgs e)
        {
            _presentador.AbrirAgregarProducto();
        }

        private void EditarTS_Click(object sender, EventArgs e)
        {
            _presentador.AbrirEditarProducto((int)TablaProductos.SelectedRows[0].Cells[0].Value); 
        }

        private void EliminarTS_Click(object sender, EventArgs e)
        {
            _presentador.BorrarProducto((int)TablaProductos.SelectedRows[0].Cells[0].Value);
        }
        public void MostrarMensaje(string mensaje, string titulo, tipoMensaje tipo)
        {
            MessageBoxIcon icono;
            if (tipo == tipoMensaje.aviso)
            {
                icono = MessageBoxIcon.Information;
            }
            else
            {
                icono = MessageBoxIcon.Error;
            }
            _ = MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, icono);
        }

        private void BusquedaTxt_TextChanged(object sender, EventArgs e)
        {
            _presentador.BuscadorTabla(BusquedaTxt.Text);
        }

        public bool MostrarMensajeConfirmar(string mensaje, string titulo)
        {
            var resultado = MessageBox.Show(null, mensaje, titulo, MessageBoxButtons.YesNo);
            return resultado == DialogResult.Yes;
        }
    }
}
