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
    public partial class FIntroducirIVA : Form
    {
        public int IVA {
            get
            {
                if (rbNormal.Checked) return 21;
                else if (rbReducido.Checked) return 10;
                else if (rbSuperreducido.Checked) return 4;
                else return -1;
            }
        }

        public FIntroducirIVA()
        {
            InitializeComponent();
            this.AcceptButton = bAceptar;
        }

        #region MANEJADORES

        private void bAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
        }

        #endregion
    }
}
