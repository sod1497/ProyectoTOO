using LogicaDeNegocio;
using ModeloDeDominio;
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
    public partial class FBuscarDependiente : Form
    {
        bool validar = true;
        List<Dependiente> dependientes;
        ServiciosDependiente serviciosDependiente;
        BindingSource bindingSource;
        ErrorProvider errorProvider;

        public FBuscarDependiente()
        {
            InitializeComponent();

            errorProvider = new ErrorProvider();
            serviciosDependiente = new ServiciosDependiente();
            dependientes = serviciosDependiente.getDependientesTienda();
            bindingSource = new BindingSource();
            bindingSource.DataSource = dependientes;
            bindingNavigator1.BindingSource = bindingSource;

            comboBox1.DataSource = bindingSource;
            comboBox1.DisplayMember = "NSS";

            tbNombre.DataBindings.Add(new Binding("Text", bindingSource, "Nombre"));
            tbApellidos.DataBindings.Add(new Binding("Text", bindingSource, "Apellidos"));
            tbComision.DataBindings.Add(new Binding("Text", bindingSource, "ComisionPorVenta"));

        }

        public FBuscarDependiente(Dependiente d):this()
        {
            //Se mueve directamente al dependiente de clave "clave"

            int i = bindingSource.IndexOf(d);
            if(i>=0)
            {
                bindingSource.Position = i;
            }
        }

        //  MANEJADORES

        private void bindingAdd_Click(object sender, EventArgs e)
        {
            
            FIntroducir f = new FIntroducir(TipoDeClase.Dependiente);
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
            {
                String clave = f.Clave;
                f.Dispose();
                if (!serviciosDependiente.existeDependiente(clave))
                {
                    formDependiente ad = new formDependiente(clave);
                    ad.ShowDialog();
                    if (ad.DialogResult == DialogResult.OK)
                    {
                        serviciosDependiente.anadirDependiente(new Dependiente(clave, ad.Nombre, ad.Apellidos, ad.Comision));
                    }
                }
                else
                {
                    DialogResult dr = MessageBox.Show(this, "Error", "Ya existe un dependiente con ese nºSS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            bindingSource.Clear();
            bindingSource.DataSource = serviciosDependiente.getDependientesTienda();
        }

        private void bindingRemove_Click(object sender, EventArgs e)
        {
            Dependiente d = (Dependiente) bindingSource.Current;
            if (d != null)
            {
                formDependiente ad = new formDependiente(d.Clave, d.Nombre, d.Apellidos, d.ComisionPorVenta, true);
                ad.ShowDialog();
                if (DialogResult.OK.Equals(ad.DialogResult))
                {
                    serviciosDependiente.borrarDependiente(d);
                }

                bindingSource.Clear();
                bindingSource.DataSource = serviciosDependiente.getDependientesTienda();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bAplicar.Enabled = !checkBox1.Checked;
            //quitar evento de actualización o lo que sea

            if(checkBox1.Checked)
            {
                tbApellidos.CausesValidation = true;
                tbComision.CausesValidation = true;
                tbNombre.CausesValidation = true;
                validar = true;
                
            }
            else
            {
                tbApellidos.CausesValidation = false;
                tbComision.CausesValidation = false;
                tbNombre.CausesValidation = false;
                bindingNavigator1.CausesValidation = false;
                validar = false;
            }
            
        }

        private void bAplicar_Click(object sender, EventArgs e)
        {
            //actualizar manualmente
            if (comboBox1.SelectedItem != null)
            {
                this.ValidateChildren();
            }
           
        }

        private void FBuscarDependiente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (validar)
            {
                this.ValidateChildren();
            }
        }

        //  VALIDADORES

        private void tbNombre_Validating(object sender, CancelEventArgs e)
        {
            if (comboBox1.SelectedItem != null && tbNombre.Text.Length == 0)
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
            if (comboBox1.SelectedItem != null && tbApellidos.Text.Length == 0)
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
            if (comboBox1.SelectedItem != null && !isComisionValid(tbComision.Text))
            {
                e.Cancel = true;
                errorProvider.SetError((Control)sender, "La comisión es un porcentaje entero");
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void tb_Validated(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem != null)
            {
                float a;
                float.TryParse(tbComision.Text, out a);
                serviciosDependiente.modificarDependiente(((Dependiente)comboBox1.SelectedItem).Clave, tbNombre.Text, tbApellidos.Text, a);
            }
            
        }

        //   MÉTODOS AUXILIARES

        private bool isComisionValid(String comision)
        {
            bool result;
            int a;

            result = int.TryParse(comision, out a);

            return result;
        }

        
    }
}
