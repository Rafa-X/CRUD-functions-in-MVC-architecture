namespace PCs_Maik
{
    partial class FormCompraRegistrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelFolio = new System.Windows.Forms.Label();
            this.textBoxCompraCantidad = new System.Windows.Forms.TextBox();
            this.textBoxIDproducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIDproveedor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelIVA = new System.Windows.Forms.Label();
            this.labelSubtotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.buttonRemover = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewCompraR = new System.Windows.Forms.DataGridView();
            this.textBoxCompraPrecio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelStock = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelNombreProd = new System.Windows.Forms.Label();
            this.labelNombreProv = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelStockMax = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompraR)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelFolio
            // 
            this.labelFolio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelFolio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFolio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelFolio.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFolio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelFolio.Location = new System.Drawing.Point(75, 10);
            this.labelFolio.Name = "labelFolio";
            this.labelFolio.Size = new System.Drawing.Size(140, 31);
            this.labelFolio.TabIndex = 19;
            this.labelFolio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxCompraCantidad
            // 
            this.textBoxCompraCantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCompraCantidad.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxCompraCantidad.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxCompraCantidad.Location = new System.Drawing.Point(152, 54);
            this.textBoxCompraCantidad.Name = "textBoxCompraCantidad";
            this.textBoxCompraCantidad.Size = new System.Drawing.Size(80, 26);
            this.textBoxCompraCantidad.TabIndex = 18;
            this.textBoxCompraCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCompraCantidad.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxCompraCantidad_KeyUp);
            // 
            // textBoxIDproducto
            // 
            this.textBoxIDproducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxIDproducto.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxIDproducto.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxIDproducto.Location = new System.Drawing.Point(153, 60);
            this.textBoxIDproducto.Name = "textBoxIDproducto";
            this.textBoxIDproducto.Size = new System.Drawing.Size(80, 26);
            this.textBoxIDproducto.TabIndex = 17;
            this.textBoxIDproducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxIDproducto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxIDproducto_KeyUp);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(37, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 28);
            this.label2.TabIndex = 16;
            this.label2.Text = "Cantidad";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(38, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 28);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID Producto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxIDproveedor
            // 
            this.textBoxIDproveedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxIDproveedor.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxIDproveedor.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxIDproveedor.Location = new System.Drawing.Point(152, 10);
            this.textBoxIDproveedor.Name = "textBoxIDproveedor";
            this.textBoxIDproveedor.Size = new System.Drawing.Size(80, 26);
            this.textBoxIDproveedor.TabIndex = 21;
            this.textBoxIDproveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxIDproveedor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxIDproveedor_KeyUp);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(37, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 28);
            this.label3.TabIndex = 20;
            this.label3.Text = "ID Proveedor";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(282, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 28);
            this.label4.TabIndex = 22;
            this.label4.Text = "Precio";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelTotal);
            this.panel1.Controls.Add(this.labelIVA);
            this.panel1.Controls.Add(this.labelSubtotal);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.buttonRegistrar);
            this.panel1.Controls.Add(this.buttonRemover);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(0, 211);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 110);
            this.panel1.TabIndex = 27;
            // 
            // labelTotal
            // 
            this.labelTotal.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.labelTotal.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelTotal.Location = new System.Drawing.Point(317, 58);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(120, 28);
            this.labelTotal.TabIndex = 23;
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelIVA
            // 
            this.labelIVA.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.labelIVA.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelIVA.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelIVA.Location = new System.Drawing.Point(161, 58);
            this.labelIVA.Name = "labelIVA";
            this.labelIVA.Size = new System.Drawing.Size(120, 28);
            this.labelIVA.TabIndex = 22;
            this.labelIVA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSubtotal
            // 
            this.labelSubtotal.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.labelSubtotal.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSubtotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelSubtotal.Location = new System.Drawing.Point(11, 58);
            this.labelSubtotal.Name = "labelSubtotal";
            this.labelSubtotal.Size = new System.Drawing.Size(120, 28);
            this.labelSubtotal.TabIndex = 17;
            this.labelSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label9.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(317, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 28);
            this.label9.TabIndex = 21;
            this.label9.Text = "Total";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label8.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(161, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 28);
            this.label8.TabIndex = 19;
            this.label8.Text = "IVA";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonRegistrar.FlatAppearance.BorderSize = 0;
            this.buttonRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistrar.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRegistrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonRegistrar.Location = new System.Drawing.Point(471, 11);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(150, 40);
            this.buttonRegistrar.TabIndex = 26;
            this.buttonRegistrar.Text = "Registrar Compra";
            this.buttonRegistrar.UseVisualStyleBackColor = false;
            this.buttonRegistrar.Click += new System.EventHandler(this.buttonRegistrar_Click);
            // 
            // buttonRemover
            // 
            this.buttonRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.buttonRemover.FlatAppearance.BorderSize = 0;
            this.buttonRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemover.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRemover.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonRemover.Location = new System.Drawing.Point(471, 57);
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.Size = new System.Drawing.Size(150, 40);
            this.buttonRemover.TabIndex = 24;
            this.buttonRemover.Text = "Remover Producto";
            this.buttonRemover.UseVisualStyleBackColor = false;
            this.buttonRemover.Click += new System.EventHandler(this.buttonRemover_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label7.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(11, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 28);
            this.label7.TabIndex = 17;
            this.label7.Text = "Subtotal";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewCompraR
            // 
            this.dataGridViewCompraR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCompraR.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewCompraR.Location = new System.Drawing.Point(0, 326);
            this.dataGridViewCompraR.Name = "dataGridViewCompraR";
            this.dataGridViewCompraR.ReadOnly = true;
            this.dataGridViewCompraR.RowTemplate.Height = 25;
            this.dataGridViewCompraR.Size = new System.Drawing.Size(644, 240);
            this.dataGridViewCompraR.TabIndex = 25;
            // 
            // textBoxCompraPrecio
            // 
            this.textBoxCompraPrecio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCompraPrecio.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxCompraPrecio.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCompraPrecio.Location = new System.Drawing.Point(396, 54);
            this.textBoxCompraPrecio.Name = "textBoxCompraPrecio";
            this.textBoxCompraPrecio.Size = new System.Drawing.Size(110, 26);
            this.textBoxCompraPrecio.TabIndex = 28;
            this.textBoxCompraPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(283, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 28);
            this.label5.TabIndex = 29;
            this.label5.Text = "Producto";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelStock
            // 
            this.labelStock.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.labelStock.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStock.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelStock.Location = new System.Drawing.Point(397, 58);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(81, 28);
            this.labelStock.TabIndex = 32;
            this.labelStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(283, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 28);
            this.label6.TabIndex = 31;
            this.label6.Text = "Stock / Max";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNombreProd
            // 
            this.labelNombreProd.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.labelNombreProd.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNombreProd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelNombreProd.Location = new System.Drawing.Point(397, 17);
            this.labelNombreProd.Name = "labelNombreProd";
            this.labelNombreProd.Size = new System.Drawing.Size(240, 28);
            this.labelNombreProd.TabIndex = 33;
            this.labelNombreProd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNombreProv
            // 
            this.labelNombreProv.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.labelNombreProv.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNombreProv.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelNombreProv.Location = new System.Drawing.Point(396, 9);
            this.labelNombreProv.Name = "labelNombreProv";
            this.labelNombreProv.Size = new System.Drawing.Size(240, 28);
            this.labelNombreProv.TabIndex = 35;
            this.labelNombreProv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(282, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 28);
            this.label11.TabIndex = 34;
            this.label11.Text = "Proveedor";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(25)))), ((int)(((byte)(50)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.labelNombreProv);
            this.panel2.Controls.Add(this.textBoxIDproveedor);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.textBoxCompraCantidad);
            this.panel2.Controls.Add(this.textBoxCompraPrecio);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(0, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(644, 95);
            this.panel2.TabIndex = 36;
            // 
            // labelStockMax
            // 
            this.labelStockMax.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.labelStockMax.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStockMax.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelStockMax.Location = new System.Drawing.Point(489, 58);
            this.labelStockMax.Name = "labelStockMax";
            this.labelStockMax.Size = new System.Drawing.Size(81, 28);
            this.labelStockMax.TabIndex = 37;
            this.labelStockMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormCompraRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(644, 566);
            this.Controls.Add(this.labelStockMax);
            this.Controls.Add(this.labelNombreProd);
            this.Controls.Add(this.labelStock);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewCompraR);
            this.Controls.Add(this.labelFolio);
            this.Controls.Add(this.textBoxIDproducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCompraRegistrar";
            this.Text = "FormCompraRegistrar";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompraR)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelFolio;
        private TextBox textBoxCompraCantidad;
        private TextBox textBoxIDproducto;
        private Label label2;
        private Label label1;
        private TextBox textBoxIDproveedor;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private Label labelTotal;
        private Label labelIVA;
        private Label labelSubtotal;
        private Label label9;
        private Label label8;
        private Label label7;
        private Button buttonRegistrar;
        private DataGridView dataGridViewCompraR;
        private Button buttonRemover;
        private TextBox textBoxCompraPrecio;
        private Label label5;
        private Label labelStock;
        private Label label6;
        private Label labelNombreProd;
        private Label labelNombreProv;
        private Label label11;
        private Panel panel2;
        private Label labelStockMax;
    }
}