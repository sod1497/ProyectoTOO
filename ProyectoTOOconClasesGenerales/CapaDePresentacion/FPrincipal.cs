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

        private void altaDependiente_Click(object sender, EventArgs e)
        {
            FIntroducir f = new FIntroducir("Dependiente");
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
            {
                String clave = f.getClave();
                f.Dispose();
                if (!lnd.existeDependiente(new Dependiente(clave, "", "", 0)))
                {
                    formDependiente ad = new formDependiente(clave);
                    ad.ShowDialog();
                    if (DialogResult.OK.Equals(ad.DialogResult))
                    {
                        lnd.anadirDependiente(new Dependiente(clave, ad.getNombre(), ad.getApellidos(), 0));
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
    }
}
