namespace ProyectoParcialProductos.UI.Consultas
{
    partial class ConsultaInventario
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
            this.TotalInventarioConsultatextBox = new System.Windows.Forms.TextBox();
            this.Refrescarbutton = new System.Windows.Forms.Button();
            this.IDnumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // TotalInventarioConsultatextBox
            // 
            this.TotalInventarioConsultatextBox.Enabled = false;
            this.TotalInventarioConsultatextBox.Location = new System.Drawing.Point(67, 42);
            this.TotalInventarioConsultatextBox.Name = "TotalInventarioConsultatextBox";
            this.TotalInventarioConsultatextBox.Size = new System.Drawing.Size(100, 20);
            this.TotalInventarioConsultatextBox.TabIndex = 0;
            // 
            // Refrescarbutton
            // 
            this.Refrescarbutton.Location = new System.Drawing.Point(83, 88);
            this.Refrescarbutton.Name = "Refrescarbutton";
            this.Refrescarbutton.Size = new System.Drawing.Size(63, 23);
            this.Refrescarbutton.TabIndex = 1;
            this.Refrescarbutton.Text = "Refrescar";
            this.Refrescarbutton.UseVisualStyleBackColor = true;
            this.Refrescarbutton.Click += new System.EventHandler(this.Refrescarbutton_Click);
            // 
            // IDnumericUpDown
            // 
            this.IDnumericUpDown.Enabled = false;
            this.IDnumericUpDown.Location = new System.Drawing.Point(67, 12);
            this.IDnumericUpDown.Name = "IDnumericUpDown";
            this.IDnumericUpDown.Size = new System.Drawing.Size(42, 20);
            this.IDnumericUpDown.TabIndex = 2;
            // 
            // ConsultaInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 123);
            this.Controls.Add(this.IDnumericUpDown);
            this.Controls.Add(this.Refrescarbutton);
            this.Controls.Add(this.TotalInventarioConsultatextBox);
            this.Name = "ConsultaInventario";
            this.Text = "Consulta de inventario";
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Refrescarbutton;
        public System.Windows.Forms.TextBox TotalInventarioConsultatextBox;
        private System.Windows.Forms.NumericUpDown IDnumericUpDown;
    }
}