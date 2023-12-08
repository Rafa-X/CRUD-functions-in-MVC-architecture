namespace PCs_Maik
{
    partial class FormProveedorModificar
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
            this.textBoxIDproveedor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.panelEM = new System.Windows.Forms.Panel();
            this.textBoxDir = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelEM.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxIDproveedor
            // 
            this.textBoxIDproveedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxIDproveedor.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxIDproveedor.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxIDproveedor.Location = new System.Drawing.Point(330, 30);
            this.textBoxIDproveedor.Name = "textBoxIDproveedor";
            this.textBoxIDproveedor.Size = new System.Drawing.Size(100, 26);
            this.textBoxIDproveedor.TabIndex = 53;
            this.textBoxIDproveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxIDproveedor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxIDproveedor_KeyUp);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(214, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 28);
            this.label5.TabIndex = 52;
            this.label5.Text = "ID Proveedor";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonModificar
            // 
            this.buttonModificar.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonModificar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModificar.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonModificar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonModificar.Location = new System.Drawing.Point(250, 275);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(150, 40);
            this.buttonModificar.TabIndex = 51;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = false;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // panelEM
            // 
            this.panelEM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(25)))), ((int)(((byte)(50)))));
            this.panelEM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEM.Controls.Add(this.textBoxDir);
            this.panelEM.Controls.Add(this.label6);
            this.panelEM.Controls.Add(this.textBoxTelefono);
            this.panelEM.Controls.Add(this.label2);
            this.panelEM.Controls.Add(this.textBoxNombre);
            this.panelEM.Controls.Add(this.label1);
            this.panelEM.Location = new System.Drawing.Point(0, 88);
            this.panelEM.Name = "panelEM";
            this.panelEM.Size = new System.Drawing.Size(644, 149);
            this.panelEM.TabIndex = 54;
            // 
            // textBoxDir
            // 
            this.textBoxDir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxDir.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxDir.Font = new System.Drawing.Font("Lucida Fax", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDir.Location = new System.Drawing.Point(257, 98);
            this.textBoxDir.Name = "textBoxDir";
            this.textBoxDir.Size = new System.Drawing.Size(245, 25);
            this.textBoxDir.TabIndex = 40;
            this.textBoxDir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(151, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 28);
            this.label6.TabIndex = 39;
            this.label6.Text = "Direccion";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTelefono.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxTelefono.Font = new System.Drawing.Font("Lucida Fax", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTelefono.Location = new System.Drawing.Point(257, 60);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(140, 25);
            this.textBoxTelefono.TabIndex = 32;
            this.textBoxTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(151, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 28);
            this.label2.TabIndex = 31;
            this.label2.Text = "Telefono";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNombre.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxNombre.Font = new System.Drawing.Font("Lucida Fax", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxNombre.Location = new System.Drawing.Point(257, 22);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(245, 25);
            this.textBoxNombre.TabIndex = 30;
            this.textBoxNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(151, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 28);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nombre";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormProveedorModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(644, 566);
            this.Controls.Add(this.panelEM);
            this.Controls.Add(this.textBoxIDproveedor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonModificar);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProveedorModificar";
            this.Text = "FormProveedorModificar";
            this.panelEM.ResumeLayout(false);
            this.panelEM.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxIDproveedor;
        private Label label5;
        private Button buttonModificar;
        private Panel panelEM;
        private TextBox textBoxDir;
        private Label label6;
        private TextBox textBoxTelefono;
        private Label label2;
        private TextBox textBoxNombre;
        private Label label1;
    }
}