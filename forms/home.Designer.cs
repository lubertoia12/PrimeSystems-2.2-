namespace PrimeSystems_2._2_.forms
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.contenedor_general = new System.Windows.Forms.Panel();
            this.panel_padre = new System.Windows.Forms.Panel();
            this.uC_menuStrip1 = new PrimeSystems_2._2_.UserControls.UC_menuStrip();
            this.uC_NAVAR1 = new PrimeSystems_2._2_.UserControls.UC_NAVAR();
            this.contenedor_general.SuspendLayout();
            this.SuspendLayout();
            // 
            // contenedor_general
            // 
            this.contenedor_general.Controls.Add(this.panel_padre);
            this.contenedor_general.Controls.Add(this.uC_menuStrip1);
            this.contenedor_general.Controls.Add(this.uC_NAVAR1);
            this.contenedor_general.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor_general.Location = new System.Drawing.Point(0, 0);
            this.contenedor_general.Name = "contenedor_general";
            this.contenedor_general.Size = new System.Drawing.Size(1520, 742);
            this.contenedor_general.TabIndex = 0;
            // 
            // panel_padre
            // 
            this.panel_padre.AutoScroll = true;
            this.panel_padre.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel_padre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_padre.Location = new System.Drawing.Point(0, 138);
            this.panel_padre.Name = "panel_padre";
            this.panel_padre.Size = new System.Drawing.Size(1520, 604);
            this.panel_padre.TabIndex = 2;
            // 
            // uC_menuStrip1
            // 
            this.uC_menuStrip1.BackColor = System.Drawing.Color.MidnightBlue;
            this.uC_menuStrip1.controles = null;
            this.uC_menuStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uC_menuStrip1.Location = new System.Drawing.Point(0, 109);
            this.uC_menuStrip1.Name = "uC_menuStrip1";
            this.uC_menuStrip1.Size = new System.Drawing.Size(1520, 29);
            this.uC_menuStrip1.TabIndex = 1;
            this.uC_menuStrip1.Load += new System.EventHandler(this.uC_menuStrip1_Load);
            // 
            // uC_NAVAR1
            // 
            this.uC_NAVAR1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uC_NAVAR1.Location = new System.Drawing.Point(0, 0);
            this.uC_NAVAR1.Name = "uC_NAVAR1";
            this.uC_NAVAR1.Size = new System.Drawing.Size(1520, 109);
            this.uC_NAVAR1.TabIndex = 0;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1520, 742);
            this.Controls.Add(this.contenedor_general);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1538, 789);
            this.MinimumSize = new System.Drawing.Size(1538, 789);
            this.Name = "home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.home_Load);
            this.contenedor_general.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel contenedor_general;
        private UserControls.UC_menuStrip uC_menuStrip1;
        private UserControls.UC_NAVAR uC_NAVAR1;
        public System.Windows.Forms.Panel panel_padre;
    }
}