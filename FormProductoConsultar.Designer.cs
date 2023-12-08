namespace PCs_Maik
{
    partial class FormProductoConsultar
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxIDprod = new System.Windows.Forms.TextBox();
            this.buttonMostrarT = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewProdC = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdC)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(25)))), ((int)(((byte)(50)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBoxIDprod);
            this.panel2.Controls.Add(this.buttonMostrarT);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(644, 70);
            this.panel2.TabIndex = 43;
            // 
            // textBoxIDprod
            // 
            this.textBoxIDprod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxIDprod.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxIDprod.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxIDprod.Location = new System.Drawing.Point(154, 22);
            this.textBoxIDprod.Name = "textBoxIDprod";
            this.textBoxIDprod.Size = new System.Drawing.Size(100, 26);
            this.textBoxIDprod.TabIndex = 30;
            this.textBoxIDprod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxIDprod.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxIDprod_KeyUp);
            // 
            // buttonMostrarT
            // 
            this.buttonMostrarT.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonMostrarT.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonMostrarT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMostrarT.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonMostrarT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonMostrarT.Location = new System.Drawing.Point(392, 15);
            this.buttonMostrarT.Name = "buttonMostrarT";
            this.buttonMostrarT.Size = new System.Drawing.Size(150, 40);
            this.buttonMostrarT.TabIndex = 29;
            this.buttonMostrarT.Text = "Mostrar Todos";
            this.buttonMostrarT.UseVisualStyleBackColor = false;
            this.buttonMostrarT.Click += new System.EventHandler(this.buttonMostrarT_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(38, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 28);
            this.label1.TabIndex = 27;
            this.label1.Text = "ID Producto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewProdC
            // 
            this.dataGridViewProdC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdC.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewProdC.Location = new System.Drawing.Point(0, 88);
            this.dataGridViewProdC.Name = "dataGridViewProdC";
            this.dataGridViewProdC.ReadOnly = true;
            this.dataGridViewProdC.RowTemplate.Height = 25;
            this.dataGridViewProdC.Size = new System.Drawing.Size(644, 478);
            this.dataGridViewProdC.TabIndex = 42;
            // 
            // FormProductoConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(644, 566);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridViewProdC);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProductoConsultar";
            this.Text = "FormProductoConsultar";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private TextBox textBoxIDprod;
        private Button buttonMostrarT;
        private Label label1;
        private DataGridView dataGridViewProdC;
    }
}