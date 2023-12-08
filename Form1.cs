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
    public partial class Form1 : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection(
        "Host=localhost; Username=postgres; Password=password; Database=pcs_maik");
        Query query = new Query();  //Class query with all the DB query codes

        public Form1()
        {
            InitializeComponent();
            customDesign();
            labelFecha.Text = DateTime.Now.Date.ToShortDateString();

            try
            {
                conn.Open();
                query.setConnection(conn);
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error.Message);
                conn.Dispose();
                conn.Close();
            }
            conn.Close();
        }

        /////////////////////////////////////////////////
        #region DESIGN
        private void customDesign()  //Hides the submenus of each category - On start
        {
            panelMenuVenta.Visible = false;
            panelMenuCompra.Visible = false;
            panelMenuProducto.Visible = false;
            panelMenuProveedor.Visible = false;
            panelMenuEmpleado.Visible = false;
            panelMenuMerma.Visible = false;
        }

        private void hideSubMenu()  //Hide the active submenu
        {
             panelMenuVenta.Visible = false;
             panelMenuCompra.Visible = false;
             panelMenuProducto.Visible = false;
             panelMenuProveedor.Visible = false;
             panelMenuEmpleado.Visible = false;
             panelMenuMerma.Visible = false;
        }

        private void showSubMenu(Panel submenu)  //alternates the active submenu
        {
            if(submenu.Visible == false)
            {
                hideSubMenu();           //hide the active submenu
                submenu.Visible = true;  //show the called submenu
            }
            else
                submenu.Visible = false;
        }
        #endregion

        /////////////////////////////////////////////////
        #region PRINCIPAL MENU BUTTONS
        private void buttonVentas_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMenuVenta);
        }

        private void buttonCompras_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMenuCompra);
        }

        private void buttonProductos_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMenuProducto);
        }

        private void buttonProveedores_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMenuProveedor);
        }

        private void buttonEmpleados_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMenuEmpleado);
        }

        private void buttonMermas_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMenuMerma);
        }

        private void buttonIVA_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "IVA - Registrar";
            openForm(new FormIVA(query));
        }
        #endregion

        /////////////////////////////////////////////////
        # region SUBMENU VENTA
        private void buttonClose_Click(object sender, EventArgs e)  //Close the active submenu form
        {
            if (active != null)
            {
                labelTitle.Text = "";
                active.Close();  
            } 
        }

        private void buttonVentaR_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "Venta - Registrar";
            openForm(new FormVentaRegistrar(query)); //calls the form giving an object with the DB queries and connection
            hideSubMenu();
        }

        private void buttonVentaC_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "Venta - Consultar";
            openForm(new FormVentaConsultar(query));
            hideSubMenu();
        }
        #endregion

        #region SUBMENU COMPRA
        private void buttonCompraR_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "Compra - Registrar";
            openForm(new FormCompraRegistrar(query));
            hideSubMenu();
        }

        private void buttonCompraC_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "Compra - Consultar";
            openForm(new FormCompraConsultar(query));
            hideSubMenu();
        }
        #endregion

        #region SUBMENU PRODUCTO
        private void buttonProductoC_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "Producto - Consultar";
            openForm(new FormProductoConsultar(query));
            hideSubMenu();
        }

        private void buttonProductoM_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "Producto - Registrar";
            openForm(new FormProductoModificar(query));
            hideSubMenu();
        }
        #endregion

        #region SUBMENU PROVEEDOR
        private void buttonProveedorR_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "Proveedor - Registrar";
            openForm(new FormProveedorRegistrar(query));
            hideSubMenu();
        }

        private void buttonProveedorC_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "Proveedor - Consultar";
            openForm(new FormProveedorConsultar(query));
            hideSubMenu();
        }

        private void buttonProveedorM_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "Proveedor - Modificar";
            openForm(new FormProveedorModificar(query));
            hideSubMenu();
        }
        #endregion

        #region SUBMENU EMPLEADO
        private void buttonEmpleadoR_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "Empleado - Registrar";
            openForm(new FormEmpleadoRegistrar(query));
            hideSubMenu();
        }

        private void buttonEmpleadoC_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "Empleado - Consultar";
            openForm(new FormEmpleadoConsultar(query));
            hideSubMenu();
        }

        private void buttonEmpleadoM_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "Empleado - Modificar";
            openForm(new FormEmpleadoModificar(query));
            hideSubMenu();
        }
        #endregion

        #region SUBMENU MERMA
        private void buttonMermaR_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "Merma - Registrar";
            openForm(new FormMermaRegistrar(query));
            hideSubMenu();
        }

        private void buttonMermaC_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "Merma - Consultar";
            openForm(new FormMermaConsultar(query));
            hideSubMenu();
        }
        #endregion

        /////////////////////////////////////////////////
        #region SHOW SUBMENU FORMS
        private Form? active = null;  //Active form displayed

        private void openForm(Form newForm)
        {
            if(active != null)
                active.Close();
            active = newForm;

            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;
            panelForms.Controls.Add(newForm);  //Add form to the list of controls of the panel
            panelForms.Tag = newForm;  //Associate the form with the panel
            newForm.Show();
        }

        #endregion   
    }
}