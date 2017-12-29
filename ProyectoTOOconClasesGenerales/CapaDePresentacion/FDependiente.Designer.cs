namespace CapaDePresentacion
{
    partial class FDependiente
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
            this.labelNSS = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellidos = new System.Windows.Forms.Label();
            this.tbNSS = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbComision = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelNSS
            // 
            this.labelNSS.AutoSize = true;
            this.labelNSS.Cursor = System.Windows.Forms.Cursors.No;
            this.labelNSS.Location = new System.Drawing.Point(39, 40);
            this.labelNSS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNSS.Name = "labelNSS";
            this.labelNSS.Size = new System.Drawing.Size(49, 17);
            this.labelNSS.TabIndex = 5;
            this.labelNSS.Text = "Nº SS:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Cursor = System.Windows.Forms.Cursors.No;
            this.labelNombre.Location = new System.Drawing.Point(39, 81);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(58, 17);
            this.labelNombre.TabIndex = 6;
            this.labelNombre.Text = "Nombre";
            // 
            // labelApellidos
            // 
            this.labelApellidos.AutoSize = true;
            this.labelApellidos.Cursor = System.Windows.Forms.Cursors.No;
            this.labelApellidos.Location = new System.Drawing.Point(39, 122);
            this.labelApellidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelApellidos.Name = "labelApellidos";
            this.labelApellidos.Size = new System.Drawing.Size(65, 17);
            this.labelApellidos.TabIndex = 7;
            this.labelApellidos.Text = "Apellidos";
            // 
            // tbNSS
            // 
            this.tbNSS.Location = new System.Drawing.Point(201, 37);
            this.tbNSS.Margin = new System.Windows.Forms.Padding(4);
            this.tbNSS.Name = "tbNSS";
            this.tbNSS.ReadOnly = true;
            this.tbNSS.Size = new System.Drawing.Size(132, 22);
            this.tbNSS.TabIndex = 3;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(201, 78);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(4);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(132, 22);
            this.tbNombre.TabIndex = 0;
            this.tbNombre.Validating += new System.ComponentModel.CancelEventHandler(this.tbNombre_Validating);
            // 
            // tbApellidos
            // 
            this.tbApellidos.Location = new System.Drawing.Point(201, 119);
            this.tbApellidos.Margin = new System.Windows.Forms.Padding(4);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(132, 22);
            this.tbApellidos.TabIndex = 1;
            this.tbApellidos.Validating += new System.ComponentModel.CancelEventHandler(this.tbApellidos_Validating);
            // 
            // btCancelar
            // 
            this.btCancelar.CausesValidation = false;
            this.btCancelar.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.btCancelar.Location = new System.Drawing.Point(233, 209);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(100, 28);
            this.btCancelar.TabIndex = 4;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btAceptar
            // 
            this.btAceptar.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.btAceptar.Location = new System.Drawing.Point(42, 209);
            this.btAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(100, 28);
            this.btAceptar.TabIndex = 3;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.Location = new System.Drawing.Point(39, 163);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Comisión (%)";
            // 
            // tbComision
            // 
            this.tbComision.Location = new System.Drawing.Point(201, 160);
            this.tbComision.Margin = new System.Windows.Forms.Padding(4);
            this.tbComision.Name = "tbComision";
            this.tbComision.Size = new System.Drawing.Size(132, 22);
            this.tbComision.TabIndex = 2;
            this.tbComision.Validating += new System.ComponentModel.CancelEventHandler(this.tbComision_Validating);
            // 
            // FDependiente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 266);
            this.Controls.Add(this.tbComision);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.tbApellidos);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbNSS);
            this.Controls.Add(this.labelApellidos);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelNSS);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(393, 313);
            this.MinimumSize = new System.Drawing.Size(393, 313);
            this.Name = "FDependiente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Alta de un dependiente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNSS;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellidos;
        private System.Windows.Forms.TextBox tbNSS;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbApellidos;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbComision;
    }
}