namespace CapaDePresentacion
{
    partial class FBuscar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FBuscar));
            this.tbComision = new System.Windows.Forms.TextBox();
            this.labelComision = new System.Windows.Forms.Label();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.labelApellidos = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelNSS = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.bAplicar = new System.Windows.Forms.Button();
            this.labelImporte = new System.Windows.Forms.Label();
            this.tbImporte = new System.Windows.Forms.TextBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingAdd = new System.Windows.Forms.ToolStripButton();
            this.bindingRemove = new System.Windows.Forms.ToolStripButton();
            this.bExtra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbComision
            // 
            this.tbComision.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbComision.Location = new System.Drawing.Point(188, 176);
            this.tbComision.Margin = new System.Windows.Forms.Padding(4);
            this.tbComision.Name = "tbComision";
            this.tbComision.Size = new System.Drawing.Size(294, 22);
            this.tbComision.TabIndex = 11;
            this.tbComision.Validating += new System.ComponentModel.CancelEventHandler(this.tbComision_Validating);
            this.tbComision.Validated += new System.EventHandler(this.tb_Validated);
            // 
            // labelComision
            // 
            this.labelComision.AutoSize = true;
            this.labelComision.Cursor = System.Windows.Forms.Cursors.No;
            this.labelComision.Location = new System.Drawing.Point(26, 179);
            this.labelComision.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelComision.Name = "labelComision";
            this.labelComision.Size = new System.Drawing.Size(95, 17);
            this.labelComision.TabIndex = 16;
            this.labelComision.Text = "labelComision";
            // 
            // tbApellidos
            // 
            this.tbApellidos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbApellidos.Location = new System.Drawing.Point(188, 135);
            this.tbApellidos.Margin = new System.Windows.Forms.Padding(4);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(294, 22);
            this.tbApellidos.TabIndex = 10;
            this.tbApellidos.Validating += new System.ComponentModel.CancelEventHandler(this.tbApellidos_Validating);
            this.tbApellidos.Validated += new System.EventHandler(this.tb_Validated);
            // 
            // tbNombre
            // 
            this.tbNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNombre.Location = new System.Drawing.Point(188, 94);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(4);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(294, 22);
            this.tbNombre.TabIndex = 9;
            this.tbNombre.Validating += new System.ComponentModel.CancelEventHandler(this.tbNombre_Validating);
            this.tbNombre.Validated += new System.EventHandler(this.tb_Validated);
            // 
            // labelApellidos
            // 
            this.labelApellidos.AutoSize = true;
            this.labelApellidos.Cursor = System.Windows.Forms.Cursors.No;
            this.labelApellidos.Location = new System.Drawing.Point(26, 138);
            this.labelApellidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelApellidos.Name = "labelApellidos";
            this.labelApellidos.Size = new System.Drawing.Size(95, 17);
            this.labelApellidos.TabIndex = 15;
            this.labelApellidos.Text = "labelApellidos";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Cursor = System.Windows.Forms.Cursors.No;
            this.labelNombre.Location = new System.Drawing.Point(26, 97);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(88, 17);
            this.labelNombre.TabIndex = 14;
            this.labelNombre.Text = "labelNombre";
            // 
            // labelNSS
            // 
            this.labelNSS.AutoSize = true;
            this.labelNSS.Cursor = System.Windows.Forms.Cursors.No;
            this.labelNSS.Location = new System.Drawing.Point(26, 56);
            this.labelNSS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNSS.Name = "labelNSS";
            this.labelNSS.Size = new System.Drawing.Size(66, 17);
            this.labelNSS.TabIndex = 13;
            this.labelNSS.Text = "labelNSS";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(188, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(294, 24);
            this.comboBox1.TabIndex = 17;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.CausesValidation = false;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(29, 316);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(233, 21);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "Aplicar cambios inmediatamente";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // bAplicar
            // 
            this.bAplicar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bAplicar.Enabled = false;
            this.bAplicar.Location = new System.Drawing.Point(337, 316);
            this.bAplicar.Name = "bAplicar";
            this.bAplicar.Size = new System.Drawing.Size(145, 32);
            this.bAplicar.TabIndex = 19;
            this.bAplicar.Text = "Aplicar cambios";
            this.bAplicar.UseVisualStyleBackColor = true;
            this.bAplicar.Click += new System.EventHandler(this.bAplicar_Click);
            // 
            // labelImporte
            // 
            this.labelImporte.AutoSize = true;
            this.labelImporte.Location = new System.Drawing.Point(29, 218);
            this.labelImporte.Name = "labelImporte";
            this.labelImporte.Size = new System.Drawing.Size(85, 17);
            this.labelImporte.TabIndex = 20;
            this.labelImporte.Text = "labelImporte";
            // 
            // tbImporte
            // 
            this.tbImporte.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbImporte.Location = new System.Drawing.Point(188, 215);
            this.tbImporte.Name = "tbImporte";
            this.tbImporte.Size = new System.Drawing.Size(294, 22);
            this.tbImporte.TabIndex = 21;
            this.tbImporte.Validating += new System.ComponentModel.CancelEventHandler(this.tbImporte_Validating);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem1;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator4,
            this.bindingAdd,
            this.bindingRemove});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem1;
            this.bindingNavigator1.Size = new System.Drawing.Size(516, 27);
            this.bindingNavigator1.TabIndex = 22;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem1.Text = "de {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem1.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem1.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem1.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem1.Text = "Mover último";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingAdd
            // 
            this.bindingAdd.Image = ((System.Drawing.Image)(resources.GetObject("bindingAdd.Image")));
            this.bindingAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingAdd.Name = "bindingAdd";
            this.bindingAdd.Size = new System.Drawing.Size(107, 24);
            this.bindingAdd.Text = "Dar de alta";
            this.bindingAdd.Click += new System.EventHandler(this.bindingAdd_Click);
            // 
            // bindingRemove
            // 
            this.bindingRemove.Image = ((System.Drawing.Image)(resources.GetObject("bindingRemove.Image")));
            this.bindingRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingRemove.Name = "bindingRemove";
            this.bindingRemove.Size = new System.Drawing.Size(111, 24);
            this.bindingRemove.Text = "Dar de baja";
            this.bindingRemove.Click += new System.EventHandler(this.bindingRemove_Click);
            // 
            // bExtra
            // 
            this.bExtra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bExtra.Location = new System.Drawing.Point(156, 266);
            this.bExtra.Name = "bExtra";
            this.bExtra.Size = new System.Drawing.Size(205, 32);
            this.bExtra.TabIndex = 23;
            this.bExtra.Text = "Acción extra";
            this.bExtra.UseVisualStyleBackColor = true;
            this.bExtra.Click += new System.EventHandler(this.bExtra_Click);
            // 
            // FBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 360);
            this.Controls.Add(this.bExtra);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.tbImporte);
            this.Controls.Add(this.labelImporte);
            this.Controls.Add(this.bAplicar);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tbComision);
            this.Controls.Add(this.labelComision);
            this.Controls.Add(this.tbApellidos);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.labelApellidos);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelNSS);
            this.MinimumSize = new System.Drawing.Size(534, 407);
            this.Name = "FBuscar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FBuscar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FBuscarDependiente_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbComision;
        private System.Windows.Forms.Label labelComision;
        private System.Windows.Forms.TextBox tbApellidos;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label labelApellidos;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelNSS;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button bAplicar;
        private System.Windows.Forms.Label labelImporte;
        private System.Windows.Forms.TextBox tbImporte;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingAdd;
        private System.Windows.Forms.ToolStripButton bindingRemove;
        private System.Windows.Forms.Button bExtra;
    }
}