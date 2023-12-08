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
    public partial class FormCompraRegistrar : Form
    {
        Query query;  //object that contain the DB queries methods and connection

        int folio, newprod;
        DataTable shopcart = new DataTable();  //sales shopping cart
        double[] finance = { 0, 0 }; //index: 0 = subtotal, 1 = IVA
        int prod_stock, prod_stock_max;  //stocks of the product
        int iva;  //value of IVA

        public FormCompraRegistrar(Query Q)
        {
            InitializeComponent();
            query = Q;  //Instance the local object

            DataTable DT = query.DBreader("select max(id_compra) from compra");  //Get the last ID_venta from table "venta"
            DataRow dr = DT.Rows[0];

            if (dr["max"].ToString() != "")  //if there are registers in "compra" assign the gathered ID
                folio = (Convert.ToInt32(dr[0]) + 1);
            else  //if there's not registers in "venta" assign the value 1 to the ID
                folio = 1;
            labelFolio.Text = "Folio: " + folio.ToString();  //next ID compra to register

            shopcart.Columns.Add("ID Producto", typeof(Int32));
            shopcart.Columns.Add("ID Proveedor", typeof(Int32));
            shopcart.Columns.Add("Nombre", typeof(String));
            shopcart.Columns.Add("Precio", typeof(Double));
            shopcart.Columns.Add("Cantidad", typeof(Int32));

            dataGridViewCompraR.DataSource = shopcart;

            foreach (DataGridViewColumn dc in dataGridViewCompraR.Columns)
                dc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridViewCompraR.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCompraR.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCompraR.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCompraR.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCompraR.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            DT = query.DBreader("SELECT valor FROM iva ORDER BY id_iva DESC");
            dr = DT.Rows[0];
            iva = Convert.ToInt32(dr[0]);
        }

        /////////////////////////////////////////////////
        #region TEXTBOX KEY UP PRODUCTO - ENTER
        private void textBoxIDproducto_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((textBoxIDproducto.Text).ToLower() == "x") newprod = newProduct();
                
                //Checks if the input is valid, if not returns
                if (query.checkInputID(textBoxIDproducto.Text) == false)
                {
                    textBoxIDproducto.Clear();
                    labelNombreProd.Text = "";
                    labelStock.Text = "";
                    labelStockMax.Text = "";
                    textBoxCompraPrecio.Clear();
                    return;
                }

                int ID = Convert.ToInt32(textBoxIDproducto.Text);
                if (ID <= 0) return;  //If the ID is no valid, returns

                textBoxIDproducto.Text = ID.ToString();  //Put the gathered ID in the textbox
                DataTable DT = query.DBreader("SELECT * FROM producto WHERE id_producto = " + textBoxIDproducto.Text);
                if (DT != null)
                {
                    DataRow dr = DT.Rows[0];
                    labelNombreProd.Text = Convert.ToString(dr["nombre"]);
                    labelStock.Text = Convert.ToString(dr["stock"]);
                    labelStockMax.Text = Convert.ToString(dr["stockmax"]);
                    textBoxCompraPrecio.Text = Convert.ToString(dr["precio"]);

                    prod_stock = Convert.ToInt32(dr["stock"]);  //stock of the requested product
                    prod_stock_max = Convert.ToInt32(dr["stockmax"]);  //max stock allowed of product
                }
                else
                {
                    labelNombreProd.Text = "Producto Nuevo";
                }
            }
        }
        #endregion

        /////////////////////////////////////////////////
        #region TEXTBOX KEY UP PROVEEDOR - ENTER
        private void textBoxIDproveedor_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Checks if the input is valid, if not returns
                if (query.checkInputID(textBoxIDproveedor.Text) == false)
                {
                    textBoxIDproveedor.Clear();
                    labelNombreProd.Text = "";
                    return;
                }

                int ID = Convert.ToInt32(textBoxIDproveedor.Text);
                if (ID <= 0) return;  //If the ID is no valid, returns

                textBoxIDproveedor.Text = ID.ToString();  //Put the gathered ID in the textbox
                DataTable DT = query.DBreader("SELECT * FROM proveedor WHERE id_proveedor = " + textBoxIDproveedor.Text);
                if (DT.Rows.Count != 0)
                {
                    DataRow dr = DT.Rows[0];
                    labelNombreProv.Text = Convert.ToString(dr["nombre"]);
                }
                else
                    MessageBox.Show("Error, no existe un Proveedor con el ID ingresado.");
            }
        }

        private void textBoxCompraCantidad_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bool existing = false;  //Flag - product is already in the shopcart or not

                int cant = Convert.ToInt32(textBoxCompraCantidad.Text);  //amount of product wanted 
                if (cant > (prod_stock_max - prod_stock))  //if the wanted amount is higher than the max stock, returns
                {
                    MessageBox.Show("Error, la cantidad especificada es mayor a la permitida en almacen.");
                    return;
                }
                if (labelNombreProv.Text.Length == 0)  //if the ID Proveedor is invalid, returns
                {
                    MessageBox.Show("Error, el campo ID Proveedor no tiene un ID valido.");
                    return;
                }

                DataTable DT = query.DBreader("SELECT id_producto,id_proveedor,nombre,precio " +
                                    "FROM producto WHERE id_producto = " + textBoxIDproducto.Text);
                DataRow dr = DT.Rows[0]; //Row with the select information

                //---Price different from the registered in DB
                if (textBoxCompraPrecio.Text != dr["precio"].ToString())
                    dr["precio"] = Convert.ToDouble(textBoxCompraPrecio.Text);  //update the new price

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
                dataGridViewCompraR.DataSource = shopcart;

                financials(dr, cant, true);  //calculate the new subtotal, IVA and total

                prod_stock += cant;  //increase the stock with the purchased amount
                labelStock.Text = prod_stock.ToString();  //print the new stock
                textBoxCompraCantidad.Text = "";  //clear the textbox
            }
        }
        #endregion

        /////////////////////////////////////////////////
        #region BUTTONS REGISTER / REMOVE
        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            DialogResult opt = MessageBox.Show("Desea Registrar la Compra ?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (opt == DialogResult.Yes)
            {
                string date = DateTime.Now.Date.ToShortDateString();

                query.DBnonQuery("INSERT INTO compra VALUES(default, '" + date + "', " + textBoxIDproveedor.Text + ")");  //insert query

                foreach (DataRow row in shopcart.Rows)  //execute the shopcart insert queries
                {
                    query.DBnonQuery("INSERT INTO detalle_compra " +
                                     "VALUES(default, "
                                     + folio + ","
                                     + row["ID Producto"] + ","
                                     + row["Cantidad"] + ","
                                     + row["Precio"] + ")");

                    query.DBnonQuery("UPDATE producto SET stock = stock+" + Convert.ToInt32(row["Cantidad"]) +
                                         " WHERE id_producto = " + Convert.ToInt32(row["ID Producto"]));
                }
                MessageBox.Show("Compra Registrada con Exito.");
                labelSubtotal.Text = "0";  //set default values to the labels and datagridview
                labelIVA.Text = "0";
                labelTotal.Text = "0";
                shopcart.Clear();
            }
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            int cant;  //amount of product to be buyed

            foreach (DataRow row in shopcart.Rows)  //search for the row that match the ID to remove
            {
                if (row["ID Producto"].ToString() == textBoxIDproducto.Text)
                {
                    cant = Convert.ToInt32(row["Cantidad"]);
                    prod_stock -= cant;  //re-add the previously requested amount
                    labelStock.Text = prod_stock.ToString();  //print the new stock

                    financials(row, Convert.ToInt32(row["Cantidad"]), false);  //calculate the new subtotal, IVA and total
                    row.Delete();
                    return;
                }
            }
        }
        #endregion

        private void newProduct()
        {
            DataTable DT = query.DBreader("select max(id_producto) from producto");  //Get the last ID_venta from table "venta"
            DataRow dr = DT.Rows[0];

            if (dr["max"].ToString() != "")  //if there are registers in "compra" assign the gathered ID
                newprod = (Convert.ToInt32(dr[0]) + 1);
            else  //if there's not registers in "venta" assign the value 1 to the ID
                newprod = 1;
        }

        private void financials(DataRow dr, int cant, bool type)
        {
            //type: true = add, false = remove
            if (type == true)  //adding product
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
