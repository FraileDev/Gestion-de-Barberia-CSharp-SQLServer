
namespace BarberH
{
    partial class Inventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventario));
            this.tboBuscar = new System.Windows.Forms.TextBox();
            this.tboPrecioMay = new System.Windows.Forms.TextBox();
            this.tboPrecioUni = new System.Windows.Forms.TextBox();
            this.tboNombre = new System.Windows.Forms.TextBox();
            this.tboIdProducto = new System.Windows.Forms.TextBox();
            this.tboExistencia = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnAtras = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tboBuscar
            // 
            this.tboBuscar.Location = new System.Drawing.Point(97, 15);
            this.tboBuscar.Name = "tboBuscar";
            this.tboBuscar.Size = new System.Drawing.Size(142, 20);
            this.tboBuscar.TabIndex = 0;
            // 
            // tboPrecioMay
            // 
            this.tboPrecioMay.Location = new System.Drawing.Point(348, 129);
            this.tboPrecioMay.Name = "tboPrecioMay";
            this.tboPrecioMay.Size = new System.Drawing.Size(100, 20);
            this.tboPrecioMay.TabIndex = 1;
            this.tboPrecioMay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboPrecioMay_KeyPress);
            // 
            // tboPrecioUni
            // 
            this.tboPrecioUni.Location = new System.Drawing.Point(101, 129);
            this.tboPrecioUni.Name = "tboPrecioUni";
            this.tboPrecioUni.Size = new System.Drawing.Size(100, 20);
            this.tboPrecioUni.TabIndex = 2;
            this.tboPrecioUni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboPrecioUni_KeyPress);
            // 
            // tboNombre
            // 
            this.tboNombre.Location = new System.Drawing.Point(348, 83);
            this.tboNombre.Name = "tboNombre";
            this.tboNombre.Size = new System.Drawing.Size(100, 20);
            this.tboNombre.TabIndex = 3;
            this.tboNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboNombre_KeyPress);
            // 
            // tboIdProducto
            // 
            this.tboIdProducto.Location = new System.Drawing.Point(101, 83);
            this.tboIdProducto.Name = "tboIdProducto";
            this.tboIdProducto.Size = new System.Drawing.Size(100, 20);
            this.tboIdProducto.TabIndex = 4;
            // 
            // tboExistencia
            // 
            this.tboExistencia.Location = new System.Drawing.Point(558, 83);
            this.tboExistencia.Name = "tboExistencia";
            this.tboExistencia.Size = new System.Drawing.Size(100, 20);
            this.tboExistencia.TabIndex = 5;
            this.tboExistencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboExistencia_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(21, 168);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(625, 250);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnMostrar.FlatAppearance.BorderSize = 0;
            this.btnMostrar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.ForeColor = System.Drawing.Color.White;
            this.btnMostrar.Location = new System.Drawing.Point(3, 82);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(135, 29);
            this.btnMostrar.TabIndex = 7;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Black;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(32, 15);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(59, 20);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(3, 130);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(135, 29);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(3, 177);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(135, 29);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(3, 235);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(135, 29);
            this.button5.TabIndex = 11;
            this.button5.Text = "Eliminar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Precio mayorista:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Precio unitario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(489, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Existencias:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "id_producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nombre producto:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(6, 344);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(135, 33);
            this.btnLimpiar.TabIndex = 23;
            this.btnLimpiar.Text = "Limpiar datos";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.btnAtras);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnMostrar);
            this.panel2.Controls.Add(this.btnLimpiar);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.btnModificar);
            this.panel2.Controls.Add(this.btnAgregar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(141, 482);
            this.panel2.TabIndex = 25;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel8.Location = new System.Drawing.Point(3, 344);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(5, 33);
            this.panel8.TabIndex = 28;
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAtras.FlatAppearance.BorderSize = 0;
            this.btnAtras.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.ForeColor = System.Drawing.Color.White;
            this.btnAtras.Location = new System.Drawing.Point(6, 441);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(135, 33);
            this.btnAtras.TabIndex = 28;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel7.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel7.Location = new System.Drawing.Point(3, 441);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(5, 33);
            this.panel7.TabIndex = 27;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel6.Location = new System.Drawing.Point(3, 235);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 29);
            this.panel6.TabIndex = 27;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel5.Location = new System.Drawing.Point(3, 177);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 29);
            this.panel5.TabIndex = 27;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel4.Location = new System.Drawing.Point(3, 130);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 29);
            this.panel4.TabIndex = 27;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Location = new System.Drawing.Point(3, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 29);
            this.panel3.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.tboExistencia);
            this.panel1.Controls.Add(this.tboIdProducto);
            this.panel1.Controls.Add(this.tboNombre);
            this.panel1.Controls.Add(this.tboPrecioUni);
            this.panel1.Controls.Add(this.tboPrecioMay);
            this.panel1.Controls.Add(this.tboBuscar);
            this.panel1.Location = new System.Drawing.Point(157, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 436);
            this.panel1.TabIndex = 26;
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(839, 482);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Inventario";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tboBuscar;
        private System.Windows.Forms.TextBox tboPrecioMay;
        private System.Windows.Forms.TextBox tboPrecioUni;
        private System.Windows.Forms.TextBox tboNombre;
        private System.Windows.Forms.TextBox tboIdProducto;
        private System.Windows.Forms.TextBox tboExistencia;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnAtras;
    }
}

