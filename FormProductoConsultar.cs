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
    public partial class FormProductoConsultar : Form
    {
        Query query;  //object that contain the DB queries methods and connection
        DataTable consult = new DataTable();  //consult query result

        public FormProductoConsultar(Query Q)
        {
            InitializeComponent();
            query = Q;  //Instance the object

            consult.Columns.Add("ID Producto", typeof(Int32));
            consult.Columns.Add("ID Proveedor", typeof(Int32));
            consult.Columns.Add("Nombre", typeof(String));
            consult.Columns.Add("Precio", typeof(Double));
            consult.Columns.Add("Stock", typeof(Int32));
            consult.Columns.Add("Stock Min", typeof(Int32));
            consult.Columns.Add("Stock Max", typeof(Int32));

            dataGridViewProdC.DataSource = consult;

            foreach (DataGridViewColumn dc in dataGridViewProdC.Columns)
            {
                dc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            dataGridViewProdC.Columns[2].MinimumWidth = 100;
        }

        private void textBoxIDprod_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataTable DT = query.DBreader("SELECT * FROM producto WHERE id_producto = " + textBoxIDprod.Text);

                if (DT.Rows.Count > 0)
                {
                    consult.Clear();
                    foreach (DataRow dr in DT.Rows)
                    {
                        consult.Rows.Add(dr.ItemArray);  //copy the queried product info
                    }
                    dataGridViewProdC.DataSource = consult;
                }
                else
                {
                    consult.Clear();
                    MessageBox.Show("Error, no existe un Producto con ese ID.");
                }
            }
        }

        private void buttonMostrarT_Click(object sender, EventArgs e)
        {
            DataTable DT = query.DBreader("SELECT * FROM producto ORDER BY id_producto");

            if (DT.Rows.Count > 0)
            {
                consult.Clear();
                foreach (DataRow dr in DT.Rows)
                {
                    consult.Rows.Add(dr.ItemArray);  //copy the queried info
                }
                dataGridViewProdC.DataSource = consult;
            }
            else
            {
                consult.Clear();
                MessageBox.Show("Error, no hay Productos registrados.");
            }
        }
    }
}
