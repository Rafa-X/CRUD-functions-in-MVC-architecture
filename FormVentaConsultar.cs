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
    public partial class FormVentaConsultar : Form
    {
        Query query;  //object that contain the DB queries methods and connection
        DataTable consult = new DataTable();  //consult query result

        public FormVentaConsultar(Query Q)
        {
            InitializeComponent();
            query = Q;  //Instance the object

            consult.Columns.Add("ID Detalle Venta", typeof(Int32));
            consult.Columns.Add("Fecha", typeof(DateTime));
            consult.Columns.Add("ID Producto", typeof(Int32));
            consult.Columns.Add("Precio Venta", typeof(Double));
            consult.Columns.Add("Cantidad", typeof(Int32));

            dataGridViewVentaC.DataSource = consult;

            foreach(DataGridViewColumn dc in dataGridViewVentaC.Columns)
            {
                dc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        /////////////////////////////////////////////////
        private void textBoxIDventa_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataTable DT = query.DBreader("SELECT b.id_detalle_venta, a.fecha, b.id_producto, b.precio_venta, b.cantidad " +
                                              "FROM venta a, detalle_venta b " +
                                              "WHERE b.id_venta = " + textBoxIDventa.Text);

                if(DT.Rows.Count > 0)
                {
                    consult.Clear();
                    foreach (DataRow dr in DT.Rows)
                    {
                        consult.Rows.Add(dr.ItemArray);  //copy the queried product info
                    }
                    dataGridViewVentaC.DataSource = consult;
                }
                else
                {
                    consult.Clear();
                    MessageBox.Show("Error, no existe una Venta con ese ID.");
                }
            }
        }
    }
}
