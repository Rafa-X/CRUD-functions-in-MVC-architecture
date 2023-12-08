namespace PCs_Maik
{
    partial class FormMermaConsultar
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
            this.textBoxIDmerma = new System.Windows.Forms.TextBox();
            this.dataGridViewMermaC = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMermaC)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(25)))), ((int)(((byte)(50)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBoxIDmerma);
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
            this.label1.Text = "ID Merma";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxIDmerma
            // 
            this.textBoxIDmerma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxIDmerma.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxIDmerma.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxIDmerma.Location = new System.Drawing.Point(159, 23);
            this.textBoxIDmerma.Name = "textBoxIDmerma";
            this.textBoxIDmerma.Size = new System.Drawing.Size(100, 26);
            this.textBoxIDmerma.TabIndex = 28;
            this.textBoxIDmerma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxIDmerma.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxIDmerma_KeyUp);
            // 
            // dataGridViewMermaC
            // 
            this.dataGridViewMermaC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMermaC.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewMermaC.Location = new System.Drawing.Point(0, 88);
            this.dataGridViewMermaC.Name = "dataGridViewMermaC";
            this.dataGridViewMermaC.ReadOnly = true;
            this.dataGridViewMermaC.RowTemplate.Height = 25;
            this.dataGridViewMermaC.Size = new System.Drawing.Size(644, 478);
            this.dataGridViewMermaC.TabIndex = 38;
            // 
            // FormMermaConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(25)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(644, 566);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridViewMermaC);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMermaConsultar";
            this.Text = "FormMermaConsultar";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMermaC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private Label label1;
        private TextBox textBoxIDmerma;
        private DataGridView dataGridViewMermaC;
    }
}