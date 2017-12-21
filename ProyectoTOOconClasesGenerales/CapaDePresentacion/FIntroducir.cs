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
    public partial class FIntroducir : Form
    {
        String clase;
        public FIntroducir(String clase)
        {
            InitializeComponent();
            this.clase = clase;
            if (this.clase.Equals("Dependiente"))
            {
                this.Text = "Introducir NºSS";
                label1.Text = "NºSS";
            }
            if (this.clase.Equals("Artículo") || this.clase.Equals("Venta"))
            {
                this.Text = "Introducir ID";
                label1.Text = "ID";
            }
        }

        private FIntroducir() { }

        public String getClave()
        {
            return textBox1.Text;
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))   //COMPROBAR QUE EL DATO INTRODUCIDO ES VÁLIDO
            {
                MessageBox.Show("No ha introducido ningún " + label1.Text);
            }
            else
            {
                Hide();
            }
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
