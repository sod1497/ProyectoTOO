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
            lnd = new ServiciosDependiente();
            lna = new ServiciosArticulos();
            lnv = new ServiciosVenta();
        }

        public FPrincipal(ServiciosDependiente lnd, ServiciosArticulos lna, ServiciosVenta lnv)
        {
            InitializeComponent();
            this.lnd = lnd;
            this.lna = lna;
            this.lnv = lnv;
        }

        #region DEPENDIENTES

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
                    FDependiente ad = new FDependiente(clave);
                    ad.ShowDialog();
                    if (ad.DialogResult == DialogResult.OK)
                    {
                        lnd.anadirDependiente(new Dependiente(clave, ad.Nombre, ad.Apellidos, ad.Comision));
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
            FIntroducir f = new FIntroducir(TipoDeClase.Dependiente);
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
            {
                String clave = f.Clave;
                f.Dispose();
                if (lnd.existeDependiente(clave))
                {
                    Dependiente d = lnd.getDependiente(clave);
                    FDependiente ad = new FDependiente(clave, d.Nombre, d.Apellidos, d.ComisionPorVenta, true);
                    ad.ShowDialog();
                    if (DialogResult.OK.Equals(ad.DialogResult))
                    {
                        lnd.borrarDependiente(d);
                    }
                }
                else
                {
                    MessageBox.Show(this, "No existe un dependiente con ese NSS", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
        }

        private void búsquedaDependiente_Click(object sender, EventArgs e)
        {
            FBuscar fBuscarDependiente = new FBuscar(TipoDeClase.Dependiente, lnv, lnd, lna);
            fBuscarDependiente.ShowDialog();
        }

        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FListadoDependientes fListadoDependientes = new FListadoDependientes(lnd, lna, lnv);
            fListadoDependientes.ShowDialog();
        }

        #endregion

        #region ARTICULOS

        /*
        * Añade un artículo. No pide el id al usuario, se genera automaticamente por la
        * capa de Lógica de Negocio
        */
        private void altaArticulo_Click(object sender, EventArgs e)
        {
            FArticulo ad = new FArticulo("Asignado automaticamente");
            ad.ShowDialog();
            if (DialogResult.OK.Equals(ad.DialogResult))
            {
                lna.anadirArticulo(new Articulo("0", ad.Descripcion, ad.Precio, ad.TipoIVA));
            }
        }

        private void bajaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FIntroducir f = new FIntroducir(TipoDeClase.Articulo);
            f.ShowDialog();
            if (f.DialogResult == DialogResult.OK)
            {
                String clave = f.Clave;
                f.Dispose();
                if (lna.existeArticulo(clave))
                {
                    Articulo a = lna.getArticulo(clave);
                    FArticulo ad = new FArticulo(clave, a.Descripcion, a.CosteFabrica.ToString(), true,a.IVA);
                    ad.ShowDialog();
                    if (DialogResult.OK.Equals(ad.DialogResult))
                    {
                        lna.borrarArticulo(clave);
                    }
                }
                else
                {
                    DialogResult dr = MessageBox.Show(this,  "No existe un artículo con ese ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
        }

        private void listadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FListadoArticulos fListadoArticulos = new FListadoArticulos();
            fListadoArticulos.ShowDialog();
        }

        private void búsquedaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FBuscar fBuscarDependiente = new FBuscar(TipoDeClase.Articulo, lnv, lnd, lna);
            fBuscarDependiente.ShowDialog();
        }

        private void búsquedaPorIVAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FIntroducirIVA fIntroducirIVA = new FIntroducirIVA();
            DialogResult r = fIntroducirIVA.ShowDialog();
            if(r==DialogResult.OK)
            {
                FListadoArticulos fListadoArticulos = new FListadoArticulos(fIntroducirIVA.IVA);
                fListadoArticulos.ShowDialog();
            }
            fIntroducirIVA.Dispose();
            
            
        }

        #endregion

        #region VENTAS

        private void altaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FVenta ad = new FVenta(lnv, lnd, lna);
            ad.ShowDialog();
            if (DialogResult.OK == ad.DialogResult)
            {
                lnv.anadirVenta(ad.Venta);
            }
            ad.Dispose();
        }

        private void listadoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FListadoVentas fListadoVentas = new FListadoVentas(lnv, lnd, lna);
            fListadoVentas.ShowDialog();
        }

        private void ventasRecientesDeDependienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FIntroducir fIntroducir = new FIntroducir(TipoDeClase.Dependiente);
            DialogResult dr = fIntroducir.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Dependiente dependiente = lnd.getDependiente(fIntroducir.Clave);
                if (dependiente != null)
                {
                    FListadoVentas fListadoVentas = new FListadoVentas(dependiente, lnv, lnd, lna);
                    fListadoVentas.ShowDialog();
                }

            }

        }

        private void ventasDeArtículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FIntroducir fIntroducir = new FIntroducir(TipoDeClase.Articulo);
            DialogResult dr = fIntroducir.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Articulo articulo = lna.getArticulo(fIntroducir.Clave);
                if (articulo != null)
                {
                    FListadoVentas fListadoVentas = new FListadoVentas(articulo, lnv, lnd, lna);
                    fListadoVentas.ShowDialog();
                }

            }
        }

        private void bajaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FIntroducir fIntroducir = new FIntroducir(TipoDeClase.Venta);
            DialogResult dr = fIntroducir.ShowDialog();
            if (dr == DialogResult.OK)
            {
                if (lnv.existeVenta(fIntroducir.Clave)) {
                    DialogResult r = MessageBox.Show("¿Seguro que queres borrar la venta?", "Borrar venta", MessageBoxButtons.OKCancel);
                    if (r == DialogResult.OK) lnv.borrarVenta(fIntroducir.Clave);
                }
                else
                {
                    MessageBox.Show("No se ha encontrado la venta especificada", "Venta no encontrada");
                }
            }
        }

        #endregion

        
    }
}
