namespace PrimeSystems_2._2_.forms.proveedores
{
    partial class AltaProveedor
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_tipo_proveedor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pro_nom_alta = new System.Windows.Forms.TextBox();
            this.activo_alta_prov = new System.Windows.Forms.RadioButton();
            this.cliente_dire_alta = new System.Windows.Forms.Label();
            this.proveedor_dire_alta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_tipo_proveedor = new System.Windows.Forms.Label();
            this.pro_mail_alta = new System.Windows.Forms.TextBox();
            this.pro_ape_alta = new System.Windows.Forms.TextBox();
            this.pro_cuit_alta = new System.Windows.Forms.TextBox();
            this.pro_tel_alta = new System.Windows.Forms.TextBox();
            this.pro_pro_alta = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.msj_error = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msj_error)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.groupBox1.Controls.Add(this.cb_tipo_proveedor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pro_nom_alta);
            this.groupBox1.Controls.Add(this.activo_alta_prov);
            this.groupBox1.Controls.Add(this.cliente_dire_alta);
            this.groupBox1.Controls.Add(this.proveedor_dire_alta);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbl_tipo_proveedor);
            this.groupBox1.Controls.Add(this.pro_mail_alta);
            this.groupBox1.Controls.Add(this.pro_ape_alta);
            this.groupBox1.Controls.Add(this.pro_cuit_alta);
            this.groupBox1.Controls.Add(this.pro_tel_alta);
            this.groupBox1.Controls.Add(this.pro_pro_alta);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(54, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(853, 237);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DEL PROVEEDOR";
            // 
            // cb_tipo_proveedor
            // 
            this.cb_tipo_proveedor.FormattingEnabled = true;
            this.cb_tipo_proveedor.Items.AddRange(new object[] {
            "EMPRESA",
            "PARTICULAR"});
            this.cb_tipo_proveedor.Location = new System.Drawing.Point(129, 36);
            this.cb_tipo_proveedor.Name = "cb_tipo_proveedor";
            this.cb_tipo_proveedor.Size = new System.Drawing.Size(115, 21);
            this.cb_tipo_proveedor.TabIndex = 24;
            this.cb_tipo_proveedor.Text = "Tipo proveedor";
            this.cb_tipo_proveedor.SelectedIndexChanged += new System.EventHandler(this.cb_tipo_proveedor_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(54, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Nombre";
            // 
            // pro_nom_alta
            // 
            this.pro_nom_alta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pro_nom_alta.Location = new System.Drawing.Point(129, 87);
            this.pro_nom_alta.Margin = new System.Windows.Forms.Padding(2);
            this.pro_nom_alta.Name = "pro_nom_alta";
            this.pro_nom_alta.Size = new System.Drawing.Size(115, 20);
            this.pro_nom_alta.TabIndex = 16;
            // 
            // activo_alta_prov
            // 
            this.activo_alta_prov.AutoSize = true;
            this.activo_alta_prov.Checked = true;
            this.activo_alta_prov.Location = new System.Drawing.Point(649, 142);
            this.activo_alta_prov.Margin = new System.Windows.Forms.Padding(2);
            this.activo_alta_prov.Name = "activo_alta_prov";
            this.activo_alta_prov.Size = new System.Drawing.Size(64, 17);
            this.activo_alta_prov.TabIndex = 15;
            this.activo_alta_prov.TabStop = true;
            this.activo_alta_prov.Text = "ACTIVO";
            this.activo_alta_prov.UseVisualStyleBackColor = true;
            // 
            // cliente_dire_alta
            // 
            this.cliente_dire_alta.AutoSize = true;
            this.cliente_dire_alta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cliente_dire_alta.ForeColor = System.Drawing.Color.Black;
            this.cliente_dire_alta.Location = new System.Drawing.Point(319, 142);
            this.cliente_dire_alta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cliente_dire_alta.Name = "cliente_dire_alta";
            this.cliente_dire_alta.Size = new System.Drawing.Size(67, 17);
            this.cliente_dire_alta.TabIndex = 14;
            this.cliente_dire_alta.Text = "Direccion";
            // 
            // proveedor_dire_alta
            // 
            this.proveedor_dire_alta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.proveedor_dire_alta.Location = new System.Drawing.Point(396, 139);
            this.proveedor_dire_alta.Margin = new System.Windows.Forms.Padding(2);
            this.proveedor_dire_alta.Name = "proveedor_dire_alta";
            this.proveedor_dire_alta.Size = new System.Drawing.Size(187, 20);
            this.proveedor_dire_alta.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(54, 191);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Correo electronico";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(54, 142);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(596, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "CUIT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(319, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Apellido";
            // 
            // lbl_tipo_proveedor
            // 
            this.lbl_tipo_proveedor.AutoSize = true;
            this.lbl_tipo_proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tipo_proveedor.ForeColor = System.Drawing.Color.Black;
            this.lbl_tipo_proveedor.Location = new System.Drawing.Point(303, 36);
            this.lbl_tipo_proveedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_tipo_proveedor.Name = "lbl_tipo_proveedor";
            this.lbl_tipo_proveedor.Size = new System.Drawing.Size(74, 17);
            this.lbl_tipo_proveedor.TabIndex = 7;
            this.lbl_tipo_proveedor.Text = "Proveedor";
            // 
            // pro_mail_alta
            // 
            this.pro_mail_alta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pro_mail_alta.Location = new System.Drawing.Point(218, 188);
            this.pro_mail_alta.Margin = new System.Windows.Forms.Padding(2);
            this.pro_mail_alta.Name = "pro_mail_alta";
            this.pro_mail_alta.Size = new System.Drawing.Size(251, 20);
            this.pro_mail_alta.TabIndex = 2;
            // 
            // pro_ape_alta
            // 
            this.pro_ape_alta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pro_ape_alta.Location = new System.Drawing.Point(396, 87);
            this.pro_ape_alta.Margin = new System.Windows.Forms.Padding(2);
            this.pro_ape_alta.Name = "pro_ape_alta";
            this.pro_ape_alta.Size = new System.Drawing.Size(154, 20);
            this.pro_ape_alta.TabIndex = 0;
            // 
            // pro_cuit_alta
            // 
            this.pro_cuit_alta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pro_cuit_alta.Location = new System.Drawing.Point(649, 87);
            this.pro_cuit_alta.Margin = new System.Windows.Forms.Padding(2);
            this.pro_cuit_alta.Name = "pro_cuit_alta";
            this.pro_cuit_alta.Size = new System.Drawing.Size(121, 20);
            this.pro_cuit_alta.TabIndex = 1;
            // 
            // pro_tel_alta
            // 
            this.pro_tel_alta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pro_tel_alta.Location = new System.Drawing.Point(129, 139);
            this.pro_tel_alta.Margin = new System.Windows.Forms.Padding(2);
            this.pro_tel_alta.Name = "pro_tel_alta";
            this.pro_tel_alta.Size = new System.Drawing.Size(142, 20);
            this.pro_tel_alta.TabIndex = 3;
            // 
            // pro_pro_alta
            // 
            this.pro_pro_alta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pro_pro_alta.Location = new System.Drawing.Point(428, 33);
            this.pro_pro_alta.Margin = new System.Windows.Forms.Padding(2);
            this.pro_pro_alta.Name = "pro_pro_alta";
            this.pro_pro_alta.Size = new System.Drawing.Size(187, 20);
            this.pro_pro_alta.TabIndex = 5;
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(141)))), ((int)(((byte)(190)))));
            this.btn_agregar.ForeColor = System.Drawing.Color.White;
            this.btn_agregar.Location = new System.Drawing.Point(525, 279);
            this.btn_agregar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(112, 27);
            this.btn_agregar.TabIndex = 23;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(234)))), ((int)(((byte)(239)))));
            this.btn_cancelar.Location = new System.Drawing.Point(325, 279);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(112, 27);
            this.btn_cancelar.TabIndex = 22;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // msj_error
            // 
            this.msj_error.ContainerControl = this;
            // 
            // AltaProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(961, 317);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.btn_cancelar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AltaProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AltaProveedor";
            this.Load += new System.EventHandler(this.AltaProveedor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msj_error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label cliente_dire_alta;
        public System.Windows.Forms.TextBox proveedor_dire_alta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_tipo_proveedor;
        public System.Windows.Forms.TextBox pro_mail_alta;
        public System.Windows.Forms.TextBox pro_ape_alta;
        public System.Windows.Forms.TextBox pro_cuit_alta;
        public System.Windows.Forms.TextBox pro_tel_alta;
        public System.Windows.Forms.TextBox pro_pro_alta;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.RadioButton activo_alta_prov;
        private System.Windows.Forms.ErrorProvider msj_error;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox pro_nom_alta;
        public System.Windows.Forms.ComboBox cb_tipo_proveedor;
    }
}