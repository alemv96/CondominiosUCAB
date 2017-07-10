namespace CONDOMINIO_UCAB
{
    partial class inicio
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.barra_superior = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.edificio = new System.Windows.Forms.Label();
            this.icono = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.apartamento = new System.Windows.Forms.Label();
            this.icono2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.propietario = new System.Windows.Forms.Label();
            this.icono3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.junta = new System.Windows.Forms.Label();
            this.icono4 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.gasto = new System.Windows.Forms.Label();
            this.icono5 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.aviso = new System.Windows.Forms.Label();
            this.icono6 = new System.Windows.Forms.Panel();
            this.linea_menu = new System.Windows.Forms.Label();
            this.tabla = new System.Windows.Forms.DataGridView();
            this.panel_detalles = new System.Windows.Forms.Panel();
            this.linea_detalles = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // barra_superior
            // 
            this.barra_superior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(181)))), ((int)(((byte)(214)))));
            this.barra_superior.Font = new System.Drawing.Font("Roboto Lt", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barra_superior.ForeColor = System.Drawing.Color.White;
            this.barra_superior.Location = new System.Drawing.Point(0, 0);
            this.barra_superior.Margin = new System.Windows.Forms.Padding(0);
            this.barra_superior.Name = "barra_superior";
            this.barra_superior.Size = new System.Drawing.Size(1280, 42);
            this.barra_superior.TabIndex = 0;
            this.barra_superior.Text = "    ADMINISTRADORA UCAB";
            this.barra_superior.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menu
            // 
            this.menu.Controls.Add(this.panel1);
            this.menu.Controls.Add(this.panel2);
            this.menu.Controls.Add(this.panel4);
            this.menu.Controls.Add(this.panel6);
            this.menu.Controls.Add(this.panel12);
            this.menu.Controls.Add(this.panel10);
            this.menu.Location = new System.Drawing.Point(5, 45);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(274, 634);
            this.menu.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.edificio);
            this.panel1.Controls.Add(this.icono);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 74);
            this.panel1.TabIndex = 0;
            // 
            // edificio
            // 
            this.edificio.AutoSize = true;
            this.edificio.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edificio.ForeColor = System.Drawing.Color.Gray;
            this.edificio.Location = new System.Drawing.Point(79, 28);
            this.edificio.Name = "edificio";
            this.edificio.Size = new System.Drawing.Size(74, 18);
            this.edificio.TabIndex = 1;
            this.edificio.Text = "EDIFICIOS";
            this.edificio.MouseEnter += new System.EventHandler(this.edificio_MouseEnter);
            this.edificio.MouseLeave += new System.EventHandler(this.edificio_MouseLeave);
            // 
            // icono
            // 
            this.icono.BackgroundImage = global::CONDOMINIO_UCAB.Properties.Resources.edificio_gris;
            this.icono.Location = new System.Drawing.Point(10, 10);
            this.icono.Name = "icono";
            this.icono.Size = new System.Drawing.Size(53, 53);
            this.icono.TabIndex = 0;
            this.icono.MouseEnter += new System.EventHandler(this.edificio_MouseEnter);
            this.icono.MouseLeave += new System.EventHandler(this.edificio_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.apartamento);
            this.panel2.Controls.Add(this.icono2);
            this.panel2.Location = new System.Drawing.Point(3, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(261, 74);
            this.panel2.TabIndex = 2;
            // 
            // apartamento
            // 
            this.apartamento.AutoSize = true;
            this.apartamento.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apartamento.ForeColor = System.Drawing.Color.Gray;
            this.apartamento.Location = new System.Drawing.Point(79, 28);
            this.apartamento.Name = "apartamento";
            this.apartamento.Size = new System.Drawing.Size(124, 18);
            this.apartamento.TabIndex = 1;
            this.apartamento.Text = "APARTAMENTOS";
            this.apartamento.MouseEnter += new System.EventHandler(this.apartamento_MouseEnter);
            this.apartamento.MouseLeave += new System.EventHandler(this.apartamento_MouseLeave);
            // 
            // icono2
            // 
            this.icono2.BackgroundImage = global::CONDOMINIO_UCAB.Properties.Resources.llave_gris;
            this.icono2.Location = new System.Drawing.Point(10, 10);
            this.icono2.Name = "icono2";
            this.icono2.Size = new System.Drawing.Size(53, 53);
            this.icono2.TabIndex = 0;
            this.icono2.MouseEnter += new System.EventHandler(this.apartamento_MouseEnter);
            this.icono2.MouseLeave += new System.EventHandler(this.apartamento_MouseLeave);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.propietario);
            this.panel4.Controls.Add(this.icono3);
            this.panel4.Location = new System.Drawing.Point(3, 163);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(261, 74);
            this.panel4.TabIndex = 3;
            // 
            // propietario
            // 
            this.propietario.AutoSize = true;
            this.propietario.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.propietario.ForeColor = System.Drawing.Color.Gray;
            this.propietario.Location = new System.Drawing.Point(79, 28);
            this.propietario.Name = "propietario";
            this.propietario.Size = new System.Drawing.Size(111, 18);
            this.propietario.TabIndex = 1;
            this.propietario.Text = "PROPIETARIOS";
            this.propietario.MouseEnter += new System.EventHandler(this.propietario_MouseEnter);
            this.propietario.MouseLeave += new System.EventHandler(this.propietario_MouseLeave);
            // 
            // icono3
            // 
            this.icono3.BackgroundImage = global::CONDOMINIO_UCAB.Properties.Resources.propietario_gris;
            this.icono3.Location = new System.Drawing.Point(10, 10);
            this.icono3.Name = "icono3";
            this.icono3.Size = new System.Drawing.Size(53, 53);
            this.icono3.TabIndex = 0;
            this.icono3.MouseEnter += new System.EventHandler(this.propietario_MouseEnter);
            this.icono3.MouseLeave += new System.EventHandler(this.propietario_MouseLeave);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.junta);
            this.panel6.Controls.Add(this.icono4);
            this.panel6.Location = new System.Drawing.Point(3, 243);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(261, 74);
            this.panel6.TabIndex = 4;
            // 
            // junta
            // 
            this.junta.AutoSize = true;
            this.junta.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.junta.ForeColor = System.Drawing.Color.Gray;
            this.junta.Location = new System.Drawing.Point(79, 28);
            this.junta.Name = "junta";
            this.junta.Size = new System.Drawing.Size(182, 18);
            this.junta.TabIndex = 1;
            this.junta.Text = "JUNTAS DE CONDOMINIO";
            this.junta.MouseEnter += new System.EventHandler(this.junta_MouseEnter);
            this.junta.MouseLeave += new System.EventHandler(this.junta_MouseLeave);
            // 
            // icono4
            // 
            this.icono4.BackgroundImage = global::CONDOMINIO_UCAB.Properties.Resources.junta_gris;
            this.icono4.Location = new System.Drawing.Point(10, 10);
            this.icono4.Name = "icono4";
            this.icono4.Size = new System.Drawing.Size(53, 53);
            this.icono4.TabIndex = 0;
            this.icono4.MouseEnter += new System.EventHandler(this.junta_MouseEnter);
            this.icono4.MouseLeave += new System.EventHandler(this.junta_MouseLeave);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.gasto);
            this.panel12.Controls.Add(this.icono5);
            this.panel12.Location = new System.Drawing.Point(3, 323);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(261, 74);
            this.panel12.TabIndex = 4;
            // 
            // gasto
            // 
            this.gasto.AutoSize = true;
            this.gasto.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gasto.ForeColor = System.Drawing.Color.Gray;
            this.gasto.Location = new System.Drawing.Point(79, 28);
            this.gasto.Name = "gasto";
            this.gasto.Size = new System.Drawing.Size(64, 18);
            this.gasto.TabIndex = 1;
            this.gasto.Text = "GASTOS";
            this.gasto.MouseEnter += new System.EventHandler(this.gasto_MouseEnter);
            this.gasto.MouseLeave += new System.EventHandler(this.gasto_MouseLeave);
            // 
            // icono5
            // 
            this.icono5.BackgroundImage = global::CONDOMINIO_UCAB.Properties.Resources.gastos_gris;
            this.icono5.Location = new System.Drawing.Point(10, 10);
            this.icono5.Name = "icono5";
            this.icono5.Size = new System.Drawing.Size(53, 53);
            this.icono5.TabIndex = 0;
            this.icono5.MouseEnter += new System.EventHandler(this.gasto_MouseEnter);
            this.icono5.MouseLeave += new System.EventHandler(this.gasto_MouseLeave);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.aviso);
            this.panel10.Controls.Add(this.icono6);
            this.panel10.Location = new System.Drawing.Point(3, 403);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(261, 74);
            this.panel10.TabIndex = 4;
            // 
            // aviso
            // 
            this.aviso.AutoSize = true;
            this.aviso.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aviso.ForeColor = System.Drawing.Color.Gray;
            this.aviso.Location = new System.Drawing.Point(79, 28);
            this.aviso.Name = "aviso";
            this.aviso.Size = new System.Drawing.Size(132, 18);
            this.aviso.TabIndex = 1;
            this.aviso.Text = "AVISOS / RECIBOS";
            this.aviso.MouseEnter += new System.EventHandler(this.aviso_MouseEnter);
            this.aviso.MouseLeave += new System.EventHandler(this.aviso_MouseLeave);
            // 
            // icono6
            // 
            this.icono6.BackgroundImage = global::CONDOMINIO_UCAB.Properties.Resources.recibos_gris;
            this.icono6.Location = new System.Drawing.Point(10, 10);
            this.icono6.Name = "icono6";
            this.icono6.Size = new System.Drawing.Size(53, 53);
            this.icono6.TabIndex = 0;
            this.icono6.MouseEnter += new System.EventHandler(this.aviso_MouseEnter);
            this.icono6.MouseLeave += new System.EventHandler(this.aviso_MouseLeave);
            // 
            // linea_menu
            // 
            this.linea_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.linea_menu.Location = new System.Drawing.Point(275, 42);
            this.linea_menu.Name = "linea_menu";
            this.linea_menu.Size = new System.Drawing.Size(1, 750);
            this.linea_menu.TabIndex = 2;
            // 
            // tabla
            // 
            this.tabla.BackgroundColor = System.Drawing.Color.White;
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.nombrw,
            this.apellido});
            this.tabla.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.tabla.Location = new System.Drawing.Point(326, 180);
            this.tabla.Name = "tabla";
            this.tabla.Size = new System.Drawing.Size(693, 420);
            this.tabla.TabIndex = 3;
            // 
            // panel_detalles
            // 
            this.panel_detalles.BackColor = System.Drawing.Color.Transparent;
            this.panel_detalles.Location = new System.Drawing.Point(1063, 42);
            this.panel_detalles.Name = "panel_detalles";
            this.panel_detalles.Size = new System.Drawing.Size(200, 637);
            this.panel_detalles.TabIndex = 4;
            // 
            // linea_detalles
            // 
            this.linea_detalles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.linea_detalles.Location = new System.Drawing.Point(1060, 42);
            this.linea_detalles.Name = "linea_detalles";
            this.linea_detalles.Size = new System.Drawing.Size(1, 750);
            this.linea_detalles.TabIndex = 5;
            // 
            // ID
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.DefaultCellStyle = dataGridViewCellStyle1;
            this.ID.HeaderText = "Cedula";
            this.ID.Name = "ID";
            this.ID.Width = 65;
            // 
            // nombrw
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 12F);
            this.nombrw.DefaultCellStyle = dataGridViewCellStyle2;
            this.nombrw.HeaderText = "Nombre";
            this.nombrw.Name = "nombrw";
            // 
            // apellido
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 12F);
            this.apellido.DefaultCellStyle = dataGridViewCellStyle3;
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.linea_detalles);
            this.Controls.Add(this.panel_detalles);
            this.Controls.Add(this.tabla);
            this.Controls.Add(this.linea_menu);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.barra_superior);
            this.Name = "inicio";
            this.Text = "ADMINISTRADORA UCAB";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label barra_superior;
        private System.Windows.Forms.FlowLayoutPanel menu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label edificio;
        private System.Windows.Forms.Panel icono;
        private System.Windows.Forms.Label linea_menu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label apartamento;
        private System.Windows.Forms.Panel icono2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label propietario;
        private System.Windows.Forms.Panel icono3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label junta;
        private System.Windows.Forms.Panel icono4;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label gasto;
        private System.Windows.Forms.Panel icono5;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label aviso;
        private System.Windows.Forms.Panel icono6;
        private System.Windows.Forms.DataGridView tabla;
        private System.Windows.Forms.Panel panel_detalles;
        private System.Windows.Forms.Label linea_detalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrw;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
    }
}

