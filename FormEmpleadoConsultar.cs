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
    public partial class FormEmpleadoConsultar : Form
    {
        Query query;  //object that contain the DB queries methods and connection
        DataTable consult = new DataTable();  //consult query result

        public FormEmpleadoConsultar(Query Q)
        {
            InitializeComponent();
            query = Q;  //Instance the object

            consult.Columns.Add("ID Empleado", typeof(Int32));
            consult.Columns.Add("Estado", typeof(Boolean));
            consult.Columns.Add("Cargo", typeof(String));
            consult.Columns.Add("Nombre", typeof(String));
            consult.Columns.Add("Telefono", typeof(String));
            consult.Columns.Add("Password", typeof(String));

            dataGridViewEmpC.DataSource = consult;

            foreach (DataGridViewColumn dc in dataGridViewEmpC.Columns)
            {
                dc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        /////////////////////////////////////////////////
        private void textBoxIDemp_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataTable DT = query.DBreader("SELECT * FROM empleado WHERE id_empleado = " + textBoxIDemp.Text);

                if (DT.Rows.Count > 0)
                {
                    consult.Clear();
                    foreach (DataRow dr in DT.Rows)
                    {
                        consult.Rows.Add(dr.ItemArray);  //copy the queried info
                    }
                    dataGridViewEmpC.DataSource = consult;
                }
                else
                {
                    consult.Clear();
                    MessageBox.Show("Error, no existe un Empleado con ese ID.");
                }
            }
        }
    }
}
