using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Progra_3
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
            llenarLabelUsuario();
        }

        public void llenarLabelUsuario()
        {
            lblUsuario.Text = ClaseArchivador.username.ToString();
        }

        private void agregarNuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nuevoUsuario frm = new nuevoUsuario();
            frm.ShowDialog();
        }


        private void ingresarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProducto frm = new FrmProducto();
            frm.ShowDialog();
        }

        private void gestionarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestionProducto frm = new FrmGestionProducto();
            frm.ShowDialog();
        }

        private void cerrarAplicaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void ingresarNuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes frmC = new frmClientes();
            frmC.ShowDialog();
        }

        private void gestionarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionClientes frm = new GestionClientes();
            frm.ShowDialog();
        }      
    }
}
