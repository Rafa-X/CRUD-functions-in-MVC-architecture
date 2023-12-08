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
    public partial class FormProveedorRegistrar : Form
    {
        Query query;  //object that will instantiate the query codes
        int max;  //max id from providers

        public FormProveedorRegistrar(Query Q)
        {
            InitializeComponent();
            query = Q;  //instance the local object

            DataTable DT = query.DBreader("select max(id_proveedor) from proveedor");  //get the last ID_empleado from table "proveedor"
            DataRow dr = DT.Rows[0];

            if (dr["max"].ToString() != "")  //if there are registers in "proveedor" assign the gathered ID
                max = (Convert.ToInt32(dr[0]) + 1);
            else  //if there's not registers in "proveedor" assign the value 1 to the ID
                max = 1;
            labelMax.Text = "ID: " + max.ToString();  //next ID venta to register
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            bool valid = true;  //states if the information within the fields are valid or not
            if (textBoxNombre.Text == "") valid = false;
            if (textBoxDir.Text == "") valid = false;
            if (textBoxTel.Text == "") valid = false;

            if (valid == false)
            {
                MessageBox.Show("Error, uno o mas campos estan vacios.");
                return;
            }

            DialogResult opt = MessageBox.Show("Desea Registrar al Proveedor ?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (opt == DialogResult.Yes)
            {
                query.DBnonQuery("INSERT INTO proveedor VALUES(default, '" + textBoxNombre.Text + "', '" + textBoxTel.Text + "', " +
                                 "'" + textBoxDir.Text + "')");

                MessageBox.Show("Proveedor registrado con exito.");
                textBoxNombre.Text = "";
                textBoxDir.Text = "";
                textBoxTel.Text = "";
            }
        }
    }
}
