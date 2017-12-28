using LogicaDeNegocio;
using ModeloDeDominio;
using System;
using ProyectoToo.Comparers;
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
    public partial class FListadoDependientes : Form
    {
        //Usar para poder actualizar la lista
        BindingList<Dependiente> dependientes;

        ServiciosDependiente serviciosDependiente;
        ServiciosArticulos serviciosArticulos;
        ServiciosVenta serviciosVenta;

        BindingSource bs;

        public FListadoDependientes(ServiciosDependiente serviciosDependiente, ServiciosArticulos serviciosArticulos, ServiciosVenta serviciosVenta)
        {
            InitializeComponent();

            this.serviciosDependiente = serviciosDependiente;
            this.serviciosArticulos = serviciosArticulos;
            this.serviciosVenta = serviciosVenta;

            dependientes = new BindingList<Dependiente>(serviciosDependiente.getDependientesTienda());
            if (dependientes.Count > 0) bModificar.Enabled = true;

            bs = new BindingSource();
            bs.DataSource = dependientes;

            lbNSS.DataSource = bs;
            lbNSS.DisplayMember = "NSS";

            lbNombre.DataSource = bs;
            lbNombre.DisplayMember = "NombreCompleto";

            lbComision.DataSource = bs;
            lbComision.DisplayMember = "ComisionPorVenta";
            
        }

        //  MANEJADORES

        private void bNSS_Click(object sender, EventArgs e)
        {
            List<Dependiente> aux = dependientes.ToList<Dependiente>();
            aux.Sort(new ComparerDependienteNSS());
            dependientes = new BindingList<Dependiente>(aux);
            bs.DataSource = dependientes;
        }

        private void bNombre_Click(object sender, EventArgs e)
        {
            List<Dependiente> aux = dependientes.ToList<Dependiente>();
            aux.Sort(new ComparerDependienteNombre());
            dependientes = new BindingList<Dependiente>(aux);
            bs.DataSource = dependientes;

        }

        private void bComisión_Click(object sender, EventArgs e)
        {
            List<Dependiente> aux = dependientes.ToList<Dependiente>();
            aux.Sort(new ComparerDependienteComision());
            dependientes = new BindingList<Dependiente>(aux);
            bs.DataSource = dependientes;

        }

        private void bAdd_Click(object sender, EventArgs e)
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
                    MessageBox.Show(this, "Error", "Ya existe un dependiente con ese NSS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            focoCambiado();

        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bModificar_Click(object sender, EventArgs e)
        {
            //Si hay algo seleccionado, abre FBuscarDependiente para ese dependiente
            Dependiente d = (Dependiente)lbNSS.SelectedItem;
            FBuscarDependiente fBuscarDependiente = new FBuscarDependiente(d, TipoDeClase.Dependiente, serviciosVenta, serviciosDependiente, serviciosArticulos);
            fBuscarDependiente.ShowDialog();
            focoCambiado();
        }

        private void bVentas_Click(object sender, EventArgs e)
        {

        }

        //  MÉTODOS AUXILIARES

        private void focoCambiado()
        {
            //Cargo los nuevos valores generados
            bs.Clear();
            dependientes = new BindingList<Dependiente>(serviciosDependiente.getDependientesTienda());
            bs.DataSource = dependientes;
            bModificar.Enabled = bs.Count > 0;
        }


    }
}
