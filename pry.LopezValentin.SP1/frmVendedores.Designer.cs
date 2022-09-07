namespace pry.LopezValentin.SP1
{
    partial class frmVendedor
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
            this.lblNombreV = new System.Windows.Forms.Label();
            this.lblNroVendedor = new System.Windows.Forms.Label();
            this.lblBienvenidaV = new System.Windows.Forms.Label();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.mskIDVendedor = new System.Windows.Forms.MaskedTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.chkComision = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cmdCargar
            // 
            this.cmdCargar.Location = new System.Drawing.Point(158, 211);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(75, 23);
            this.cmdCargar.TabIndex = 0;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.UseVisualStyleBackColor = true;
            this.cmdCargar.Click += new System.EventHandler(this.cmdCargar_Click);
            // 
            // lblNombreV
            // 
            this.lblNombreV.AutoSize = true;
            this.lblNombreV.Location = new System.Drawing.Point(14, 67);
            this.lblNombreV.Name = "lblNombreV";
            this.lblNombreV.Size = new System.Drawing.Size(85, 13);
            this.lblNombreV.TabIndex = 2;
            this.lblNombreV.Text = "Ingrese Nombre:";
            // 
            // lblNroVendedor
            // 
            this.lblNroVendedor.AutoSize = true;
            this.lblNroVendedor.Location = new System.Drawing.Point(14, 116);
            this.lblNroVendedor.Name = "lblNroVendedor";
            this.lblNroVendedor.Size = new System.Drawing.Size(79, 13);
            this.lblNroVendedor.TabIndex = 3;
            this.lblNroVendedor.Text = "Ingrese NroID :";
            // 
            // lblBienvenidaV
            // 
            this.lblBienvenidaV.AutoSize = true;
            this.lblBienvenidaV.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenidaV.Location = new System.Drawing.Point(9, 9);
            this.lblBienvenidaV.Name = "lblBienvenidaV";
            this.lblBienvenidaV.Size = new System.Drawing.Size(224, 29);
            this.lblBienvenidaV.TabIndex = 4;
            this.lblBienvenidaV.Text = "Cargar Vendedores";
            // 
            // txtVendedor
            // 
            this.txtVendedor.Location = new System.Drawing.Point(105, 67);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(100, 20);
            this.txtVendedor.TabIndex = 5;
            // 
            // mskIDVendedor
            // 
            this.mskIDVendedor.Location = new System.Drawing.Point(96, 116);
            this.mskIDVendedor.Mask = "999";
            this.mskIDVendedor.Name = "mskIDVendedor";
            this.mskIDVendedor.Size = new System.Drawing.Size(24, 20);
            this.mskIDVendedor.TabIndex = 6;
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Location = new System.Drawing.Point(14, 161);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(56, 17);
            this.chkActivo.TabIndex = 7;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // chkComision
            // 
            this.chkComision.AutoSize = true;
            this.chkComision.Location = new System.Drawing.Point(96, 161);
            this.chkComision.Name = "chkComision";
            this.chkComision.Size = new System.Drawing.Size(68, 17);
            this.chkComision.TabIndex = 8;
            this.chkComision.Text = "Comisión";
            this.chkComision.UseVisualStyleBackColor = true;
            // 
            // frmVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 246);
            this.Controls.Add(this.chkComision);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.mskIDVendedor);
            this.Controls.Add(this.txtVendedor);
            this.Controls.Add(this.lblBienvenidaV);
            this.Controls.Add(this.lblNroVendedor);
            this.Controls.Add(this.lblNombreV);
            this.Controls.Add(this.cmdCargar);
            this.Name = "frmVendedor";
            this.Text = "Cargar Vendedores";
            this.Load += new System.EventHandler(this.frmVendedor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdCargar;
        private System.Windows.Forms.Label lblNombreV;
        private System.Windows.Forms.Label lblNroVendedor;
        private System.Windows.Forms.Label lblBienvenidaV;
        private System.Windows.Forms.TextBox txtVendedor;
        private System.Windows.Forms.MaskedTextBox mskIDVendedor;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.CheckBox chkComision;
    }
}