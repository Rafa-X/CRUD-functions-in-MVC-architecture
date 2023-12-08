namespace PCs_Maik
{
    partial class FormEmpleadoConsultar
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIDemp = new System.Windows.Forms.TextBox();
            this.dataGridViewEmpC = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpC)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(25)))), ((int)(((byte)(50)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBoxIDemp);
            this.panel2.Location = new System.Drawing.Point(0, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(644, 70);
            this.panel2.TabIndex = 39;
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
            this.label1.Text = "ID Empleado";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxIDemp
            // 
            this.textBoxIDemp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxIDemp.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxIDemp.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxIDemp.Location = new System.Drawing.Point(154, 22);
            this.textBoxIDemp.Name = "textBoxIDemp";
            this.textBoxIDemp.Size = new System.Drawing.Size(100, 26);
            this.textBoxIDemp.TabIndex = 28;
            this.textBoxIDemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxIDemp.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxIDemp_KeyUp);
            // 
            // dataGridViewEmpC
            // 
            this.dataGridViewEmpC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmpC.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewEmpC.Location = new System.Drawing.Point(0, 88);
            this.dataGridViewEmpC.Name = "dataGridViewEmpC";
            this.dataGridViewEmpC.ReadOnly = true;
            this.dataGridViewEmpC.RowTemplate.Height = 25;
            this.dataGridViewEmpC.Size = new System.Drawing.Size(644, 478);
            this.dataGridViewEmpC.TabIndex = 38;
            // 
            // FormEmpleadoConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(644, 566);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridViewEmpC);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEmpleadoConsultar";
            this.Text = "FormEmpleadoConsultar";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private Label label1;
        private TextBox textBoxIDemp;
        private DataGridView dataGridViewEmpC;
    }
}