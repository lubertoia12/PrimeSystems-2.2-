namespace PrimeSystems_2._2_.forms.MODULOS
{
    partial class CLIENTES
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
            this.pnl_fondo = new System.Windows.Forms.Panel();
            this.pnl_btn = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_borrar_cliente = new System.Windows.Forms.Button();
            this.btn_nuevo_cliente = new System.Windows.Forms.Button();
            this.btn_modificar_cliente = new System.Windows.Forms.Button();
            this.btn_cancelar_cliente = new System.Windows.Forms.Button();
            this.pnl_filtro_clientes = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel_frm = new System.Windows.Forms.Panel();
            this.dgv_clientes = new System.Windows.Forms.DataGridView();
            this.btn_filtro_activas = new System.Windows.Forms.Button();
            this.btn_filtro_inactivas = new System.Windows.Forms.Button();
            this.btn_filtro_todos = new System.Windows.Forms.Button();
            this.pnl_fondo.SuspendLayout();
            this.pnl_btn.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnl_filtro_clientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_fondo
            // 
            this.pnl_fondo.AutoScroll = true;
            this.pnl_fondo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.pnl_fondo.Controls.Add(this.pnl_btn);
            this.pnl_fondo.Controls.Add(this.pnl_filtro_clientes);
            this.pnl_fondo.Controls.Add(this.panel_frm);
            this.pnl_fondo.Controls.Add(this.dgv_clientes);
            this.pnl_fondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_fondo.Location = new System.Drawing.Point(0, 0);
            this.pnl_fondo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_fondo.Name = "pnl_fondo";
            this.pnl_fondo.Size = new System.Drawing.Size(1520, 742);
            this.pnl_fondo.TabIndex = 1;
            // 
            // pnl_btn
            // 
            this.pnl_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.pnl_btn.Controls.Add(this.groupBox2);
            this.pnl_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_btn.Location = new System.Drawing.Point(1353, 78);
            this.pnl_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_btn.Name = "pnl_btn";
            this.pnl_btn.Size = new System.Drawing.Size(167, 664);
            this.pnl_btn.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.btn_borrar_cliente);
            this.groupBox2.Controls.Add(this.btn_nuevo_cliente);
            this.groupBox2.Controls.Add(this.btn_modificar_cliente);
            this.groupBox2.Controls.Add(this.btn_cancelar_cliente);
            this.groupBox2.Location = new System.Drawing.Point(3, 2);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(163, 369);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // btn_borrar_cliente
            // 
            this.btn_borrar_cliente.AutoSize = true;
            this.btn_borrar_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(100)))), ((int)(((byte)(89)))));
            this.btn_borrar_cliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_borrar_cliente.FlatAppearance.BorderSize = 0;
            this.btn_borrar_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_borrar_cliente.ForeColor = System.Drawing.Color.White;
            this.btn_borrar_cliente.Location = new System.Drawing.Point(17, 197);
            this.btn_borrar_cliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_borrar_cliente.Name = "btn_borrar_cliente";
            this.btn_borrar_cliente.Size = new System.Drawing.Size(129, 59);
            this.btn_borrar_cliente.TabIndex = 10;
            this.btn_borrar_cliente.Text = "BORRAR";
            this.btn_borrar_cliente.UseVisualStyleBackColor = false;
            this.btn_borrar_cliente.Click += new System.EventHandler(this.btn_borrar_cliente_Click);
            // 
            // btn_nuevo_cliente
            // 
            this.btn_nuevo_cliente.AutoSize = true;
            this.btn_nuevo_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(141)))), ((int)(((byte)(190)))));
            this.btn_nuevo_cliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nuevo_cliente.FlatAppearance.BorderSize = 0;
            this.btn_nuevo_cliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(122)))), ((int)(((byte)(166)))));
            this.btn_nuevo_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo_cliente.ForeColor = System.Drawing.Color.White;
            this.btn_nuevo_cliente.Location = new System.Drawing.Point(17, 30);
            this.btn_nuevo_cliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_nuevo_cliente.Name = "btn_nuevo_cliente";
            this.btn_nuevo_cliente.Size = new System.Drawing.Size(129, 59);
            this.btn_nuevo_cliente.TabIndex = 9;
            this.btn_nuevo_cliente.Text = "NUEVO";
            this.btn_nuevo_cliente.UseVisualStyleBackColor = false;
            this.btn_nuevo_cliente.Click += new System.EventHandler(this.btn_nuevo_cliente_Click);
            // 
            // btn_modificar_cliente
            // 
            this.btn_modificar_cliente.AutoSize = true;
            this.btn_modificar_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(234)))), ((int)(((byte)(239)))));
            this.btn_modificar_cliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_modificar_cliente.FlatAppearance.BorderSize = 0;
            this.btn_modificar_cliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(220)))), ((int)(((byte)(227)))));
            this.btn_modificar_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modificar_cliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.btn_modificar_cliente.Location = new System.Drawing.Point(17, 114);
            this.btn_modificar_cliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_modificar_cliente.Name = "btn_modificar_cliente";
            this.btn_modificar_cliente.Size = new System.Drawing.Size(129, 59);
            this.btn_modificar_cliente.TabIndex = 8;
            this.btn_modificar_cliente.Text = "MODIFICAR";
            this.btn_modificar_cliente.UseVisualStyleBackColor = false;
            this.btn_modificar_cliente.Click += new System.EventHandler(this.btn_modificar_cliente_Click);
            // 
            // btn_cancelar_cliente
            // 
            this.btn_cancelar_cliente.AutoSize = true;
            this.btn_cancelar_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.btn_cancelar_cliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar_cliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(202)))), ((int)(((byte)(212)))));
            this.btn_cancelar_cliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.btn_cancelar_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar_cliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(55)))), ((int)(((byte)(72)))));
            this.btn_cancelar_cliente.Location = new System.Drawing.Point(17, 277);
            this.btn_cancelar_cliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cancelar_cliente.Name = "btn_cancelar_cliente";
            this.btn_cancelar_cliente.Size = new System.Drawing.Size(129, 59);
            this.btn_cancelar_cliente.TabIndex = 7;
            this.btn_cancelar_cliente.Text = "CANCELAR";
            this.btn_cancelar_cliente.UseVisualStyleBackColor = false;
            this.btn_cancelar_cliente.Click += new System.EventHandler(this.btn_cancelar_cliente_Click);
            // 
            // pnl_filtro_clientes
            // 
            this.pnl_filtro_clientes.BackColor = System.Drawing.Color.White;
            this.pnl_filtro_clientes.Controls.Add(this.btn_filtro_activas);
            this.pnl_filtro_clientes.Controls.Add(this.btn_filtro_inactivas);
            this.pnl_filtro_clientes.Controls.Add(this.btn_filtro_todos);
            this.pnl_filtro_clientes.Controls.Add(this.textBox1);
            this.pnl_filtro_clientes.Controls.Add(this.label3);
            this.pnl_filtro_clientes.Controls.Add(this.label2);
            this.pnl_filtro_clientes.Controls.Add(this.label1);
            this.pnl_filtro_clientes.Controls.Add(this.textBox2);
            this.pnl_filtro_clientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_filtro_clientes.Location = new System.Drawing.Point(0, 0);
            this.pnl_filtro_clientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_filtro_clientes.Name = "pnl_filtro_clientes";
            this.pnl_filtro_clientes.Size = new System.Drawing.Size(1520, 78);
            this.pnl_filtro_clientes.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(357, 31);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(77, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "BUSCAR POR:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(612, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "DNI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(251, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.textBox2.Location = new System.Drawing.Point(701, 27);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(169, 22);
            this.textBox2.TabIndex = 2;
            // 
            // panel_frm
            // 
            this.panel_frm.BackColor = System.Drawing.Color.White;
            this.panel_frm.Location = new System.Drawing.Point(27, 292);
            this.panel_frm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_frm.Name = "panel_frm";
            this.panel_frm.Size = new System.Drawing.Size(1299, 430);
            this.panel_frm.TabIndex = 4;
            // 
            // dgv_clientes
            // 
            this.dgv_clientes.BackgroundColor = System.Drawing.Color.White;
            this.dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_clientes.Location = new System.Drawing.Point(187, 110);
            this.dgv_clientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_clientes.Name = "dgv_clientes";
            this.dgv_clientes.ReadOnly = true;
            this.dgv_clientes.RowHeadersWidth = 51;
            this.dgv_clientes.RowTemplate.Height = 24;
            this.dgv_clientes.Size = new System.Drawing.Size(957, 167);
            this.dgv_clientes.TabIndex = 1;
            this.dgv_clientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_clientes_CellClick);
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
            this.btn_filtro_activas.Location = new System.Drawing.Point(1053, 24);
            this.btn_filtro_activas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_filtro_activas.Name = "btn_filtro_activas";
            this.btn_filtro_activas.Size = new System.Drawing.Size(99, 32);
            this.btn_filtro_activas.TabIndex = 8;
            this.btn_filtro_activas.Text = "ACTIVAS";
            this.btn_filtro_activas.UseVisualStyleBackColor = false;
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
            this.btn_filtro_inactivas.Location = new System.Drawing.Point(1171, 25);
            this.btn_filtro_inactivas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_filtro_inactivas.Name = "btn_filtro_inactivas";
            this.btn_filtro_inactivas.Size = new System.Drawing.Size(116, 32);
            this.btn_filtro_inactivas.TabIndex = 7;
            this.btn_filtro_inactivas.Text = "INACTIVAS";
            this.btn_filtro_inactivas.UseVisualStyleBackColor = false;
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
            this.btn_filtro_todos.Location = new System.Drawing.Point(940, 24);
            this.btn_filtro_todos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_filtro_todos.Name = "btn_filtro_todos";
            this.btn_filtro_todos.Size = new System.Drawing.Size(85, 32);
            this.btn_filtro_todos.TabIndex = 6;
            this.btn_filtro_todos.Text = "TODAS";
            this.btn_filtro_todos.UseVisualStyleBackColor = false;
            // 
            // CLIENTES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1520, 742);
            this.Controls.Add(this.pnl_fondo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CLIENTES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CLIENTES";
            this.Load += new System.EventHandler(this.CLIENTES_Load);
            this.pnl_fondo.ResumeLayout(false);
            this.pnl_btn.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnl_filtro_clientes.ResumeLayout(false);
            this.pnl_filtro_clientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_fondo;
        private System.Windows.Forms.Panel pnl_filtro_clientes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel pnl_btn;
        public System.Windows.Forms.Panel panel_frm;
        public System.Windows.Forms.DataGridView dgv_clientes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_borrar_cliente;
        public System.Windows.Forms.Button btn_nuevo_cliente;
        private System.Windows.Forms.Button btn_modificar_cliente;
        private System.Windows.Forms.Button btn_cancelar_cliente;
        private System.Windows.Forms.Button btn_filtro_activas;
        private System.Windows.Forms.Button btn_filtro_inactivas;
        private System.Windows.Forms.Button btn_filtro_todos;
    }
}