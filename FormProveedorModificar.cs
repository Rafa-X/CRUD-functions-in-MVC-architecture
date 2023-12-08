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
    public partial class FormProveedorModificar : Form
    {
        Query query;  //object that will instantiate the query codes

        public FormProveedorModificar(Query Q)
        {
            InitializeComponent();
            query = Q;  //instance the local object
        }

        private void textBoxIDproveedor_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int ID = Convert.ToInt32(textBoxIDproveedor.Text);
                if (ID <= 0) return;  //If the ID is not valid, returns

                textBoxIDproveedor.Text = ID.ToString();  //Put the gathered ID in the textbox
                DataTable DT = query.DBreader("SELECT nombre, telefono, direccion " +
                                              "FROM proveedor WHERE id_proveedor = " + textBoxIDproveedor.Text);

                if (DT.Rows.Count != 0)
                {
                    DataRow dr = DT.Rows[0];

                    textBoxNombre.Text = Convert.ToString(dr["nombre"]);
                    textBoxTelefono.Text = Convert.ToString(dr["telefono"]);
                    textBoxDir.Text = Convert.ToString(dr["direccion"]);
                }
                else
                {
                    textBoxNombre.Text = "";
                    textBoxTelefono.Text = "";
                    textBoxDir.Text = "";

                    MessageBox.Show("Error, no existe un Proveedor con el ID ingresado.");
                }
            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            DialogResult opt = MessageBox.Show("Desea Modificar al Proveedor ?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (opt == DialogResult.Yes)
            {
                query.DBnonQuery("UPDATE proveedor SET " +
                                 "  nombre = '"    + textBoxNombre.Text + "'" +
                                 ", telefono = '"  + textBoxTelefono.Text + "'" +
                                 ", direccion = '" + textBoxDir.Text + "'" +
                                 " WHERE id_proveedor = " + textBoxIDproveedor.Text);

                MessageBox.Show("Proveedor Modificado con Exito.");
                textBoxIDproveedor.Text = "";
                textBoxNombre.Text = "";
                textBoxTelefono.Text = "";
                textBoxDir.Text = "";
            }
        }
    }
}
