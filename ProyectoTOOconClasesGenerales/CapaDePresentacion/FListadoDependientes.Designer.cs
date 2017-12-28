namespace CapaDePresentacion
{
    partial class FListadoDependientes
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
            this.lbNSS = new System.Windows.Forms.ListBox();
            this.lbNombre = new System.Windows.Forms.ListBox();
            this.lbComision = new System.Windows.Forms.ListBox();
            this.bNSS = new System.Windows.Forms.Button();
            this.bNombre = new System.Windows.Forms.Button();
            this.bComisión = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bAdd = new System.Windows.Forms.Button();
            this.bCerrar = new System.Windows.Forms.Button();
            this.bModificar = new System.Windows.Forms.Button();
            this.bVentas = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNSS
            // 
            this.lbNSS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNSS.FormattingEnabled = true;
            this.lbNSS.ItemHeight = 16;
            this.lbNSS.Location = new System.Drawing.Point(3, 54);
            this.lbNSS.Name = "lbNSS";
            this.lbNSS.Size = new System.Drawing.Size(179, 292);
            this.lbNSS.TabIndex = 0;
            // 
            // lbNombre
            // 
            this.lbNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNombre.FormattingEnabled = true;
            this.lbNombre.ItemHeight = 16;
            this.lbNombre.Location = new System.Drawing.Point(188, 54);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(174, 292);
            this.lbNombre.TabIndex = 1;
            // 
            // lbComision
            // 
            this.lbComision.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbComision.FormattingEnabled = true;
            this.lbComision.ItemHeight = 16;
            this.lbComision.Location = new System.Drawing.Point(368, 54);
            this.lbComision.Name = "lbComision";
            this.lbComision.Size = new System.Drawing.Size(176, 292);
            this.lbComision.TabIndex = 2;
            // 
            // bNSS
            // 
            this.bNSS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bNSS.Location = new System.Drawing.Point(3, 3);
            this.bNSS.Name = "bNSS";
            this.bNSS.Size = new System.Drawing.Size(179, 45);
            this.bNSS.TabIndex = 3;
            this.bNSS.Text = "NSS";
            this.bNSS.UseVisualStyleBackColor = true;
            this.bNSS.Click += new System.EventHandler(this.bNSS_Click);
            // 
            // bNombre
            // 
            this.bNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bNombre.Location = new System.Drawing.Point(188, 3);
            this.bNombre.Name = "bNombre";
            this.bNombre.Size = new System.Drawing.Size(174, 45);
            this.bNombre.TabIndex = 4;
            this.bNombre.Text = "Nombre";
            this.bNombre.UseVisualStyleBackColor = true;
            this.bNombre.Click += new System.EventHandler(this.bNombre_Click);
            // 
            // bComisión
            // 
            this.bComisión.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bComisión.Location = new System.Drawing.Point(368, 3);
            this.bComisión.Name = "bComisión";
            this.bComisión.Size = new System.Drawing.Size(176, 45);
            this.bComisión.TabIndex = 5;
            this.bComisión.Text = "Comisión";
            this.bComisión.UseVisualStyleBackColor = true;
            this.bComisión.Click += new System.EventHandler(this.bComisión_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.Controls.Add(this.bNSS, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.bComisión, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.bNombre, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbNSS, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbComision, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbNombre, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 9);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(547, 352);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // bAdd
            // 
            this.bAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bAdd.Location = new System.Drawing.Point(172, 367);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(116, 30);
            this.bAdd.TabIndex = 8;
            this.bAdd.Text = "Dar de alta";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bCerrar
            // 
            this.bCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bCerrar.Location = new System.Drawing.Point(483, 367);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(71, 30);
            this.bCerrar.TabIndex = 9;
            this.bCerrar.Text = "Cerrar";
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // bModificar
            // 
            this.bModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bModificar.Enabled = false;
            this.bModificar.Location = new System.Drawing.Point(386, 367);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(91, 30);
            this.bModificar.TabIndex = 10;
            this.bModificar.Text = "Modificar";
            this.bModificar.UseVisualStyleBackColor = true;
            this.bModificar.Click += new System.EventHandler(this.bModificar_Click);
            // 
            // bVentas
            // 
            this.bVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bVentas.Location = new System.Drawing.Point(294, 368);
            this.bVentas.Name = "bVentas";
            this.bVentas.Size = new System.Drawing.Size(86, 29);
            this.bVentas.TabIndex = 11;
            this.bVentas.Text = "Ver ventas";
            this.bVentas.UseVisualStyleBackColor = true;
            this.bVentas.Click += new System.EventHandler(this.bVentas_Click);
            // 
            // FListadoDependientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 406);
            this.Controls.Add(this.bVentas);
            this.Controls.Add(this.bModificar);
            this.Controls.Add(this.bCerrar);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(412, 325);
            this.Name = "FListadoDependientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Listado de dependientes";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbNSS;
        private System.Windows.Forms.ListBox lbNombre;
        private System.Windows.Forms.ListBox lbComision;
        private System.Windows.Forms.Button bNSS;
        private System.Windows.Forms.Button bNombre;
        private System.Windows.Forms.Button bComisión;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bCerrar;
        private System.Windows.Forms.Button bModificar;
        private System.Windows.Forms.Button bVentas;
    }
}