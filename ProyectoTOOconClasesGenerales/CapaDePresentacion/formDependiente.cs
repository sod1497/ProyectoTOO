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
    public partial class formDependiente : Form
    {
        private formDependiente() { }

        //Este constructor crea una entrada de datos para el alta de dependiente
        public formDependiente(String clave)
        {
            InitializeComponent();

            this.Text = "Alta dependiente";
            tbNSS.Text = clave;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_ClickDarAlta);

        }

        //Este constructor crea una baja de dependiente o una visualizacion de datos de dependiente.
        //Si se quiere una baja de dependiente, poner darDeBaja a true.
        public formDependiente(String clave, String nombre, String apellidos, Boolean darDeBaja)
        {
            InitializeComponent();

            if (darDeBaja)
            {
                this.Text = "Dar de baja dependiente";
                this.btAceptar.Text = "Dar baja";
                this.btAceptar.Click += new System.EventHandler(this.btAceptar_ClickDarBaja);
            }
            else
            {
                this.Text = "Datos de un dependiente";
                this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            }

            tbNSS.Text = clave;
            tbNombre.Text = nombre;
            tbNombre.ReadOnly = true;
            tbApellidos.Text = apellidos;
            tbApellidos.ReadOnly = true;
        }

        public String getNombre()
        {
            return tbNombre.Text;
        }
        public String getApellidos()
        {
            return tbApellidos.Text;
        }

        private void btAceptar_ClickDarAlta(object sender, EventArgs e)
        {
            if (tbNombre.Text.Equals(""))
            {
                MessageBox.Show(this, "Introduzca el Nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tbApellidos.Text.Equals(""))
            {
                MessageBox.Show(this, "Introduzca los Apellidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Hide();
            }
        }
        private void btAceptar_ClickDarBaja(object sender, EventArgs e)
        {
            if (DialogResult.OK.Equals(MessageBox.Show(this, "¿Esta seguro de que desea dar de baja al dependiente?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)))
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
