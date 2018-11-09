namespace formProveedorProductos
{
    partial class formProveedores
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabProveedor = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.lbid = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbtitulo = new System.Windows.Forms.Label();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.lblapellidos = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblnombres = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.btneliminar1 = new System.Windows.Forms.Button();
            this.tabProveedor.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // tabProveedor
            // 
            this.tabProveedor.Controls.Add(this.tabPage1);
            this.tabProveedor.Controls.Add(this.tabPage2);
            this.tabProveedor.Location = new System.Drawing.Point(0, 2);
            this.tabProveedor.Name = "tabProveedor";
            this.tabProveedor.SelectedIndex = 0;
            this.tabProveedor.Size = new System.Drawing.Size(549, 262);
            this.tabProveedor.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtcodigo);
            this.tabPage1.Controls.Add(this.lbid);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.lbtitulo);
            this.tabPage1.Controls.Add(this.txttelefono);
            this.tabPage1.Controls.Add(this.lbltelefono);
            this.tabPage1.Controls.Add(this.txtdireccion);
            this.tabPage1.Controls.Add(this.lblapellidos);
            this.tabPage1.Controls.Add(this.txtnombre);
            this.tabPage1.Controls.Add(this.lblnombres);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(541, 236);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registrar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(59, 42);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(225, 20);
            this.txtcodigo.TabIndex = 26;
            // 
            // lbid
            // 
            this.lbid.AutoSize = true;
            this.lbid.Location = new System.Drawing.Point(3, 45);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(18, 13);
            this.lbid.TabIndex = 25;
            this.lbid.Text = "ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbtitulo
            // 
            this.lbtitulo.AutoSize = true;
            this.lbtitulo.Location = new System.Drawing.Point(67, 25);
            this.lbtitulo.Name = "lbtitulo";
            this.lbtitulo.Size = new System.Drawing.Size(124, 13);
            this.lbtitulo.TabIndex = 22;
            this.lbtitulo.Text = "Registro de Proveedores";
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(60, 148);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(100, 20);
            this.txttelefono.TabIndex = 21;
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.Location = new System.Drawing.Point(0, 148);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(49, 13);
            this.lbltelefono.TabIndex = 20;
            this.lbltelefono.Text = "Teléfono";
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(59, 113);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(220, 20);
            this.txtdireccion.TabIndex = 19;
            // 
            // lblapellidos
            // 
            this.lblapellidos.AutoSize = true;
            this.lblapellidos.Location = new System.Drawing.Point(0, 113);
            this.lblapellidos.Name = "lblapellidos";
            this.lblapellidos.Size = new System.Drawing.Size(52, 13);
            this.lblapellidos.TabIndex = 18;
            this.lblapellidos.Text = "Dirección";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(59, 76);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(220, 20);
            this.txtnombre.TabIndex = 17;
            // 
            // lblnombres
            // 
            this.lblnombres.AutoSize = true;
            this.lblnombres.Location = new System.Drawing.Point(1, 76);
            this.lblnombres.Name = "lblnombres";
            this.lblnombres.Size = new System.Drawing.Size(49, 13);
            this.lblnombres.TabIndex = 16;
            this.lblnombres.Text = "Nombres";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btneliminar1);
            this.tabPage2.Controls.Add(this.btnEditar);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtbuscar);
            this.tabPage2.Controls.Add(this.btnbuscar);
            this.tabPage2.Controls.Add(this.dgvProveedores);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(541, 236);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalles";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(277, 29);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Buscar";
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(51, 29);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(139, 20);
            this.txtbuscar.TabIndex = 2;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(196, 29);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 1;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.AllowUserToAddRows = false;
            this.dgvProveedores.AllowUserToDeleteRows = false;
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Location = new System.Drawing.Point(37, 81);
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.ReadOnly = true;
            this.dgvProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProveedores.Size = new System.Drawing.Size(460, 150);
            this.dgvProveedores.TabIndex = 0;
            this.dgvProveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProveedores_CellContentClick);
            // 
            // btneliminar1
            // 
            this.btneliminar1.Location = new System.Drawing.Point(364, 29);
            this.btneliminar1.Name = "btneliminar1";
            this.btneliminar1.Size = new System.Drawing.Size(75, 23);
            this.btneliminar1.TabIndex = 5;
            this.btneliminar1.Text = "Eliminar";
            this.btneliminar1.UseVisualStyleBackColor = true;
            this.btneliminar1.Click += new System.EventHandler(this.btneliminar1_Click);
            // 
            // formProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 293);
            this.Controls.Add(this.tabProveedor);
            this.Name = "formProveedores";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.formProveedores_Load);
            this.tabProveedor.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabProveedor;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbtitulo;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Label lbltelefono;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.Label lblapellidos;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblnombres;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label lbid;
        private System.Windows.Forms.Button btneliminar1;
    }
}

