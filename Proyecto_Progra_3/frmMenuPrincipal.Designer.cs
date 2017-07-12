namespace Proyecto_Progra_3
{
    partial class frmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarNuevoUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarAplicaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarNuevoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.productosToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(617, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarNuevoUsuarioToolStripMenuItem,
            this.cerrarAplicaciónToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // agregarNuevoUsuarioToolStripMenuItem
            // 
            this.agregarNuevoUsuarioToolStripMenuItem.Name = "agregarNuevoUsuarioToolStripMenuItem";
            this.agregarNuevoUsuarioToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.agregarNuevoUsuarioToolStripMenuItem.Text = "Agregar Nuevo Usuario";
            this.agregarNuevoUsuarioToolStripMenuItem.Click += new System.EventHandler(this.agregarNuevoUsuarioToolStripMenuItem_Click);
            // 
            // cerrarAplicaciónToolStripMenuItem
            // 
            this.cerrarAplicaciónToolStripMenuItem.Name = "cerrarAplicaciónToolStripMenuItem";
            this.cerrarAplicaciónToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.cerrarAplicaciónToolStripMenuItem.Text = "Cerrar Aplicación";
            this.cerrarAplicaciónToolStripMenuItem.Click += new System.EventHandler(this.cerrarAplicaciónToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarNuevoClienteToolStripMenuItem,
            this.gestionarClientesToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // ingresarNuevoClienteToolStripMenuItem
            // 
            this.ingresarNuevoClienteToolStripMenuItem.Name = "ingresarNuevoClienteToolStripMenuItem";
            this.ingresarNuevoClienteToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.ingresarNuevoClienteToolStripMenuItem.Text = " Nuevo Cliente/Proveedor";
            this.ingresarNuevoClienteToolStripMenuItem.Click += new System.EventHandler(this.ingresarNuevoClienteToolStripMenuItem_Click);
            // 
            // gestionarClientesToolStripMenuItem
            // 
            this.gestionarClientesToolStripMenuItem.Name = "gestionarClientesToolStripMenuItem";
            this.gestionarClientesToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.gestionarClientesToolStripMenuItem.Text = "Gestionar Clientes/Proveedor";
            this.gestionarClientesToolStripMenuItem.Click += new System.EventHandler(this.gestionarClientesToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarProductoToolStripMenuItem,
            this.gestionarProductoToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // ingresarProductoToolStripMenuItem
            // 
            this.ingresarProductoToolStripMenuItem.Name = "ingresarProductoToolStripMenuItem";
            this.ingresarProductoToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.ingresarProductoToolStripMenuItem.Text = "Ingresar Producto";
            this.ingresarProductoToolStripMenuItem.Click += new System.EventHandler(this.ingresarProductoToolStripMenuItem_Click);
            // 
            // gestionarProductoToolStripMenuItem
            // 
            this.gestionarProductoToolStripMenuItem.Name = "gestionarProductoToolStripMenuItem";
            this.gestionarProductoToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.gestionarProductoToolStripMenuItem.Text = "Gestionar Producto";
            this.gestionarProductoToolStripMenuItem.Click += new System.EventHandler(this.gestionarProductoToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(442, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bienvenido";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(519, 236);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(16, 13);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "...";
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 261);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ToolStripMenuItem agregarNuevoUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarAplicaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarNuevoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarClientesToolStripMenuItem;
    }
}