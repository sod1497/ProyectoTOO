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
    public partial class FListadoVentas : Form
    {
        ServiciosArticulos serviciosArticulos;
        ServiciosDependiente serviciosDependiente;
        ServiciosVenta serviciosVenta;

        ErrorProvider errorProvider;

        BindingSource bindingVentas;
        BindingSource bindingLineas;
        BindingList<Venta> ventas;
        BindingList<LineaDeVenta> lineas;
        List<Articulo> articulos;
        List<Dependiente> dependientes;

        public FListadoVentas(ServiciosVenta sv, ServiciosDependiente sd, ServiciosArticulos sa)
        {
            InitializeComponent();

            this.Text = "Listado de ventas";

            serviciosDependiente = sd;
            serviciosArticulos = sa;
            serviciosVenta = sv;

            errorProvider = new ErrorProvider();

            bindingLineas = new BindingSource();
            bindingVentas = new BindingSource();
            ventas = new BindingList<Venta>(serviciosVenta.getVentas());
            bindingVentas.DataSource = ventas;

            if (ventas.Count > 0)
            {
                lineas = new BindingList<LineaDeVenta>(((Venta)bindingVentas.Current).LineasDeVenta);
                lbIdVentas.DataSource = bindingVentas;
                lbIdVentas.DisplayMember = "Id";

                dependientes = new List<Dependiente>();
                foreach (Venta v in ventas)
                {
                    dependientes.Add(v.Dependiente);
                }
                lbDependientes.DataSource = dependientes;
                lbDependientes.DisplayMember = "NombreCompleto";
                lbImportes.DataSource = bindingVentas;
                lbImportes.DisplayMember = "ImporteTotal";
                lbFechas.DataSource = bindingVentas;
                lbFechas.DisplayMember = "Fecha";
            }
            else
            {
                lineas = new BindingList<LineaDeVenta>();
            }
            bindingLineas.DataSource = lineas;

            if (lineas.Count > 0) //Hay una venta seleccionada
            {
                if (bindingVentas.Current is VentaConTarjeta)
                {
                    tbTarjeta.Text = ((VentaConTarjeta)bindingVentas.Current).Tarjeta;
                }
                else
                {
                    tbTarjeta.Text = "En efectivo";
                }

                tbFecha.Text = ((Venta)bindingVentas.Current).Fecha.ToString();
                tbNssDependiente.Text = ((Venta)bindingVentas.Current).Dependiente.NSS;
                tbNombreDependiente.Text = ((Venta)bindingVentas.Current).Dependiente.NombreCompleto;

                articulos = ((Venta)bindingVentas.Current).Articulos;
                lbLineasArticulo.DataSource = articulos;
                lbLineasArticulo.DisplayMember = "Id";
                lbLineasCantidad.DataSource = bindingLineas;
                lbLineasCantidad.DisplayMember = "Cantidad";
                lbLineasImporte.DataSource = bindingLineas;
                lbLineasImporte.DisplayMember = "Importe";
            }
        }

        public FListadoVentas(Articulo a, ServiciosVenta sv, ServiciosDependiente sd, ServiciosArticulos sa)
        {
            InitializeComponent();

            this.Text = "Listado de ventas de articulo";

            serviciosDependiente = sd;
            serviciosArticulos = sa;
            serviciosVenta = sv;

            errorProvider = new ErrorProvider();

            bindingLineas = new BindingSource();
            bindingVentas = new BindingSource();
            ventas = new BindingList<Venta>(serviciosVenta.getVentasDeArticulo(a));
            bindingVentas.DataSource = ventas;

            if (ventas.Count > 0)
            {
                lineas = new BindingList<LineaDeVenta>(((Venta)bindingVentas.Current).LineasDeVenta);
                lbIdVentas.DataSource = bindingVentas;
                lbIdVentas.DisplayMember = "Id";

                dependientes = new List<Dependiente>();
                foreach (Venta v in ventas)
                {
                    dependientes.Add(v.Dependiente);
                }
                lbDependientes.DataSource = dependientes;
                lbDependientes.DisplayMember = "NombreCompleto";
                lbImportes.DataSource = bindingVentas;
                lbImportes.DisplayMember = "ImporteTotal";
                lbFechas.DataSource = bindingVentas;
                lbFechas.DisplayMember = "Fecha";
            }
            else
            {
                lineas = new BindingList<LineaDeVenta>();
            }
            bindingLineas.DataSource = lineas;

            if (lineas.Count > 0) //Hay una venta seleccionada
            {
                if (bindingVentas.Current is VentaConTarjeta)
                {
                    tbTarjeta.Text = ((VentaConTarjeta)bindingVentas.Current).Tarjeta;
                }
                else
                {
                    tbTarjeta.Text = "En efectivo";
                }

                tbFecha.Text = ((Venta)bindingVentas.Current).Fecha.ToString();
                tbNssDependiente.Text = ((Venta)bindingVentas.Current).Dependiente.NSS;
                tbNombreDependiente.Text = ((Venta)bindingVentas.Current).Dependiente.NombreCompleto;

                articulos = ((Venta)bindingVentas.Current).Articulos;
                lbLineasArticulo.DataSource = articulos;
                lbLineasArticulo.DisplayMember = "Id";
                lbLineasCantidad.DataSource = bindingLineas;
                lbLineasCantidad.DisplayMember = "Cantidad";
                lbLineasImporte.DataSource = bindingLineas;
                lbLineasImporte.DisplayMember = "Importe";
            }
        }

        public FListadoVentas(Dependiente d, ServiciosVenta sv, ServiciosDependiente sd, ServiciosArticulos sa)
        {
            InitializeComponent();

            this.Text = "Listado de ventas de dependiente";

            serviciosDependiente = sd;
            serviciosArticulos = sa;
            serviciosVenta = sv;

            errorProvider = new ErrorProvider();

            bindingLineas = new BindingSource();
            bindingVentas = new BindingSource();
            ventas = new BindingList<Venta>(serviciosDependiente.obtenerVentasMes(d,DateTime.Now));
            bindingVentas.DataSource = ventas;

            if (ventas.Count > 0)
            {
                lineas = new BindingList<LineaDeVenta>(((Venta)bindingVentas.Current).LineasDeVenta);
                lbIdVentas.DataSource = bindingVentas;
                lbIdVentas.DisplayMember = "Id";

                dependientes = new List<Dependiente>();
                foreach (Venta v in ventas)
                {
                    dependientes.Add(v.Dependiente);
                }
                lbDependientes.DataSource = dependientes;
                lbDependientes.DisplayMember = "NombreCompleto";
                lbImportes.DataSource = bindingVentas;
                lbImportes.DisplayMember = "ImporteTotal";
                lbFechas.DataSource = bindingVentas;
                lbFechas.DisplayMember = "Fecha";
            }
            else
            {
                lineas = new BindingList<LineaDeVenta>();
            }
            bindingLineas.DataSource = lineas;

            if (lineas.Count > 0) //Hay una venta seleccionada
            {
                if (bindingVentas.Current is VentaConTarjeta)
                {
                    tbTarjeta.Text = ((VentaConTarjeta)bindingVentas.Current).Tarjeta;
                }
                else
                {
                    tbTarjeta.Text = "En efectivo";
                }

                tbFecha.Text = ((Venta)bindingVentas.Current).Fecha.ToString();
                tbNssDependiente.Text = ((Venta)bindingVentas.Current).Dependiente.NSS;
                tbNombreDependiente.Text = ((Venta)bindingVentas.Current).Dependiente.NombreCompleto;

                articulos = ((Venta)bindingVentas.Current).Articulos;
                lbLineasArticulo.DataSource = articulos;
                lbLineasArticulo.DisplayMember = "Id";
                lbLineasCantidad.DataSource = bindingLineas;
                lbLineasCantidad.DisplayMember = "Cantidad";
                lbLineasImporte.DataSource = bindingLineas;
                lbLineasImporte.DisplayMember = "Importe";
            }
        }

        #region MANEJADORES

        private void lbIdVentas_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (bindingVentas.Current is VentaConTarjeta)
            {
                tbTarjeta.Text = ((VentaConTarjeta)bindingVentas.Current).Tarjeta;
            }
            else
            {
                tbTarjeta.Text = "En efectivo";
            }

            tbFecha.Text = ((Venta)bindingVentas.Current).Fecha.ToString();
            tbNssDependiente.Text = ((Venta)bindingVentas.Current).Dependiente.NSS;
            tbNombreDependiente.Text = ((Venta)bindingVentas.Current).Dependiente.NombreCompleto;

            articulos = ((Venta)bindingVentas.Current).Articulos;
            lbLineasArticulo.DataSource = articulos;
            lbLineasArticulo.DisplayMember = "Id";
            lineas = new BindingList<LineaDeVenta>(((Venta)bindingVentas.Current).LineasDeVenta);
            bindingLineas.DataSource = lineas;
            lbLineasCantidad.DataSource = bindingLineas;
            lbLineasCantidad.DisplayMember = "Cantidad";
            lbLineasImporte.DataSource = bindingLineas;
            lbLineasImporte.DisplayMember = "Importe";

            try
            {
                lbDependientes.SelectedIndex = lbIdVentas.SelectedIndex;
            }
            catch(ArgumentOutOfRangeException)
            {
                //Cuando se está creando dará un nulo
            }
        }

        private void lbDependientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbIdVentas.SelectedIndex = lbDependientes.SelectedIndex;
        }

        private void lbLineasArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lbLineasCantidad.SelectedIndex = lbLineasArticulo.SelectedIndex;
            }
            catch(ArgumentOutOfRangeException)
            {
                //Cuando se crea da un null
            }
        }

        private void lbLineasCantidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbLineasArticulo.SelectedIndex = lbLineasCantidad.SelectedIndex;
        }

        private void bDependiente_Click(object sender, EventArgs e)
        {
            Dependiente d = dependientes[lbDependientes.SelectedIndex];
            FBuscar fBuscar = new FBuscar(d, TipoDeClase.Dependiente, serviciosVenta, serviciosDependiente, serviciosArticulos);
            fBuscar.ShowDialog();
            fBuscar.Dispose();
        }

        private void bArticulo_Click(object sender, EventArgs e)
        {
            Articulo d = articulos[lbLineasArticulo.SelectedIndex];
            FBuscar fBuscar = new FBuscar(d, TipoDeClase.Articulo, serviciosVenta, serviciosDependiente, serviciosArticulos);
            fBuscar.ShowDialog();
            fBuscar.Dispose();
        }

        #endregion
        
    }
}
