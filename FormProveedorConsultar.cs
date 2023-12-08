using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCs_Maik
{
    public partial class FormProveedorConsultar : Form
    {
        Query query;  //object that contain the DB queries methods and connection
        DataTable consult = new DataTable();  //consult query result

        public FormProveedorConsultar(Query Q)
        {
            InitializeComponent();
            query = Q;  //Instance the object

            consult.Columns.Add("ID Proveedor", typeof(Int32));
            consult.Columns.Add("Nombre", typeof(String));
            consult.Columns.Add("Telefono", typeof(String));
            consult.Columns.Add("Direccion", typeof(String));

            dataGridViewProvC.DataSource = consult;

            foreach (DataGridViewColumn dc in dataGridViewProvC.Columns)
            {
                dc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        /////////////////////////////////////////////////
        private void textBoxIDprov_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataTable DT = query.DBreader("SELECT * FROM proveedor WHERE id_proveedor = " + textBoxIDprov.Text);

                if (DT.Rows.Count > 0)
                {
                    consult.Clear();
                    foreach (DataRow dr in DT.Rows)
                    {
                        consult.Rows.Add(dr.ItemArray);  //copy the queried product info
                    }
                    dataGridViewProvC.DataSource = consult;
                }
                else
                {
                    consult.Clear();
                    MessageBox.Show("Error, no existe un Proveedor con ese ID.");
                }
            }
        }

        private void buttonMostrarT_Click(object sender, EventArgs e)
        {
            DataTable DT = query.DBreader("SELECT * FROM proveedor ORDER BY id_proveedor");

            if (DT.Rows.Count > 0)
            {
                consult.Clear();
                foreach (DataRow dr in DT.Rows)
                {
                    consult.Rows.Add(dr.ItemArray);  //copy the queried info
                }
                dataGridViewProvC.DataSource = consult;
            }
            else
            {
                consult.Clear();
                MessageBox.Show("Error, no hay Proveedores registrados.");
            }
        }
    }
}
