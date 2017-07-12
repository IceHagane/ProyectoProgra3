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
    public partial class Cotizacion : Form
    {
        public Cotizacion()
        {
            InitializeComponent();
            llenarDgv();
        }

        private void llenarDgv()
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
                dgvCotiszacion.RowCount = 0;
                while (Rec.Read())
                {
                    dgvCotiszacion.RowCount = dgvCotiszacion.RowCount + 1;
                    fila = dgvCotiszacion.RowCount - 1;
                    dgvCotiszacion.Rows[fila].Cells[0].Value = Rec["cod_producto"].ToString();
                    dgvCotiszacion.Rows[fila].Cells[1].Value = Rec["nom_producto"].ToString();
                    dgvCotiszacion.Rows[fila].Cells[2].Value = Rec["precio_producto"].ToString();
                    dgvCotiszacion.Rows[fila].Cells[3].Value = Rec["stock_producto"].ToString();
                    dgvCotiszacion.Rows[fila].Cells[4].Value = Rec["id_ent"].ToString();
                    dgvCotiszacion.Rows[fila].Cells[5].Value = Rec["nom_ent"].ToString();
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

        private void Cotizacion_Load(object sender, EventArgs e)
        {
            string CadSql;
            CadSql = "SELECT nom_producto, cod_producto FROM productos";
            Subrrutinas.llenarCombobox(cboProducto, CadSql, "nom_producto", "cod_producto");
            CadSql = "Select nom_ent, id_ent from datos_entidades where id_tipo = 2 or id_tipo = 3";
            Subrrutinas.llenarCombobox(cboEntidad, CadSql, "nom_ent", "id_ent");
        }

        private void cmdBuscar1_MouseClick(object sender, MouseEventArgs e)
        {
            if (cboProducto.SelectedIndex != -1)
            {

                string CadSql, ad;
                ad = cboProducto.SelectedItem.ToString();
                CadSql = "select p.cod_producto, p.nom_producto, p.precio_producto, p.stock_producto, e.id_ent, e.nom_ent from productos p, datos_entidades e where p.id_ent = e.id_ent and nom_producto Like '" + ad + "';";
                

                Conexion con = new Conexion();
                int fila;
                //MySqlDataReader Rec = null;
                try
                {
                    
                    con.EjecutarConsulta(CadSql);
                    dgvCotiszacion.RowCount = 0;
                    while (con.Rec.Read())
                    {
                        dgvCotiszacion.RowCount = dgvCotiszacion.RowCount + 1;
                        fila = dgvCotiszacion.RowCount - 1;
                        dgvCotiszacion.Rows[fila].Cells[0].Value = con.Rec["cod_producto"].ToString();
                        dgvCotiszacion.Rows[fila].Cells[1].Value = con.Rec["nom_producto"].ToString();
                        dgvCotiszacion.Rows[fila].Cells[2].Value = con.Rec["precio_producto"].ToString();
                        dgvCotiszacion.Rows[fila].Cells[3].Value = con.Rec["stock_producto"].ToString();
                        dgvCotiszacion.Rows[fila].Cells[4].Value = con.Rec["id_ent"].ToString();
                        dgvCotiszacion.Rows[fila].Cells[5].Value = con.Rec["nom_ent"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {

                    con.CerrarConexion();
                        con.Rec = null;
                    
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un Producto", "ERROR");
            }
        }

        private void cmdBuscar2_Click(object sender, EventArgs e)
        {
            if (cboEntidad.SelectedIndex != -1)
            {
                string CadSql;
                CadSql = "select p.cod_producto, p.nom_producto, p.precio_producto, p.stock_producto, e.id_ent, e.nom_ent from productos p, datos_entidades e where p.id_ent = e.id_ent and nom_ent Like '" + cboEntidad.SelectedItem + "'";

                Conexion con = new Conexion();
                int fila;
                MySqlDataReader Rec = null;
                try
                {
                    con.AbrirConexion();
                    Rec = con.EjecutarConsulta(CadSql);
                    dgvCotiszacion.RowCount = 0;
                    while (Rec.Read())
                    {
                        dgvCotiszacion.RowCount = dgvCotiszacion.RowCount + 1;
                        fila = dgvCotiszacion.RowCount - 1;
                        dgvCotiszacion.Rows[fila].Cells[0].Value = Rec["cod_producto"].ToString();
                        dgvCotiszacion.Rows[fila].Cells[1].Value = Rec["nom_producto"].ToString();
                        dgvCotiszacion.Rows[fila].Cells[2].Value = Rec["precio_producto"].ToString();
                        dgvCotiszacion.Rows[fila].Cells[3].Value = Rec["stock_producto"].ToString();
                        dgvCotiszacion.Rows[fila].Cells[4].Value = Rec["id_ent"].ToString();
                        dgvCotiszacion.Rows[fila].Cells[5].Value = Rec["nom_ent"].ToString();
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
            else
            {
                MessageBox.Show("Debe seleccionar un Proveedor", "ERROR");
            }
        }
    }
}
