using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSourceDemo
{
    public partial class EjemploConexion : Form
    {
        public object cajaTextoID { get; private set; }

        public EjemploConexion()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwindDataSet);

        }

        private void EjemploConexion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.Customers' Puede moverla o quitarla según sea necesario.
            this.customersTableAdapter.Fill(this.northwindDataSet.Customers);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void customerIDLabel_Click(object sender, EventArgs e)
        {

        }
        private void customersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwindDataSet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            customersBindingSource.AddNew();
        }

        private void cajaTextoID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13){
                var index = customersBindingSource.Find("customerID", cajaTextoID);
                if (index > -1)
                {
                    customersBindingSource.Position = index;
                    return;
                }
                else
                {
                    MessageBox.Show("Elemento no encontrado");
                }
            };
        }
    }
}
