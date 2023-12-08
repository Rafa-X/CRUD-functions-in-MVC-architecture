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
    public partial class FormMermaRegistrar : Form
    {
        Query query;  //object that will instantiate the query codes

        int folio, prod_stock;
        DataTable losses = new DataTable();  //product losses temporal list

        public FormMermaRegistrar(Query Q)
        {
            InitializeComponent();
            query = Q;  //instance the local object

            DataTable DT = query.DBreader("select max(id_merma) from merma");  //get the last ID_venta from table "venta"
            DataRow dr = DT.Rows[0];

            if (dr["max"].ToString() != "")  //if there are registers in "venta" assign the gathered ID
                folio = (Convert.ToInt32(dr[0]) + 1);
            else  //if there's not registers in "venta" assign the value 1 to the ID
                folio = 1;
            labelFolio.Text = "Folio: " + folio.ToString();  //next ID venta to register

            losses.Columns.Add("ID Empleado", typeof(Int32));
            losses.Columns.Add("ID Producto", typeof(Int32));
            losses.Columns.Add("Nombre", typeof(String));
            losses.Columns.Add("Cantidad", typeof(Int32));
            losses.Columns.Add("Clasificacion", typeof(String));

            dataGridViewMermaR.DataSource = losses;

            foreach (DataGridViewColumn dc in dataGridViewMermaR.Columns)
                dc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridViewMermaR.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewMermaR.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewMermaR.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewMermaR.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewMermaR.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        /////////////////////////////////////////////////
        #region TEXTBOX SALE KEY UP - ENTER
        private void textBoxIDempleado_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                int ID = Convert.ToInt32(textBoxIDempleado.Text);
                if (ID <= 0) return;  //If the ID is not valid, returns

                textBoxIDempleado.Text = ID.ToString();  //Put the gathered ID in the textbox
                DataTable DT = query.DBreader("SELECT * FROM empleado WHERE id_empleado = " + textBoxIDempleado.Text);
                if (DT.Rows.Count != 0)
                {
                    DataRow dr = DT.Rows[0];
                    labelNombreE.Text = Convert.ToString(dr["nombre"]);
                }
                else
                {
                    labelNombreE.Text = "";
                    MessageBox.Show("Error, no existe un Empleado con el ID ingresado.");
                }
            }
        }

        private void textBoxIDproducto_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int ID = Convert.ToInt32(textBoxIDproducto.Text);
                if (ID <= 0) return;  //If the ID is not valid, returns

                textBoxIDproducto.Text = ID.ToString();  //Put the gathered ID in the textbox
                DataTable DT = query.DBreader("SELECT nombre,stock FROM producto WHERE id_producto = " + textBoxIDproducto.Text);
                if (DT.Rows.Count != 0)
                {
                    DataRow dr = DT.Rows[0];
                    labelNombreP.Text = Convert.ToString(dr["nombre"]);
                    labelStock.Text = Convert.ToString(dr["stock"]);

                    prod_stock = Convert.ToInt32(dr["stock"]);  //stock of the requested product
                }
                else
                {
                    labelNombreP.Text = "";
                    labelStock.Text = "";
                    MessageBox.Show("Error, no existe un Producto con el ID ingresado.");
                }
            }
        }

        private void textBoxMermaCantidad_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bool existing = false;  //Flag - product is already in losses or not

                int cant = Convert.ToInt32(textBoxMermaCantidad.Text);  //amount of product requested
                if (cant > prod_stock)  //If the requested amount is higher than the stock, returns
                {
                    MessageBox.Show("Error, la cantidad solicitada es mayor a las existencias.");
                    return;
                }
                if (textBoxIDempleado.Text == "")  //If ID empleado is empty, returns
                {
                    MessageBox.Show("Error, el campo 'ID Empleado' no puede estar vacio.");
                    return;
                }
                if (comboBoxCausa.Text == "")  //If cause of loss is empty, returns
                {
                    MessageBox.Show("Error, el campo 'Causa de Merma' no puede estar vacio.");
                    return;
                }

                DataTable DT = query.DBreader("SELECT a.id_empleado, b.id_producto, b.nombre " +
                                              "FROM empleado a, producto b " +
                                              "WHERE a.id_empleado = " + textBoxIDempleado.Text + " AND b.id_producto = " + textBoxIDproducto.Text);
                DataRow dr = DT.Rows[0]; //Row with the select information

                //---Product already in losses
                foreach (DataRow row in losses.Rows)
                {
                    //Update the requested amount of a product if is already in losses
                    if (row["ID Producto"].ToString() == dr["id_producto"].ToString())
                    {
                        row["Cantidad"] = Convert.ToInt32(row["Cantidad"]) + cant;  //add the amount value
                        existing = true;
                    }
                }

                //---New Product in losses
                if (existing == false)
                {
                    losses.Rows.Add(dr.ItemArray);  //copy the queried product info          
                    int count = losses.Rows.Count;
                    DataRow row = losses.Rows[count - 1];  //instance the last row to add the wanted amount
                    row["Cantidad"] = cant;
                    row["Clasificacion"] = comboBoxCausa.Text;  //set the cause of loss
                }
                dataGridViewMermaR.DataSource = losses;

                prod_stock -= cant;  //reduce the stock with the wanted amount
                labelStock.Text = prod_stock.ToString();  //print the new stock
                textBoxMermaCantidad.Text = "";  //clear the textbox
            }
        }
        #endregion

        /////////////////////////////////////////////////
        #region BUTTONS REGISTER / REMOVE
        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            DialogResult opt = MessageBox.Show("Desea Registrar la Merma ?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (opt == DialogResult.Yes)
            {
                string date = DateTime.Now.Date.ToShortDateString();

                query.DBnonQuery("INSERT INTO merma VALUES(default, "+ textBoxIDempleado.Text + ", '" + date + "')");  //insert query

                foreach (DataRow row in losses.Rows)  //execute the shopcart insert queries
                {
                    DataTable DT = query.DBreader("SELECT precio from producto where id_producto = " + row["ID Producto"]);
                    DataRow dr = DT.Rows[0];

                    query.DBnonQuery("INSERT INTO detalle_merma " +
                                     "VALUES(default, "
                                     + folio + ","
                                     + row["ID Producto"] + ","
                                     + row["Cantidad"] + ","
                                     + dr["precio"] + ","
                                     + row["Clasificacion"] + ")");

                    query.DBnonQuery("UPDATE producto SET stock = stock-" + Convert.ToInt32(row["Cantidad"]) +
                                     " WHERE id_producto = " + Convert.ToInt32(row["ID Producto"]));
                }
                MessageBox.Show("Merma Registrada con Exito.");
                losses.Clear();
            }
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            int cant;  //amount of product to be added as disponible for sale

            foreach (DataRow row in losses.Rows)  //search for the row that match the ID to remove
            {
                if (row["ID Producto"].ToString() == textBoxIDproducto.Text)
                {
                    cant = Convert.ToInt32(row["Cantidad"]);
                    prod_stock += cant;  //re-add the previously requested amount
                    labelStock.Text = prod_stock.ToString();  //print the new stock

                    row.Delete();
                    return;
                }
            }
        }
        #endregion
    }
}
