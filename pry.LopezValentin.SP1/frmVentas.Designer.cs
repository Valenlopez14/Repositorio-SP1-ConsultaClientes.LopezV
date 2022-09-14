namespace pry.LopezValentin.SP1
{
    partial class frmVentas
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
            this.cmdCargar = new System.Windows.Forms.Button();
            this.lstTipoFactura = new System.Windows.Forms.ComboBox();
            this.lblTipoFactura = new System.Windows.Forms.Label();
            this.lblNumeroFactura = new System.Windows.Forms.Label();
            this.mskNroFac = new System.Windows.Forms.MaskedTextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.DTPFecha = new System.Windows.Forms.DateTimePicker();
            this.lblClienteID = new System.Windows.Forms.Label();
            this.mskIDCliente = new System.Windows.Forms.MaskedTextBox();
            this.mskIdVendedor = new System.Windows.Forms.MaskedTextBox();
            this.lblVendedorID = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdCargar
            // 
            this.cmdCargar.Location = new System.Drawing.Point(168, 264);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(75, 23);
            this.cmdCargar.TabIndex = 0;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.UseVisualStyleBackColor = true;
            this.cmdCargar.Click += new System.EventHandler(this.cmdCargar_Click);
            // 
            // lstTipoFactura
            // 
            this.lstTipoFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstTipoFactura.FormattingEnabled = true;
            this.lstTipoFactura.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.lstTipoFactura.Location = new System.Drawing.Point(103, 52);
            this.lstTipoFactura.Name = "lstTipoFactura";
            this.lstTipoFactura.Size = new System.Drawing.Size(40, 21);
            this.lstTipoFactura.TabIndex = 1;
            // 
            // lblTipoFactura
            // 
            this.lblTipoFactura.AutoSize = true;
            this.lblTipoFactura.Location = new System.Drawing.Point(12, 55);
            this.lblTipoFactura.Name = "lblTipoFactura";
            this.lblTipoFactura.Size = new System.Drawing.Size(85, 13);
            this.lblTipoFactura.TabIndex = 2;
            this.lblTipoFactura.Text = "Tipo de Factura:";
            // 
            // lblNumeroFactura
            // 
            this.lblNumeroFactura.AutoSize = true;
            this.lblNumeroFactura.Location = new System.Drawing.Point(12, 92);
            this.lblNumeroFactura.Name = "lblNumeroFactura";
            this.lblNumeroFactura.Size = new System.Drawing.Size(95, 13);
            this.lblNumeroFactura.TabIndex = 3;
            this.lblNumeroFactura.Text = "Numero de Fatura:";
            // 
            // mskNroFac
            // 
            this.mskNroFac.Location = new System.Drawing.Point(113, 92);
            this.mskNroFac.Mask = "A-999-9";
            this.mskNroFac.Name = "mskNroFac";
            this.mskNroFac.Size = new System.Drawing.Size(42, 20);
            this.mskNroFac.TabIndex = 4;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(12, 125);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(94, 13);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "Fecha de Emision:";
            // 
            // DTPFecha
            // 
            this.DTPFecha.Location = new System.Drawing.Point(112, 125);
            this.DTPFecha.Name = "DTPFecha";
            this.DTPFecha.Size = new System.Drawing.Size(115, 20);
            this.DTPFecha.TabIndex = 6;
            // 
            // lblClienteID
            // 
            this.lblClienteID.AutoSize = true;
            this.lblClienteID.Location = new System.Drawing.Point(12, 160);
            this.lblClienteID.Name = "lblClienteID";
            this.lblClienteID.Size = new System.Drawing.Size(71, 13);
            this.lblClienteID.TabIndex = 7;
            this.lblClienteID.Text = "ID de Cliente:";
            // 
            // mskIDCliente
            // 
            this.mskIDCliente.Location = new System.Drawing.Point(89, 157);
            this.mskIDCliente.Mask = "9-99";
            this.mskIDCliente.Name = "mskIDCliente";
            this.mskIDCliente.Size = new System.Drawing.Size(29, 20);
            this.mskIDCliente.TabIndex = 8;
            // 
            // mskIdVendedor
            // 
            this.mskIdVendedor.Location = new System.Drawing.Point(103, 199);
            this.mskIdVendedor.Name = "mskIdVendedor";
            this.mskIdVendedor.Size = new System.Drawing.Size(29, 20);
            this.mskIdVendedor.TabIndex = 9;
            // 
            // lblVendedorID
            // 
            this.lblVendedorID.AutoSize = true;
            this.lblVendedorID.Location = new System.Drawing.Point(12, 199);
            this.lblVendedorID.Name = "lblVendedorID";
            this.lblVendedorID.Size = new System.Drawing.Size(85, 13);
            this.lblVendedorID.TabIndex = 10;
            this.lblVendedorID.Text = "ID de Vendedor:";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(12, 236);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(40, 13);
            this.lblMonto.TabIndex = 11;
            this.lblMonto.Text = "Monto:";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(58, 233);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(38, 20);
            this.txtMonto.TabIndex = 12;
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.Location = new System.Drawing.Point(36, 9);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(191, 29);
            this.lblBienvenida.TabIndex = 13;
            this.lblBienvenida.Text = "Carga de Ventas";
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 299);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblVendedorID);
            this.Controls.Add(this.mskIdVendedor);
            this.Controls.Add(this.mskIDCliente);
            this.Controls.Add(this.lblClienteID);
            this.Controls.Add(this.DTPFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.mskNroFac);
            this.Controls.Add(this.lblNumeroFactura);
            this.Controls.Add(this.lblTipoFactura);
            this.Controls.Add(this.lstTipoFactura);
            this.Controls.Add(this.cmdCargar);
            this.Name = "frmVentas";
            this.Tag = "$";
            this.Text = "Ventas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdCargar;
        private System.Windows.Forms.ComboBox lstTipoFactura;
        private System.Windows.Forms.Label lblTipoFactura;
        private System.Windows.Forms.Label lblNumeroFactura;
        private System.Windows.Forms.MaskedTextBox mskNroFac;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker DTPFecha;
        private System.Windows.Forms.Label lblClienteID;
        private System.Windows.Forms.MaskedTextBox mskIDCliente;
        private System.Windows.Forms.MaskedTextBox mskIdVendedor;
        private System.Windows.Forms.Label lblVendedorID;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblBienvenida;
    }
}