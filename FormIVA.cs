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
    public partial class FormIVA : Form
    {
        Query query;  //object that will instantiate the query codes
        DataTable consult = new DataTable();  //consult query result

        public FormIVA(Query Q)
        {
            InitializeComponent();
            query = Q;  //Instance the object

            consult.Columns.Add("ID IVA", typeof(Int32));
            consult.Columns.Add("Fecha Inicio", typeof(DateTime));
            consult.Columns.Add("Valor", typeof(Int32));

            dataGridViewIVA.DataSource = consult;

            foreach (DataGridViewColumn dc in dataGridViewIVA.Columns)
            {
                dc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            //show the registered iva values
            DataTable DT = query.DBreader("SELECT * FROM iva ORDER BY id_iva");  
            if (DT.Rows.Count > 0)
            {
                consult.Clear();
                foreach (DataRow dr in DT.Rows)
                {
                    consult.Rows.Add(dr.ItemArray);  //copy the queried info
                }
                dataGridViewIVA.DataSource = consult;
            }
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            DialogResult opt = MessageBox.Show("Desea Registrar el IVA ?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (opt == DialogResult.Yes)
            {
                string date = DateTime.Now.Date.ToShortDateString();

                query.DBnonQuery("INSERT INTO IVA VALUES(default, '" + date + "', " + textBoxIVA.Text + ")");  //insert query

                MessageBox.Show("IVA Registrado con Exito.");
            }
        }
    }
}
