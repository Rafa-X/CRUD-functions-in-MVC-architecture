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
    public partial class FormCompraConsultar : Form
    {
        Query query;  //object that contain the DB queries methods and connection
        DataTable consult = new DataTable();  //consult query result

        public FormCompraConsultar(Query Q)
        {
            InitializeComponent();
            query = Q;  //Instance the object

            consult.Columns.Add("ID Detalle Compra", typeof(Int32));
            consult.Columns.Add("Fecha", typeof(DateTime));
            consult.Columns.Add("Nombre Proveedor", typeof(String));
            consult.Columns.Add("ID Producto", typeof(Int32));
            consult.Columns.Add("Precio Compra", typeof(Double));
            consult.Columns.Add("Cantidad", typeof(Int32));

            dataGridViewCompraC.DataSource = consult;

            foreach (DataGridViewColumn dc in dataGridViewCompraC.Columns)
            {
                dc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void textBoxIDcompra_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Checks if the input is valid, if not returns
                if (query.checkInputID(textBoxIDcompra.Text) == false)
                {
                    textBoxIDcompra.Clear();
                    consult.Clear();  //clean the dataGrid
                    return;
                }

                DataTable DT = query.DBreader("SELECT b.id_detalle_compra, a.fecha, c.nombre, b.id_producto, b.precio_compra, b.cantidad " +
                                              "FROM compra a, detalle_compra b, proveedor c " +
                                              "WHERE b.id_compra = " + textBoxIDcompra.Text + " AND a.id_compra = " + textBoxIDcompra.Text + 
                                              " AND a.id_proveedor = c.id_proveedor");

                if (DT.Rows.Count > 0)
                {
                    consult.Clear();
                    foreach (DataRow dr in DT.Rows)
                    {
                        consult.Rows.Add(dr.ItemArray);  //copy the queried product info
                    }
                    dataGridViewCompraC.DataSource = consult;
                }
                else
                {
                    consult.Clear();
                    MessageBox.Show("Error, no existe una Compra con ese ID.");
                }
            }
        }
    }
}
