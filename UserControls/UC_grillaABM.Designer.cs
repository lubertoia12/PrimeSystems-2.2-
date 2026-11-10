namespace PrimeSystems_2._2_.UserControls
{
    partial class UC_grillaABM
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_fondo = new System.Windows.Forms.Panel();
            this.pnl_botones = new System.Windows.Forms.Panel();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_inactivar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnl_fondo.SuspendLayout();
            this.pnl_botones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_fondo
            // 
            this.pnl_fondo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnl_fondo.Controls.Add(this.dataGridView1);
            this.pnl_fondo.Controls.Add(this.pnl_botones);
            this.pnl_fondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_fondo.Location = new System.Drawing.Point(0, 0);
            this.pnl_fondo.Name = "pnl_fondo";
            this.pnl_fondo.Size = new System.Drawing.Size(1398, 519);
            this.pnl_fondo.TabIndex = 1;
            // 
            // pnl_botones
            // 
            this.pnl_botones.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnl_botones.Controls.Add(this.btn_modificar);
            this.pnl_botones.Controls.Add(this.btn_inactivar);
            this.pnl_botones.Controls.Add(this.btn_agregar);
            this.pnl_botones.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_botones.Location = new System.Drawing.Point(1219, 0);
            this.pnl_botones.Name = "pnl_botones";
            this.pnl_botones.Size = new System.Drawing.Size(179, 519);
            this.pnl_botones.TabIndex = 4;
            // 
            // btn_modificar
            // 
            this.btn_modificar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_modificar.Location = new System.Drawing.Point(24, 70);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(131, 27);
            this.btn_modificar.TabIndex = 2;
            this.btn_modificar.Text = "modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_inactivar
            // 
            this.btn_inactivar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_inactivar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inactivar.Location = new System.Drawing.Point(24, 99);
            this.btn_inactivar.Name = "btn_inactivar";
            this.btn_inactivar.Size = new System.Drawing.Size(131, 27);
            this.btn_inactivar.TabIndex = 3;
            this.btn_inactivar.Text = "inactivar";
            this.btn_inactivar.UseVisualStyleBackColor = true;
            this.btn_inactivar.Click += new System.EventHandler(this.btn_inactivar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_agregar.Location = new System.Drawing.Point(24, 41);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(131, 27);
            this.btn_agregar.TabIndex = 1;
            this.btn_agregar.Text = "agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1219, 519);
            this.dataGridView1.TabIndex = 5;
            // 
            // UC_grillaABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_fondo);
            this.Name = "UC_grillaABM";
            this.Size = new System.Drawing.Size(1398, 519);
            this.pnl_fondo.ResumeLayout(false);
            this.pnl_botones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_fondo;
        private System.Windows.Forms.Panel pnl_botones;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_inactivar;
        private System.Windows.Forms.Button btn_agregar;
        
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
