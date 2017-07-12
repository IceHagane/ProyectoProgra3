using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Proyecto_Progra_3
{
    public partial class GestionClientes : Form
    {
        public GestionClientes()
        {
            InitializeComponent();
            llenarDgv();
        }

        private void GestionClientes_Load(object sender, EventArgs e)
        {
            String CadSql;
            CadSql = "select des_ciudad, cod_ciudad from ciudades ";
            Subrrutinas.llenarCombobox(cboCiudad, CadSql, "des_ciudad", "cod_ciudad");
            CadSql = "select des_comuna, cod_comuna from comunas";
            Subrrutinas.llenarCombobox(cboComuna, CadSql, "des_comuna", "cod_comuna");
            CadSql = "SELECT des_tipo,id_tipo from tipo_entidades;";
            Subrrutinas.llenarCombobox(cboTipo, CadSql, "des_tipo", "id_tipo");
            CadSql = "Select razon_social, id_razon from razon_social";
            Subrrutinas.llenarCombobox(cboRazon, CadSql, "razon_social", "id_razon");
        }
        private void limpiar()
        {
            txtDireccion.Text = "";
            txtEmail.Text = "";
            txtEntidad.Text = "";
            txtIDD.Text = "";
            txtNombre.Text = "";
            txtNumeroD.Text = "";
            txtTelefono.Text = "";
            cboCiudad.SelectedIndex = -1;
            cboComuna.SelectedIndex = -1;
            cboRazon.SelectedIndex = -1;
            cboTipo.SelectedIndex = -1;
            cboCiudad.Text = "";
            cboComuna.Text = "";
            cboRazon.Text = "";
            cboTipo.Text = "";
            mskDgv.Text = "";
            mskRut.Text = "";
            txtIDD.Enabled = true;
            txtEntidad.Enabled = true;
            dgvGestion.Enabled = true;
        }
        private void llenarDgv()
        {
            string CadSql;
            CadSql = "select e.id_ent, e.nom_ent, e.rut_ent, e.dgv, e.telefono_ent, e.email_ent, t.des_tipo, r.razon_social, d.id_direccion, d.direccion, d.num_direccion, c.des_ciudad, o.des_comuna from datos_entidades e, tipo_entidades t, razon_social r, direcciones d, ciudades c, comunas o where e.id_tipo = t.id_tipo and e.id_razon = r.id_razon and d.cod_ciudad = c.cod_ciudad and d.cod_comuna = o.cod_comuna and e.id_ent = d.id_ent";

            Conexion con = new Conexion();
            int fila;
            MySqlDataReader Rec = null;
            try
            {
                con.AbrirConexion();
                Rec = con.EjecutarConsulta(CadSql);
                dgvGestion.RowCount = 0;
                while (Rec.Read())
                {
                    dgvGestion.RowCount = dgvGestion.RowCount + 1;
                    fila = dgvGestion.RowCount - 1;
                    dgvGestion.Rows[fila].Cells[0].Value = Rec["id_ent"].ToString();
                    dgvGestion.Rows[fila].Cells[1].Value = Rec["nom_ent"].ToString();
                    dgvGestion.Rows[fila].Cells[2].Value = Rec["rut_ent"].ToString();
                    dgvGestion.Rows[fila].Cells[3].Value = Rec["dgv"].ToString();
                    dgvGestion.Rows[fila].Cells[4].Value = Rec["telefono_ent"].ToString();
                    dgvGestion.Rows[fila].Cells[5].Value = Rec["email_ent"].ToString();
                    dgvGestion.Rows[fila].Cells[6].Value = Rec["des_tipo"].ToString();
                    dgvGestion.Rows[fila].Cells[7].Value = Rec["razon_social"].ToString();
                    dgvGestion.Rows[fila].Cells[8].Value = Rec["id_direccion"].ToString();
                    dgvGestion.Rows[fila].Cells[9].Value = Rec["direccion"].ToString();
                    dgvGestion.Rows[fila].Cells[10].Value = Rec["num_direccion"].ToString();
                    dgvGestion.Rows[fila].Cells[11].Value = Rec["des_ciudad"].ToString();
                    dgvGestion.Rows[fila].Cells[12].Value = Rec["des_comuna"].ToString();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                if (Rec != null)
                {
                    Rec.Close();
                    Rec = null;
                }
            }
        }

        private void dgvGestion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pasaDatosD();
            pasaDatosE();
            dgvGestion.Enabled = false;
            txtIDD.Enabled = false;
            txtEntidad.Enabled = false;
        }
        public void pasaDatosE()
        {
            string CadSql;
            string cod_ent = dgvGestion.CurrentRow.Cells[0].Value.ToString();
            CadSql = "SELECT e.id_ent, e.nom_ent, e.rut_ent, e.dgv, e.telefono_ent, e.email_ent, t.des_tipo, r.razon_social from datos_entidades e, razon_social r, tipo_entidades t WHERE e.id_razon = r.id_razon and e.id_tipo = t.id_tipo and id_ent = '" + cod_ent + "'";
            Conexion con = new Conexion();
            MySqlDataReader Rec = null;
            try
            {
                con.AbrirConexion();
                Rec = con.EjecutarConsulta(CadSql);
                while (Rec.Read())
                {
                    txtEntidad.Text = Rec["id_ent"].ToString();
                    txtNombre.Text = Rec["nom_ent"].ToString();
                    mskRut.Text = Rec["rut_ent"].ToString();
                    mskDgv.Text = Rec["dgv"].ToString();
                    txtTelefono.Text = Rec["telefono_ent"].ToString();
                    txtEmail.Text = Rec["email_ent"].ToString();
                    cboTipo.SelectedText = Rec["des_tipo"].ToString();
                    cboRazon.SelectedText = Rec["razon_social"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (Rec != null)
                {
                    Rec.Close();
                    Rec = null;
                }
            }
        }
        public void pasaDatosD()
        {
            string CadSql;
            string cod_dir = dgvGestion.CurrentRow.Cells[8].Value.ToString();
            CadSql = "SELECT d.id_direccion, d.direccion, d.num_direccion, c.des_ciudad, o. des_comuna FROM direcciones d, ciudades c, comunas o WHERE d.cod_ciudad = c.cod_ciudad and d.cod_comuna = o.cod_comuna and id_direccion = '" + cod_dir + "'";
            Conexion con = new Conexion();
            MySqlDataReader Rec = null;
            try
            {
                con.AbrirConexion();
                Rec = con.EjecutarConsulta(CadSql);
                while (Rec.Read())
                {
                    txtIDD.Text = Rec["id_direccion"].ToString();
                    txtDireccion.Text = Rec["direccion"].ToString();
                    txtNumeroD.Text = Rec["num_direccion"].ToString();
                    cboCiudad.SelectedText = Rec["des_ciudad"].ToString();
                    cboComuna.SelectedText = Rec["des_comuna"].ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (Rec != null)
                {
                    Rec.Close();
                    Rec = null;
                }
            }
        }

        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            if (txtDireccion.Text.Length >= 1 && txtEmail.Text.Length >= 1 && txtEntidad.Text.Length >= 1 && txtIDD.Text.Length >= 1 && txtNombre.Text.Length >= 1 && txtNumeroD.Text.Length >= 1 && txtTelefono.Text.Length >= 1 && mskDgv.Text.Length >= 1 && mskRut.Text.Length >= 1 && cboCiudad.SelectedIndex != -1 && cboComuna.SelectedIndex != -1 && cboRazon.SelectedIndex != -1 && cboTipo.SelectedIndex != -1)
            {
                string codEnt;
                codEnt = txtEntidad.Text;
                Conexion con = new Conexion();
                string CadSqlE;
                CadSqlE = "update datos_entidades set rut_ent = '" + mskRut.Text + "', dgv = '" + mskDgv.Text + "', nom_ent = '" + txtNombre.Text + "', telefono_ent = '" + txtTelefono.Text + "', email_ent = '" + txtEmail.Text + "', id_tipo = '" + cboTipo.SelectedValue + "', id_razon = '" + cboRazon.SelectedValue + "' Where id_ent = '" + codEnt + "'";
                string CadSqlD;
                CadSqlD = "update direcciones set direccion = '" + txtDireccion.Text + "', num_direccion = '" + txtNumeroD.Text + "', cod_ciudad = '" + cboCiudad.SelectedValue + "', cod_comuna = '" + cboComuna.SelectedValue + "', id_ent = '" + codEnt + "' where id_direccion = '" + txtIDD.Text + "'";

                try
                {
                    if (con.EjecutarIUD(CadSqlE) > 0 && con.EjecutarIUD(CadSqlD) > 0)
                    {
                        MessageBox.Show("Modificacion Completada", "Listo");
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Error de Modificacion", "ERROR");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                llenarDgv();
            }
            else
            {
                MessageBox.Show("Debe tener todos los campos completos", "ERROR");
            }
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (txtEntidad.Text.Length >= 1 && txtIDD.Text.Length >= 1)
            {
                Conexion con = new Conexion();

                string CadSqlE;
                CadSqlE = "DELETE FROM datos_entidades WHERE id_ent = '" + txtEntidad.Text + "'";
                string CadSqlD;
                CadSqlD = "DELETE FROM direcciones WHERE id_direccion = '" + txtIDD.Text + "'";

                try
                {
                    if (con.EjecutarIUD(CadSqlE) > 0 && con.EjecutarIUD(CadSqlD) > 0)
                    {
                        MessageBox.Show("Registro Eliminado", "Listo");
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Ha Ocurrido un error", "ERROR");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                llenarDgv();
            }
            else
            {
                MessageBox.Show("Revise Los ID de Entidad y de Direccion y asegurece que el campo este lleno", "ERROR");
            }
        }

        private void txtEntidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.KeyChar = Convert.ToChar(0);
            }
        }
        private void txtIDD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.KeyChar = Convert.ToChar(0);
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.KeyChar = Convert.ToChar(0);
            }
        }

        private void txtNumeroD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.KeyChar = Convert.ToChar(0);
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '\b')
            {
                e.KeyChar = Convert.ToChar(0);
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '@' && e.KeyChar != '.')
            {
                e.KeyChar = Convert.ToChar(0);
            } 
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '\b')
            {
                e.KeyChar = Convert.ToChar(0);
            }
        }
    }
}
