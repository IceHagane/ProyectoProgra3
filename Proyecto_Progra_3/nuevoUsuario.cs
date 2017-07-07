﻿using System;
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
    public partial class nuevoUsuario : Form
    {
        Conexion con = new Conexion();
        public nuevoUsuario()
        {
            InitializeComponent();
            Privilegios();

        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            DatosValidos();
        }

        public void DatosValidos()
        {
            if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtContraseña.Text) || string.IsNullOrEmpty(txtConfirmar.Text)
                || cboPermisos.SelectedIndex == -1)
            {
                MessageBox.Show("Debe llenar todos los campos");
                txtUsuario.Focus();
            }
            else if (txtContraseña.Text != txtConfirmar.Text)
            {
                MessageBox.Show("Debe ingresar la misma contraseña en ambos campos");
                txtContraseña.Text = "";
                txtConfirmar.Text = "";
                txtContraseña.Focus();
            }
            {
                string CadSql;
                CadSql = "SELECT nom_usuario FROM USUARIOS WHERE nom_usuario='" + txtUsuario.Text + "';";
                try
                {
                    con.EjecutarConsulta(CadSql);
                    while (con.Rec.Read())
                    {
                        ClaseArchivador.usuario_nuevo = con.Rec["nom_usuario"].ToString();
                    }
                    string ad = ClaseArchivador.usuario_nuevo.ToString();
                    if (txtUsuario.Text.Equals(ad))
                    {
                        MessageBox.Show("El usuario ya existe");
                        Limpiar();
                    }
                    else
                    {

                        string CadSql2, nom_usuario, pass_usu;
                        int cod_usu; 
                         nom_usuario = txtUsuario.Text;
                         pass_usu = txtContraseña.Text;
                         cod_usu = Convert.ToInt32(cboPermisos.SelectedValue);
                        CadSql2 = "INSERT INTO usuarios(nom_usuario,pass_usuario,id_tipo_usuario) VALUES('" + txtUsuario.Text + "','" +
                            txtContraseña.Text + "'," + cboPermisos.SelectedValue + ");";
                        try
                        {
                            con.EjecutarIUD(CadSql2);
                            MessageBox.Show("Usuario" + txtUsuario.Text.ToUpper() + " Registrado con Exito");
                            Limpiar();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }


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

        }
        public void Privilegios()
        {
            string CadSql;
            CadSql = "Select id_tipo_usuario,tipo_permiso from permisos";
            Subrrutinas.llenarCombobox(cboPermisos, CadSql, "tipo_permiso", "id_tipo_usuario");
        }

        public void Limpiar()
        {
            txtUsuario.Text = "";
            txtContraseña.Text = "";
            txtConfirmar.Text = "";
            cboPermisos.SelectedIndex = -1;
            txtUsuario.Focus();
        }

    }
}

