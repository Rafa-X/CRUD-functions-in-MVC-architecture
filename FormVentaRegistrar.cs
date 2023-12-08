using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace PCs_Maik
{
    public partial class FormVentaRegistrar : Form
    {
        Query query;  //object that will instantiate the query codes

        int folio;
        DataTable shopcart = new DataTable();  //sales shopping cart
        double[] finance = { 0, 0 }; //index: 0 = subtotal, 1 = IVA
        int prod_stock;
        int iva;  //value of IVA

        public FormVentaRegistrar(Query Q)
        {
            InitializeComponent();
            query = Q;  //instance the local object

            DataTable DT = query.DBreader("select max(id_venta) from venta");  //get the last ID_venta from table "venta"
            DataRow dr = DT.Rows[0];

            if (dr["max"].ToString() != "")  //if there are registers in "venta" assign the gathered ID
                folio = (Convert.ToInt32(dr[0]) + 1);
            else  //if there's not registers in "venta" assign the value 1 to the ID
                folio = 1;
            labelFolio.Text = "Folio: " + folio.ToString();  //next ID venta to register

            shopcart.Columns.Add("ID Producto", typeof(Int32));
            shopcart.Columns.Add("ID Proveedor", typeof(Int32));
            shopcart.Columns.Add("Nombre", typeof(String));
            shopcart.Columns.Add("Precio", typeof(Double));
            shopcart.Columns.Add("Cantidad", typeof(Int32));

            dataGridViewVentaR.DataSource = shopcart;

            foreach (DataGridViewColumn dc in dataGridViewVentaR.Columns)
                dc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dataGridViewVentaR.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewVentaR.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewVentaR.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewVentaR.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewVentaR.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            DT = query.DBreader("SELECT valor FROM iva ORDER BY id_iva DESC");
            dr = DT.Rows[0];
            iva = Convert.ToInt32(dr[0]);
        }
        
        /////////////////////////////////////////////////
        #region TEXTBOX SALE KEY UP - ENTER
        private void textBoxID_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && int.TryParse(textBoxID.Text, out int ID))
            {
                //int ID = Convert.ToInt32(textBoxID.Text);
                if (ID <= 0) return;  //If the ID is not valid, returns

                textBoxID.Text = ID.ToString();  //Put the gathered ID in the textbox
                DataTable DT = query.DBreader("SELECT * FROM producto WHERE id_producto = " + textBoxID.Text);
                if(DT.Rows.Count != 0)
                {
                    DataRow dr = DT.Rows[0];
                    labelNombre.Text = Convert.ToString(dr["nombre"]);
                    labelPrecio.Text = "$ " + Convert.ToString(dr["precio"]);
                    labelStock.Text  = Convert.ToString(dr["stock"]);

                    prod_stock = Convert.ToInt32(dr["stock"]);  //stock of the requested product
                }
                else
                {
                    labelNombre.Text = "";
                    labelPrecio.Text = "";
                    labelStock.Text  = "";
                    MessageBox.Show("Error, no existe un Producto con el ID ingresado.");
                }
            }
        }

        private void textBoxVentaCantidad_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bool existing = false;  //Flag - product is already in the shopcart or not

                int cant = Convert.ToInt32(textBoxVentaCantidad.Text);  //amount of product wanted
                if (cant > prod_stock)  //If the wanted amount is higher than the stock, returns
                {
                    MessageBox.Show("Error, la cantidad solicitada es mayor a las existencias.");
                    return;
                }

                DataTable DT = query.DBreader("SELECT id_producto,id_proveedor,nombre,precio " +
                                    "FROM producto WHERE id_producto = " + textBoxID.Text);
                DataRow dr = DT.Rows[0]; //Row with the select information

                //---Product already in shopcart
                foreach (DataRow row in shopcart.Rows)
                {
                    //Update the wanted amount of a product if is already in the shopcart
                    if (row["ID Producto"].ToString() == dr["id_producto"].ToString())
                    {
                        row["Cantidad"] = Convert.ToInt32(row["Cantidad"]) + cant;  //add the amount value
                        existing = true;
                    }
                }

                //---New Product in shopcart
                if (existing == false)
                {
                    shopcart.Rows.Add(dr.ItemArray);  //copy the queried product info
                    int count = shopcart.Rows.Count;
                    DataRow row = shopcart.Rows[count - 1];  //instance the last row to add the wanted amount
                    row["Cantidad"] = cant;
                }
                dataGridViewVentaR.DataSource = shopcart;

                financials(dr, cant, true);  //calculate the new subtotal, IVA and total

                prod_stock -= cant;  //reduce the stock with the wanted amount
                labelStock.Text = prod_stock.ToString();  //print the new stock
                textBoxVentaCantidad.Text = "";  //clear the textbox
            }
        }
        #endregion

        /////////////////////////////////////////////////
        #region BUTTONS REGISTER / REMOVE
        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            DialogResult opt = MessageBox.Show("Desea Registrar la Venta ?","Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (opt == DialogResult.Yes)
            {
                string date = DateTime.Now.Date.ToShortDateString();

                query.DBnonQuery("INSERT INTO venta VALUES(default, '" + date + "')");  //insert query

                foreach (DataRow row in shopcart.Rows)  //execute the shopcart insert queries
                {
                    query.DBnonQuery("INSERT INTO detalle_venta " +
                                     "VALUES(default, "
                                     + folio + ","
                                     + row["ID Producto"] + ","
                                     + row["Cantidad"] + ","
                                     + row["Precio"] + ")");

                    query.DBnonQuery("UPDATE producto SET stock = stock-" + Convert.ToInt32(row["Cantidad"]) + 
                                     " WHERE id_producto = " + Convert.ToInt32(row["ID Producto"]));
                }
                MessageBox.Show("Venta Registrada con Exito.");
                labelSubtotal.Text = "0";  //set default values to the labels and datagridview
                labelIVA.Text = "0";
                labelTotal.Text = "0";
                shopcart.Clear();
            }
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            int cant;  //amount of product to be added as disponible for sale

            foreach (DataRow row in shopcart.Rows)  //search for the row that match the ID to remove
            {
                if(row["ID Producto"].ToString() == textBoxID.Text)
                {
                    cant = Convert.ToInt32(row["Cantidad"]);
                    prod_stock += cant;  //re-add the previously requested amount
                    labelStock.Text = prod_stock.ToString();  //print the new stock
                    
                    financials(row, cant, false);  //calculate the new subtotal, IVA and total
                    row.Delete();
                    return;
                }
            }
        }
        #endregion

        private void financials(DataRow dr, int cant, bool type)
        {
            //type: true = add, false = remove
            if(type == true)  //adding product
            {
                finance[0] += Convert.ToDouble(dr["precio"]) * cant;  //SUBTOTAL
                finance[1] += Math.Round(((Convert.ToDouble(dr["precio"]) * cant) * iva) / 100, 2);  //IVA
            }
            else  //removing product
            {
                finance[0] -= Convert.ToDouble(dr["precio"]) * cant;  //SUBTOTAL
                finance[1] -= Math.Round(((Convert.ToDouble(dr["precio"]) * cant) * iva) / 100, 2);  //IVA
            }
            labelSubtotal.Text = finance[0].ToString();
            labelIVA.Text = finance[1].ToString();
            labelTotal.Text = (finance[0] + finance[1]).ToString();  //TOTAL
        }
    }
}
