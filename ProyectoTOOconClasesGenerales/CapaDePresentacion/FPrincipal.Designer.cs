namespace CapaDePresentacion
{
    partial class FPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.depedientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDependiente = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaDependiente = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.búsquedaDependiente = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.búsquedaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.búsquedaToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasRecientesDeDependienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasDeArtículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.depedientesToolStripMenuItem,
            this.artículosToolStripMenuItem,
            this.ventasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(595, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // depedientesToolStripMenuItem
            // 
            this.depedientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaDependiente,
            this.bajaDependiente,
            this.toolStripSeparator1,
            this.búsquedaDependiente,
            this.listadoToolStripMenuItem});
            this.depedientesToolStripMenuItem.Name = "depedientesToolStripMenuItem";
            this.depedientesToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.depedientesToolStripMenuItem.Text = "Depedientes";
            // 
            // altaDependiente
            // 
            this.altaDependiente.Name = "altaDependiente";
            this.altaDependiente.Size = new System.Drawing.Size(149, 26);
            this.altaDependiente.Text = "Alta";
            this.altaDependiente.Click += new System.EventHandler(this.altaDependiente_Click);
            // 
            // bajaDependiente
            // 
            this.bajaDependiente.Name = "bajaDependiente";
            this.bajaDependiente.Size = new System.Drawing.Size(149, 26);
            this.bajaDependiente.Text = "Baja";
            this.bajaDependiente.Click += new System.EventHandler(this.bajaDependiente_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(146, 6);
            // 
            // búsquedaDependiente
            // 
            this.búsquedaDependiente.Name = "búsquedaDependiente";
            this.búsquedaDependiente.Size = new System.Drawing.Size(149, 26);
            this.búsquedaDependiente.Text = "Búsqueda";
            this.búsquedaDependiente.Click += new System.EventHandler(this.búsquedaDependiente_Click);
            // 
            // listadoToolStripMenuItem
            // 
            this.listadoToolStripMenuItem.Name = "listadoToolStripMenuItem";
            this.listadoToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.listadoToolStripMenuItem.Text = "Listado";
            this.listadoToolStripMenuItem.Click += new System.EventHandler(this.listadoToolStripMenuItem_Click);
            // 
            // artículosToolStripMenuItem
            // 
            this.artículosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaToolStripMenuItem1,
            this.bajaToolStripMenuItem1,
            this.toolStripSeparator2,
            this.búsquedaToolStripMenuItem1,
            this.listadoToolStripMenuItem1});
            this.artículosToolStripMenuItem.Name = "artículosToolStripMenuItem";
            this.artículosToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.artículosToolStripMenuItem.Text = "Artículos";
            // 
            // altaToolStripMenuItem1
            // 
            this.altaToolStripMenuItem1.Name = "altaToolStripMenuItem1";
            this.altaToolStripMenuItem1.Size = new System.Drawing.Size(149, 26);
            this.altaToolStripMenuItem1.Text = "Alta";
            this.altaToolStripMenuItem1.Click += new System.EventHandler(this.altaArticulo_Click);
            // 
            // bajaToolStripMenuItem1
            // 
            this.bajaToolStripMenuItem1.Name = "bajaToolStripMenuItem1";
            this.bajaToolStripMenuItem1.Size = new System.Drawing.Size(149, 26);
            this.bajaToolStripMenuItem1.Text = "Baja";
            this.bajaToolStripMenuItem1.Click += new System.EventHandler(this.bajaToolStripMenuItem1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(146, 6);
            // 
            // búsquedaToolStripMenuItem1
            // 
            this.búsquedaToolStripMenuItem1.Name = "búsquedaToolStripMenuItem1";
            this.búsquedaToolStripMenuItem1.Size = new System.Drawing.Size(149, 26);
            this.búsquedaToolStripMenuItem1.Text = "Búsqueda";
            this.búsquedaToolStripMenuItem1.Click += new System.EventHandler(this.búsquedaToolStripMenuItem1_Click);
            // 
            // listadoToolStripMenuItem1
            // 
            this.listadoToolStripMenuItem1.Name = "listadoToolStripMenuItem1";
            this.listadoToolStripMenuItem1.Size = new System.Drawing.Size(149, 26);
            this.listadoToolStripMenuItem1.Text = "Listado";
            this.listadoToolStripMenuItem1.Click += new System.EventHandler(this.listadoToolStripMenuItem1_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaToolStripMenuItem2,
            this.bajaToolStripMenuItem2,
            this.toolStripSeparator3,
            this.búsquedaToolStripMenuItem2,
            this.listadoToolStripMenuItem2});
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // altaToolStripMenuItem2
            // 
            this.altaToolStripMenuItem2.Name = "altaToolStripMenuItem2";
            this.altaToolStripMenuItem2.Size = new System.Drawing.Size(181, 26);
            this.altaToolStripMenuItem2.Text = "Alta";
            this.altaToolStripMenuItem2.Click += new System.EventHandler(this.altaToolStripMenuItem2_Click);
            // 
            // bajaToolStripMenuItem2
            // 
            this.bajaToolStripMenuItem2.Name = "bajaToolStripMenuItem2";
            this.bajaToolStripMenuItem2.Size = new System.Drawing.Size(181, 26);
            this.bajaToolStripMenuItem2.Text = "Baja";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(178, 6);
            // 
            // búsquedaToolStripMenuItem2
            // 
            this.búsquedaToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasRecientesDeDependienteToolStripMenuItem,
            this.ventasDeArtículoToolStripMenuItem});
            this.búsquedaToolStripMenuItem2.Name = "búsquedaToolStripMenuItem2";
            this.búsquedaToolStripMenuItem2.Size = new System.Drawing.Size(181, 26);
            this.búsquedaToolStripMenuItem2.Text = "Búsqueda";
            // 
            // ventasRecientesDeDependienteToolStripMenuItem
            // 
            this.ventasRecientesDeDependienteToolStripMenuItem.Name = "ventasRecientesDeDependienteToolStripMenuItem";
            this.ventasRecientesDeDependienteToolStripMenuItem.Size = new System.Drawing.Size(299, 26);
            this.ventasRecientesDeDependienteToolStripMenuItem.Text = "Ventas recientes de dependiente";
            this.ventasRecientesDeDependienteToolStripMenuItem.Click += new System.EventHandler(this.ventasRecientesDeDependienteToolStripMenuItem_Click);
            // 
            // ventasDeArtículoToolStripMenuItem
            // 
            this.ventasDeArtículoToolStripMenuItem.Name = "ventasDeArtículoToolStripMenuItem";
            this.ventasDeArtículoToolStripMenuItem.Size = new System.Drawing.Size(299, 26);
            this.ventasDeArtículoToolStripMenuItem.Text = "Ventas de artículo";
            this.ventasDeArtículoToolStripMenuItem.Click += new System.EventHandler(this.ventasDeArtículoToolStripMenuItem_Click);
            // 
            // listadoToolStripMenuItem2
            // 
            this.listadoToolStripMenuItem2.Name = "listadoToolStripMenuItem2";
            this.listadoToolStripMenuItem2.Size = new System.Drawing.Size(181, 26);
            this.listadoToolStripMenuItem2.Text = "Listado";
            this.listadoToolStripMenuItem2.Click += new System.EventHandler(this.listadoToolStripMenuItem2_Click);
            // 
            // FPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 419);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de ventas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem depedientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDependiente;
        private System.Windows.Forms.ToolStripMenuItem bajaDependiente;
        private System.Windows.Forms.ToolStripMenuItem búsquedaDependiente;
        private System.Windows.Forms.ToolStripMenuItem artículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bajaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem búsquedaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem búsquedaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem bajaToolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem listadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem listadoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem listadoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ventasRecientesDeDependienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasDeArtículoToolStripMenuItem;
    }
}