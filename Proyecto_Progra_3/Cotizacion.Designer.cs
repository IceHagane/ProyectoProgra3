namespace Proyecto_Progra_3
{
    partial class Cotizacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cotizacion));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.cboEntidad = new System.Windows.Forms.ComboBox();
            this.cmdBuscar1 = new System.Windows.Forms.Button();
            this.cmdBuscar2 = new System.Windows.Forms.Button();
            this.dgvCotiszacion = new System.Windows.Forms.DataGridView();
            this.cod_prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_entidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_entidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCotiszacion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Entidad";
            // 
            // cboProducto
            // 
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Location = new System.Drawing.Point(117, 35);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(121, 21);
            this.cboProducto.TabIndex = 3;
            // 
            // cboEntidad
            // 
            this.cboEntidad.FormattingEnabled = true;
            this.cboEntidad.Location = new System.Drawing.Point(385, 35);
            this.cboEntidad.Name = "cboEntidad";
            this.cboEntidad.Size = new System.Drawing.Size(121, 21);
            this.cboEntidad.TabIndex = 4;
            // 
            // cmdBuscar1
            // 
            this.cmdBuscar1.Location = new System.Drawing.Point(244, 34);
            this.cmdBuscar1.Name = "cmdBuscar1";
            this.cmdBuscar1.Size = new System.Drawing.Size(75, 23);
            this.cmdBuscar1.TabIndex = 6;
            this.cmdBuscar1.Text = "Buscar";
            this.cmdBuscar1.UseVisualStyleBackColor = true;
            this.cmdBuscar1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmdBuscar1_MouseClick);
            // 
            // cmdBuscar2
            // 
            this.cmdBuscar2.Location = new System.Drawing.Point(512, 35);
            this.cmdBuscar2.Name = "cmdBuscar2";
            this.cmdBuscar2.Size = new System.Drawing.Size(75, 23);
            this.cmdBuscar2.TabIndex = 7;
            this.cmdBuscar2.Text = "Buscar";
            this.cmdBuscar2.UseVisualStyleBackColor = true;
            this.cmdBuscar2.Click += new System.EventHandler(this.cmdBuscar2_Click);
            // 
            // dgvCotiszacion
            // 
            this.dgvCotiszacion.AllowUserToAddRows = false;
            this.dgvCotiszacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCotiszacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_prod,
            this.nom_prod,
            this.precio_producto,
            this.stock_producto,
            this.Id_entidad,
            this.nom_entidad});
            this.dgvCotiszacion.Location = new System.Drawing.Point(17, 99);
            this.dgvCotiszacion.Name = "dgvCotiszacion";
            this.dgvCotiszacion.ReadOnly = true;
            this.dgvCotiszacion.Size = new System.Drawing.Size(644, 150);
            this.dgvCotiszacion.TabIndex = 27;
            // 
            // cod_prod
            // 
            this.cod_prod.HeaderText = "Codigo Producto";
            this.cod_prod.Name = "cod_prod";
            this.cod_prod.ReadOnly = true;
            // 
            // nom_prod
            // 
            this.nom_prod.HeaderText = "Nombre Producto";
            this.nom_prod.Name = "nom_prod";
            this.nom_prod.ReadOnly = true;
            // 
            // precio_producto
            // 
            this.precio_producto.HeaderText = "Precio";
            this.precio_producto.Name = "precio_producto";
            this.precio_producto.ReadOnly = true;
            // 
            // stock_producto
            // 
            this.stock_producto.HeaderText = "Stock";
            this.stock_producto.Name = "stock_producto";
            this.stock_producto.ReadOnly = true;
            // 
            // Id_entidad
            // 
            this.Id_entidad.HeaderText = "ID Entidad";
            this.Id_entidad.Name = "Id_entidad";
            this.Id_entidad.ReadOnly = true;
            // 
            // nom_entidad
            // 
            this.nom_entidad.HeaderText = "Nombre Entidad";
            this.nom_entidad.Name = "nom_entidad";
            this.nom_entidad.ReadOnly = true;
            // 
            // Cotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 261);
            this.Controls.Add(this.dgvCotiszacion);
            this.Controls.Add(this.cmdBuscar2);
            this.Controls.Add(this.cmdBuscar1);
            this.Controls.Add(this.cboEntidad);
            this.Controls.Add(this.cboProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Cotizacion";
            this.Text = "Cotizacion";
            this.Load += new System.EventHandler(this.Cotizacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCotiszacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.ComboBox cboEntidad;
        private System.Windows.Forms.Button cmdBuscar1;
        private System.Windows.Forms.Button cmdBuscar2;
        private System.Windows.Forms.DataGridView dgvCotiszacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_entidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_entidad;
    }
}