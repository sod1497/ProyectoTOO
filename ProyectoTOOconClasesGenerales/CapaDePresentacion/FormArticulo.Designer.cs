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
            this.tbCodigo.Location = new System.Drawing.Point(132, 46);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.ReadOnly = true;
            this.tbCodigo.Size = new System.Drawing.Size(100, 20);
            this.tbCodigo.TabIndex = 0;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(132, 80);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(100, 20);
            this.tbDescripcion.TabIndex = 1;
            // 
            // tbPrecioCoste
            // 
            this.tbPrecioCoste.Location = new System.Drawing.Point(132, 113);
            this.tbPrecioCoste.Name = "tbPrecioCoste";
            this.tbPrecioCoste.Size = new System.Drawing.Size(100, 20);
            this.tbPrecioCoste.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Precio coste";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btNormal);
            this.flowLayoutPanel1.Controls.Add(this.btReducido);
            this.flowLayoutPanel1.Controls.Add(this.btSuperRed);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(83, 191);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(116, 91);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // btNormal
            // 
            this.btNormal.AutoSize = true;
            this.btNormal.Checked = true;
            this.btNormal.Location = new System.Drawing.Point(3, 3);
            this.btNormal.Name = "btNormal";
            this.btNormal.Size = new System.Drawing.Size(58, 17);
            this.btNormal.TabIndex = 0;
            this.btNormal.TabStop = true;
            this.btNormal.Text = "Normal";
            this.btNormal.UseVisualStyleBackColor = true;
            // 
            // btReducido
            // 
            this.btReducido.AutoSize = true;
            this.btReducido.Location = new System.Drawing.Point(3, 26);
            this.btReducido.Name = "btReducido";
            this.btReducido.Size = new System.Drawing.Size(71, 17);
            this.btReducido.TabIndex = 1;
            this.btReducido.Text = "Reducido";
            this.btReducido.UseVisualStyleBackColor = true;
            // 
            // btSuperRed
            // 
            this.btSuperRed.AutoSize = true;
            this.btSuperRed.Location = new System.Drawing.Point(3, 49);
            this.btSuperRed.Name = "btSuperRed";
            this.btSuperRed.Size = new System.Drawing.Size(94, 17);
            this.btSuperRed.TabIndex = 2;
            this.btSuperRed.Text = "Superreducido";
            this.btSuperRed.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tipo IVA";
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(157, 309);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 8;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(51, 309);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 9;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // formArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 375);
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
            this.Name = "formArticulo";
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