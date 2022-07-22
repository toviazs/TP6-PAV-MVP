
namespace TP6.Vista.Formularios
{
    partial class AddProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductForm));
            this.CodigoLbl = new System.Windows.Forms.Label();
            this.DescripcionLbl = new System.Windows.Forms.Label();
            this.StockLbl = new System.Windows.Forms.Label();
            this.EstadoLbl = new System.Windows.Forms.Label();
            this.CostoSILbl = new System.Windows.Forms.Label();
            this.CostoCILbl = new System.Windows.Forms.Label();
            this.MargenGnciaLbl = new System.Windows.Forms.Label();
            this.IvaLbl = new System.Windows.Forms.Label();
            this.PrecioFinalLbl = new System.Windows.Forms.Label();
            this.CodigoTxt = new System.Windows.Forms.TextBox();
            this.DescripcionTxt = new System.Windows.Forms.TextBox();
            this.StockTxt = new System.Windows.Forms.TextBox();
            this.CostoSITxt = new System.Windows.Forms.TextBox();
            this.CostoCITxt = new System.Windows.Forms.TextBox();
            this.IvaTxt = new System.Windows.Forms.TextBox();
            this.PrecioFinalTxt = new System.Windows.Forms.TextBox();
            this.EstadoCB = new System.Windows.Forms.ComboBox();
            this.MargenGnciaTxt = new System.Windows.Forms.TextBox();
            this.AgregarBtn = new System.Windows.Forms.Button();
            this.bsProducto = new System.Windows.Forms.BindingSource(this.components);
            this.VolverBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // CodigoLbl
            // 
            this.CodigoLbl.AutoSize = true;
            this.CodigoLbl.Location = new System.Drawing.Point(58, 15);
            this.CodigoLbl.Name = "CodigoLbl";
            this.CodigoLbl.Size = new System.Drawing.Size(46, 15);
            this.CodigoLbl.TabIndex = 0;
            this.CodigoLbl.Text = "Código";
            // 
            // DescripcionLbl
            // 
            this.DescripcionLbl.AutoSize = true;
            this.DescripcionLbl.Location = new System.Drawing.Point(31, 44);
            this.DescripcionLbl.Name = "DescripcionLbl";
            this.DescripcionLbl.Size = new System.Drawing.Size(69, 15);
            this.DescripcionLbl.TabIndex = 1;
            this.DescripcionLbl.Text = "Descripción";
            // 
            // StockLbl
            // 
            this.StockLbl.AutoSize = true;
            this.StockLbl.Location = new System.Drawing.Point(64, 73);
            this.StockLbl.Name = "StockLbl";
            this.StockLbl.Size = new System.Drawing.Size(36, 15);
            this.StockLbl.TabIndex = 2;
            this.StockLbl.Text = "Stock";
            // 
            // EstadoLbl
            // 
            this.EstadoLbl.AutoSize = true;
            this.EstadoLbl.Location = new System.Drawing.Point(58, 102);
            this.EstadoLbl.Name = "EstadoLbl";
            this.EstadoLbl.Size = new System.Drawing.Size(42, 15);
            this.EstadoLbl.TabIndex = 3;
            this.EstadoLbl.Text = "Estado";
            // 
            // CostoSILbl
            // 
            this.CostoSILbl.AutoSize = true;
            this.CostoSILbl.Location = new System.Drawing.Point(36, 131);
            this.CostoSILbl.Name = "CostoSILbl";
            this.CostoSILbl.Size = new System.Drawing.Size(68, 15);
            this.CostoSILbl.TabIndex = 4;
            this.CostoSILbl.Text = "Costo s/IVA";
            // 
            // CostoCILbl
            // 
            this.CostoCILbl.AutoSize = true;
            this.CostoCILbl.Location = new System.Drawing.Point(36, 160);
            this.CostoCILbl.Name = "CostoCILbl";
            this.CostoCILbl.Size = new System.Drawing.Size(69, 15);
            this.CostoCILbl.TabIndex = 5;
            this.CostoCILbl.Text = "Costo c/IVA";
            // 
            // MargenGnciaLbl
            // 
            this.MargenGnciaLbl.AutoSize = true;
            this.MargenGnciaLbl.Location = new System.Drawing.Point(5, 189);
            this.MargenGnciaLbl.Name = "MargenGnciaLbl";
            this.MargenGnciaLbl.Size = new System.Drawing.Size(99, 15);
            this.MargenGnciaLbl.TabIndex = 6;
            this.MargenGnciaLbl.Text = "Margen ganancia";
            // 
            // IvaLbl
            // 
            this.IvaLbl.AutoSize = true;
            this.IvaLbl.Location = new System.Drawing.Point(76, 218);
            this.IvaLbl.Name = "IvaLbl";
            this.IvaLbl.Size = new System.Drawing.Size(24, 15);
            this.IvaLbl.TabIndex = 7;
            this.IvaLbl.Text = "IVA";
            // 
            // PrecioFinalLbl
            // 
            this.PrecioFinalLbl.AutoSize = true;
            this.PrecioFinalLbl.Location = new System.Drawing.Point(38, 247);
            this.PrecioFinalLbl.Name = "PrecioFinalLbl";
            this.PrecioFinalLbl.Size = new System.Drawing.Size(66, 15);
            this.PrecioFinalLbl.TabIndex = 8;
            this.PrecioFinalLbl.Text = "Precio final";
            // 
            // CodigoTxt
            // 
            this.CodigoTxt.Location = new System.Drawing.Point(119, 12);
            this.CodigoTxt.Name = "CodigoTxt";
            this.CodigoTxt.Size = new System.Drawing.Size(100, 23);
            this.CodigoTxt.TabIndex = 0;
            // 
            // DescripcionTxt
            // 
            this.DescripcionTxt.Location = new System.Drawing.Point(119, 41);
            this.DescripcionTxt.Name = "DescripcionTxt";
            this.DescripcionTxt.Size = new System.Drawing.Size(100, 23);
            this.DescripcionTxt.TabIndex = 1;
            // 
            // StockTxt
            // 
            this.StockTxt.Location = new System.Drawing.Point(119, 70);
            this.StockTxt.Name = "StockTxt";
            this.StockTxt.Size = new System.Drawing.Size(100, 23);
            this.StockTxt.TabIndex = 2;
            // 
            // CostoSITxt
            // 
            this.CostoSITxt.Location = new System.Drawing.Point(119, 128);
            this.CostoSITxt.Name = "CostoSITxt";
            this.CostoSITxt.Size = new System.Drawing.Size(100, 23);
            this.CostoSITxt.TabIndex = 4;
            this.CostoSITxt.Leave += new System.EventHandler(this.CostoSITxt_Leave);
            // 
            // CostoCITxt
            // 
            this.CostoCITxt.Enabled = false;
            this.CostoCITxt.Location = new System.Drawing.Point(119, 157);
            this.CostoCITxt.Name = "CostoCITxt";
            this.CostoCITxt.Size = new System.Drawing.Size(100, 23);
            this.CostoCITxt.TabIndex = 5;
            // 
            // IvaTxt
            // 
            this.IvaTxt.Enabled = false;
            this.IvaTxt.Location = new System.Drawing.Point(119, 215);
            this.IvaTxt.Name = "IvaTxt";
            this.IvaTxt.Size = new System.Drawing.Size(100, 23);
            this.IvaTxt.TabIndex = 7;
            // 
            // PrecioFinalTxt
            // 
            this.PrecioFinalTxt.Location = new System.Drawing.Point(119, 244);
            this.PrecioFinalTxt.Name = "PrecioFinalTxt";
            this.PrecioFinalTxt.Size = new System.Drawing.Size(100, 23);
            this.PrecioFinalTxt.TabIndex = 8;
            this.PrecioFinalTxt.Leave += new System.EventHandler(this.PrecioFinalTxt_Leave);
            // 
            // EstadoCB
            // 
            this.EstadoCB.Enabled = false;
            this.EstadoCB.FormattingEnabled = true;
            this.EstadoCB.Location = new System.Drawing.Point(119, 99);
            this.EstadoCB.Name = "EstadoCB";
            this.EstadoCB.Size = new System.Drawing.Size(100, 23);
            this.EstadoCB.TabIndex = 3;
            // 
            // MargenGnciaTxt
            // 
            this.MargenGnciaTxt.Location = new System.Drawing.Point(119, 186);
            this.MargenGnciaTxt.Name = "MargenGnciaTxt";
            this.MargenGnciaTxt.Size = new System.Drawing.Size(100, 23);
            this.MargenGnciaTxt.TabIndex = 6;
            this.MargenGnciaTxt.Leave += new System.EventHandler(this.MargenGnciaTxt_Leave);
            // 
            // AgregarBtn
            // 
            this.AgregarBtn.Location = new System.Drawing.Point(144, 291);
            this.AgregarBtn.Name = "AgregarBtn";
            this.AgregarBtn.Size = new System.Drawing.Size(75, 23);
            this.AgregarBtn.TabIndex = 11;
            this.AgregarBtn.Text = "Agregar";
            this.AgregarBtn.UseVisualStyleBackColor = true;
            this.AgregarBtn.Click += new System.EventHandler(this.AgregarBtn_Click);
            // 
            // VolverBtn
            // 
            this.VolverBtn.Location = new System.Drawing.Point(5, 291);
            this.VolverBtn.Name = "VolverBtn";
            this.VolverBtn.Size = new System.Drawing.Size(75, 23);
            this.VolverBtn.TabIndex = 12;
            this.VolverBtn.Text = "Volver";
            this.VolverBtn.UseVisualStyleBackColor = true;
            this.VolverBtn.Click += new System.EventHandler(this.VolverBtn_Click);
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 325);
            this.Controls.Add(this.CodigoLbl);
            this.Controls.Add(this.CodigoTxt);
            this.Controls.Add(this.VolverBtn);
            this.Controls.Add(this.AgregarBtn);
            this.Controls.Add(this.EstadoCB);
            this.Controls.Add(this.PrecioFinalTxt);
            this.Controls.Add(this.MargenGnciaTxt);
            this.Controls.Add(this.IvaTxt);
            this.Controls.Add(this.CostoCITxt);
            this.Controls.Add(this.CostoSITxt);
            this.Controls.Add(this.StockTxt);
            this.Controls.Add(this.DescripcionTxt);
            this.Controls.Add(this.PrecioFinalLbl);
            this.Controls.Add(this.IvaLbl);
            this.Controls.Add(this.MargenGnciaLbl);
            this.Controls.Add(this.CostoCILbl);
            this.Controls.Add(this.CostoSILbl);
            this.Controls.Add(this.EstadoLbl);
            this.Controls.Add(this.StockLbl);
            this.Controls.Add(this.DescripcionLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddProductForm";
            this.Text = "Añadir Producto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddProductForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.bsProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CodigoLbl;
        private System.Windows.Forms.Label DescripcionLbl;
        private System.Windows.Forms.Label StockLbl;
        private System.Windows.Forms.Label EstadoLbl;
        private System.Windows.Forms.Label CostoSILbl;
        private System.Windows.Forms.Label CostoCILbl;
        private System.Windows.Forms.Label MargenGnciaLbl;
        private System.Windows.Forms.Label IvaLbl;
        private System.Windows.Forms.Label PrecioFinalLbl;
        private System.Windows.Forms.TextBox CodigoTxt;
        private System.Windows.Forms.TextBox DescripcionTxt;
        private System.Windows.Forms.TextBox StockTxt;
        private System.Windows.Forms.TextBox CostoSITxt;
        private System.Windows.Forms.TextBox CostoCITxt;
        private System.Windows.Forms.TextBox IvaTxt;
        private System.Windows.Forms.TextBox PrecioFinalTxt;
        private System.Windows.Forms.ComboBox EstadoCB;
        private System.Windows.Forms.TextBox MargenGnciaTxt;
        private System.Windows.Forms.Button AgregarBtn;
        private System.Windows.Forms.BindingSource bsProducto;
        private System.Windows.Forms.Button VolverBtn;
    }
}