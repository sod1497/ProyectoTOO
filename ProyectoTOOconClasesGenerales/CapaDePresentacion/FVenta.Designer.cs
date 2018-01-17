namespace CapaDePresentacion
{
    partial class FVenta
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.labelDependiente = new System.Windows.Forms.Label();
            this.cbDependientes = new System.Windows.Forms.ComboBox();
            this.cbIDArticulo = new System.Windows.Forms.ComboBox();
            this.tbDescripcionArticulo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbLineasArticulo = new System.Windows.Forms.ListBox();
            this.tbPrecioUD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.lbLineasImporte = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbLineasCantidad = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbImporte = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTarjeta = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rbTarjeta = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbDependiente = new System.Windows.Forms.TextBox();
            this.lbImporteTotal = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(21, 47);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.ReadOnly = true;
            this.tbCodigo.Size = new System.Drawing.Size(231, 22);
            this.tbCodigo.TabIndex = 1;
            // 
            // labelDependiente
            // 
            this.labelDependiente.AutoSize = true;
            this.labelDependiente.Location = new System.Drawing.Point(18, 77);
            this.labelDependiente.Name = "labelDependiente";
            this.labelDependiente.Size = new System.Drawing.Size(89, 17);
            this.labelDependiente.TabIndex = 2;
            this.labelDependiente.Text = "Dependiente";
            // 
            // cbDependientes
            // 
            this.cbDependientes.FormattingEnabled = true;
            this.cbDependientes.Location = new System.Drawing.Point(21, 97);
            this.cbDependientes.Name = "cbDependientes";
            this.cbDependientes.Size = new System.Drawing.Size(231, 24);
            this.cbDependientes.TabIndex = 3;
            this.cbDependientes.SelectedIndexChanged += new System.EventHandler(this.cbDependientes_SelectedIndexChanged);
            // 
            // cbIDArticulo
            // 
            this.cbIDArticulo.FormattingEnabled = true;
            this.cbIDArticulo.Location = new System.Drawing.Point(15, 47);
            this.cbIDArticulo.Name = "cbIDArticulo";
            this.cbIDArticulo.Size = new System.Drawing.Size(187, 24);
            this.cbIDArticulo.TabIndex = 5;
            this.cbIDArticulo.SelectedIndexChanged += new System.EventHandler(this.cbIDArticulo_SelectedIndexChanged);
            // 
            // tbDescripcionArticulo
            // 
            this.tbDescripcionArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDescripcionArticulo.Location = new System.Drawing.Point(225, 47);
            this.tbDescripcionArticulo.Multiline = true;
            this.tbDescripcionArticulo.Name = "tbDescripcionArticulo";
            this.tbDescripcionArticulo.ReadOnly = true;
            this.tbDescripcionArticulo.Size = new System.Drawing.Size(190, 54);
            this.tbDescripcionArticulo.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbCantidad
            // 
            this.tbCantidad.Location = new System.Drawing.Point(74, 79);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.ReadOnly = true;
            this.tbCantidad.Size = new System.Drawing.Size(69, 22);
            this.tbCantidad.TabIndex = 8;
            this.tbCantidad.Text = "0";
            this.tbCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCantidad.Validating += new System.ComponentModel.CancelEventHandler(this.tbCantidad_Validating);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(149, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Lineas de venta";
            // 
            // lbLineasArticulo
            // 
            this.lbLineasArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLineasArticulo.FormattingEnabled = true;
            this.lbLineasArticulo.ItemHeight = 16;
            this.lbLineasArticulo.Location = new System.Drawing.Point(3, 20);
            this.lbLineasArticulo.Name = "lbLineasArticulo";
            this.lbLineasArticulo.Size = new System.Drawing.Size(126, 260);
            this.lbLineasArticulo.TabIndex = 11;
            this.lbLineasArticulo.SelectedIndexChanged += new System.EventHandler(this.lbLineas_SelectedIndexChanged);
            // 
            // tbPrecioUD
            // 
            this.tbPrecioUD.Location = new System.Drawing.Point(15, 136);
            this.tbPrecioUD.Name = "tbPrecioUD";
            this.tbPrecioUD.ReadOnly = true;
            this.tbPrecioUD.Size = new System.Drawing.Size(187, 22);
            this.tbPrecioUD.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Unidad";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Controls.Add(this.tbImporte);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbDescripcionArticulo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbIDArticulo);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbCantidad);
            this.groupBox1.Controls.Add(this.tbPrecioUD);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 514);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Artículos";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbLineasImporte, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label9, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbLineasCantidad, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label10, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbLineasArticulo, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 196);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(400, 295);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "ID Artículo";
            // 
            // lbLineasImporte
            // 
            this.lbLineasImporte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLineasImporte.FormattingEnabled = true;
            this.lbLineasImporte.ItemHeight = 16;
            this.lbLineasImporte.Location = new System.Drawing.Point(267, 20);
            this.lbLineasImporte.Name = "lbLineasImporte";
            this.lbLineasImporte.Size = new System.Drawing.Size(130, 260);
            this.lbLineasImporte.TabIndex = 20;
            this.lbLineasImporte.SelectedIndexChanged += new System.EventHandler(this.lbLineas_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(135, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Cantidad";
            // 
            // lbLineasCantidad
            // 
            this.lbLineasCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLineasCantidad.FormattingEnabled = true;
            this.lbLineasCantidad.ItemHeight = 16;
            this.lbLineasCantidad.Location = new System.Drawing.Point(135, 20);
            this.lbLineasCantidad.Name = "lbLineasCantidad";
            this.lbLineasCantidad.Size = new System.Drawing.Size(126, 260);
            this.lbLineasCantidad.TabIndex = 19;
            this.lbLineasCantidad.SelectedIndexChanged += new System.EventHandler(this.lbLineas_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(267, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Importe";
            // 
            // tbImporte
            // 
            this.tbImporte.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbImporte.Location = new System.Drawing.Point(228, 135);
            this.tbImporte.Name = "tbImporte";
            this.tbImporte.ReadOnly = true;
            this.tbImporte.Size = new System.Drawing.Size(187, 22);
            this.tbImporte.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(225, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Importe total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Descripción";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Identificador y cantidad";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(535, 501);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 31);
            this.button3.TabIndex = 15;
            this.button3.Text = "Finalizar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(626, 501);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 31);
            this.button4.TabIndex = 16;
            this.button4.Text = "Cancelar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbTarjeta);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.rbTarjeta);
            this.groupBox2.Location = new System.Drawing.Point(458, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 155);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pago";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Tarjeta";
            // 
            // tbTarjeta
            // 
            this.tbTarjeta.Location = new System.Drawing.Point(21, 113);
            this.tbTarjeta.Name = "tbTarjeta";
            this.tbTarjeta.Size = new System.Drawing.Size(212, 22);
            this.tbTarjeta.TabIndex = 2;
            this.tbTarjeta.Validating += new System.ComponentModel.CancelEventHandler(this.tbTarjeta_Validating);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.CausesValidation = false;
            this.radioButton1.Location = new System.Drawing.Point(21, 60);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(135, 21);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.Text = "Pago en efectivo";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rbTarjeta
            // 
            this.rbTarjeta.AutoSize = true;
            this.rbTarjeta.Checked = true;
            this.rbTarjeta.Location = new System.Drawing.Point(21, 33);
            this.rbTarjeta.Name = "rbTarjeta";
            this.rbTarjeta.Size = new System.Drawing.Size(133, 21);
            this.rbTarjeta.TabIndex = 0;
            this.rbTarjeta.TabStop = true;
            this.rbTarjeta.Text = "Pago con tarjeta";
            this.rbTarjeta.UseVisualStyleBackColor = true;
            this.rbTarjeta.CheckedChanged += new System.EventHandler(this.rbTarjeta_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.tbDependiente);
            this.groupBox3.Controls.Add(this.tbCodigo);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cbDependientes);
            this.groupBox3.Controls.Add(this.labelDependiente);
            this.groupBox3.Location = new System.Drawing.Point(458, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(258, 168);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos de la venta";
            // 
            // tbDependiente
            // 
            this.tbDependiente.Location = new System.Drawing.Point(21, 136);
            this.tbDependiente.Name = "tbDependiente";
            this.tbDependiente.ReadOnly = true;
            this.tbDependiente.Size = new System.Drawing.Size(231, 22);
            this.tbDependiente.TabIndex = 4;
            // 
            // lbImporteTotal
            // 
            this.lbImporteTotal.AutoSize = true;
            this.lbImporteTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImporteTotal.Location = new System.Drawing.Point(6, 18);
            this.lbImporteTotal.Name = "lbImporteTotal";
            this.lbImporteTotal.Size = new System.Drawing.Size(75, 46);
            this.lbImporteTotal.TabIndex = 19;
            this.lbImporteTotal.Text = "0 €";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.lbImporteTotal);
            this.groupBox4.Location = new System.Drawing.Point(458, 347);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(258, 73);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Total";
            // 
            // FVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 540);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(746, 587);
            this.Name = "FVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FVenta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label labelDependiente;
        private System.Windows.Forms.ComboBox cbDependientes;
        private System.Windows.Forms.ComboBox cbIDArticulo;
        private System.Windows.Forms.TextBox tbDescripcionArticulo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbLineasArticulo;
        private System.Windows.Forms.TextBox tbPrecioUD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbImporte;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTarjeta;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rbTarjeta;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbDependiente;
        private System.Windows.Forms.ListBox lbLineasImporte;
        private System.Windows.Forms.ListBox lbLineasCantidad;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbImporteTotal;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}