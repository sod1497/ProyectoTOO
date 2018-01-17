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
    public partial class FListadoArticulos : Form
    {
        ErrorProvider errorProvider;
        ServiciosArticulos serviciosArticulos;
        BindingList<Articulo> articulos;
        BindingSource bindingSource;
        float coste;

        public FListadoArticulos()
        {
            InitializeComponent();
            serviciosArticulos = new ServiciosArticulos();
            errorProvider = new ErrorProvider();
            articulos = new BindingList<Articulo>(serviciosArticulos.getTodosArticulos());
            articulos.AllowNew = true;
            bindingSource = new BindingSource();
            bindingSource.DataSource = articulos;

            dataGridView1.AllowUserToAddRows = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = bindingSource;
            dataGridView1.CausesValidation = true;

            //basado en https://stackoverflow.com/questions/1180004/binding-to-bindinglistt-choose-what-to-bind

            DataGridViewColumn dgvc = new DataGridViewColumn();
            dgvc.Name = "Identificador";
            dgvc.HeaderText = "Identificador";
            dgvc.DataPropertyName = "ID";
            dgvc.CellTemplate = new DataGridViewTextBoxCell();
            dataGridView1.Columns.Add(dgvc);

            dgvc = new DataGridViewColumn();
            dgvc.Name = "Descripción";
            dgvc.HeaderText = "Descripción";
            dgvc.DataPropertyName = "Descripcion";
            dgvc.CellTemplate = new DataGridViewTextBoxCell();
            dataGridView1.Columns.Add(dgvc);

            dgvc = new DataGridViewColumn();
            dgvc.Name = "Coste de Fábrica";
            dgvc.HeaderText = "Coste de Fábrica";
            dgvc.DataPropertyName = "CosteFabrica";
            dgvc.CellTemplate = new DataGridViewTextBoxCell();
            dataGridView1.Columns.Add(dgvc);

            dgvc = new DataGridViewColumn();
            dgvc.Name = "IVA";
            dgvc.HeaderText = "IVA";
            dgvc.DataPropertyName = "IVA";
            dgvc.CellTemplate = new DataGridViewTextBoxCell();
            dataGridView1.Columns.Add(dgvc);

            dgvc = new DataGridViewColumn();
            dgvc.Name = "Importe";
            dgvc.HeaderText = "Importe";
            dgvc.DataPropertyName = "Importe";
            dgvc.CellTemplate = new DataGridViewTextBoxCell();
            dataGridView1.Columns.Add(dgvc);
        }

        public FListadoArticulos(int iva)
        {
            InitializeComponent();
            serviciosArticulos = new ServiciosArticulos();
            errorProvider = new ErrorProvider();
            articulos = new BindingList<Articulo>(serviciosArticulos.getArticulosConIva(iva));
            articulos.AllowNew = true;
            bindingSource = new BindingSource();
            bindingSource.DataSource = articulos;

            dataGridView1.AllowUserToAddRows = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = bindingSource;
            dataGridView1.CausesValidation = true;

            //basado en https://stackoverflow.com/questions/1180004/binding-to-bindinglistt-choose-what-to-bind

            DataGridViewColumn dgvc = new DataGridViewColumn();
            dgvc.Name = "Identificador";
            dgvc.HeaderText = "Identificador";
            dgvc.DataPropertyName = "ID";
            dgvc.CellTemplate = new DataGridViewTextBoxCell();
            dataGridView1.Columns.Add(dgvc);

            dgvc = new DataGridViewColumn();
            dgvc.Name = "Descripción";
            dgvc.HeaderText = "Descripción";
            dgvc.DataPropertyName = "Descripcion";
            dgvc.CellTemplate = new DataGridViewTextBoxCell();
            dataGridView1.Columns.Add(dgvc);

            dgvc = new DataGridViewColumn();
            dgvc.Name = "Coste de Fábrica";
            dgvc.HeaderText = "Coste de Fábrica";
            dgvc.DataPropertyName = "CosteFabrica";
            dgvc.CellTemplate = new DataGridViewTextBoxCell();
            dataGridView1.Columns.Add(dgvc);

            dgvc = new DataGridViewColumn();
            dgvc.Name = "IVA";
            dgvc.HeaderText = "IVA";
            dgvc.DataPropertyName = "IVA";
            dgvc.CellTemplate = new DataGridViewTextBoxCell();
            dataGridView1.Columns.Add(dgvc);

            dgvc = new DataGridViewColumn();
            dgvc.Name = "Importe";
            dgvc.HeaderText = "Importe";
            dgvc.DataPropertyName = "Importe";
            dgvc.CellTemplate = new DataGridViewTextBoxCell();
            dataGridView1.Columns.Add(dgvc);
        }

        #region VALIDADORES

        private void cell_Validating(object sender, DataGridViewCellValidatingEventArgs e)
        {        
            //Basado en https://docs.microsoft.com/en-us/dotnet/framework/winforms/controls/how-to-validate-data-in-the-windows-forms-datagridview-control
            string headerText = dataGridView1.Columns[e.ColumnIndex].HeaderText;
            if (headerText.Equals("Descripción"))
            {

                if (e.FormattedValue.ToString().Length == 0)
                {
                    dataGridView1.Rows[e.RowIndex].ErrorText = "La descripción no puede estar vacía";
                    e.Cancel = true;
                }
                else
                {
                    //dataGridView1.Rows[e.RowIndex].ErrorText = String.Empty;
                    actualizarDato(e);
                }
            }

            if (headerText.Equals("Coste de Fábrica"))
            {

                if (!isPrecioValid(e.FormattedValue.ToString()))
                {
                    dataGridView1.Rows[e.RowIndex].ErrorText = "Introduce el coste de fábrica (real positivo)";
                    e.Cancel = true;
                }
                else
                {
                    actualizarDato(e);
                }
            }
            if (headerText.Equals("IVA"))
            {

                if (!isIvaValid(e.FormattedValue.ToString()))
                {
                    dataGridView1.Rows[e.RowIndex].ErrorText = "Introduce un IVA válido (21, 10 o 4)";
                    e.Cancel = true;
                }
                else
                {
                    actualizarDato(e);
                }
            }

        }

        void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Clear the row error in case the user presses ESC.   
            dataGridView1.Rows[e.RowIndex].ErrorText = String.Empty;
        }
        #endregion

        #region MÉTODOS AUXILIARES

        //Devuelve true si el precio es un real positivo o 0
        private bool isPrecioValid(string text)
        {
            bool result;
            float a;

            result = float.TryParse(text, out a) && a >= 0;

            return result;
        }

        //Devuelve true si el iva cumple uno de los valores
        private bool isIvaValid(string text)
        {
            return text == "21" || text == "10" || text == "4";
        }

        /*
         * Revisará si todos los datos necesarios se han insertado y en caso correcto
         * añadirá el articulo nuevo (si no tiene id) o lo modificará (si ya tiene id)
         */
        private bool actualizarDato(DataGridViewCellValidatingEventArgs e)
        {
            //Si todos los datos excepto el id están completos, guardo el nuevo articulo, Sino guardo cambios directamente
            string id = dataGridView1.CurrentRow.Cells[0].FormattedValue.ToString();
            int iva;
            int.TryParse(dataGridView1.CurrentRow.Cells[3].FormattedValue.ToString(), out iva);
            float coste;
            float.TryParse(dataGridView1.CurrentRow.Cells[2].FormattedValue.ToString(), out coste);
            string descripcion = dataGridView1.CurrentRow.Cells[1].FormattedValue.ToString();

            //Para el valor recien insertado
            switch(e.ColumnIndex)
            {
                case 1:
                    {
                        descripcion = e.FormattedValue.ToString();
                        break;
                    }
                case 2:
                    {
                        float.TryParse(e.FormattedValue.ToString(), out coste);
                        break;
                    }
                case 3:
                    {
                        int.TryParse(e.FormattedValue.ToString(), out iva);
                        break;
                    }
            }

            if (descripcion != "" && coste != 0 && iva != 0)
            {
                if (id == "")
                {
                    return serviciosArticulos.anadirArticulo(new Articulo("0",descripcion,coste,iva));
                }
                else
                {
                    return serviciosArticulos.modificarArticulo(id,descripcion,coste,iva);
                }
            }
            else
            {
                return false;
            }
            
        }
        #endregion

    }
}
