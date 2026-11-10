namespace PrimeSystems_2._2_.forms.usuario
{
    partial class ModificarUsuario
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
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_cancelar_mod = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.inactivo_mod_user = new System.Windows.Forms.RadioButton();
            this.activo_mod_user = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_rol_mod = new System.Windows.Forms.ComboBox();
            this.user_mail_mod = new System.Windows.Forms.TextBox();
            this.user_ape_mod = new System.Windows.Forms.TextBox();
            this.user_dni_mod = new System.Windows.Forms.TextBox();
            this.user_tel_mod = new System.Windows.Forms.TextBox();
            this.user_nom_mod = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.user_passConf_mod = new System.Windows.Forms.TextBox();
            this.user_user_mod = new System.Windows.Forms.TextBox();
            this.user_pass_mod = new System.Windows.Forms.TextBox();
            this.btn_modificar_user = new System.Windows.Forms.Button();
            this.btn_cancelar_ModUser = new System.Windows.Forms.Button();
            this.msj_error = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msj_error)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(338, -156);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = " Nuevo usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(594, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Modificar usuario";
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(392, 768);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(150, 31);
            this.btn_modificar.TabIndex = 22;
            this.btn_modificar.Text = "aceptar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar_mod
            // 
            this.btn_cancelar_mod.Location = new System.Drawing.Point(122, 768);
            this.btn_cancelar_mod.Name = "btn_cancelar_mod";
            this.btn_cancelar_mod.Size = new System.Drawing.Size(150, 31);
            this.btn_cancelar_mod.TabIndex = 20;
            this.btn_cancelar_mod.Text = "cancelar";
            this.btn_cancelar_mod.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.groupBox1.Controls.Add(this.inactivo_mod_user);
            this.groupBox1.Controls.Add(this.activo_mod_user);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cb_rol_mod);
            this.groupBox1.Controls.Add(this.user_mail_mod);
            this.groupBox1.Controls.Add(this.user_ape_mod);
            this.groupBox1.Controls.Add(this.user_dni_mod);
            this.groupBox1.Controls.Add(this.user_tel_mod);
            this.groupBox1.Controls.Add(this.user_nom_mod);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(29, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(735, 306);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales";
            // 
            // inactivo_mod_user
            // 
            this.inactivo_mod_user.AutoSize = true;
            this.inactivo_mod_user.ForeColor = System.Drawing.Color.Black;
            this.inactivo_mod_user.Location = new System.Drawing.Point(598, 115);
            this.inactivo_mod_user.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inactivo_mod_user.Name = "inactivo_mod_user";
            this.inactivo_mod_user.Size = new System.Drawing.Size(90, 20);
            this.inactivo_mod_user.TabIndex = 16;
            this.inactivo_mod_user.TabStop = true;
            this.inactivo_mod_user.Text = "INACTIVO";
            this.inactivo_mod_user.UseVisualStyleBackColor = true;
            // 
            // activo_mod_user
            // 
            this.activo_mod_user.AutoSize = true;
            this.activo_mod_user.ForeColor = System.Drawing.Color.Black;
            this.activo_mod_user.Location = new System.Drawing.Point(504, 115);
            this.activo_mod_user.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.activo_mod_user.Name = "activo_mod_user";
            this.activo_mod_user.Size = new System.Drawing.Size(77, 20);
            this.activo_mod_user.TabIndex = 15;
            this.activo_mod_user.TabStop = true;
            this.activo_mod_user.Text = "ACTIVO";
            this.activo_mod_user.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(43, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Correo electronico";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(43, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(302, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "ROL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(43, 115);
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
            this.label2.Location = new System.Drawing.Point(388, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Apellido";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(43, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Nombre";
            // 
            // cb_rol_mod
            // 
            this.cb_rol_mod.FormattingEnabled = true;
            this.cb_rol_mod.Location = new System.Drawing.Point(359, 114);
            this.cb_rol_mod.Name = "cb_rol_mod";
            this.cb_rol_mod.Size = new System.Drawing.Size(97, 24);
            this.cb_rol_mod.TabIndex = 6;
            // 
            // user_mail_mod
            // 
            this.user_mail_mod.BackColor = System.Drawing.Color.White;
            this.user_mail_mod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user_mail_mod.Location = new System.Drawing.Point(251, 236);
            this.user_mail_mod.Name = "user_mail_mod";
            this.user_mail_mod.Size = new System.Drawing.Size(435, 22);
            this.user_mail_mod.TabIndex = 2;
            // 
            // user_ape_mod
            // 
            this.user_ape_mod.BackColor = System.Drawing.Color.White;
            this.user_ape_mod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user_ape_mod.Location = new System.Drawing.Point(479, 54);
            this.user_ape_mod.Name = "user_ape_mod";
            this.user_ape_mod.Size = new System.Drawing.Size(207, 22);
            this.user_ape_mod.TabIndex = 0;
            // 
            // user_dni_mod
            // 
            this.user_dni_mod.BackColor = System.Drawing.Color.White;
            this.user_dni_mod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user_dni_mod.Location = new System.Drawing.Point(139, 116);
            this.user_dni_mod.Name = "user_dni_mod";
            this.user_dni_mod.Size = new System.Drawing.Size(130, 22);
            this.user_dni_mod.TabIndex = 1;
            // 
            // user_tel_mod
            // 
            this.user_tel_mod.BackColor = System.Drawing.Color.White;
            this.user_tel_mod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user_tel_mod.Location = new System.Drawing.Point(251, 180);
            this.user_tel_mod.Name = "user_tel_mod";
            this.user_tel_mod.Size = new System.Drawing.Size(435, 22);
            this.user_tel_mod.TabIndex = 3;
            // 
            // user_nom_mod
            // 
            this.user_nom_mod.BackColor = System.Drawing.Color.White;
            this.user_nom_mod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user_nom_mod.Location = new System.Drawing.Point(139, 54);
            this.user_nom_mod.Name = "user_nom_mod";
            this.user_nom_mod.Size = new System.Drawing.Size(207, 22);
            this.user_nom_mod.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.user_passConf_mod);
            this.groupBox2.Controls.Add(this.user_user_mod);
            this.groupBox2.Controls.Add(this.user_pass_mod);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(822, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(430, 221);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Usuario";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(22, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Confirmar contraseña";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(22, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Contraseña";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(22, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 20);
            this.label11.TabIndex = 13;
            this.label11.Text = "Username";
            // 
            // user_passConf_mod
            // 
            this.user_passConf_mod.BackColor = System.Drawing.Color.White;
            this.user_passConf_mod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user_passConf_mod.Location = new System.Drawing.Point(218, 145);
            this.user_passConf_mod.Name = "user_passConf_mod";
            this.user_passConf_mod.Size = new System.Drawing.Size(176, 22);
            this.user_passConf_mod.TabIndex = 8;
            // 
            // user_user_mod
            // 
            this.user_user_mod.BackColor = System.Drawing.Color.White;
            this.user_user_mod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user_user_mod.Location = new System.Drawing.Point(218, 52);
            this.user_user_mod.Name = "user_user_mod";
            this.user_user_mod.Size = new System.Drawing.Size(176, 22);
            this.user_user_mod.TabIndex = 6;
            // 
            // user_pass_mod
            // 
            this.user_pass_mod.BackColor = System.Drawing.Color.White;
            this.user_pass_mod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user_pass_mod.Location = new System.Drawing.Point(218, 99);
            this.user_pass_mod.Name = "user_pass_mod";
            this.user_pass_mod.Size = new System.Drawing.Size(176, 22);
            this.user_pass_mod.TabIndex = 9;
            // 
            // btn_modificar_user
            // 
            this.btn_modificar_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(141)))), ((int)(((byte)(190)))));
            this.btn_modificar_user.ForeColor = System.Drawing.Color.White;
            this.btn_modificar_user.Location = new System.Drawing.Point(1066, 327);
            this.btn_modificar_user.Name = "btn_modificar_user";
            this.btn_modificar_user.Size = new System.Drawing.Size(150, 33);
            this.btn_modificar_user.TabIndex = 26;
            this.btn_modificar_user.Text = "Modificar";
            this.btn_modificar_user.UseVisualStyleBackColor = false;
            this.btn_modificar_user.Click += new System.EventHandler(this.btn_mod_Click);
            // 
            // btn_cancelar_ModUser
            // 
            this.btn_cancelar_ModUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(234)))), ((int)(((byte)(239)))));
            this.btn_cancelar_ModUser.ForeColor = System.Drawing.Color.Black;
            this.btn_cancelar_ModUser.Location = new System.Drawing.Point(848, 327);
            this.btn_cancelar_ModUser.Name = "btn_cancelar_ModUser";
            this.btn_cancelar_ModUser.Size = new System.Drawing.Size(150, 33);
            this.btn_cancelar_ModUser.TabIndex = 25;
            this.btn_cancelar_ModUser.Text = "cancelar";
            this.btn_cancelar_ModUser.UseVisualStyleBackColor = false;
            this.btn_cancelar_ModUser.Click += new System.EventHandler(this.btn_cancelar_ModUser_Click);
            // 
            // msj_error
            // 
            this.msj_error.ContainerControl = this;
            // 
            // ModificarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1281, 382);
            this.Controls.Add(this.btn_modificar_user);
            this.Controls.Add(this.btn_cancelar_ModUser);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_cancelar_mod);
            this.Controls.Add(this.label10);
            this.Name = "ModificarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificarUsuario";
            this.Load += new System.EventHandler(this.ModificarUsuario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msj_error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_cancelar_mod;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox cb_rol_mod;
        public System.Windows.Forms.TextBox user_mail_mod;
        public System.Windows.Forms.TextBox user_ape_mod;
        public System.Windows.Forms.TextBox user_dni_mod;
        public System.Windows.Forms.TextBox user_tel_mod;
        public System.Windows.Forms.TextBox user_nom_mod;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox user_passConf_mod;
        public System.Windows.Forms.TextBox user_user_mod;
        public System.Windows.Forms.TextBox user_pass_mod;
        private System.Windows.Forms.Button btn_modificar_user;
        private System.Windows.Forms.Button btn_cancelar_ModUser;
        private System.Windows.Forms.ErrorProvider msj_error;
        private System.Windows.Forms.RadioButton inactivo_mod_user;
        private System.Windows.Forms.RadioButton activo_mod_user;
    }
}