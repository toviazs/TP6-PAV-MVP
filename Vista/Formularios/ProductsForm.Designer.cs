
namespace TP6.Vista.Formularios
{
    partial class ProductsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AgregarTS = new System.Windows.Forms.ToolStripButton();
            this.EditarTS = new System.Windows.Forms.ToolStripButton();
            this.EliminarTS = new System.Windows.Forms.ToolStripButton();
            this.TablaProductos = new System.Windows.Forms.DataGridView();
            this.BusquedaTxt = new System.Windows.Forms.TextBox();
            this.bsProducto = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AgregarTS,
            this.EditarTS,
            this.EliminarTS});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(761, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AgregarTS
            // 
            this.AgregarTS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AgregarTS.Image = ((System.Drawing.Image)(resources.GetObject("AgregarTS.Image")));
            this.AgregarTS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AgregarTS.Name = "AgregarTS";
            this.AgregarTS.Size = new System.Drawing.Size(23, 22);
            this.AgregarTS.Text = "Agregar";
            this.AgregarTS.Click += new System.EventHandler(this.AgregarTS_Click);
            // 
            // EditarTS
            // 
            this.EditarTS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EditarTS.Image = ((System.Drawing.Image)(resources.GetObject("EditarTS.Image")));
            this.EditarTS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditarTS.Name = "EditarTS";
            this.EditarTS.Size = new System.Drawing.Size(23, 22);
            this.EditarTS.Text = "Editar";
            this.EditarTS.Click += new System.EventHandler(this.EditarTS_Click);
            // 
            // EliminarTS
            // 
            this.EliminarTS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EliminarTS.Image = ((System.Drawing.Image)(resources.GetObject("EliminarTS.Image")));
            this.EliminarTS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EliminarTS.Name = "EliminarTS";
            this.EliminarTS.Size = new System.Drawing.Size(23, 22);
            this.EliminarTS.Text = "Eliminar";
            this.EliminarTS.Click += new System.EventHandler(this.EliminarTS_Click);
            // 
            // TablaProductos
            // 
            this.TablaProductos.AllowUserToAddRows = false;
            this.TablaProductos.AllowUserToDeleteRows = false;
            this.TablaProductos.AllowUserToResizeColumns = false;
            this.TablaProductos.AllowUserToResizeRows = false;
            this.TablaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaProductos.Location = new System.Drawing.Point(12, 57);
            this.TablaProductos.MultiSelect = false;
            this.TablaProductos.Name = "TablaProductos";
            this.TablaProductos.ReadOnly = true;
            this.TablaProductos.RowTemplate.Height = 25;
            this.TablaProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TablaProductos.Size = new System.Drawing.Size(737, 381);
            this.TablaProductos.TabIndex = 1;
            // 
            // BusquedaTxt
            // 
            this.BusquedaTxt.Location = new System.Drawing.Point(12, 28);
            this.BusquedaTxt.Name = "BusquedaTxt";
            this.BusquedaTxt.Size = new System.Drawing.Size(737, 23);
            this.BusquedaTxt.TabIndex = 2;
            this.BusquedaTxt.TextChanged += new System.EventHandler(this.BusquedaTxt_TextChanged);
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 450);
            this.Controls.Add(this.BusquedaTxt);
            this.Controls.Add(this.TablaProductos);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ProductsForm";
            this.Text = "ProductsForm";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton AgregarTS;
        private System.Windows.Forms.ToolStripButton EditarTS;
        private System.Windows.Forms.ToolStripButton EliminarTS;
        private System.Windows.Forms.DataGridView TablaProductos;
        private System.Windows.Forms.TextBox BusquedaTxt;
        private System.Windows.Forms.BindingSource bsProducto;
    }
}