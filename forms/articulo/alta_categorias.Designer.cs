namespace PrimeSystems_2._2_.forms.articulo
{
    partial class alta_categorias
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
            this.gb_categoria = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_eliminar_categoria = new System.Windows.Forms.Button();
            this.btn_modificar_categoria = new System.Windows.Forms.Button();
            this.btn_agregar_categoria = new System.Windows.Forms.Button();
            this.lista = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_subcategoria = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_eliminar_subcat = new System.Windows.Forms.Button();
            this.btn_modificar_subcategoria = new System.Windows.Forms.Button();
            this.btn_agregar_subcategoria = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.categoria = new System.Windows.Forms.ComboBox();
            this.nombre_subcategoria = new System.Windows.Forms.Label();
            this.btn_cerrar_altaCat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_subcategoria = new System.Windows.Forms.TextBox();
            this.gb_categoria.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).BeginInit();
            this.gb_subcategoria.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_categoria
            // 
            this.gb_categoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.gb_categoria.Controls.Add(this.panel1);
            this.gb_categoria.Controls.Add(this.lista);
            this.gb_categoria.Controls.Add(this.nombre);
            this.gb_categoria.Controls.Add(this.label1);
            this.gb_categoria.Location = new System.Drawing.Point(27, 28);
            this.gb_categoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_categoria.Name = "gb_categoria";
            this.gb_categoria.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_categoria.Size = new System.Drawing.Size(557, 354);
            this.gb_categoria.TabIndex = 0;
            this.gb_categoria.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_eliminar_categoria);
            this.panel1.Controls.Add(this.btn_modificar_categoria);
            this.panel1.Controls.Add(this.btn_agregar_categoria);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 286);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 66);
            this.panel1.TabIndex = 3;
            // 
            // btn_eliminar_categoria
            // 
            this.btn_eliminar_categoria.AutoSize = true;
            this.btn_eliminar_categoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(100)))), ((int)(((byte)(89)))));
            this.btn_eliminar_categoria.FlatAppearance.BorderSize = 0;
            this.btn_eliminar_categoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar_categoria.ForeColor = System.Drawing.Color.Black;
            this.btn_eliminar_categoria.Location = new System.Drawing.Point(353, 14);
            this.btn_eliminar_categoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_eliminar_categoria.Name = "btn_eliminar_categoria";
            this.btn_eliminar_categoria.Size = new System.Drawing.Size(87, 32);
            this.btn_eliminar_categoria.TabIndex = 2;
            this.btn_eliminar_categoria.Text = "Eliminar";
            this.btn_eliminar_categoria.UseVisualStyleBackColor = false;
            // 
            // btn_modificar_categoria
            // 
            this.btn_modificar_categoria.AutoSize = true;
            this.btn_modificar_categoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(234)))), ((int)(((byte)(239)))));
            this.btn_modificar_categoria.FlatAppearance.BorderSize = 0;
            this.btn_modificar_categoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modificar_categoria.Location = new System.Drawing.Point(224, 14);
            this.btn_modificar_categoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_modificar_categoria.Name = "btn_modificar_categoria";
            this.btn_modificar_categoria.Size = new System.Drawing.Size(96, 32);
            this.btn_modificar_categoria.TabIndex = 1;
            this.btn_modificar_categoria.Text = "Modificar";
            this.btn_modificar_categoria.UseVisualStyleBackColor = false;
            // 
            // btn_agregar_categoria
            // 
            this.btn_agregar_categoria.AutoSize = true;
            this.btn_agregar_categoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(141)))), ((int)(((byte)(190)))));
            this.btn_agregar_categoria.FlatAppearance.BorderSize = 0;
            this.btn_agregar_categoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar_categoria.ForeColor = System.Drawing.Color.White;
            this.btn_agregar_categoria.Location = new System.Drawing.Point(92, 14);
            this.btn_agregar_categoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_agregar_categoria.Name = "btn_agregar_categoria";
            this.btn_agregar_categoria.Size = new System.Drawing.Size(88, 32);
            this.btn_agregar_categoria.TabIndex = 0;
            this.btn_agregar_categoria.Text = "Agregar";
            this.btn_agregar_categoria.UseVisualStyleBackColor = false;
            // 
            // lista
            // 
            this.lista.BackgroundColor = System.Drawing.Color.White;
            this.lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lista.Location = new System.Drawing.Point(24, 108);
            this.lista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lista.Name = "lista";
            this.lista.RowHeadersWidth = 51;
            this.lista.RowTemplate.Height = 28;
            this.lista.Size = new System.Drawing.Size(508, 139);
            this.lista.TabIndex = 2;
            // 
            // nombre
            // 
            this.nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nombre.Location = new System.Drawing.Point(212, 50);
            this.nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(283, 22);
            this.nombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre categoria";
            // 
            // gb_subcategoria
            // 
            this.gb_subcategoria.AutoSize = true;
            this.gb_subcategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.gb_subcategoria.Controls.Add(this.txt_subcategoria);
            this.gb_subcategoria.Controls.Add(this.label2);
            this.gb_subcategoria.Controls.Add(this.panel2);
            this.gb_subcategoria.Controls.Add(this.dataGridView2);
            this.gb_subcategoria.Controls.Add(this.categoria);
            this.gb_subcategoria.Controls.Add(this.nombre_subcategoria);
            this.gb_subcategoria.Location = new System.Drawing.Point(631, 28);
            this.gb_subcategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_subcategoria.Name = "gb_subcategoria";
            this.gb_subcategoria.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_subcategoria.Size = new System.Drawing.Size(551, 354);
            this.gb_subcategoria.TabIndex = 1;
            this.gb_subcategoria.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_eliminar_subcat);
            this.panel2.Controls.Add(this.btn_modificar_subcategoria);
            this.panel2.Controls.Add(this.btn_agregar_subcategoria);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 286);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(545, 66);
            this.panel2.TabIndex = 4;
            // 
            // btn_eliminar_subcat
            // 
            this.btn_eliminar_subcat.AutoSize = true;
            this.btn_eliminar_subcat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(100)))), ((int)(((byte)(89)))));
            this.btn_eliminar_subcat.FlatAppearance.BorderSize = 0;
            this.btn_eliminar_subcat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar_subcat.ForeColor = System.Drawing.Color.Black;
            this.btn_eliminar_subcat.Location = new System.Drawing.Point(365, 14);
            this.btn_eliminar_subcat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_eliminar_subcat.Name = "btn_eliminar_subcat";
            this.btn_eliminar_subcat.Size = new System.Drawing.Size(87, 32);
            this.btn_eliminar_subcat.TabIndex = 5;
            this.btn_eliminar_subcat.Text = "Eliminar";
            this.btn_eliminar_subcat.UseVisualStyleBackColor = false;
            // 
            // btn_modificar_subcategoria
            // 
            this.btn_modificar_subcategoria.AutoSize = true;
            this.btn_modificar_subcategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(234)))), ((int)(((byte)(239)))));
            this.btn_modificar_subcategoria.FlatAppearance.BorderSize = 0;
            this.btn_modificar_subcategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modificar_subcategoria.Location = new System.Drawing.Point(236, 14);
            this.btn_modificar_subcategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_modificar_subcategoria.Name = "btn_modificar_subcategoria";
            this.btn_modificar_subcategoria.Size = new System.Drawing.Size(96, 32);
            this.btn_modificar_subcategoria.TabIndex = 4;
            this.btn_modificar_subcategoria.Text = "Modificar";
            this.btn_modificar_subcategoria.UseVisualStyleBackColor = false;
            // 
            // btn_agregar_subcategoria
            // 
            this.btn_agregar_subcategoria.AutoSize = true;
            this.btn_agregar_subcategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(141)))), ((int)(((byte)(190)))));
            this.btn_agregar_subcategoria.FlatAppearance.BorderSize = 0;
            this.btn_agregar_subcategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar_subcategoria.ForeColor = System.Drawing.Color.White;
            this.btn_agregar_subcategoria.Location = new System.Drawing.Point(104, 14);
            this.btn_agregar_subcategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_agregar_subcategoria.Name = "btn_agregar_subcategoria";
            this.btn_agregar_subcategoria.Size = new System.Drawing.Size(88, 32);
            this.btn_agregar_subcategoria.TabIndex = 3;
            this.btn_agregar_subcategoria.Text = "Agregar";
            this.btn_agregar_subcategoria.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(32, 160);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(491, 122);
            this.dataGridView2.TabIndex = 3;
            // 
            // categoria
            // 
            this.categoria.FormattingEnabled = true;
            this.categoria.Location = new System.Drawing.Point(258, 31);
            this.categoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.categoria.Name = "categoria";
            this.categoria.Size = new System.Drawing.Size(243, 24);
            this.categoria.TabIndex = 2;
            // 
            // nombre_subcategoria
            // 
            this.nombre_subcategoria.AutoSize = true;
            this.nombre_subcategoria.Location = new System.Drawing.Point(73, 39);
            this.nombre_subcategoria.Name = "nombre_subcategoria";
            this.nombre_subcategoria.Size = new System.Drawing.Size(66, 16);
            this.nombre_subcategoria.TabIndex = 1;
            this.nombre_subcategoria.Text = "Categoria";
            // 
            // btn_cerrar_altaCat
            // 
            this.btn_cerrar_altaCat.AutoSize = true;
            this.btn_cerrar_altaCat.Location = new System.Drawing.Point(543, 402);
            this.btn_cerrar_altaCat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cerrar_altaCat.Name = "btn_cerrar_altaCat";
            this.btn_cerrar_altaCat.Size = new System.Drawing.Size(120, 28);
            this.btn_cerrar_altaCat.TabIndex = 2;
            this.btn_cerrar_altaCat.Text = "cerrar";
            this.btn_cerrar_altaCat.UseVisualStyleBackColor = true;
            this.btn_cerrar_altaCat.Click += new System.EventHandler(this.btn_cerrar_altaCat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre subcategoria";
            // 
            // txt_subcategoria
            // 
            this.txt_subcategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_subcategoria.Location = new System.Drawing.Point(258, 102);
            this.txt_subcategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_subcategoria.Name = "txt_subcategoria";
            this.txt_subcategoria.Size = new System.Drawing.Size(243, 22);
            this.txt_subcategoria.TabIndex = 4;
            // 
            // alta_categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1212, 441);
            this.Controls.Add(this.btn_cerrar_altaCat);
            this.Controls.Add(this.gb_subcategoria);
            this.Controls.Add(this.gb_categoria);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "alta_categorias";
            this.Text = "gestion de categorias";
            this.Load += new System.EventHandler(this.alta_categorias_Load);
            this.gb_categoria.ResumeLayout(false);
            this.gb_categoria.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lista)).EndInit();
            this.gb_subcategoria.ResumeLayout(false);
            this.gb_subcategoria.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_categoria;
        private System.Windows.Forms.GroupBox gb_subcategoria;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView lista;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox categoria;
        private System.Windows.Forms.Label nombre_subcategoria;
        private System.Windows.Forms.Button btn_eliminar_categoria;
        private System.Windows.Forms.Button btn_modificar_categoria;
        private System.Windows.Forms.Button btn_agregar_categoria;
        private System.Windows.Forms.Button btn_eliminar_subcat;
        private System.Windows.Forms.Button btn_modificar_subcategoria;
        private System.Windows.Forms.Button btn_agregar_subcategoria;
        private System.Windows.Forms.Button btn_cerrar_altaCat;
        private System.Windows.Forms.TextBox txt_subcategoria;
        private System.Windows.Forms.Label label2;
    }
}