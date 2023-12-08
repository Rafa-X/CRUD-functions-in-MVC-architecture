namespace PCs_Maik
{
    partial class FormIVA
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
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.textBoxIVA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewIVA = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIVA)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonRegistrar.FlatAppearance.BorderSize = 0;
            this.buttonRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistrar.Font = new System.Drawing.Font("Lucida Bright", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRegistrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonRegistrar.Location = new System.Drawing.Point(250, 122);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(150, 40);
            this.buttonRegistrar.TabIndex = 30;
            this.buttonRegistrar.Text = "Registrar IVA";
            this.buttonRegistrar.UseVisualStyleBackColor = false;
            this.buttonRegistrar.Click += new System.EventHandler(this.buttonRegistrar_Click);
            // 
            // textBoxIVA
            // 
            this.textBoxIVA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxIVA.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxIVA.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxIVA.Location = new System.Drawing.Point(326, 50);
            this.textBoxIVA.Name = "textBoxIVA";
            this.textBoxIVA.Size = new System.Drawing.Size(160, 26);
            this.textBoxIVA.TabIndex = 29;
            this.textBoxIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(159, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 28);
            this.label1.TabIndex = 28;
            this.label1.Text = "Nuevo valor de IVA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewIVA
            // 
            this.dataGridViewIVA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIVA.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewIVA.Location = new System.Drawing.Point(0, 213);
            this.dataGridViewIVA.Name = "dataGridViewIVA";
            this.dataGridViewIVA.ReadOnly = true;
            this.dataGridViewIVA.RowTemplate.Height = 25;
            this.dataGridViewIVA.Size = new System.Drawing.Size(644, 353);
            this.dataGridViewIVA.TabIndex = 43;
            // 
            // FormIVA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(644, 566);
            this.Controls.Add(this.dataGridViewIVA);
            this.Controls.Add(this.buttonRegistrar);
            this.Controls.Add(this.textBoxIVA);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormIVA";
            this.Text = "FormIVA";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIVA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonRegistrar;
        private TextBox textBoxIVA;
        private Label label1;
        private DataGridView dataGridViewIVA;
    }
}