namespace CapaDePresentacion
{
    partial class formArticulo
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
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.tbPrecioCoste = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btNormal = new System.Windows.Forms.RadioButton();
            this.btReducido = new System.Windows.Forms.RadioButton();
            this.btSuperRed = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(44, 59);
            this.tbCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCodigo.MinimumSize = new System.Drawing.Size(189, 22);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.ReadOnly = true;
            this.tbCodigo.Size = new System.Drawing.Size(189, 22);
            this.tbCodigo.TabIndex = 7;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDescripcion.Location = new System.Drawing.Point(44, 180);
            this.tbDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(361, 70);
            this.tbDescripcion.TabIndex = 1;
            this.tbDescripcion.Validating += new System.ComponentModel.CancelEventHandler(this.tbDescripcion_Validating);
            // 
            // tbPrecioCoste
            // 
            this.tbPrecioCoste.Location = new System.Drawing.Point(44, 120);
            this.tbPrecioCoste.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPrecioCoste.Name = "tbPrecioCoste";
            this.tbPrecioCoste.Size = new System.Drawing.Size(189, 22);
            this.tbPrecioCoste.TabIndex = 0;
            this.tbPrecioCoste.Validating += new System.ComponentModel.CancelEventHandler(this.tbPrecio_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 159);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Precio coste";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.btNormal);
            this.flowLayoutPanel1.Controls.Add(this.btReducido);
            this.flowLayoutPanel1.Controls.Add(this.btSuperRed);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(268, 59);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(137, 98);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // btNormal
            // 
            this.btNormal.AutoSize = true;
            this.btNormal.Checked = true;
            this.btNormal.Location = new System.Drawing.Point(4, 4);
            this.btNormal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btNormal.Name = "btNormal";
            this.btNormal.Size = new System.Drawing.Size(74, 21);
            this.btNormal.TabIndex = 2;
            this.btNormal.TabStop = true;
            this.btNormal.Text = "Normal";
            this.btNormal.UseVisualStyleBackColor = true;
            // 
            // btReducido
            // 
            this.btReducido.AutoSize = true;
            this.btReducido.Location = new System.Drawing.Point(4, 33);
            this.btReducido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btReducido.Name = "btReducido";
            this.btReducido.Size = new System.Drawing.Size(89, 21);
            this.btReducido.TabIndex = 3;
            this.btReducido.Text = "Reducido";
            this.btReducido.UseVisualStyleBackColor = true;
            // 
            // btSuperRed
            // 
            this.btSuperRed.AutoSize = true;
            this.btSuperRed.Location = new System.Drawing.Point(4, 62);
            this.btSuperRed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSuperRed.Name = "btSuperRed";
            this.btSuperRed.Size = new System.Drawing.Size(122, 21);
            this.btSuperRed.TabIndex = 4;
            this.btSuperRed.Text = "Superreducido";
            this.btSuperRed.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tipo IVA";
            // 
            // btAceptar
            // 
            this.btAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btAceptar.Location = new System.Drawing.Point(110, 273);
            this.btAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(100, 28);
            this.btAceptar.TabIndex = 5;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            // 
            // btCancelar
            // 
            this.btCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancelar.CausesValidation = false;
            this.btCancelar.Location = new System.Drawing.Point(234, 273);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(100, 28);
            this.btCancelar.TabIndex = 6;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // formArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 327);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPrecioCoste);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.tbCodigo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(458, 374);
            this.MinimumSize = new System.Drawing.Size(458, 374);
            this.Name = "formArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Introducir Articulo";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.TextBox tbPrecioCoste;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton btNormal;
        private System.Windows.Forms.RadioButton btReducido;
        private System.Windows.Forms.RadioButton btSuperRed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btCancelar;
    }
}