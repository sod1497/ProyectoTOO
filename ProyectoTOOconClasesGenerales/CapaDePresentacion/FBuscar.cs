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
    public partial class FBuscar : Form
    {
        bool validar = true;
        TipoDeClase tipoDeClase;
        float coste;
        int iva;

        List<Dependiente> dependientes;
        List<Articulo> articulos;
        List<Venta> ventas;

        ServiciosDependiente serviciosDependiente;
        ServiciosArticulos serviciosArticulos;
        ServiciosVenta serviciosVenta;

        BindingSource bindingSource;
        ErrorProvider errorProvider;

        public FBuscar(TipoDeClase tipoDeClase, ServiciosVenta sv, ServiciosDependiente sd, ServiciosArticulos sa)
        {
            InitializeComponent();

            errorProvider = new ErrorProvider();
            bindingSource = new BindingSource();

            serviciosDependiente = sd;
            serviciosArticulos = sa;
            serviciosVenta = sv;

            this.tipoDeClase = tipoDeClase;

            switch (tipoDeClase)
            {
                case TipoDeClase.Dependiente:
                    {
                        dependientes = serviciosDependiente.getDependientesTienda();
                        bindingSource.DataSource = dependientes;
                        bindingNavigator1.BindingSource = bindingSource;

                        comboBox1.DataSource = bindingSource;
                        comboBox1.DisplayMember = "NSS";

                        this.Text = "Buscar dependiente";
                        labelNSS.Text = "Nº SS";
                        labelNombre.Text = "Nombre";
                        labelApellidos.Text = "Apellidos";
                        labelComision.Text = "Comisión (%)";

                        labelImporte.Visible = false;
                        tbImporte.Visible = false;

                        tbNombre.DataBindings.Add(new Binding("Text", bindingSource, "Nombre"));
                        tbApellidos.DataBindings.Add(new Binding("Text", bindingSource, "Apellidos"));
                        tbComision.DataBindings.Add(new Binding("Text", bindingSource, "ComisionPorVenta"));

                        bExtra.Text = "Ver ventas de este mes";
                        

                        break;
                    }
                case TipoDeClase.Articulo:
                    {
                        articulos = serviciosArticulos.getTodosArticulos();
                        bindingSource.DataSource = articulos;
                        bindingNavigator1.BindingSource = bindingSource;

                        comboBox1.DataSource = bindingSource;
                        comboBox1.DisplayMember = "ID";

                        this.Text = "Buscar articulo";
                        labelNSS.Text = "ID";
                        labelNombre.Text = "Descripción";
                        labelApellidos.Text = "IVA";
                        labelComision.Text = "Coste";
                        labelImporte.Text = "Importe";
                        tbImporte.ReadOnly = true;

                        tbNombre.DataBindings.Add(new Binding("Text", bindingSource, "Descripcion"));
                        tbApellidos.DataBindings.Add(new Binding("Text", bindingSource, "IVA"));
                        tbComision.DataBindings.Add(new Binding("Text", bindingSource, "CosteFabrica"));
                        tbImporte.DataBindings.Add(new Binding("Text", bindingSource, "Importe"));

                        bExtra.Text = "Ver ventas";

                        break;
                    }
            }



        }

        public FBuscar(TipoBasico d, TipoDeClase tipoDeClase, ServiciosVenta sv, ServiciosDependiente sd, ServiciosArticulos sa) : this(tipoDeClase, sv, sd, sa)
        {
            //Se mueve directamente al dependiente de clave "clave"

            int i = bindingSource.IndexOf(d);
            if (i >= 0)
            {
                bindingSource.Position = i;
            }
        }

        #region MANEJADORES

        private void bindingAdd_Click(object sender, EventArgs e)
        {
            if (tipoDeClase == TipoDeClase.Articulo)
            {
                FArticulo ad = new FArticulo("Asignado automaticamente");
                ad.ShowDialog();
                if (DialogResult.OK.Equals(ad.DialogResult))
                {
                    serviciosArticulos.anadirArticulo(new Articulo("0", ad.Descripcion, ad.Precio, ad.TipoIVA));
                }

                bindingSource.Clear();
                bindingSource.DataSource = serviciosArticulos.getTodosArticulos();
            }
            else if (tipoDeClase == TipoDeClase.Dependiente)
            {
                FIntroducir f = new FIntroducir(TipoDeClase.Dependiente);
                f.ShowDialog();
                if (f.DialogResult == DialogResult.OK)
                {
                    String clave = f.Clave;
                    f.Dispose();
                    if (!serviciosDependiente.existeDependiente(clave))
                    {
                        FDependiente ad = new FDependiente(clave);
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

        }

        private void bindingRemove_Click(object sender, EventArgs e)
        {
            if (tipoDeClase == TipoDeClase.Dependiente)
            {
                Dependiente d = (Dependiente)bindingSource.Current;
                if (d != null)
                {
                    FDependiente ad = new FDependiente(d.Clave, d.Nombre, d.Apellidos, d.ComisionPorVenta, true);
                    ad.ShowDialog();
                    if (DialogResult.OK.Equals(ad.DialogResult))
                    {
                        serviciosDependiente.borrarDependiente(d);
                    }

                    bindingSource.Clear();
                    bindingSource.DataSource = serviciosDependiente.getDependientesTienda();
                }
            }
            else if (tipoDeClase == TipoDeClase.Articulo)
            {
                Articulo d = (Articulo)bindingSource.Current;
                if (d != null)
                {
                    FArticulo ad = new FArticulo(d.Clave, d.Descripcion, d.CosteFabrica.ToString(), true,d.IVA);
                    ad.ShowDialog();
                    if (DialogResult.OK.Equals(ad.DialogResult))
                    {
                        serviciosArticulos.borrarArticulo(d);
                    }

                    bindingSource.Clear();
                    bindingSource.DataSource = serviciosArticulos.getTodosArticulos();
                }
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bAplicar.Enabled = !checkBox1.Checked;
            //quitar evento de actualización o lo que sea


            if (checkBox1.Checked)
            {
                tbApellidos.CausesValidation = true;
                tbComision.CausesValidation = true;
                tbNombre.CausesValidation = true;
                tbImporte.CausesValidation = true;
                validar = true;

            }
            else
            {
                tbApellidos.CausesValidation = false;
                tbComision.CausesValidation = false;
                tbNombre.CausesValidation = false;
                tbImporte.CausesValidation = false;
                bindingNavigator1.CausesValidation = false;
                validar = false;
            }



        }

        private void bAplicar_Click(object sender, EventArgs e)
        {
            //actualizar manualmente
            if (comboBox1.SelectedItem != null)
            {
                this.ValidateChildren();//no va a desencadenar el evento tb_Validated así que lo añado a continuación
                tb_Validated(sender, e);
            }

        }

        private void FBuscarDependiente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (validar)
            {
                this.ValidateChildren();
            }
        }


        private void bExtra_Click(object sender, EventArgs e)
        {
            if(tipoDeClase==TipoDeClase.Dependiente)
            {
                FListadoVentas fListadoVentas = new FListadoVentas((Dependiente)bindingSource.Current, serviciosVenta, serviciosDependiente, serviciosArticulos);
                fListadoVentas.ShowDialog();
            }else if(tipoDeClase==TipoDeClase.Articulo)
            {
                FListadoVentas fListadoVentas = new FListadoVentas((Articulo)bindingSource.Current, serviciosVenta, serviciosDependiente, serviciosArticulos);
                fListadoVentas.ShowDialog();
            }
        }

        #endregion

        #region VALIDADORES

        private void tbNombre_Validating(object sender, CancelEventArgs e)
        {
            if (tipoDeClase == TipoDeClase.Dependiente)
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

            else if (tipoDeClase == TipoDeClase.Articulo)
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

        }

        private void tbApellidos_Validating(object sender, CancelEventArgs e)
        {
            if (tipoDeClase == TipoDeClase.Dependiente)
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
            else if (tipoDeClase == TipoDeClase.Articulo)
            {
                if (comboBox1.SelectedItem != null && tbApellidos.Text.ToString() != "21" && tbApellidos.Text.ToString() != "10" && tbApellidos.Text.ToString() != "4")
                {
                    e.Cancel = true;
                    errorProvider.SetError((Control)sender, "El IVA ha de ser 21, 10 o 4");
                }
                else
                {
                    int.TryParse(tbApellidos.Text.ToString(), out iva);
                    errorProvider.Clear();
                }
            }

        }

        private void tbComision_Validating(object sender, CancelEventArgs e)
        {
            if (tipoDeClase == TipoDeClase.Dependiente)
            {
                if (comboBox1.SelectedItem != null && !isComisionValid(tbComision.Text))
                {
                    e.Cancel = true;
                    errorProvider.SetError((Control)sender, "El coste de fábrica ha de ser un ");
                }
                else
                {
                    errorProvider.Clear();
                }
            }
            else if (tipoDeClase == TipoDeClase.Articulo)
            {
                if (comboBox1.SelectedItem != null && !isPrecioValid(tbComision.Text))
                {
                    e.Cancel = true;
                    errorProvider.SetError((Control)sender, "El coste de fábrica ha de ser un real positivo");
                }
                else
                {
                    errorProvider.Clear();
                }
            }

        }

        private void tbImporte_Validating(object sender, CancelEventArgs e)
        {
            //Para dependiente y artículo no hace nada


        }

        private void tb_Validated(object sender, EventArgs e)
        {
            if (tipoDeClase == TipoDeClase.Dependiente)
            {
                if (comboBox1.SelectedItem != null)
                {
                    int a;
                    int.TryParse(tbComision.Text, out a);
                    serviciosDependiente.modificarDependiente(((Dependiente)comboBox1.SelectedItem).Clave, tbNombre.Text, tbApellidos.Text, a);
                }
            }
            if (tipoDeClase == TipoDeClase.Articulo)
            {
                if (comboBox1.SelectedItem != null)
                {
                    float.TryParse(tbComision.Text, out coste);
                    int.TryParse(tbApellidos.Text, out iva);
                    serviciosArticulos.modificarArticulo(((Articulo)comboBox1.SelectedItem).Clave, tbNombre.Text, coste, iva);
                }
            }


        }
        #endregion

        #region MÉTODOS AUXILIARES

        //Devuelve true si la comisión es un entero positivo o 0
        private bool isComisionValid(String comision)
        {
            bool result;
            int a;

            result = int.TryParse(comision, out a);

            return result && a>=0;
        }

        
        //Devuelve true si el precio es un real positivo o 0
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
