using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
using System.Text.RegularExpressions;

namespace Proyecto_Progra_3
{
    public partial class frmClientes : Form
    {

        Conexion con = new Conexion();

        public frmClientes()
        {
            InitializeComponent();
        }

        public void limpiar() 
        {
            txtNombre.Text = "";
            txtEmail.Text = "";
            txtNumero.Text = "";
            mskRUT.Text = "";
            mskTelefono.Text = "";
            txtDireccion.Text = "";
            txtGiro.Text = "";
            mskdgv.Text = "";
            cboCiudad.SelectedIndex = -1;
            cboComuna.SelectedIndex = -1;
        }




        private void mskRUT_Leave(object sender, EventArgs e)
        {
            ClaseRUT auxR = new ClaseRUT();
            this.mskRUT.Text = auxR.formatear(this.mskRUT.Text);
        }

    

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

   

        private void txtGiro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void mskTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

 

        private void frmClientes_Load_1(object sender, EventArgs e)
        {
            String CadSql;
            CadSql = "select des_ciudad, cod_ciudad from ciudades ";
            Subrrutinas.llenarCombobox(cboCiudad, CadSql, "des_ciudad", "cod_ciudad");
            CadSql = "select des_comuna, cod_comuna from comunas";
            Subrrutinas.llenarCombobox(cboComuna, CadSql, "des_comuna", "cod_comuna");
            CadSql = "SELECT des_tipo,id_tipo from tipo_entidades;";
            Subrrutinas.llenarCombobox(cbxEntidad, CadSql, "des_tipo", "id_tipo");
        }

        private void cmdLimpiar_MouseClick_1(object sender, MouseEventArgs e)
        {
            limpiar();
        }

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {

        }
    }
}
