namespace PrimeSystems_2._2_.forms.proveedores
{
    partial class alta_proveedor_popup
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
            this.btn_agregar_proveedor = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.activo_alta_prov = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pro_mail_alta = new System.Windows.Forms.TextBox();
            this.pro_nom_alta = new System.Windows.Forms.TextBox();
            this.pro_cuit_alta = new System.Windows.Forms.TextBox();
            this.pro_tel_alta = new System.Windows.Forms.TextBox();
            this.pro_pro_alta = new System.Windows.Forms.TextBox();
            this.msj_error = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msj_error)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.groupBox1.Controls.Add(this.btn_agregar_proveedor);
            this.groupBox1.Controls.Add(this.btn_cancelar);
            this.groupBox1.Controls.Add(this.activo_alta_prov);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pro_mail_alta);
            this.groupBox1.Controls.Add(this.pro_nom_alta);
            this.groupBox1.Controls.Add(this.pro_cuit_alta);
            this.groupBox1.Controls.Add(this.pro_tel_alta);
            this.groupBox1.Controls.Add(this.pro_pro_alta);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(7, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(356, 330);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales";
            // 
            // btn_agregar_proveedor
            // 
            this.btn_agregar_proveedor.AutoSize = true;
            this.btn_agregar_proveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(141)))), ((int)(((byte)(190)))));
            this.btn_agregar_proveedor.ForeColor = System.Drawing.Color.White;
            this.btn_agregar_proveedor.Location = new System.Drawing.Point(198, 265);
            this.btn_agregar_proveedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_agregar_proveedor.Name = "btn_agregar_proveedor";
            this.btn_agregar_proveedor.Size = new System.Drawing.Size(67, 27);
            this.btn_agregar_proveedor.TabIndex = 17;
            this.btn_agregar_proveedor.Text = "Agregar";
            this.btn_agregar_proveedor.UseVisualStyleBackColor = false;
            this.btn_agregar_proveedor.Click += new System.EventHandler(this.btn_agregar_proveedor_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.AutoSize = true;
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(234)))), ((int)(((byte)(239)))));
            this.btn_cancelar.Location = new System.Drawing.Point(71, 265);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(71, 27);
            this.btn_cancelar.TabIndex = 16;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // activo_alta_prov
            // 
            this.activo_alta_prov.AutoSize = true;
            this.activo_alta_prov.Checked = true;
            this.activo_alta_prov.Location = new System.Drawing.Point(142, 210);
            this.activo_alta_prov.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.activo_alta_prov.Name = "activo_alta_prov";
            this.activo_alta_prov.Size = new System.Drawing.Size(64, 17);
            this.activo_alta_prov.TabIndex = 15;
            this.activo_alta_prov.TabStop = true;
            this.activo_alta_prov.Text = "ACTIVO";
            this.activo_alta_prov.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(36, 144);
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
            this.label5.Location = new System.Drawing.Point(201, 93);
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
            this.label3.Location = new System.Drawing.Point(201, 38);
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
            this.label2.Location = new System.Drawing.Point(36, 93);
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
            this.label1.Location = new System.Drawing.Point(36, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Proveedor";
            // 
            // pro_mail_alta
            // 
            this.pro_mail_alta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pro_mail_alta.Location = new System.Drawing.Point(39, 162);
            this.pro_mail_alta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pro_mail_alta.Name = "pro_mail_alta";
            this.pro_mail_alta.Size = new System.Drawing.Size(274, 20);
            this.pro_mail_alta.TabIndex = 2;
            // 
            // pro_nom_alta
            // 
            this.pro_nom_alta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pro_nom_alta.Location = new System.Drawing.Point(39, 111);
            this.pro_nom_alta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pro_nom_alta.Name = "pro_nom_alta";
            this.pro_nom_alta.Size = new System.Drawing.Size(125, 20);
            this.pro_nom_alta.TabIndex = 0;
            // 
            // pro_cuit_alta
            // 
            this.pro_cuit_alta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pro_cuit_alta.Location = new System.Drawing.Point(204, 57);
            this.pro_cuit_alta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pro_cuit_alta.Name = "pro_cuit_alta";
            this.pro_cuit_alta.Size = new System.Drawing.Size(109, 20);
            this.pro_cuit_alta.TabIndex = 1;
            // 
            // pro_tel_alta
            // 
            this.pro_tel_alta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pro_tel_alta.Location = new System.Drawing.Point(204, 111);
            this.pro_tel_alta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pro_tel_alta.Name = "pro_tel_alta";
            this.pro_tel_alta.Size = new System.Drawing.Size(109, 20);
            this.pro_tel_alta.TabIndex = 3;
            // 
            // pro_pro_alta
            // 
            this.pro_pro_alta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pro_pro_alta.Location = new System.Drawing.Point(39, 57);
            this.pro_pro_alta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pro_pro_alta.Name = "pro_pro_alta";
            this.pro_pro_alta.Size = new System.Drawing.Size(125, 20);
            this.pro_pro_alta.TabIndex = 5;
            // 
            // msj_error
            // 
            this.msj_error.ContainerControl = this;
            // 
            // alta_proveedor_popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(374, 350);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "alta_proveedor_popup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "alta_proveedor_popup";
            this.Load += new System.EventHandler(this.alta_proveedor_popup_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msj_error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_agregar_proveedor;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.RadioButton activo_alta_prov;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox pro_mail_alta;
        public System.Windows.Forms.TextBox pro_nom_alta;
        public System.Windows.Forms.TextBox pro_cuit_alta;
        public System.Windows.Forms.TextBox pro_tel_alta;
        public System.Windows.Forms.TextBox pro_pro_alta;
        private System.Windows.Forms.ErrorProvider msj_error;
    }
}