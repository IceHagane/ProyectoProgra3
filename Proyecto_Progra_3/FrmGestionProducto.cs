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
    public partial class FrmGestionProducto : Form
    {
        public FrmGestionProducto()
        {
            InitializeComponent();
            llenardgv();
        }

        private void llenardgv()
        {
            string CadSql;
            CadSql = "SELECT p.cod_producto, p.nom_producto, p.precio_producto, p.stock_producto, p.id_ent, e.nom_ent FROM productos p, datos_entidades e where p.id_ent = e.id_ent";

            Conexion con = new Conexion();
            int fila;
            MySqlDataReader Rec = null;
            try
            {
                con.AbrirConexion();
                Rec = con.EjecutarConsulta(CadSql);
                dgvProductos.RowCount = 0;
                while (Rec.Read())
                {
                    dgvProductos.RowCount = dgvProductos.RowCount +1;
                    fila = dgvProductos.RowCount -1;
                    dgvProductos.Rows[fila].Cells[0].Value = Rec["cod_producto"].ToString();
                    dgvProductos.Rows[fila].Cells[1].Value = Rec["nom_producto"].ToString();
                    dgvProductos.Rows[fila].Cells[2].Value = Rec["precio_producto"].ToString();
                    dgvProductos.Rows[fila].Cells[3].Value = Rec["stock_producto"].ToString();
                    dgvProductos.Rows[fila].Cells[4].Value = Rec["id_ent"].ToString();
                    dgvProductos.Rows[fila].Cells[5].Value = Rec["nom_ent"].ToString();
                }
            }
                catch (Exception e){
                    MessageBox.Show(e.Message);
                }
            finally
            {
                if(Rec != null)
                {
                    Rec.Close();
                    Rec = null;
                }
            }
            }

        private void limpiar()
        {
            txtCodigo.Text = "";
            txtEntidad.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
            txtEntidad.Enabled = true;
            txtCodigo.Enabled = true;
            dgvProductos.Enabled = true;
        }

        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length >= 1 && txtPrecio.Text.Length >= 1 && txtStock.Text.Length >= 1)
            {               
                Conexion con = new Conexion();
                string codProd = txtCodigo.Text;
                codProd = txtCodigo.Text;

                string CadSql;
                CadSql = "update productos set nom_producto='" + txtNombre.Text + "', precio_producto= '" + txtPrecio.Text + "', stock_producto= '" + txtStock.Text + "' where cod_producto='" + codProd + "'";

                try
                {
                    if (con.EjecutarIUD(CadSql) > 0)
                    {
                        MessageBox.Show("Modificacion Completada", "Listo");
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Error De Modificacion", "ERROR");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                llenardgv();
            }
            else
            {
                MessageBox.Show("Debe llenar los campos disponibles para modificar", "ERROR");
            }
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
             String Codigo = txtCodigo.Text;

             if (Codigo.Length >= 1)
             {
                 Conexion con = new Conexion();
                 string codProd = txtCodigo.Text;
                 codProd = txtCodigo.Text;

                 string CadSql;
                 CadSql = "DELETE FROM productos WHERE cod_producto = '" + codProd + "'";

                 try
                 {
                     if (con.EjecutarIUD(CadSql) > 0)
                     {
                         MessageBox.Show("Producto Eliminado", "Listo");
                         limpiar();
                     }
                     else
                     {
                         MessageBox.Show("Producto NO Eliminado", "ERROR");
                     }
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show(ex.Message);
                 }
                 llenardgv();
             }
             else
             {
                 MessageBox.Show("El campo Codigo debe tener un valor referente al codigo de producto", "ERROR");
             }
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string CadSql;
            string codProd = dgvProductos.CurrentRow.Cells[0].Value.ToString();
            CadSql = "select * from productos where cod_producto = '" + codProd + "' ";
            Conexion con = new Conexion();
            MySqlDataReader Rec = null;
            try
            {
                con.AbrirConexion();
                Rec = con.EjecutarConsulta(CadSql);
                while (Rec.Read())
                {
                    txtCodigo.Text = Rec["cod_producto"].ToString();
                    txtNombre.Text = Rec["nom_producto"].ToString();
                    txtPrecio.Text = Rec["precio_producto"].ToString();
                    txtStock.Text = Rec["stock_producto"].ToString();
                    txtEntidad.Text = Rec["id_ent"].ToString();
                    txtCodigo.Enabled = false;
                    txtEntidad.Enabled = false;
                    dgvProductos.Enabled = false;
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

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '\b')
            {
                e.KeyChar = Convert.ToChar(0);
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
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
    }
}
