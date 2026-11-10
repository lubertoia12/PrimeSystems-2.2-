namespace PrimeSystems_2._2_.forms.cliente
{
    partial class AgregarCliente
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
            this.msj_error = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_agregar_cliente = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.alta_activo_cliente = new System.Windows.Forms.RadioButton();
            this.cliente_dire_alta = new System.Windows.Forms.Label();
            this.alta_dire_cliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.alta_tel_cliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.alta_mail_cliente = new System.Windows.Forms.TextBox();
            this.alta_ape_cliente = new System.Windows.Forms.TextBox();
            this.alta_dni_cliente = new System.Windows.Forms.TextBox();
            this.alta_nom_cliente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.msj_error)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // msj_error
            // 
            this.msj_error.ContainerControl = this;
            // 
            // btn_agregar_cliente
            // 
            this.btn_agregar_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(141)))), ((int)(((byte)(190)))));
            this.btn_agregar_cliente.ForeColor = System.Drawing.Color.White;
            this.btn_agregar_cliente.Location = new System.Drawing.Point(695, 331);
            this.btn_agregar_cliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_agregar_cliente.Name = "btn_agregar_cliente";
            this.btn_agregar_cliente.Size = new System.Drawing.Size(149, 33);
            this.btn_agregar_cliente.TabIndex = 25;
            this.btn_agregar_cliente.Text = "agregar";
            this.btn_agregar_cliente.UseVisualStyleBackColor = false;
            this.btn_agregar_cliente.Click += new System.EventHandler(this.btn_agregar_cliente_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(234)))), ((int)(((byte)(239)))));
            this.btn_cancelar.Location = new System.Drawing.Point(427, 331);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(149, 33);
            this.btn_cancelar.TabIndex = 24;
            this.btn_cancelar.Text = "cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(555, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "agregar cliente";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.groupBox1.Controls.Add(this.alta_activo_cliente);
            this.groupBox1.Controls.Add(this.cliente_dire_alta);
            this.groupBox1.Controls.Add(this.alta_dire_cliente);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.alta_tel_cliente);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.alta_mail_cliente);
            this.groupBox1.Controls.Add(this.alta_ape_cliente);
            this.groupBox1.Controls.Add(this.alta_dni_cliente);
            this.groupBox1.Controls.Add(this.alta_nom_cliente);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(69, 70);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1141, 240);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales";
            // 
            // alta_activo_cliente
            // 
            this.alta_activo_cliente.AutoCheck = false;
            this.alta_activo_cliente.Checked = true;
            this.alta_activo_cliente.ForeColor = System.Drawing.Color.Black;
            this.alta_activo_cliente.Location = new System.Drawing.Point(828, 133);
            this.alta_activo_cliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.alta_activo_cliente.Name = "alta_activo_cliente";
            this.alta_activo_cliente.Size = new System.Drawing.Size(85, 21);
            this.alta_activo_cliente.TabIndex = 17;
            this.alta_activo_cliente.TabStop = true;
            this.alta_activo_cliente.Text = "ACTIVO";
            this.alta_activo_cliente.UseVisualStyleBackColor = true;
            // 
            // cliente_dire_alta
            // 
            this.cliente_dire_alta.AutoSize = true;
            this.cliente_dire_alta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cliente_dire_alta.ForeColor = System.Drawing.Color.Black;
            this.cliente_dire_alta.Location = new System.Drawing.Point(449, 128);
            this.cliente_dire_alta.Name = "cliente_dire_alta";
            this.cliente_dire_alta.Size = new System.Drawing.Size(81, 20);
            this.cliente_dire_alta.TabIndex = 14;
            this.cliente_dire_alta.Text = "Direccion";
            // 
            // alta_dire_cliente
            // 
            this.alta_dire_cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alta_dire_cliente.Location = new System.Drawing.Point(555, 129);
            this.alta_dire_cliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.alta_dire_cliente.Name = "alta_dire_cliente";
            this.alta_dire_cliente.Size = new System.Drawing.Size(214, 22);
            this.alta_dire_cliente.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(240, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Correo electronico";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(824, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(449, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(79, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre";
            // 
            // alta_tel_cliente
            // 
            this.alta_tel_cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alta_tel_cliente.Location = new System.Drawing.Point(181, 124);
            this.alta_tel_cliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.alta_tel_cliente.Name = "alta_tel_cliente";
            this.alta_tel_cliente.Size = new System.Drawing.Size(214, 22);
            this.alta_tel_cliente.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(79, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Telefono";
            // 
            // alta_mail_cliente
            // 
            this.alta_mail_cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alta_mail_cliente.Location = new System.Drawing.Point(421, 188);
            this.alta_mail_cliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.alta_mail_cliente.Name = "alta_mail_cliente";
            this.alta_mail_cliente.Size = new System.Drawing.Size(509, 22);
            this.alta_mail_cliente.TabIndex = 2;
            // 
            // alta_ape_cliente
            // 
            this.alta_ape_cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alta_ape_cliente.Location = new System.Drawing.Point(555, 60);
            this.alta_ape_cliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.alta_ape_cliente.Name = "alta_ape_cliente";
            this.alta_ape_cliente.Size = new System.Drawing.Size(214, 22);
            this.alta_ape_cliente.TabIndex = 0;
            // 
            // alta_dni_cliente
            // 
            this.alta_dni_cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alta_dni_cliente.Location = new System.Drawing.Point(888, 60);
            this.alta_dni_cliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.alta_dni_cliente.Name = "alta_dni_cliente";
            this.alta_dni_cliente.Size = new System.Drawing.Size(170, 22);
            this.alta_dni_cliente.TabIndex = 1;
            // 
            // alta_nom_cliente
            // 
            this.alta_nom_cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alta_nom_cliente.Location = new System.Drawing.Point(181, 60);
            this.alta_nom_cliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.alta_nom_cliente.Name = "alta_nom_cliente";
            this.alta_nom_cliente.Size = new System.Drawing.Size(214, 22);
            this.alta_nom_cliente.TabIndex = 5;
            // 
            // AgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1281, 382);
            this.Controls.Add(this.btn_agregar_cliente);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AgregarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarCliente";
            ((System.ComponentModel.ISupportInitialize)(this.msj_error)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider msj_error;
        private System.Windows.Forms.Button btn_agregar_cliente;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton alta_activo_cliente;
        private System.Windows.Forms.Label cliente_dire_alta;
        public System.Windows.Forms.TextBox alta_dire_cliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox alta_tel_cliente;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox alta_mail_cliente;
        public System.Windows.Forms.TextBox alta_ape_cliente;
        public System.Windows.Forms.TextBox alta_dni_cliente;
        public System.Windows.Forms.TextBox alta_nom_cliente;
    }
}