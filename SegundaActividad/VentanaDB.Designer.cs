namespace SegundaActividad
{
    partial class VentanaDB
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
            this.lblContenidoDB = new System.Windows.Forms.Label();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.pbxProducto = new System.Windows.Forms.PictureBox();
            this.btnMostrarTodo = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pnlFondo = new System.Windows.Forms.Panel();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txbIngresarCodigo = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblIdMarca = new System.Windows.Forms.Label();
            this.lblIdCateogria = new System.Windows.Forms.Label();
            this.txbIngresarNombre = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProducto)).BeginInit();
            this.pnlFondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblContenidoDB
            // 
            this.lblContenidoDB.AutoSize = true;
            this.lblContenidoDB.Location = new System.Drawing.Point(17, 16);
            this.lblContenidoDB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContenidoDB.Name = "lblContenidoDB";
            this.lblContenidoDB.Size = new System.Drawing.Size(90, 16);
            this.lblContenidoDB.TabIndex = 0;
            this.lblContenidoDB.Text = "Contenido DB";
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(16, 62);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.Size = new System.Drawing.Size(874, 207);
            this.dgvArticulos.TabIndex = 1;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // pbxProducto
            // 
            this.pbxProducto.Location = new System.Drawing.Point(20, 308);
            this.pbxProducto.Name = "pbxProducto";
            this.pbxProducto.Size = new System.Drawing.Size(249, 219);
            this.pbxProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxProducto.TabIndex = 2;
            this.pbxProducto.TabStop = false;
            // 
            // btnMostrarTodo
            // 
            this.btnMostrarTodo.Location = new System.Drawing.Point(906, 62);
            this.btnMostrarTodo.Name = "btnMostrarTodo";
            this.btnMostrarTodo.Size = new System.Drawing.Size(149, 35);
            this.btnMostrarTodo.TabIndex = 3;
            this.btnMostrarTodo.Text = "Mostrar Todo";
            this.btnMostrarTodo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnMostrarTodo.UseVisualStyleBackColor = true;
            this.btnMostrarTodo.Click += new System.EventHandler(this.btnMostrarTodo_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(906, 310);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(149, 35);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregarArticulo_Click);
            // 
            // pnlFondo
            // 
            this.pnlFondo.BackColor = System.Drawing.Color.DarkCyan;
            this.pnlFondo.Controls.Add(this.pictureBox1);
            this.pnlFondo.Controls.Add(this.textBox4);
            this.pnlFondo.Controls.Add(this.textBox3);
            this.pnlFondo.Controls.Add(this.textBox2);
            this.pnlFondo.Controls.Add(this.textBox1);
            this.pnlFondo.Controls.Add(this.txbIngresarNombre);
            this.pnlFondo.Controls.Add(this.lblIdCateogria);
            this.pnlFondo.Controls.Add(this.lblIdMarca);
            this.pnlFondo.Controls.Add(this.lblDescripcion);
            this.pnlFondo.Controls.Add(this.lblPrecio);
            this.pnlFondo.Controls.Add(this.lblNombre);
            this.pnlFondo.Controls.Add(this.txbIngresarCodigo);
            this.pnlFondo.Controls.Add(this.lblCodigo);
            this.pnlFondo.Location = new System.Drawing.Point(297, 308);
            this.pnlFondo.Name = "pnlFondo";
            this.pnlFondo.Size = new System.Drawing.Size(593, 219);
            this.pnlFondo.TabIndex = 6;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.DarkGray;
            this.lblCodigo.Location = new System.Drawing.Point(17, 18);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(57, 16);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo: ";
            // 
            // txbIngresarCodigo
            // 
            this.txbIngresarCodigo.Location = new System.Drawing.Point(116, 15);
            this.txbIngresarCodigo.Name = "txbIngresarCodigo";
            this.txbIngresarCodigo.Size = new System.Drawing.Size(120, 22);
            this.txbIngresarCodigo.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.DarkGray;
            this.lblNombre.Location = new System.Drawing.Point(17, 50);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.Color.DarkGray;
            this.lblPrecio.Location = new System.Drawing.Point(17, 178);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(52, 16);
            this.lblPrecio.TabIndex = 3;
            this.lblPrecio.Text = "Precio: ";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.Color.DarkGray;
            this.lblDescripcion.Location = new System.Drawing.Point(17, 81);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(79, 16);
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblIdMarca
            // 
            this.lblIdMarca.AutoSize = true;
            this.lblIdMarca.BackColor = System.Drawing.Color.DarkGray;
            this.lblIdMarca.Location = new System.Drawing.Point(17, 114);
            this.lblIdMarca.Name = "lblIdMarca";
            this.lblIdMarca.Size = new System.Drawing.Size(62, 16);
            this.lblIdMarca.TabIndex = 5;
            this.lblIdMarca.Text = "Id Marca:";
            // 
            // lblIdCateogria
            // 
            this.lblIdCateogria.AutoSize = true;
            this.lblIdCateogria.BackColor = System.Drawing.Color.DarkGray;
            this.lblIdCateogria.Enabled = false;
            this.lblIdCateogria.Location = new System.Drawing.Point(17, 145);
            this.lblIdCateogria.Name = "lblIdCateogria";
            this.lblIdCateogria.Size = new System.Drawing.Size(83, 16);
            this.lblIdCateogria.TabIndex = 6;
            this.lblIdCateogria.Text = "Id Categoria:";
            // 
            // txbIngresarNombre
            // 
            this.txbIngresarNombre.Location = new System.Drawing.Point(116, 44);
            this.txbIngresarNombre.Name = "txbIngresarNombre";
            this.txbIngresarNombre.Size = new System.Drawing.Size(120, 22);
            this.txbIngresarNombre.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(116, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 22);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(116, 111);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 22);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(116, 142);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(120, 22);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(116, 175);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(120, 22);
            this.textBox4.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(334, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 136);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // VentanaDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pnlFondo);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnMostrarTodo);
            this.Controls.Add(this.pbxProducto);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.lblContenidoDB);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VentanaDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Base de Datos";
            this.Load += new System.EventHandler(this.VentanaDB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProducto)).EndInit();
            this.pnlFondo.ResumeLayout(false);
            this.pnlFondo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContenidoDB;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox pbxProducto;
        private System.Windows.Forms.Button btnMostrarTodo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel pnlFondo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txbIngresarCodigo;
        private System.Windows.Forms.Label lblIdCateogria;
        private System.Windows.Forms.Label lblIdMarca;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txbIngresarNombre;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}