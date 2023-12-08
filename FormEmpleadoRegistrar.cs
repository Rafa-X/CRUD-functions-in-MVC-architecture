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
    public partial class FormEmpleadoRegistrar : Form
    {
        Query query;  //object that will instantiate the query codes
        int max;  //max id from employes

        public FormEmpleadoRegistrar(Query Q)
        {
            InitializeComponent();
            query = Q;  //instance the local object

            DataTable DT = query.DBreader("select max(id_empleado) from empleado");  //get the last ID_empleado from table "empleado"
            DataRow dr = DT.Rows[0];

            if (dr["max"].ToString() != "")  //if there are registers in "empleado" assign the gathered ID
                max = (Convert.ToInt32(dr[0]) + 1);
            else  //if there's not registers in "empleado" assign the value 1 to the ID
                max = 1;
            labelMax.Text = "ID: " + max.ToString();  //next ID venta to register
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            bool valid = true;  //states if the information within the fields are valid or not
            if (textBoxNombre.Text == "") valid = false;
            if (textBoxTelefono.Text == "") valid = false;
            if (comboBoxCargo.Text == "") valid = false;

            if(valid == false) 
            { 
                MessageBox.Show("Error, uno o mas campos estan vacios.");
                return;
            }

            MessageBox.Show("Desea Registrar el Empleado ?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            string pass = gen_pass();

            query.DBnonQuery("INSERT INTO empleado VALUES(default, true, '" + comboBoxCargo.Text + "', " +
                             "'" + textBoxNombre.Text + "', '" + textBoxTelefono.Text + "', '" + pass + "')");

            MessageBox.Show("Empleado registrado con exito.");
            textBoxNombre.Text = "";
            textBoxTelefono.Text = "";
            comboBoxCargo.Text = "";
        }

        private string gen_pass()  //generate a random password
        {
            Random rdn = new Random();
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            int lon = chars.Length;
            char one;
            int lonmax = 10;
            string pass = string.Empty;
            
            for (int i = 0; i < lonmax; i++)
{
                one = chars[rdn.Next(lon)];
                pass += one.ToString();
            }
            return pass;
        }
    }
}
