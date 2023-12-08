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
    public partial class FormProductoModificar : Form
    {
        Query query;  //object that will instantiate the query codes

        public FormProductoModificar(Query Q)
        {
            InitializeComponent();
            query = Q;  //instance the local object
        }

        private void textBoxIDprod_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int ID = Convert.ToInt32(textBoxIDprod.Text);
                if (ID <= 0) return;  //If the ID is not valid, returns

                textBoxIDprod.Text = ID.ToString();  //Put the gathered ID in the textbox
                DataTable DT = query.DBreader("SELECT id_proveedor, nombre, precio, stockmin, stockmax " +
                                              "FROM producto WHERE id_producto = " + textBoxIDprod.Text);

                if (DT.Rows.Count != 0)
                {
                    DataRow dr = DT.Rows[0];
                    textBoxIDprov.Text   = Convert.ToString(dr["id_proveedor"]);
                    textBoxNombre.Text   = Convert.ToString(dr["nombre"]);
                    textBoxPrecio.Text   = Convert.ToString(dr["precio"]);
                    textBoxStockmin.Text = Convert.ToString(dr["stockmin"]);
                    textBoxStockmax.Text = Convert.ToString(dr["stockmax"]);
                }
                else
                {
                    textBoxIDprov.Text   = "";
                    textBoxNombre.Text   = "";
                    textBoxPrecio.Text   = "";
                    textBoxStockmin.Text = "";
                    textBoxStockmax.Text = "";
                    MessageBox.Show("Error, no existe un Producto con el ID ingresado.");
                }
            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            DialogResult opt = MessageBox.Show("Desea Modificar el Producto ?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (opt == DialogResult.Yes)
            {
                query.DBnonQuery("UPDATE producto SET id_proveedor = " + textBoxIDprod.Text +
                                 ", nombre = '"  + textBoxNombre.Text + "'" +
                                 ", precio = "   + textBoxPrecio.Text +
                                 ", stockmin = " + textBoxStockmin.Text +
                                 ", stockmax = " + textBoxStockmax.Text + 
                                 " WHERE id_producto = "+ textBoxIDprod.Text);

                MessageBox.Show("Producto Modificado con Exito.");
            }
        }
    }
}
