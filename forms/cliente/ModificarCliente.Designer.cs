namespace PrimeSystems_2._2_.forms.cliente
{
    partial class ModificarCliente
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
            this.components = new System.ComponentModel.Container();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.inactivo_mod_cliente = new System.Windows.Forms.RadioButton();
            this.activo_mod_cliente = new System.Windows.Forms.RadioButton();
            this.cliente_dire_alta = new System.Windows.Forms.Label();
            this.cliente_dire_mod = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cliente_tel_mod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cliente_mail_mod = new System.Windows.Forms.TextBox();
            this.cliente_ape_mod = new System.Windows.Forms.TextBox();
            this.cliente_dni_mod = new System.Windows.Forms.TextBox();
            this.cliente_nom_mod = new System.Windows.Forms.TextBox();
            this.msj_error = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msj_error)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(141)))), ((int)(((byte)(190)))));
            this.btn_modificar.ForeColor = System.Drawing.Color.White;
            this.btn_modificar.Location = new System.Drawing.Point(521, 269);
            this.btn_modificar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(112, 27);
            this.btn_modificar.TabIndex = 21;
            this.btn_modificar.Text = "modificar";
            this.btn_modificar.UseVisualStyleBackColor = false;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(234)))), ((int)(((byte)(239)))));
            this.btn_cancelar.Location = new System.Drawing.Point(320, 269);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(112, 27);
            this.btn_cancelar.TabIndex = 20;
            this.btn_cancelar.Text = "cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(416, 15);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "modificar cliente";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.groupBox1.Controls.Add(this.inactivo_mod_cliente);
            this.groupBox1.Controls.Add(this.activo_mod_cliente);
            this.groupBox1.Controls.Add(this.cliente_dire_alta);
            this.groupBox1.Controls.Add(this.cliente_dire_mod);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cliente_tel_mod);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cliente_mail_mod);
            this.groupBox1.Controls.Add(this.cliente_ape_mod);
            this.groupBox1.Controls.Add(this.cliente_dni_mod);
            this.groupBox1.Controls.Add(this.cliente_nom_mod);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(52, 57);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(856, 195);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales";
            // 
            // inactivo_mod_cliente
            // 
            this.inactivo_mod_cliente.AutoSize = true;
            this.inactivo_mod_cliente.ForeColor = System.Drawing.Color.Black;
            this.inactivo_mod_cliente.Location = new System.Drawing.Point(699, 108);
            this.inactivo_mod_cliente.Margin = new System.Windows.Forms.Padding(2);
            this.inactivo_mod_cliente.Name = "inactivo_mod_cliente";
            this.inactivo_mod_cliente.Size = new System.Drawing.Size(75, 17);
            this.inactivo_mod_cliente.TabIndex = 18;
            this.inactivo_mod_cliente.TabStop = true;
            this.inactivo_mod_cliente.Text = "INACTIVO";
            this.inactivo_mod_cliente.UseVisualStyleBackColor = true;
            // 
            // activo_mod_cliente
            // 
            this.activo_mod_cliente.AutoSize = true;
            this.activo_mod_cliente.ForeColor = System.Drawing.Color.Black;
            this.activo_mod_cliente.Location = new System.Drawing.Point(621, 108);
            this.activo_mod_cliente.Margin = new System.Windows.Forms.Padding(2);
            this.activo_mod_cliente.Name = "activo_mod_cliente";
            this.activo_mod_cliente.Size = new System.Drawing.Size(64, 17);
            this.activo_mod_cliente.TabIndex = 17;
            this.activo_mod_cliente.TabStop = true;
            this.activo_mod_cliente.Text = "ACTIVO";
            this.activo_mod_cliente.UseVisualStyleBackColor = true;
            // 
            // cliente_dire_alta
            // 
            this.cliente_dire_alta.AutoSize = true;
            this.cliente_dire_alta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cliente_dire_alta.ForeColor = System.Drawing.Color.Black;
            this.cliente_dire_alta.Location = new System.Drawing.Point(337, 104);
            this.cliente_dire_alta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cliente_dire_alta.Name = "cliente_dire_alta";
            this.cliente_dire_alta.Size = new System.Drawing.Size(67, 17);
            this.cliente_dire_alta.TabIndex = 14;
            this.cliente_dire_alta.Text = "Direccion";
            // 
            // cliente_dire_mod
            // 
            this.cliente_dire_mod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cliente_dire_mod.Location = new System.Drawing.Point(416, 105);
            this.cliente_dire_mod.Margin = new System.Windows.Forms.Padding(2);
            this.cliente_dire_mod.Name = "cliente_dire_mod";
            this.cliente_dire_mod.Size = new System.Drawing.Size(161, 20);
            this.cliente_dire_mod.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(180, 153);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Correo electronico";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(618, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(337, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(59, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre";
            // 
            // cliente_tel_mod
            // 
            this.cliente_tel_mod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cliente_tel_mod.Location = new System.Drawing.Point(136, 101);
            this.cliente_tel_mod.Margin = new System.Windows.Forms.Padding(2);
            this.cliente_tel_mod.Name = "cliente_tel_mod";
            this.cliente_tel_mod.Size = new System.Drawing.Size(161, 20);
            this.cliente_tel_mod.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(59, 104);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Telefono";
            // 
            // cliente_mail_mod
            // 
            this.cliente_mail_mod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cliente_mail_mod.Location = new System.Drawing.Point(316, 153);
            this.cliente_mail_mod.Margin = new System.Windows.Forms.Padding(2);
            this.cliente_mail_mod.Name = "cliente_mail_mod";
            this.cliente_mail_mod.Size = new System.Drawing.Size(382, 20);
            this.cliente_mail_mod.TabIndex = 2;
            // 
            // cliente_ape_mod
            // 
            this.cliente_ape_mod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cliente_ape_mod.Location = new System.Drawing.Point(416, 49);
            this.cliente_ape_mod.Margin = new System.Windows.Forms.Padding(2);
            this.cliente_ape_mod.Name = "cliente_ape_mod";
            this.cliente_ape_mod.Size = new System.Drawing.Size(161, 20);
            this.cliente_ape_mod.TabIndex = 0;
            // 
            // cliente_dni_mod
            // 
            this.cliente_dni_mod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cliente_dni_mod.Location = new System.Drawing.Point(666, 49);
            this.cliente_dni_mod.Margin = new System.Windows.Forms.Padding(2);
            this.cliente_dni_mod.Name = "cliente_dni_mod";
            this.cliente_dni_mod.Size = new System.Drawing.Size(128, 20);
            this.cliente_dni_mod.TabIndex = 1;
            // 
            // cliente_nom_mod
            // 
            this.cliente_nom_mod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cliente_nom_mod.Location = new System.Drawing.Point(136, 49);
            this.cliente_nom_mod.Margin = new System.Windows.Forms.Padding(2);
            this.cliente_nom_mod.Name = "cliente_nom_mod";
            this.cliente_nom_mod.Size = new System.Drawing.Size(161, 20);
            this.cliente_nom_mod.TabIndex = 5;
            // 
            // msj_error
            // 
            this.msj_error.ContainerControl = this;
            // 
            // ModificarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(961, 310);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ModificarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificarCliente";
            this.Load += new System.EventHandler(this.ModificarCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msj_error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label cliente_dire_alta;
        public System.Windows.Forms.TextBox cliente_dire_mod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox cliente_mail_mod;
        public System.Windows.Forms.TextBox cliente_ape_mod;
        public System.Windows.Forms.TextBox cliente_dni_mod;
        public System.Windows.Forms.TextBox cliente_tel_mod;
        public System.Windows.Forms.TextBox cliente_nom_mod;
        private System.Windows.Forms.RadioButton inactivo_mod_cliente;
        private System.Windows.Forms.RadioButton activo_mod_cliente;
        private System.Windows.Forms.ErrorProvider msj_error;
    }
}