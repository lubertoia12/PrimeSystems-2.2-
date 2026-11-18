namespace PrimeSystems_2._2_.forms.compras
{
    partial class compras_interfaz
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_fondo = new System.Windows.Forms.Panel();
            this.panelcont = new System.Windows.Forms.Panel();
            this.dgv_compras_h = new System.Windows.Forms.DataGridView();
            this.pnl_botones = new System.Windows.Forms.Panel();
            this.gb_botonesABM_ventas = new System.Windows.Forms.GroupBox();
            this.btn_borrar_compra = new System.Windows.Forms.Button();
            this.btn_nueva_compra = new System.Windows.Forms.Button();
            this.btn_modificar_compra = new System.Windows.Forms.Button();
            this.btn_cancelar_compra = new System.Windows.Forms.Button();
            this.pnl_filtro = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_filtro_activas = new System.Windows.Forms.Button();
            this.btn_filtro_inactivas = new System.Windows.Forms.Button();
            this.btn_filtro_todos = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.panel_fondo.SuspendLayout();
            this.panelcont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_compras_h)).BeginInit();
            this.pnl_botones.SuspendLayout();
            this.gb_botonesABM_ventas.SuspendLayout();
            this.pnl_filtro.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_fondo
            // 
            this.panel_fondo.AutoScroll = true;
            this.panel_fondo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.panel_fondo.Controls.Add(this.panelcont);
            this.panel_fondo.Controls.Add(this.pnl_botones);
            this.panel_fondo.Controls.Add(this.pnl_filtro);
            this.panel_fondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_fondo.Location = new System.Drawing.Point(0, 0);
            this.panel_fondo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_fondo.Name = "panel_fondo";
            this.panel_fondo.Size = new System.Drawing.Size(1520, 742);
            this.panel_fondo.TabIndex = 1;
            // 
            // panelcont
            // 
            this.panelcont.AutoScroll = true;
            this.panelcont.Controls.Add(this.dgv_compras_h);
            this.panelcont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcont.Location = new System.Drawing.Point(0, 86);
            this.panelcont.Name = "panelcont";
            this.panelcont.Size = new System.Drawing.Size(1351, 656);
            this.panelcont.TabIndex = 8;
            // 
            // dgv_compras_h
            // 
            this.dgv_compras_h.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.dgv_compras_h.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_compras_h.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_compras_h.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_compras_h.BackgroundColor = System.Drawing.Color.White;
            this.dgv_compras_h.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_compras_h.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(230)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_compras_h.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_compras_h.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_compras_h.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_compras_h.EnableHeadersVisualStyles = false;
            this.dgv_compras_h.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(232)))), ((int)(((byte)(237)))));
            this.dgv_compras_h.Location = new System.Drawing.Point(80, 74);
            this.dgv_compras_h.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_compras_h.Name = "dgv_compras_h";
            this.dgv_compras_h.RowHeadersVisible = false;
            this.dgv_compras_h.RowHeadersWidth = 51;
            this.dgv_compras_h.RowTemplate.Height = 24;
            this.dgv_compras_h.Size = new System.Drawing.Size(1176, 316);
            this.dgv_compras_h.TabIndex = 3;
            // 
            // pnl_botones
            // 
            this.pnl_botones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.pnl_botones.Controls.Add(this.gb_botonesABM_ventas);
            this.pnl_botones.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_botones.Location = new System.Drawing.Point(1351, 86);
            this.pnl_botones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_botones.Name = "pnl_botones";
            this.pnl_botones.Size = new System.Drawing.Size(169, 656);
            this.pnl_botones.TabIndex = 6;
            // 
            // gb_botonesABM_ventas
            // 
            this.gb_botonesABM_ventas.BackColor = System.Drawing.Color.White;
            this.gb_botonesABM_ventas.Controls.Add(this.btn_borrar_compra);
            this.gb_botonesABM_ventas.Controls.Add(this.btn_nueva_compra);
            this.gb_botonesABM_ventas.Controls.Add(this.btn_modificar_compra);
            this.gb_botonesABM_ventas.Controls.Add(this.btn_cancelar_compra);
            this.gb_botonesABM_ventas.Location = new System.Drawing.Point(3, -6);
            this.gb_botonesABM_ventas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_botonesABM_ventas.Name = "gb_botonesABM_ventas";
            this.gb_botonesABM_ventas.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_botonesABM_ventas.Size = new System.Drawing.Size(163, 369);
            this.gb_botonesABM_ventas.TabIndex = 0;
            this.gb_botonesABM_ventas.TabStop = false;
            // 
            // btn_borrar_compra
            // 
            this.btn_borrar_compra.AutoSize = true;
            this.btn_borrar_compra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(100)))), ((int)(((byte)(89)))));
            this.btn_borrar_compra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_borrar_compra.FlatAppearance.BorderSize = 0;
            this.btn_borrar_compra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_borrar_compra.ForeColor = System.Drawing.Color.White;
            this.btn_borrar_compra.Location = new System.Drawing.Point(17, 197);
            this.btn_borrar_compra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_borrar_compra.Name = "btn_borrar_compra";
            this.btn_borrar_compra.Size = new System.Drawing.Size(129, 59);
            this.btn_borrar_compra.TabIndex = 10;
            this.btn_borrar_compra.Text = "BORRAR";
            this.btn_borrar_compra.UseVisualStyleBackColor = false;
            // 
            // btn_nueva_compra
            // 
            this.btn_nueva_compra.AutoSize = true;
            this.btn_nueva_compra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(141)))), ((int)(((byte)(190)))));
            this.btn_nueva_compra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nueva_compra.FlatAppearance.BorderSize = 0;
            this.btn_nueva_compra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(122)))), ((int)(((byte)(166)))));
            this.btn_nueva_compra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nueva_compra.ForeColor = System.Drawing.Color.White;
            this.btn_nueva_compra.Location = new System.Drawing.Point(17, 30);
            this.btn_nueva_compra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_nueva_compra.Name = "btn_nueva_compra";
            this.btn_nueva_compra.Size = new System.Drawing.Size(129, 59);
            this.btn_nueva_compra.TabIndex = 9;
            this.btn_nueva_compra.Text = "NUEVO";
            this.btn_nueva_compra.UseVisualStyleBackColor = false;
            this.btn_nueva_compra.Click += new System.EventHandler(this.btn_nueva_compra_Click);
            // 
            // btn_modificar_compra
            // 
            this.btn_modificar_compra.AutoSize = true;
            this.btn_modificar_compra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(234)))), ((int)(((byte)(239)))));
            this.btn_modificar_compra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_modificar_compra.FlatAppearance.BorderSize = 0;
            this.btn_modificar_compra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(227)))));
            this.btn_modificar_compra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modificar_compra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.btn_modificar_compra.Location = new System.Drawing.Point(17, 114);
            this.btn_modificar_compra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_modificar_compra.Name = "btn_modificar_compra";
            this.btn_modificar_compra.Size = new System.Drawing.Size(129, 59);
            this.btn_modificar_compra.TabIndex = 8;
            this.btn_modificar_compra.Text = "MODIFICAR";
            this.btn_modificar_compra.UseVisualStyleBackColor = false;
            // 
            // btn_cancelar_compra
            // 
            this.btn_cancelar_compra.AutoSize = true;
            this.btn_cancelar_compra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.btn_cancelar_compra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar_compra.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(202)))), ((int)(((byte)(212)))));
            this.btn_cancelar_compra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.btn_cancelar_compra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar_compra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.btn_cancelar_compra.Location = new System.Drawing.Point(17, 277);
            this.btn_cancelar_compra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cancelar_compra.Name = "btn_cancelar_compra";
            this.btn_cancelar_compra.Size = new System.Drawing.Size(129, 59);
            this.btn_cancelar_compra.TabIndex = 7;
            this.btn_cancelar_compra.Text = "CANCELAR";
            this.btn_cancelar_compra.UseVisualStyleBackColor = false;
            // 
            // pnl_filtro
            // 
            this.pnl_filtro.BackColor = System.Drawing.Color.White;
            this.pnl_filtro.Controls.Add(this.label5);
            this.pnl_filtro.Controls.Add(this.btn_filtro_activas);
            this.pnl_filtro.Controls.Add(this.btn_filtro_inactivas);
            this.pnl_filtro.Controls.Add(this.btn_filtro_todos);
            this.pnl_filtro.Controls.Add(this.label3);
            this.pnl_filtro.Controls.Add(this.txt_cliente);
            this.pnl_filtro.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_filtro.Location = new System.Drawing.Point(0, 0);
            this.pnl_filtro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_filtro.Name = "pnl_filtro";
            this.pnl_filtro.Size = new System.Drawing.Size(1520, 86);
            this.pnl_filtro.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.label5.Location = new System.Drawing.Point(247, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Proveedor:";
            // 
            // btn_filtro_activas
            // 
            this.btn_filtro_activas.AutoSize = true;
            this.btn_filtro_activas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(234)))), ((int)(((byte)(239)))));
            this.btn_filtro_activas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_filtro_activas.FlatAppearance.BorderSize = 0;
            this.btn_filtro_activas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(227)))));
            this.btn_filtro_activas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_filtro_activas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.btn_filtro_activas.Location = new System.Drawing.Point(700, 25);
            this.btn_filtro_activas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_filtro_activas.Name = "btn_filtro_activas";
            this.btn_filtro_activas.Size = new System.Drawing.Size(99, 32);
            this.btn_filtro_activas.TabIndex = 4;
            this.btn_filtro_activas.Text = "ACTIVAS";
            this.btn_filtro_activas.UseVisualStyleBackColor = false;
            this.btn_filtro_activas.Click += new System.EventHandler(this.btn_filtro_activas_Click);
            // 
            // btn_filtro_inactivas
            // 
            this.btn_filtro_inactivas.AutoSize = true;
            this.btn_filtro_inactivas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(234)))), ((int)(((byte)(239)))));
            this.btn_filtro_inactivas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_filtro_inactivas.FlatAppearance.BorderSize = 0;
            this.btn_filtro_inactivas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(227)))));
            this.btn_filtro_inactivas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_filtro_inactivas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.btn_filtro_inactivas.Location = new System.Drawing.Point(818, 26);
            this.btn_filtro_inactivas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_filtro_inactivas.Name = "btn_filtro_inactivas";
            this.btn_filtro_inactivas.Size = new System.Drawing.Size(116, 32);
            this.btn_filtro_inactivas.TabIndex = 3;
            this.btn_filtro_inactivas.Text = "INACTIVAS";
            this.btn_filtro_inactivas.UseVisualStyleBackColor = false;
            this.btn_filtro_inactivas.Click += new System.EventHandler(this.btn_filtro_inactivas_Click);
            // 
            // btn_filtro_todos
            // 
            this.btn_filtro_todos.AutoSize = true;
            this.btn_filtro_todos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(227)))), ((int)(((byte)(241)))));
            this.btn_filtro_todos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_filtro_todos.FlatAppearance.BorderSize = 0;
            this.btn_filtro_todos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(215)))), ((int)(((byte)(233)))));
            this.btn_filtro_todos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_filtro_todos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(77)))));
            this.btn_filtro_todos.Location = new System.Drawing.Point(587, 25);
            this.btn_filtro_todos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_filtro_todos.Name = "btn_filtro_todos";
            this.btn_filtro_todos.Size = new System.Drawing.Size(85, 32);
            this.btn_filtro_todos.TabIndex = 2;
            this.btn_filtro_todos.Text = "TODAS";
            this.btn_filtro_todos.UseVisualStyleBackColor = false;
            this.btn_filtro_todos.Click += new System.EventHandler(this.btn_filtro_todos_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.label3.Location = new System.Drawing.Point(77, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "BUSCAR POR:";
            // 
            // txt_cliente
            // 
            this.txt_cliente.BackColor = System.Drawing.Color.White;
            this.txt_cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_cliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.txt_cliente.Location = new System.Drawing.Point(338, 31);
            this.txt_cliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(197, 22);
            this.txt_cliente.TabIndex = 0;
            // 
            // compras_interfaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1520, 742);
            this.Controls.Add(this.panel_fondo);
            this.Name = "compras_interfaz";
            this.Text = "compras_interfaz";
            this.Load += new System.EventHandler(this.compras_interfaz_Load);
            this.panel_fondo.ResumeLayout(false);
            this.panelcont.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_compras_h)).EndInit();
            this.pnl_botones.ResumeLayout(false);
            this.gb_botonesABM_ventas.ResumeLayout(false);
            this.gb_botonesABM_ventas.PerformLayout();
            this.pnl_filtro.ResumeLayout(false);
            this.pnl_filtro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_fondo;
        private System.Windows.Forms.Panel pnl_botones;
        private System.Windows.Forms.GroupBox gb_botonesABM_ventas;
        private System.Windows.Forms.Button btn_borrar_compra;
        public System.Windows.Forms.Button btn_nueva_compra;
        private System.Windows.Forms.Button btn_modificar_compra;
        private System.Windows.Forms.Button btn_cancelar_compra;
        private System.Windows.Forms.Panel pnl_filtro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_filtro_activas;
        private System.Windows.Forms.Button btn_filtro_inactivas;
        private System.Windows.Forms.Button btn_filtro_todos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_cliente;
        public System.Windows.Forms.DataGridView dgv_compras_h;
        private System.Windows.Forms.Panel panelcont;
    }
}