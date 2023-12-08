namespace PCs_Maik
{
    partial class FormMermaRegistrar
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
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxCausa = new System.Windows.Forms.ComboBox();
            this.dataGridViewMermaR = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.buttonRemover = new System.Windows.Forms.Button();
            this.labelNombreE = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxIDempleado = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelStock = new System.Windows.Forms.Label();
            this.labelNombreP = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMermaCantidad = new System.Windows.Forms.TextBox();
            this.textBoxIDproducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMermaR)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.labelFolio.Location = new System.Drawing.Point(75, 9);
            this.labelFolio.Name = "labelFolio";
            this.labelFolio.Size = new System.Drawing.Size(140, 28);
            this.labelFolio.TabIndex = 21;
            this.labelFolio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(131, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 38);
            this.label4.TabIndex = 22;
            this.label4.Text = "Causa de Merma";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxCausa
            // 
            this.comboBoxCausa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxCausa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxCausa.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxCausa.FormattingEnabled = true;
            this.comboBoxCausa.Items.AddRange(new object[] {
            "Robo",
            "Roto",
            "Expirado"});
            this.comboBoxCausa.Location = new System.Drawing.Point(242, 37);
            this.comboBoxCausa.Name = "comboBoxCausa";
            this.comboBoxCausa.Size = new System.Drawing.Size(120, 24);
            this.comboBoxCausa.TabIndex = 23;
            // 
            // dataGridViewMermaR
            // 
            this.dataGridViewMermaR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMermaR.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewMermaR.Location = new System.Drawing.Point(0, 316);
            this.dataGridViewMermaR.Name = "dataGridViewMermaR";
            this.dataGridViewMermaR.ReadOnly = true;
            this.dataGridViewMermaR.RowTemplate.Height = 25;
            this.dataGridViewMermaR.Size = new System.Drawing.Size(644, 250);
            this.dataGridViewMermaR.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonRegistrar);
            this.panel1.Controls.Add(this.buttonRemover);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBoxCausa);
            this.panel1.Location = new System.Drawing.Point(0, 212);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 98);
            this.panel1.TabIndex = 29;
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonRegistrar.FlatAppearance.BorderSize = 0;
            this.buttonRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistrar.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRegistrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonRegistrar.Location = new System.Drawing.Point(470, 5);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(150, 40);
            this.buttonRegistrar.TabIndex = 15;
            this.buttonRegistrar.Text = "Registrar Merma";
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
            this.buttonRemover.Location = new System.Drawing.Point(470, 51);
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.Size = new System.Drawing.Size(150, 40);
            this.buttonRemover.TabIndex = 0;
            this.buttonRemover.Text = "Remover Producto";
            this.buttonRemover.UseVisualStyleBackColor = false;
            this.buttonRemover.Click += new System.EventHandler(this.buttonRemover_Click);
            // 
            // labelNombreE
            // 
            this.labelNombreE.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.labelNombreE.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNombreE.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelNombreE.Location = new System.Drawing.Point(381, 49);
            this.labelNombreE.Name = "labelNombreE";
            this.labelNombreE.Size = new System.Drawing.Size(240, 28);
            this.labelNombreE.TabIndex = 33;
            this.labelNombreE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(263, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 28);
            this.label7.TabIndex = 32;
            this.label7.Text = "Nombre";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxIDempleado
            // 
            this.textBoxIDempleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxIDempleado.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxIDempleado.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxIDempleado.Location = new System.Drawing.Point(152, 49);
            this.textBoxIDempleado.Name = "textBoxIDempleado";
            this.textBoxIDempleado.Size = new System.Drawing.Size(80, 26);
            this.textBoxIDempleado.TabIndex = 31;
            this.textBoxIDempleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxIDempleado.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxIDempleado_KeyUp);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(38, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 28);
            this.label8.TabIndex = 30;
            this.label8.Text = "ID Empleado";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(25)))), ((int)(((byte)(50)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.labelStock);
            this.panel2.Controls.Add(this.labelNombreP);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBoxMermaCantidad);
            this.panel2.Controls.Add(this.textBoxIDproducto);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(644, 93);
            this.panel2.TabIndex = 53;
            // 
            // labelStock
            // 
            this.labelStock.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.labelStock.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelStock.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelStock.Location = new System.Drawing.Point(379, 49);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(90, 28);
            this.labelStock.TabIndex = 36;
            this.labelStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNombreP
            // 
            this.labelNombreP.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.labelNombreP.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNombreP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelNombreP.Location = new System.Drawing.Point(380, 11);
            this.labelNombreP.Name = "labelNombreP";
            this.labelNombreP.Size = new System.Drawing.Size(240, 28);
            this.labelNombreP.TabIndex = 34;
            this.labelNombreP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(261, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 28);
            this.label6.TabIndex = 35;
            this.label6.Text = "Stock";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(262, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 28);
            this.label3.TabIndex = 33;
            this.label3.Text = "Nombre";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxMermaCantidad
            // 
            this.textBoxMermaCantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMermaCantidad.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxMermaCantidad.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxMermaCantidad.Location = new System.Drawing.Point(148, 50);
            this.textBoxMermaCantidad.Name = "textBoxMermaCantidad";
            this.textBoxMermaCantidad.Size = new System.Drawing.Size(80, 26);
            this.textBoxMermaCantidad.TabIndex = 32;
            this.textBoxMermaCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxMermaCantidad.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxMermaCantidad_KeyUp);
            // 
            // textBoxIDproducto
            // 
            this.textBoxIDproducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxIDproducto.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxIDproducto.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxIDproducto.Location = new System.Drawing.Point(148, 12);
            this.textBoxIDproducto.Name = "textBoxIDproducto";
            this.textBoxIDproducto.Size = new System.Drawing.Size(80, 26);
            this.textBoxIDproducto.TabIndex = 31;
            this.textBoxIDproducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxIDproducto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxIDproducto_KeyUp);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(37, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 28);
            this.label2.TabIndex = 30;
            this.label2.Text = "Cantidad";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(37, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 28);
            this.label1.TabIndex = 29;
            this.label1.Text = "ID Producto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMermaRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(644, 566);
            this.Controls.Add(this.labelNombreE);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxIDempleado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewMermaR);
            this.Controls.Add(this.labelFolio);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMermaRegistrar";
            this.Text = "FormMermaRegistrar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMermaR)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelFolio;
        private Label label4;
        private ComboBox comboBoxCausa;
        private DataGridView dataGridViewMermaR;
        private Panel panel1;
        private Button buttonRegistrar;
        private Button buttonRemover;
        private Label labelNombreE;
        private Label label7;
        private TextBox textBoxIDempleado;
        private Label label8;
        private Panel panel2;
        private Label labelStock;
        private Label label6;
        private Label labelNombreP;
        private Label label3;
        private TextBox textBoxMermaCantidad;
        private TextBox textBoxIDproducto;
        private Label label2;
        private Label label1;
    }
}