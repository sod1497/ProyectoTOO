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
    public partial class FPrincipal : Form
    {
        private ServiciosDependiente lnd;
        private ServiciosArticulos lna;
        private ServiciosVenta lnv;

        private FPrincipal()
        {
            InitializeComponent();
        }

        public FPrincipal(ServiciosDependiente lnd, ServiciosArticulos lna, ServiciosVenta lnv)
        {
            InitializeComponent();
            this.lnd = lnd;
            this.lna = lna;
            this.lnv = lnv;
        }

        //  DEPENDIENTES

        private void altaDependiente_Click(object sender, EventArgs e)
        {
            FIntroducir f = new FIntroducir(TipoDeClase.Dependiente);
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
            {
                String clave = f.Clave;
                f.Dispose();
                if (!lnd.existeDependiente(clave))
                {
                    formDependiente ad = new formDependiente(clave);
                    ad.ShowDialog();
                    if (DialogResult.OK.Equals(ad.DialogResult))
                    {
                        lnd.anadirDependiente(new Dependiente(clave, ad.Nombre, ad.Apellidos, 0));
                    }
                }
                else
                {
                    DialogResult dr = MessageBox.Show(this, "¿Quieres introducir otro?", "Ya existe un dependiente con ese nºSS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (DialogResult.Yes.Equals(dr))
                    {
                        altaDependiente.PerformClick();
                    }
                }
            }
        }

        private void bajaDependiente_Click(object sender, EventArgs e)
        {

        }

        private void búsquedaDependiente_Click(object sender, EventArgs e)
        {

        }

        //  ARTICULOS

        private void altaArticulo_Click(object sender, EventArgs e)
        {
            FIntroducir f = new FIntroducir(TipoDeClase.Articulo);
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
            {
                String clave = f.Clave;
                f.Dispose();
                if (!lna.existeArticulo(clave))
                {
                    formArticulo ad = new formArticulo(clave);
                    ad.ShowDialog();
                    if (DialogResult.OK.Equals(ad.DialogResult))
                    {
                        lna.anadirArticulo(new Articulo(clave, ad.Descripcion, ad.Precio, ad.TipoIVA));
                    }
                }
                else
                {
                    DialogResult dr = MessageBox.Show(this, "¿Quieres introducir otro?", "Ya existe un dependiente con ese nºSS", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (DialogResult.Yes.Equals(dr))
                    {
                        altaDependiente.PerformClick();
                    }
                }
            }
        }

        //  VENTAS



        //  OTROS
    }
}
