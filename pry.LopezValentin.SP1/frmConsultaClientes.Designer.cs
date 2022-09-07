namespace pry.LopezValentin.SP1
{
    partial class frmConsultaClientes
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
            this.GRLConsultaClientes = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdListar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GRLConsultaClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // GRLConsultaClientes
            // 
            this.GRLConsultaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRLConsultaClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3});
            this.GRLConsultaClientes.Location = new System.Drawing.Point(2, 1);
            this.GRLConsultaClientes.Name = "GRLConsultaClientes";
            this.GRLConsultaClientes.Size = new System.Drawing.Size(244, 259);
            this.GRLConsultaClientes.TabIndex = 0;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ID";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "NOMBRE";
            this.Column3.Name = "Column3";
            // 
            // cmdListar
            // 
            this.cmdListar.Location = new System.Drawing.Point(161, 274);
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Size = new System.Drawing.Size(75, 23);
            this.cmdListar.TabIndex = 1;
            this.cmdListar.Text = "Listar";
            this.cmdListar.UseVisualStyleBackColor = true;
            this.cmdListar.Click += new System.EventHandler(this.cmdListar_Click_1);
            // 
            // frmConsultaClientes
            // 
            this.ClientSize = new System.Drawing.Size(248, 309);
            this.Controls.Add(this.cmdListar);
            this.Controls.Add(this.GRLConsultaClientes);
            this.Name = "frmConsultaClientes";
            this.Text = "Consulta Clientes";
            this.Load += new System.EventHandler(this.frmConsultaClientes_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.GRLConsultaClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GRLClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView GRLConsultaClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button cmdListar;
    }
}