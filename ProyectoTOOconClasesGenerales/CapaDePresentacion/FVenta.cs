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
    public partial class FVenta : Form
    {
        ServiciosVenta serviciosVenta;
        ServiciosArticulos serviciosArticulos;
        ServiciosDependiente serviciosDependiente;
        ErrorProvider errorProvider;
        BindingSource bindingLineas;
        List<Articulo> articulos;
        List<String> idArticulos;
        List<Articulo> articulosDeVenta;
        List<String> idArticulosDeVenta;
        BindingList<LineaDeVenta> lineas;
        List<Dependiente> dependientes;
        List<String> idDependientes;
        int cantidad;
        Venta venta;
        Dependiente dependiente;
        bool conTarjeta;
        bool tarjetaValidada;


        public FVenta(ServiciosVenta sv, ServiciosDependiente sd, ServiciosArticulos sa)
        {
            InitializeComponent();

            serviciosDependiente = sd;
            serviciosArticulos = sa;
            serviciosVenta = sv;

            errorProvider = new ErrorProvider();

            articulos = serviciosArticulos.getTodosArticulos();
            idArticulos = new List<string>();
            foreach (Articulo a in articulos) idArticulos.Add(a.Clave);
            articulosDeVenta = new List<Articulo>();
            idArticulosDeVenta = new List<string>();
            foreach (Articulo a in articulosDeVenta) idArticulosDeVenta.Add(a.Clave);

            lineas = new BindingList<LineaDeVenta>();
            bindingLineas = new BindingSource();
            bindingLineas.DataSource = lineas;

            dependientes = serviciosDependiente.getDependientesTienda();
            idDependientes = new List<string>();
            foreach (Dependiente d in dependientes) idDependientes.Add(d.NSS);

            //Elementos en pantalla
            tbCodigo.Text = "Asignado automáticamente";
            cbDependientes.DataSource = idDependientes;
            cbIDArticulo.DataSource = idArticulos;
            Articulo articulo = articulos.Find(x => x.Id == ((String)cbIDArticulo.SelectedItem)); //https://msdn.microsoft.com/en-us/library/x0b5b5bc(v=vs.110).aspx
            if (articulo != null)
            {
                tbDescripcionArticulo.Text = articulo.Descripcion;
                tbPrecioUD.Text = articulo.Importe.ToString();
                int cantidad;
                int.TryParse(tbCantidad.Text, out cantidad);
                tbImporte.Text = (articulo.Importe * cantidad).ToString();
            }

            lbLineasArticulo.DataSource = bindingLineas;
            lbLineasArticulo.DisplayMember = "IdArticulo";
            lbLineasCantidad.DataSource = bindingLineas;
            lbLineasCantidad.DisplayMember = "Cantidad";
            lbLineasImporte.DataSource = bindingLineas;
            lbLineasImporte.DisplayMember = "Importe";

            Dependiente dependiente = dependientes.Find(x => x.NSS == (String)cbDependientes.SelectedItem);
            if (dependiente != null) tbDependiente.Text = dependiente.NombreCompleto;

            conTarjeta = true;
            tarjetaValidada = false;
        }

        public FVenta(Venta venta, ServiciosVenta sv, ServiciosDependiente sd, ServiciosArticulos sa)
        {
            InitializeComponent();

            serviciosDependiente = sd;
            serviciosArticulos = sa;
            serviciosVenta = sv;

            errorProvider = new ErrorProvider();

            articulosDeVenta = venta.Articulos;
            articulos = articulosDeVenta; //No quiero que muestre todos, solo los que pertenecen a la venta

            lineas = new BindingList<LineaDeVenta>(venta.LineasDeVenta);
            bindingLineas = new BindingSource();
            bindingLineas.DataSource = lineas;

            dependientes = new List<Dependiente>();
            dependientes.Add(venta.Dependiente);
            idDependientes = new List<string>();
            idDependientes.Add(venta.Dependiente.NSS);

            //Elementos en pantalla
            tbCodigo.Text = venta.ID;
            cbDependientes.DataSource = idDependientes;
            tbDependiente.Text = venta.Dependiente.NombreCompleto;
            idArticulosDeVenta = new List<string>();
            foreach (Articulo a in articulosDeVenta) idArticulosDeVenta.Add(a.Id);
            cbIDArticulo.DataSource = idArticulosDeVenta;

            lbLineasArticulo.DataSource = bindingLineas;
            lbLineasArticulo.DisplayMember = "IdArticulo";
            lbLineasCantidad.DataSource = bindingLineas;
            lbLineasCantidad.DisplayMember = "Cantidad";
            lbLineasImporte.DataSource = bindingLineas;
            lbLineasImporte.DisplayMember = "Importe";

            Articulo articulo = ((LineaDeVenta)lbLineasArticulo.SelectedItem).Articulo;
            int i = 0;
            foreach (String a in cbIDArticulo.Items)
            {
                if (a == articulo.Id) i = cbIDArticulo.Items.IndexOf(a);
            }
            cbIDArticulo.SelectedIndex = i;

            conTarjeta = true;
        }

        public Venta Venta
        {
            get
            {
                return this.venta;
            }
        }

        /*
        * Se muestran los articulos con 0 en la cantidad. Cuando se pulse + o se cambie
        * la cantidad se añade la línea de venta. Cuando se seleccione una línea de venta
        * de la lista, el artículo ha de cambiar a esa y la cantidad tb
        */

        #region MANEJADORES

        private void cbIDArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Articulo articulo = articulos.Find(x => x.Id == (String)cbIDArticulo.SelectedItem);

            if (articulosDeVenta.Contains(articulo))
            {
                foreach (LineaDeVenta l in lineas)
                {
                    if (l.Articulo == articulo)
                    {
                        lbLineasArticulo.SelectedIndex = lineas.IndexOf(l);
                        cantidad = ((LineaDeVenta)lbLineasArticulo.SelectedItem).Cantidad;
                        break;
                    }
                }
            }
            else
            {
                tbCantidad.Text = "0";
                cantidad = 0;
            }

            tbDescripcionArticulo.Text = articulo.Descripcion;
            tbPrecioUD.Text = articulo.Importe.ToString();
            tbImporte.Text = (articulo.Importe * cantidad).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int aux;
            int.TryParse(tbCantidad.Text, out aux);
            Articulo articulo = articulos.Find(x => x.Id == (String)cbIDArticulo.SelectedItem);

            aux++;
            tbCantidad.Text = aux.ToString();

            if (aux == 1)
            {
                Articulo a = articulos.Find(x => x.Id == (String)cbIDArticulo.SelectedItem);
                LineaDeVenta nueva = new LineaDeVenta(a, 1);
                lineas.Add(nueva);
                articulosDeVenta.Add(a);
                lbLineasArticulo.SelectedIndex = lineas.IndexOf(nueva);
            }
            else
            {
                ((LineaDeVenta)bindingLineas.Current).Cantidad = aux;
            }

            bindingLineas.ResetBindings(true);
            actualizarTotal();
            tbImporte.Text = (articulo.Importe * aux).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int aux;
            int.TryParse(tbCantidad.Text, out aux);
            Articulo articulo = articulos.Find(x => x.Id == (String)cbIDArticulo.SelectedItem);

            aux--;
            if (aux >= 0)
            {
                tbCantidad.Text = aux.ToString();

                if (aux == 0)
                {
                    lineas.Remove((LineaDeVenta)bindingLineas.Current);
                    articulosDeVenta.Remove(articulo);
                }
                else
                {
                    ((LineaDeVenta)bindingLineas.Current).Cantidad = aux;
                    tbImporte.Text = (articulo.Importe * aux).ToString();
                }

            }
            bindingLineas.ResetBindings(true);
            actualizarTotal();

        }

        private void lbLineas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Articulo articulo = ((LineaDeVenta)lbLineasArticulo.SelectedItem).Articulo;
            foreach (String a in cbIDArticulo.Items)
            {
                if (a == articulo.Id) cbIDArticulo.SelectedItem = a;
            }
            cantidad = ((LineaDeVenta)lbLineasArticulo.SelectedItem).Cantidad;
            tbCantidad.Text = cantidad.ToString();
            tbPrecioUD.Text = articulo.Importe.ToString();
        }

        private void rbTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            tbTarjeta.Enabled = rbTarjeta.Checked;
            conTarjeta = rbTarjeta.Checked;
        }

        private void cbDependientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            dependiente = dependientes.Find(x => x.NSS == (String)cbDependientes.SelectedItem);
            tbDependiente.Text = dependiente.NombreCompleto;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(this, "¿Seguro que quieres cancelar la venta?", "Cancelar venta", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.ValidateChildren();
            if(conTarjeta&&!tarjetaValidada)
            {
                MessageBox.Show("Revisa la tarjeta introducida");
            }
            else if (lineas.Count > 0)
            {
                if (conTarjeta)
                {
                    venta = new VentaConTarjeta("0", DateTime.Now, dependiente, tbTarjeta.Text);
                }
                else
                {
                    venta = new VentaSinTarjeta("0", DateTime.Now, dependiente);
                }
                foreach (LineaDeVenta l in lineas)
                {
                    venta.anadirLineaVenta(l);
                }
                this.DialogResult = DialogResult.OK;
                this.Hide();
            }
            else
            {
                MessageBox.Show("No se puede añadir una venta vacía");
            }

        }

        #endregion

        #region VALIDADORES

        private void tbCantidad_Validating(object sender, CancelEventArgs e)
        {
            int aux;
            bool exito = int.TryParse(tbCantidad.Text, out aux);
            if (!exito || aux < 0)
            {
                e.Cancel = true;
                errorProvider.SetError((Control)sender, "Entrada no válida");
            }
            bindingLineas.ResetBindings(true);
        }

        private void tbTarjeta_Validating(object sender, CancelEventArgs e)
        {
            if (conTarjeta && !isTarjetaValida(tbTarjeta.Text))
            {
                e.Cancel = true;
                errorProvider.SetError((Control)sender, "Entrada no válida");
                tarjetaValidada = false;
            }
            else
            {
                errorProvider.SetError((Control)sender, String.Empty);
                tarjetaValidada = true;
            }
        }

        #endregion

        #region MÉTODOS AUXILIARES

        private void actualizarTotal()
        {
            double total = 0;

            foreach (LineaDeVenta l in lineas)
            {
                total += l.Importe;
            }

            lbImporteTotal.Text = total + " €";
        }

        private bool isTarjetaValida(String s)
        {
            long l;
            bool valid = long.TryParse(s, out l);

            if (valid)
            {
                valid = (l / 10000000000000000 == 0) && (l / 1000000000000000 > 0);
            }

            return valid;
        }

        #endregion
    }
}
