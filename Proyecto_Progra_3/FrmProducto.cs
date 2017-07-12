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
    public partial class FrmProducto : Form
    {
        Conexion con = new Conexion();

        public FrmProducto()
        {
            InitializeComponent();
        }
        public void limpiar()
        {
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
            cboEntidad.SelectedIndex = -1;
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            String CadSql;
            CadSql = "select nom_ent, id_ent from datos_entidades where id_tipo = 2 or id_tipo = 3";
            Subrrutinas.llenarCombobox(cboEntidad, CadSql, "nom_ent", "id_ent");
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.KeyChar = Convert.ToChar(0);
            }
        }

        private void btnIngresar_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtNombre.Text.Length >= 1 && cboEntidad.SelectedIndex != -1 && txtPrecio.Text.Length >= 1 && txtStock.Text.Length >= 1)
            {
                string CadSql;
                CadSql = "insert into productos (nom_producto, precio_producto, stock_producto, id_ent) values ('" + txtNombre.Text + "'," + txtPrecio.Text + "," +
                txtStock.Text + "," + cboEntidad.SelectedValue + ")";

                try
                {
                    if (con.EjecutarIUD(CadSql) > 0)
                    {
                        MessageBox.Show("Producto Guardado", "Listo");
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Producto NO Guardado", "ERROR");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Debe llenar los campos vacios", "ERROR");
            }
        }

        private void btnLimpiar_MouseClick(object sender, MouseEventArgs e)
        {
            limpiar();
        }
    }
}
