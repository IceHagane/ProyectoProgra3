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
            this.txtNombre.Text = "";
            this.txtEmail.Text = "";
            this.txtNumero.Text = "";
            this.mskRUT.Text = "";
            this.mskTelefono.Text = "";
            this.txtDireccion.Text = "";
            this.txtGiro.Text = "";
            cboCiudad.SelectedIndex = -1;
            cboComuna.SelectedIndex = -1;
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            String CadSql;
            CadSql = "select des_ciudad, cod_ciudad from ciudades ";
            Subrrutinas.llenarCombobox(cboCiudad, CadSql, "des_ciudad", "cod_ciudad");
            CadSql = "select des_comuna, cod_comuna from comunas";
            Subrrutinas.llenarCombobox(cboComuna, CadSql, "des_comuna", "cod_comuna"); 
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }

            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.KeyChar = Convert.ToChar(0);
            }
        }

        private void mskRUT_Leave(object sender, EventArgs e)
        {
            ClaseRUT auxR = new ClaseRUT();
            this.mskRUT.Text = auxR.formatear(this.mskRUT.Text);
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            
         
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
        
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

        private void cmdLimpiar_MouseClick(object sender, MouseEventArgs e)
        {
            limpiar();
        }

        private void cboCiudad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            String COD;
            COD = "Select id_ent from ciudades where cod_ciudad ='" + cboCiudad.SelectedItem.ToString() + "';";
            try
            {
                con.EjecutarConsulta(COD);
                while (con.Rec.Read())
                {
                    Ciudades.cod_ciudad = Convert.ToInt32(con.Rec["cod_ciudad"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con.Rec != null)
                {
                    con.CerrarConexion();
                    con.Rec = null;
                }
            }
        }

        private void cboComuna_SelectionChangeCommitted(object sender, EventArgs e)
        {
            String COD;
            COD = "Select id_ent from comuna where cod_comuna ='" + cboCiudad.SelectedItem.ToString() + "';";
            try
            {
                con.EjecutarConsulta(COD);
                while (con.Rec.Read())
                {
                    Comuna.cod_comuna = Convert.ToInt32(con.Rec["cod_comuna"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con.Rec != null)
                {
                    con.CerrarConexion();
                    con.Rec = null;
                }
            }
        }

        private void cmdRegistrar_MouseClick(object sender, MouseEventArgs e)
        {
            
            

        }
    }
}
