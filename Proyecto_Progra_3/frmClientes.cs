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
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            cboRazon.SelectedIndex = -1;
            mskdgv.Text = "";
            txtIDE.Text = "";
            cboCiudad.SelectedIndex = -1;
            cboComuna.SelectedIndex = -1;
            cboEntidad.SelectedIndex = -1;
        }

        private void mskRUT_Leave(object sender, EventArgs e)
        {
            ClaseRUT auxR = new ClaseRUT();
            this.mskRUT.Text = auxR.formatear(this.mskRUT.Text);
        }

        private void frmClientes_Load_1(object sender, EventArgs e)
        {
            String CadSql;
            CadSql = "select des_ciudad, cod_ciudad from ciudades ";
            Subrrutinas.llenarCombobox(cboCiudad, CadSql, "des_ciudad", "cod_ciudad");
            CadSql = "select des_comuna, cod_comuna from comunas";
            Subrrutinas.llenarCombobox(cboComuna, CadSql, "des_comuna", "cod_comuna");
            CadSql = "SELECT des_tipo,id_tipo from tipo_entidades;";
            Subrrutinas.llenarCombobox(cboEntidad, CadSql, "des_tipo", "id_tipo");
            CadSql = "Select razon_social, id_razon from razon_social";
            Subrrutinas.llenarCombobox(cboRazon, CadSql, "razon_social", "id_razon");
        }

        private void cmdLimpiar_MouseClick_1(object sender, MouseEventArgs e)
        {
            limpiar();
        }

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            if (txtIDE.Text.Length >= 1 && txtNombre.Text.Length >= 1 && txtDireccion.Text.Length >= 1 && txtEmail.Text.Length >= 1 
                && txtNumero.Text.Length >= 1 && txtTelefono.Text.Length >= 1 && cboCiudad.SelectedIndex != -1 && cboComuna.SelectedIndex != -1 
                && cboEntidad.SelectedIndex != -1 && cboRazon.SelectedIndex != -1)
            {
                string Entidad;
                Entidad = "insert into datos_entidades (id_ent ,rut_ent, dgv, nom_ent, telefono_ent, email_ent, id_tipo, id_razon) values ( '" + txtIDE.Text + "','" + mskRUT.Text + "', '" + mskdgv.Text + "', '" + txtNombre.Text + "', '" + txtTelefono.Text + "','" + txtEmail.Text + "', " + cboEntidad.SelectedValue + ", " + cboRazon.SelectedValue + ")";
                string Direccion;
                Direccion = "insert into direcciones (direccion, num_direccion, cod_ciudad, cod_comuna, id_ent) values ('" + txtDireccion.Text + "', '" + txtNumero.Text + "', '" + cboCiudad.SelectedValue + "', '" + cboComuna.SelectedValue + "','" + txtIDE.Text + "' )";

                if (con.EjecutarIUD(Entidad) > 0 && con.EjecutarIUD(Direccion) > 0)
                {
                    MessageBox.Show("Entidad Ingrsada con Exito", "Listo");
                    limpiar();
                }
                else
                {
                    MessageBox.Show("Error al tratar de Ingresar una entidad", "ERROR");
                }
            }
            else
            {
                MessageBox.Show("Hay campos vacios, por favor revise y rellene todos los campos", "ERROR");
            }
        }


        private void txtIDE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '\b')
            {
                e.KeyChar = Convert.ToChar(0);
            }
        }

        private void txtTelefono_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '\b')
            {
                e.KeyChar = Convert.ToChar(0);
            }
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void mskdgv_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Email = txtEmail.Text;
            ClaseRUT Clase = new ClaseRUT();
            Clase.valida_Email(Email);            
        }
    }
}
