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
    public partial class FormEmpleadoModificar : Form
    {
        Query query;  //object that will instantiate the query codes

        public FormEmpleadoModificar(Query Q)
        {
            InitializeComponent();
            query = Q;  //instance the local object
        }

        private void textBoxIDempleado_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int ID = Convert.ToInt32(textBoxIDempleado.Text);
                if (ID <= 0) return;  //If the ID is not valid, returns

                textBoxIDempleado.Text = ID.ToString();  //Put the gathered ID in the textbox
                DataTable DT = query.DBreader("SELECT estado, cargo, nombre, telefono, pass " +
                                              "FROM empleado WHERE id_empleado = " + textBoxIDempleado.Text);

                if (DT.Rows.Count != 0)
                {
                    DataRow dr = DT.Rows[0];

                    if (Convert.ToBoolean(dr["estado"]) == true) comboBoxEstado.Text = "Activo";
                    else comboBoxEstado.Text = "Inactivo";
                    comboBoxCargo.Text = Convert.ToString(dr["cargo"]);
                    textBoxNombre.Text = Convert.ToString(dr["nombre"]);
                    textBoxTelefono.Text = Convert.ToString(dr["telefono"]);
                    textBoxPass.Text = Convert.ToString(dr["pass"]);
                }
                else
                {
                    comboBoxEstado.Text = "";
                    comboBoxCargo.Text = "";
                    textBoxNombre.Text = "";
                    textBoxTelefono.Text = "";
                    textBoxPass.Text = "";

                    MessageBox.Show("Error, no existe un Empleado con el ID ingresado.");
                }
            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            bool state;

            DialogResult opt = MessageBox.Show("Desea Modificar al Empleado ?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (opt == DialogResult.Yes)
            {
                if (comboBoxEstado.Text == "Activo") state = true;
                else state = false;

                query.DBnonQuery("UPDATE empleado SET estado = " + state.ToString() +
                                 ", cargo = '"  + comboBoxCargo.Text + "'" +
                                 ", nombre = '" + textBoxNombre.Text + "'" +
                                 ", telefono = '" + textBoxTelefono.Text + "'" +
                                 ", pass = '"     + textBoxPass.Text + "'" +
                                 " WHERE id_empleado = " + textBoxIDempleado.Text);

                MessageBox.Show("Empleado Modificado con Exito.");
                textBoxIDempleado.Text = "";
                comboBoxEstado.Text = "";
                comboBoxCargo.Text = "";
                textBoxNombre.Text = "";
                textBoxTelefono.Text = "";
                textBoxPass.Text = "";
            }
        }
    }
}
