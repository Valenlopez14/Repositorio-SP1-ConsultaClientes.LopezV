﻿namespace pry.LopezValentin.SP1
{
    partial class frmClientes
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
            this.lblNombreC = new System.Windows.Forms.Label();
            this.lblNroC = new System.Windows.Forms.Label();
            this.txtNombreC = new System.Windows.Forms.TextBox();
            this.mskNroClientes = new System.Windows.Forms.MaskedTextBox();
            this.lblBienvenidaC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdCargar
            // 
            this.cmdCargar.Location = new System.Drawing.Point(309, 163);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(75, 23);
            this.cmdCargar.TabIndex = 0;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.UseVisualStyleBackColor = true;
            this.cmdCargar.Click += new System.EventHandler(this.cmdCargar_Click);
            // 
            // lblNombreC
            // 
            this.lblNombreC.AutoSize = true;
            this.lblNombreC.Location = new System.Drawing.Point(12, 66);
            this.lblNombreC.Name = "lblNombreC";
            this.lblNombreC.Size = new System.Drawing.Size(120, 13);
            this.lblNombreC.TabIndex = 2;
            this.lblNombreC.Text = "Ingrese Nombre Cliente:";
            // 
            // lblNroC
            // 
            this.lblNroC.AutoSize = true;
            this.lblNroC.Location = new System.Drawing.Point(12, 114);
            this.lblNroC.Name = "lblNroC";
            this.lblNroC.Size = new System.Drawing.Size(100, 13);
            this.lblNroC.TabIndex = 3;
            this.lblNroC.Text = "Ingrese Nro Cliente:";
            // 
            // txtNombreC
            // 
            this.txtNombreC.Location = new System.Drawing.Point(138, 63);
            this.txtNombreC.Name = "txtNombreC";
            this.txtNombreC.Size = new System.Drawing.Size(100, 20);
            this.txtNombreC.TabIndex = 4;
            // 
            // mskNroClientes
            // 
            this.mskNroClientes.Location = new System.Drawing.Point(118, 111);
            this.mskNroClientes.Mask = "9-99";
            this.mskNroClientes.Name = "mskNroClientes";
            this.mskNroClientes.Size = new System.Drawing.Size(27, 20);
            this.mskNroClientes.TabIndex = 5;
            // 
            // lblBienvenidaC
            // 
            this.lblBienvenidaC.AutoSize = true;
            this.lblBienvenidaC.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenidaC.Location = new System.Drawing.Point(87, 9);
            this.lblBienvenidaC.Name = "lblBienvenidaC";
            this.lblBienvenidaC.Size = new System.Drawing.Size(206, 29);
            this.lblBienvenidaC.TabIndex = 6;
            this.lblBienvenidaC.Text = "Carga de Clientes";
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 198);
            this.Controls.Add(this.lblBienvenidaC);
            this.Controls.Add(this.mskNroClientes);
            this.Controls.Add(this.txtNombreC);
            this.Controls.Add(this.lblNroC);
            this.Controls.Add(this.lblNombreC);
            this.Controls.Add(this.cmdCargar);
            this.Name = "frmClientes";
            this.Text = "Cargar Clientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdCargar;
        private System.Windows.Forms.Label lblNombreC;
        private System.Windows.Forms.Label lblNroC;
        private System.Windows.Forms.TextBox txtNombreC;
        private System.Windows.Forms.MaskedTextBox mskNroClientes;
        private System.Windows.Forms.Label lblBienvenidaC;
    }
}