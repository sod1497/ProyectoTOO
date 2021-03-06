﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDePresentacion
{
    public partial class FArticulo : Form
    {
        //Guardará el valor validado
        float coste;
        ErrorProvider errorProvider;

        private FArticulo() { }

        //Este constructor crea una entrada de datos para el alta de dependiente
        public FArticulo(String clave)
        {
            InitializeComponent();

            errorProvider = new ErrorProvider();
            this.Text = "Alta artículo";
            tbCodigo.Text = clave;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_ClickDarAlta);

        }

        //Este constructor crea una baja de dependiente o una visualizacion de datos de dependiente.
        //Si se quiere una baja de dependiente, poner darDeBaja a true.
        public FArticulo(String clave, String descripcion, String precioCoste, Boolean darDeBaja, int iva)
        {
            InitializeComponent();

            errorProvider = new ErrorProvider();

            if (darDeBaja)
            {
                this.Text = "Dar de baja artículo";
                this.btAceptar.Text = "Dar baja";
                this.btAceptar.Click += new System.EventHandler(this.btAceptar_ClickDarBaja);
                this.btNormal.Enabled = false;
                this.btReducido.Enabled = false;
                this.btSuperRed.Enabled = false;
            }
            else
            {
                this.Text = "Datos de un artículo";
                this.btAceptar.Visible = false;
                this.btCancelar.Text = "Cerrar";
            }

            tbCodigo.Text = clave;
            tbDescripcion.Text = descripcion;
            tbDescripcion.ReadOnly = true;
            tbPrecioCoste.Text = precioCoste;
            tbPrecioCoste.ReadOnly = true;

            switch(iva)
            {
                case 21:
                    {
                        btNormal.Checked = true;
                        break;
                    }
                case 10:
                    {
                        btReducido.Checked = true;
                        break;
                    }
                case 4:
                    {
                        btSuperRed.Checked = true;
                        break;
                    }
            }
        }

        #region PROPIEDADES

        public String Descripcion
        {
            get { return tbDescripcion.Text; }
        }

        public float Precio
        {
            get
            {
                return coste;
            }
        }

        /*
        * Devuelve 21, 10 o 4 dependiendo del dato seleccionado. 
        */
        public int TipoIVA
        {
            get
            {
                if (btNormal.Checked)
                    return 21;
                else if (btReducido.Checked)
                    return 10;
                else
                    return 4;
            }
        }

        #endregion

        #region MANEJADORES

        private void btAceptar_ClickDarAlta(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }

        private void btAceptar_ClickDarBaja(object sender, EventArgs e)
        {
            if (DialogResult.OK.Equals(MessageBox.Show(this, "¿Esta seguro de que desea dar de baja al articulo?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)))
            {
                this.DialogResult = DialogResult.OK;
                this.Hide();
            }
            else
                this.DialogResult = DialogResult.Cancel;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
        }
        #endregion

        #region VALIDADORES
        
        private void tbDescripcion_Validating(object sender, CancelEventArgs e)
        {
            if (tbDescripcion.Text.Length == 0)
            {
                e.Cancel = true;
                errorProvider.SetError((Control)sender, "No puede estar vacío");
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void tbPrecio_Validating(object sender, CancelEventArgs e)
        {
            if (!isPrecioValid(tbPrecioCoste.Text))
            {
                e.Cancel = true;
                errorProvider.SetError((Control)sender, "Se requiere un real positivo");
            }
            else
            {
                errorProvider.Clear();
            }
        }

        #endregion

        #region MÉTODOS AUXILIARES 

        /*
         * Devuelve true si el valor del precio es un real positivo o 0
         */
        private bool isPrecioValid(string text)
        {
            bool result;
            float a;

            result = float.TryParse(text, out a) && a >= 0;
            if (result) this.coste = a;

            return result;
        }

        #endregion
    }
}
