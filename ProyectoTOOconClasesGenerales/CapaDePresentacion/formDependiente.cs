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
        ErrorProvider errorProvider;

        private formDependiente() { }

        //Este constructor crea una entrada de datos para el alta de dependiente
        public formDependiente(String clave)
        {
            InitializeComponent();

            this.AcceptButton = btAceptar;
            errorProvider = new ErrorProvider();
            this.Text = "Alta dependiente";
            tbNSS.Text = clave;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_ClickDarAlta);

        }

        //Este constructor crea una baja de dependiente o una visualizacion de datos de dependiente.
        //Si se quiere una baja de dependiente, poner darDeBaja a true.
        public formDependiente(String clave, String nombre, String apellidos, float comision, bool darDeBaja)
        {
            InitializeComponent();

            errorProvider = new ErrorProvider();
            this.AcceptButton = btAceptar;
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
            tbComision.Text = comision.ToString();
            tbComision.ReadOnly = true;
        }

        //  PROPS

        public String Nombre {
            get
            {
                return tbNombre.Text;
            }
        }

        public String Apellidos {
            get
            {
                return tbApellidos.Text;
            }
        }

        public float Comision
        {
            get{
                float result;
                bool b= float.TryParse(tbComision.Text,out result);
                return result;
            }

        }

        //  MANEJADORES

        private void btAceptar_ClickDarAlta(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Hide();

        }

        private void btAceptar_ClickDarBaja(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show(this, "¿Esta seguro de que desea dar de baja al dependiente?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
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

        //  VALIDADORES

        private void tbNombre_Validating(object sender, CancelEventArgs e)
        {
            if (tbNombre.Text.Length==0)
            {
                e.Cancel = true;
                errorProvider.SetError((Control)sender, "No puede estar vacío");
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void tbApellidos_Validating(object sender, CancelEventArgs e)
        {
            if (tbApellidos.Text.Length==0)
            {
                e.Cancel = true;
                errorProvider.SetError((Control)sender, "No puede estar vacío");
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void tbComision_Validating(object sender, CancelEventArgs e)
        {
            if (!isComisionValid(tbComision.Text))
            {
                e.Cancel = true;
                errorProvider.SetError((Control)sender, "La comisión es un porcentaje entero");
            }
            else
            {
                errorProvider.Clear();
            }
        }

        //   MÉTODOS AUXILIARES

        private bool isComisionValid(String comision)
        {
            bool result;
            int a;

            result = int.TryParse(comision,out a);

            return result;
        }
    }
}
