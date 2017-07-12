namespace Proyecto_Progra_3
{
    partial class GestionClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionClientes));
            this.dgvGestion = new System.Windows.Forms.DataGridView();
            this.id_ent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_ent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RUT_ent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono_ent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email_ent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num_direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comunda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.cmdModificar = new System.Windows.Forms.Button();
            this.cmdLimpiar = new System.Windows.Forms.Button();
            this.txtEntidad = new System.Windows.Forms.TextBox();
            this.txtIDD = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.mskRut = new System.Windows.Forms.MaskedTextBox();
            this.mskDgv = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cboRazon = new System.Windows.Forms.ComboBox();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.cboCiudad = new System.Windows.Forms.ComboBox();
            this.cboComuna = new System.Windows.Forms.ComboBox();
            this.txtNumeroD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGestion)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGestion
            // 
            this.dgvGestion.AllowUserToAddRows = false;
            this.dgvGestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGestion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_ent,
            this.nom_ent,
            this.RUT_ent,
            this.DGV,
            this.Telefono_ent,
            this.email_ent,
            this.tipo,
            this.razon,
            this.id_direccion,
            this.direccion,
            this.num_direccion,
            this.ciudad,
            this.comunda});
            this.dgvGestion.Location = new System.Drawing.Point(12, 173);
            this.dgvGestion.Name = "dgvGestion";
            this.dgvGestion.ReadOnly = true;
            this.dgvGestion.Size = new System.Drawing.Size(1188, 150);
            this.dgvGestion.TabIndex = 27;
            this.dgvGestion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGestion_CellClick);
            // 
            // id_ent
            // 
            this.id_ent.HeaderText = "ID Entidad";
            this.id_ent.Name = "id_ent";
            this.id_ent.ReadOnly = true;
            // 
            // nom_ent
            // 
            this.nom_ent.HeaderText = "Nombre";
            this.nom_ent.Name = "nom_ent";
            this.nom_ent.ReadOnly = true;
            this.nom_ent.Width = 70;
            // 
            // RUT_ent
            // 
            this.RUT_ent.HeaderText = "RUT";
            this.RUT_ent.Name = "RUT_ent";
            this.RUT_ent.ReadOnly = true;
            this.RUT_ent.Width = 70;
            // 
            // DGV
            // 
            this.DGV.HeaderText = "Digito";
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.Width = 35;
            // 
            // Telefono_ent
            // 
            this.Telefono_ent.HeaderText = "Telefono";
            this.Telefono_ent.Name = "Telefono_ent";
            this.Telefono_ent.ReadOnly = true;
            this.Telefono_ent.Width = 70;
            // 
            // email_ent
            // 
            this.email_ent.HeaderText = "Emal";
            this.email_ent.Name = "email_ent";
            this.email_ent.ReadOnly = true;
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            // 
            // razon
            // 
            this.razon.HeaderText = "Razon Social";
            this.razon.Name = "razon";
            this.razon.ReadOnly = true;
            // 
            // id_direccion
            // 
            this.id_direccion.HeaderText = "ID Direccion";
            this.id_direccion.Name = "id_direccion";
            this.id_direccion.ReadOnly = true;
            // 
            // direccion
            // 
            this.direccion.HeaderText = "Direccion";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            // 
            // num_direccion
            // 
            this.num_direccion.HeaderText = "Numero Direccion";
            this.num_direccion.Name = "num_direccion";
            this.num_direccion.ReadOnly = true;
            // 
            // ciudad
            // 
            this.ciudad.HeaderText = "Ciudad";
            this.ciudad.Name = "ciudad";
            this.ciudad.ReadOnly = true;
            // 
            // comunda
            // 
            this.comunda.HeaderText = "Comuna";
            this.comunda.Name = "comunda";
            this.comunda.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Entidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "ID Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "RUT:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(172, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Telefono";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(414, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(691, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Tipo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(376, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Razon Social";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(394, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "Direccion";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(679, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 40;
            this.label11.Text = "Ciudad";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(679, 134);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 41;
            this.label12.Text = "Comuna";
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Location = new System.Drawing.Point(1033, 84);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(75, 23);
            this.cmdEliminar.TabIndex = 42;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // cmdModificar
            // 
            this.cmdModificar.Location = new System.Drawing.Point(1033, 36);
            this.cmdModificar.Name = "cmdModificar";
            this.cmdModificar.Size = new System.Drawing.Size(75, 23);
            this.cmdModificar.TabIndex = 43;
            this.cmdModificar.Text = "Modificar";
            this.cmdModificar.UseVisualStyleBackColor = true;
            this.cmdModificar.Click += new System.EventHandler(this.cmdModificar_Click);
            // 
            // cmdLimpiar
            // 
            this.cmdLimpiar.Location = new System.Drawing.Point(1033, 132);
            this.cmdLimpiar.Name = "cmdLimpiar";
            this.cmdLimpiar.Size = new System.Drawing.Size(75, 23);
            this.cmdLimpiar.TabIndex = 44;
            this.cmdLimpiar.Text = "Limpiar";
            this.cmdLimpiar.UseVisualStyleBackColor = true;
            this.cmdLimpiar.Click += new System.EventHandler(this.cmdLimpiar_Click);
            // 
            // txtEntidad
            // 
            this.txtEntidad.Location = new System.Drawing.Point(100, 30);
            this.txtEntidad.Name = "txtEntidad";
            this.txtEntidad.Size = new System.Drawing.Size(41, 20);
            this.txtEntidad.TabIndex = 45;
            this.txtEntidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEntidad_KeyPress);
            // 
            // txtIDD
            // 
            this.txtIDD.Location = new System.Drawing.Point(100, 128);
            this.txtIDD.Name = "txtIDD";
            this.txtIDD.Size = new System.Drawing.Size(43, 20);
            this.txtIDD.TabIndex = 46;
            this.txtIDD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDD_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(222, 29);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(133, 20);
            this.txtNombre.TabIndex = 47;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(227, 132);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(128, 20);
            this.txtTelefono.TabIndex = 48;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(453, 29);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(139, 20);
            this.txtEmail.TabIndex = 49;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(453, 82);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(89, 20);
            this.txtDireccion.TabIndex = 50;
            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
            // 
            // mskRut
            // 
            this.mskRut.Location = new System.Drawing.Point(227, 77);
            this.mskRut.Mask = "##.###.###";
            this.mskRut.Name = "mskRut";
            this.mskRut.Size = new System.Drawing.Size(78, 20);
            this.mskRut.TabIndex = 51;
            // 
            // mskDgv
            // 
            this.mskDgv.Location = new System.Drawing.Point(327, 77);
            this.mskDgv.Mask = "A";
            this.mskDgv.Name = "mskDgv";
            this.mskDgv.Size = new System.Drawing.Size(21, 20);
            this.mskDgv.TabIndex = 52;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(311, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(10, 13);
            this.label13.TabIndex = 53;
            this.label13.Text = "-";
            // 
            // cboRazon
            // 
            this.cboRazon.FormattingEnabled = true;
            this.cboRazon.Location = new System.Drawing.Point(453, 131);
            this.cboRazon.Name = "cboRazon";
            this.cboRazon.Size = new System.Drawing.Size(185, 21);
            this.cboRazon.TabIndex = 54;
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(731, 30);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(133, 21);
            this.cboTipo.TabIndex = 55;
            // 
            // cboCiudad
            // 
            this.cboCiudad.FormattingEnabled = true;
            this.cboCiudad.Location = new System.Drawing.Point(731, 81);
            this.cboCiudad.Name = "cboCiudad";
            this.cboCiudad.Size = new System.Drawing.Size(133, 21);
            this.cboCiudad.TabIndex = 56;
            // 
            // cboComuna
            // 
            this.cboComuna.FormattingEnabled = true;
            this.cboComuna.Location = new System.Drawing.Point(731, 131);
            this.cboComuna.Name = "cboComuna";
            this.cboComuna.Size = new System.Drawing.Size(133, 21);
            this.cboComuna.TabIndex = 57;
            // 
            // txtNumeroD
            // 
            this.txtNumeroD.Location = new System.Drawing.Point(568, 83);
            this.txtNumeroD.Name = "txtNumeroD";
            this.txtNumeroD.Size = new System.Drawing.Size(60, 20);
            this.txtNumeroD.TabIndex = 58;
            this.txtNumeroD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroD_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(548, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "#";
            // 
            // GestionClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1209, 335);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumeroD);
            this.Controls.Add(this.cboComuna);
            this.Controls.Add(this.cboCiudad);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.cboRazon);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.mskDgv);
            this.Controls.Add(this.mskRut);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtIDD);
            this.Controls.Add(this.txtEntidad);
            this.Controls.Add(this.cmdLimpiar);
            this.Controls.Add(this.cmdModificar);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvGestion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GestionClientes";
            this.Text = "Gestion Cliente/Proveedor";
            this.Load += new System.EventHandler(this.GestionClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGestion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGestion;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_ent;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_ent;
        private System.Windows.Forms.DataGridViewTextBoxColumn RUT_ent;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono_ent;
        private System.Windows.Forms.DataGridViewTextBoxColumn email_ent;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn razon;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn num_direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn comunda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.Button cmdModificar;
        private System.Windows.Forms.Button cmdLimpiar;
        private System.Windows.Forms.TextBox txtEntidad;
        private System.Windows.Forms.TextBox txtIDD;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.MaskedTextBox mskRut;
        private System.Windows.Forms.MaskedTextBox mskDgv;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cboRazon;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.ComboBox cboCiudad;
        private System.Windows.Forms.ComboBox cboComuna;
        private System.Windows.Forms.TextBox txtNumeroD;
        private System.Windows.Forms.Label label1;
    }
}