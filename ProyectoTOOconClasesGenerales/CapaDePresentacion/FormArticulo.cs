using System;
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
    public partial class formArticulo : Form
    {

        //utilizar los inas


        private formArticulo() { }

        //Este constructor crea una entrada de datos para el alta de dependiente
        public formArticulo(String clave)
        {
            InitializeComponent();

            this.Text = "Alta artículo";
            tbCodigo.Text = clave;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_ClickDarAlta);

        }

        //Este constructor crea una baja de dependiente o una visualizacion de datos de dependiente.
        //Si se quiere una baja de dependiente, poner darDeBaja a true.
        public formArticulo(String clave, String descripcion, String precioCoste, Boolean darDeBaja)
        {
            InitializeComponent();

            if (darDeBaja)
            {
                this.Text = "Dar de baja artículo";
                this.btAceptar.Text = "Dar baja";
                this.btAceptar.Click += new System.EventHandler(this.btAceptar_ClickDarBaja);
            }
            else
            {
                this.Text = "Datos de un artículo";
                this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            }

            tbCodigo.Text = clave;
            tbDescripcion.Text = descripcion;
            tbDescripcion.ReadOnly = true;
            tbPrecioCoste.Text = precioCoste;
            tbPrecioCoste.ReadOnly = true;
        }

        public String getDescripcion()
        {
            return tbDescripcion.Text;
        }
        public String getPrecio()
        {
            return tbPrecioCoste.Text;
        }


        /*
        * Devuelve 21, 10 o 4 dependiendo del dato seleccionado. 
        */
        public int getTipoIVA()
        {
            if (btNormal.Checked)
                return 21;
            else if (btReducido.Checked)
                return 10;
            else
                return 4;
        }


        private void btAceptar_ClickDarAlta(object sender, EventArgs e)
        {
            if (tbDescripcion.Text.Equals(""))
            {
                MessageBox.Show(this, "Introduzca descripción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tbPrecioCoste.Text.Equals(""))
            {
                MessageBox.Show(this, "Introduzca el precio coste", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();
            }
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
        private void btAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }
    }
}
