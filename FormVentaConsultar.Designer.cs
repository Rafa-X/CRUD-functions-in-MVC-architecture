namespace PCs_Maik
{
    partial class FormVentaConsultar
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
            this.dataGridViewVentaC = new System.Windows.Forms.DataGridView();
            this.textBoxIDventa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVentaC)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewVentaC
            // 
            this.dataGridViewVentaC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVentaC.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewVentaC.Location = new System.Drawing.Point(0, 88);
            this.dataGridViewVentaC.Name = "dataGridViewVentaC";
            this.dataGridViewVentaC.ReadOnly = true;
            this.dataGridViewVentaC.RowTemplate.Height = 25;
            this.dataGridViewVentaC.Size = new System.Drawing.Size(644, 478);
            this.dataGridViewVentaC.TabIndex = 26;
            // 
            // textBoxIDventa
            // 
            this.textBoxIDventa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxIDventa.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxIDventa.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxIDventa.Location = new System.Drawing.Point(156, 22);
            this.textBoxIDventa.Name = "textBoxIDventa";
            this.textBoxIDventa.Size = new System.Drawing.Size(100, 26);
            this.textBoxIDventa.TabIndex = 28;
            this.textBoxIDventa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxIDventa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxIDventa_KeyUp);
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
            this.label1.Text = "ID Venta";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(25)))), ((int)(((byte)(50)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBoxIDventa);
            this.panel2.Location = new System.Drawing.Point(0, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(644, 70);
            this.panel2.TabIndex = 37;
            // 
            // FormVentaConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(644, 566);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridViewVentaC);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVentaConsultar";
            this.Text = "FormVentaConsultar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVentaC)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridViewVentaC;
        private TextBox textBoxIDventa;
        private Label label1;
        private Panel panel2;
    }
}