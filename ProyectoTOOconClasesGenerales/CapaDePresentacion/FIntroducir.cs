using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDePresentacion
{
    public partial class FIntroducir : Form
    {
        TipoDeClase clase;
        ErrorProvider errorProvider;

        public FIntroducir(TipoDeClase clase)
        {
            InitializeComponent();
            errorProvider = new ErrorProvider();
            this.clase = clase;
            if (this.clase.Equals(TipoDeClase.Dependiente))
            {
                this.Text = "Introducir NºSS";
                label1.Text = "NºSS";
                textBox1.Validating += new CancelEventHandler(tbNSS_Validating);
            }
            if (this.clase.Equals(TipoDeClase.Articulo) || this.clase.Equals("Venta"))
            {
                this.Text = "Introducir ID";
                label1.Text = "ID";
                textBox1.Validating += new CancelEventHandler(tbID_Validating);
            }
        }

        private FIntroducir() { }

        public String Clave
        {
            get
            {
                return textBox1.Text;
            }
        }





        //  MANEJADORES

        private void bAceptar_Click(object sender, EventArgs e)
        {
            this.ValidateChildren(); //ya valida el solito, es solo porsiaca
            this.DialogResult = DialogResult.OK;
            Hide();

        }

        /*
         * Para que no valide el botón cancelar, pongo su propiedad "CausesValidation" a false
         */
        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Hide();
        }





        // VALIDADORES

        private void tbNSS_Validating(object sender, CancelEventArgs e)
        {
            if (!isNSSvalid(textBox1.Text))
            {
                e.Cancel = true;
                errorProvider.SetError((Control)sender, "El NSS introducido no cumple el formato correcto (11 dígitos)");
            }
        }

        private void tbID_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text.Length==0)
            {
                e.Cancel = true;
                errorProvider.SetError((Control)sender, "El ID no puede ser vacío");
            }
        }






        //  METODOS AUXILIARES

        /*
         * Revisa si un nss cumple el formato indicado
         */
        private bool isNSSvalid(String nss)
        {
            //se ha de cumplir que es un entero de máximo 11 dígitos (requisitos mínimos)
            bool result;
            long a;

            result = nss.Length==11 && long.TryParse(nss, out a) && a>0;

            return result;
        }
    }
}
