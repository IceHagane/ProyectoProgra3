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
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            llenardgv();
        }

        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
