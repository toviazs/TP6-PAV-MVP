
namespace TP6.Vista.Formularios
{
    partial class EditProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProductForm));
            this.EstadoCB = new System.Windows.Forms.ComboBox();
            this.PrecioFinalTxt = new System.Windows.Forms.TextBox();
            this.MargenGnciaTxt = new System.Windows.Forms.TextBox();
            this.IvaTxt = new System.Windows.Forms.TextBox();
            this.CostoCITxt = new System.Windows.Forms.TextBox();
            this.CostoSITxt = new System.Windows.Forms.TextBox();
            this.StockTxt = new System.Windows.Forms.TextBox();
            this.DescripcionTxt = new System.Windows.Forms.TextBox();
            this.CodigoTxt = new System.Windows.Forms.TextBox();
            this.PrecioFinalLbl = new System.Windows.Forms.Label();
            this.IvaLbl = new System.Windows.Forms.Label();
            this.MargenGnciaLbl = new System.Windows.Forms.Label();
            this.CostoCILbl = new System.Windows.Forms.Label();
            this.CostoSILbl = new System.Windows.Forms.Label();
            this.EstadoLbl = new System.Windows.Forms.Label();
            this.StockLbl = new System.Windows.Forms.Label();
            this.DescripcionLbl = new System.Windows.Forms.Label();
            this.CodigoLbl = new System.Windows.Forms.Label();
            this.bsProducto = new System.Windows.Forms.BindingSource(this.components);
            this.ModificarBtn = new System.Windows.Forms.Button();
            this.VolverBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // EstadoCB
            // 
            this.EstadoCB.FormattingEnabled = true;
            this.EstadoCB.Location = new System.Drawing.Point(113, 99);
            this.EstadoCB.Name = "EstadoCB";
            this.EstadoCB.Size = new System.Drawing.Size(100, 23);
            this.EstadoCB.TabIndex = 3;
            // 
            // PrecioFinalTxt
            // 
            this.PrecioFinalTxt.Location = new System.Drawing.Point(113, 244);
            this.PrecioFinalTxt.Name = "PrecioFinalTxt";
            this.PrecioFinalTxt.Size = new System.Drawing.Size(100, 23);
            this.PrecioFinalTxt.TabIndex = 8;
            this.PrecioFinalTxt.Leave += new System.EventHandler(this.PrecioFinalTxt_Leave);
            // 
            // MargenGnciaTxt
            // 
            this.MargenGnciaTxt.Location = new System.Drawing.Point(113, 186);
            this.MargenGnciaTxt.Name = "MargenGnciaTxt";
            this.MargenGnciaTxt.Size = new System.Drawing.Size(100, 23);
            this.MargenGnciaTxt.TabIndex = 6;
            this.MargenGnciaTxt.Leave += new System.EventHandler(this.MargenGnciaTxt_Leave);
            // 
            // IvaTxt
            // 
            this.IvaTxt.Enabled = false;
            this.IvaTxt.Location = new System.Drawing.Point(113, 215);
            this.IvaTxt.Name = "IvaTxt";
            this.IvaTxt.Size = new System.Drawing.Size(100, 23);
            this.IvaTxt.TabIndex = 7;
            // 
            // CostoCITxt
            // 
            this.CostoCITxt.Enabled = false;
            this.CostoCITxt.Location = new System.Drawing.Point(113, 157);
            this.CostoCITxt.Name = "CostoCITxt";
            this.CostoCITxt.Size = new System.Drawing.Size(100, 23);
            this.CostoCITxt.TabIndex = 5;
            // 
            // CostoSITxt
            // 
            this.CostoSITxt.Location = new System.Drawing.Point(113, 128);
            this.CostoSITxt.Name = "CostoSITxt";
            this.CostoSITxt.Size = new System.Drawing.Size(100, 23);
            this.CostoSITxt.TabIndex = 4;
            this.CostoSITxt.Leave += new System.EventHandler(this.CostoSITxt_Leave);
            // 
            // StockTxt
            // 
            this.StockTxt.Location = new System.Drawing.Point(113, 70);
            this.StockTxt.Name = "StockTxt";
            this.StockTxt.Size = new System.Drawing.Size(100, 23);
            this.StockTxt.TabIndex = 2;
            // 
            // DescripcionTxt
            // 
            this.DescripcionTxt.Location = new System.Drawing.Point(113, 41);
            this.DescripcionTxt.Name = "DescripcionTxt";
            this.DescripcionTxt.Size = new System.Drawing.Size(100, 23);
            this.DescripcionTxt.TabIndex = 1;
            // 
            // CodigoTxt
            // 
            this.CodigoTxt.Location = new System.Drawing.Point(113, 12);
            this.CodigoTxt.Name = "CodigoTxt";
            this.CodigoTxt.Size = new System.Drawing.Size(100, 23);
            this.CodigoTxt.TabIndex = 0;
            // 
            // PrecioFinalLbl
            // 
            this.PrecioFinalLbl.AutoSize = true;
            this.PrecioFinalLbl.Location = new System.Drawing.Point(41, 247);
            this.PrecioFinalLbl.Name = "PrecioFinalLbl";
            this.PrecioFinalLbl.Size = new System.Drawing.Size(66, 15);
            this.PrecioFinalLbl.TabIndex = 19;
            this.PrecioFinalLbl.Text = "Precio final";
            // 
            // IvaLbl
            // 
            this.IvaLbl.AutoSize = true;
            this.IvaLbl.Location = new System.Drawing.Point(83, 218);
            this.IvaLbl.Name = "IvaLbl";
            this.IvaLbl.Size = new System.Drawing.Size(24, 15);
            this.IvaLbl.TabIndex = 18;
            this.IvaLbl.Text = "IVA";
            // 
            // MargenGnciaLbl
            // 
            this.MargenGnciaLbl.AutoSize = true;
            this.MargenGnciaLbl.Location = new System.Drawing.Point(8, 189);
            this.MargenGnciaLbl.Name = "MargenGnciaLbl";
            this.MargenGnciaLbl.Size = new System.Drawing.Size(99, 15);
            this.MargenGnciaLbl.TabIndex = 17;
            this.MargenGnciaLbl.Text = "Margen ganancia";
            // 
            // CostoCILbl
            // 
            this.CostoCILbl.AutoSize = true;
            this.CostoCILbl.Location = new System.Drawing.Point(38, 160);
            this.CostoCILbl.Name = "CostoCILbl";
            this.CostoCILbl.Size = new System.Drawing.Size(69, 15);
            this.CostoCILbl.TabIndex = 16;
            this.CostoCILbl.Text = "Costo c/IVA";
            // 
            // CostoSILbl
            // 
            this.CostoSILbl.AutoSize = true;
            this.CostoSILbl.Location = new System.Drawing.Point(39, 131);
            this.CostoSILbl.Name = "CostoSILbl";
            this.CostoSILbl.Size = new System.Drawing.Size(68, 15);
            this.CostoSILbl.TabIndex = 15;
            this.CostoSILbl.Text = "Costo s/IVA";
            // 
            // EstadoLbl
            // 
            this.EstadoLbl.AutoSize = true;
            this.EstadoLbl.Location = new System.Drawing.Point(65, 102);
            this.EstadoLbl.Name = "EstadoLbl";
            this.EstadoLbl.Size = new System.Drawing.Size(42, 15);
            this.EstadoLbl.TabIndex = 14;
            this.EstadoLbl.Text = "Estado";
            // 
            // StockLbl
            // 
            this.StockLbl.AutoSize = true;
            this.StockLbl.Location = new System.Drawing.Point(71, 73);
            this.StockLbl.Name = "StockLbl";
            this.StockLbl.Size = new System.Drawing.Size(36, 15);
            this.StockLbl.TabIndex = 13;
            this.StockLbl.Text = "Stock";
            // 
            // DescripcionLbl
            // 
            this.DescripcionLbl.AutoSize = true;
            this.DescripcionLbl.Location = new System.Drawing.Point(38, 44);
            this.DescripcionLbl.Name = "DescripcionLbl";
            this.DescripcionLbl.Size = new System.Drawing.Size(69, 15);
            this.DescripcionLbl.TabIndex = 12;
            this.DescripcionLbl.Text = "Descripción";
            // 
            // CodigoLbl
            // 
            this.CodigoLbl.AutoSize = true;
            this.CodigoLbl.Location = new System.Drawing.Point(61, 15);
            this.CodigoLbl.Name = "CodigoLbl";
            this.CodigoLbl.Size = new System.Drawing.Size(46, 15);
            this.CodigoLbl.TabIndex = 11;
            this.CodigoLbl.Text = "Código";
            // 
            // ModificarBtn
            // 
            this.ModificarBtn.Location = new System.Drawing.Point(138, 281);
            this.ModificarBtn.Name = "ModificarBtn";
            this.ModificarBtn.Size = new System.Drawing.Size(75, 23);
            this.ModificarBtn.TabIndex = 29;
            this.ModificarBtn.Text = "Modificar";
            this.ModificarBtn.UseVisualStyleBackColor = true;
            this.ModificarBtn.Click += new System.EventHandler(this.ModificarBtn_Click);
            // 
            // VolverBtn
            // 
            this.VolverBtn.Location = new System.Drawing.Point(12, 281);
            this.VolverBtn.Name = "VolverBtn";
            this.VolverBtn.Size = new System.Drawing.Size(75, 23);
            this.VolverBtn.TabIndex = 30;
            this.VolverBtn.Text = "Volver";
            this.VolverBtn.UseVisualStyleBackColor = true;
            this.VolverBtn.Click += new System.EventHandler(this.VolverBtn_Click);
            // 
            // EditProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 310);
            this.Controls.Add(this.VolverBtn);
            this.Controls.Add(this.ModificarBtn);
            this.Controls.Add(this.EstadoCB);
            this.Controls.Add(this.PrecioFinalTxt);
            this.Controls.Add(this.MargenGnciaTxt);
            this.Controls.Add(this.IvaTxt);
            this.Controls.Add(this.CostoCITxt);
            this.Controls.Add(this.CostoSITxt);
            this.Controls.Add(this.StockTxt);
            this.Controls.Add(this.DescripcionTxt);
            this.Controls.Add(this.CodigoTxt);
            this.Controls.Add(this.PrecioFinalLbl);
            this.Controls.Add(this.IvaLbl);
            this.Controls.Add(this.MargenGnciaLbl);
            this.Controls.Add(this.CostoCILbl);
            this.Controls.Add(this.CostoSILbl);
            this.Controls.Add(this.EstadoLbl);
            this.Controls.Add(this.StockLbl);
            this.Controls.Add(this.DescripcionLbl);
            this.Controls.Add(this.CodigoLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditProductForm";
            this.Text = "Editar Producto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditProductForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.bsProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox EstadoCB;
        private System.Windows.Forms.TextBox PrecioFinalTxt;
        private System.Windows.Forms.TextBox MargenGnciaTxt;
        private System.Windows.Forms.TextBox IvaTxt;
        private System.Windows.Forms.TextBox CostoCITxt;
        private System.Windows.Forms.TextBox CostoSITxt;
        private System.Windows.Forms.TextBox StockTxt;
        private System.Windows.Forms.TextBox DescripcionTxt;
        private System.Windows.Forms.TextBox CodigoTxt;
        private System.Windows.Forms.Label PrecioFinalLbl;
        private System.Windows.Forms.Label IvaLbl;
        private System.Windows.Forms.Label MargenGnciaLbl;
        private System.Windows.Forms.Label CostoCILbl;
        private System.Windows.Forms.Label CostoSILbl;
        private System.Windows.Forms.Label EstadoLbl;
        private System.Windows.Forms.Label StockLbl;
        private System.Windows.Forms.Label DescripcionLbl;
        private System.Windows.Forms.Label CodigoLbl;
        private System.Windows.Forms.BindingSource bsProducto;
        private System.Windows.Forms.Button ModificarBtn;
        private System.Windows.Forms.Button VolverBtn;
    }
}