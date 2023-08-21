namespace Etiqueta
{
    partial class FEtiqueta
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LEtiqueta = new System.Windows.Forms.Label();
            this.TTexto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudLetra = new System.Windows.Forms.NumericUpDown();
            this.LLetra = new System.Windows.Forms.Label();
            this.BColor = new System.Windows.Forms.Button();
            this.BTamanioMenos = new System.Windows.Forms.Button();
            this.BTamanioMas = new System.Windows.Forms.Button();
            this.BSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudLetra)).BeginInit();
            this.SuspendLayout();
            // 
            // LEtiqueta
            // 
            this.LEtiqueta.AutoSize = true;
            this.LEtiqueta.Font = new System.Drawing.Font("Algerian", 14F);
            this.LEtiqueta.ForeColor = System.Drawing.Color.Black;
            this.LEtiqueta.Location = new System.Drawing.Point(264, 56);
            this.LEtiqueta.Name = "LEtiqueta";
            this.LEtiqueta.Size = new System.Drawing.Size(100, 21);
            this.LEtiqueta.TabIndex = 0;
            this.LEtiqueta.Text = "ETIQUETA";
            this.LEtiqueta.TextChanged += new System.EventHandler(this.TTexto_TextChanged);
            // 
            // TTexto
            // 
            this.TTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TTexto.Location = new System.Drawing.Point(290, 113);
            this.TTexto.MaxLength = 10;
            this.TTexto.Name = "TTexto";
            this.TTexto.Size = new System.Drawing.Size(179, 24);
            this.TTexto.TabIndex = 1;
            this.TTexto.Text = "ETIQUETA";
            this.TTexto.TextChanged += new System.EventHandler(this.TTexto_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Texto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(234, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Letra:";
            // 
            // nudLetra
            // 
            this.nudLetra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudLetra.Location = new System.Drawing.Point(290, 166);
            this.nudLetra.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudLetra.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLetra.Name = "nudLetra";
            this.nudLetra.Size = new System.Drawing.Size(47, 24);
            this.nudLetra.TabIndex = 4;
            this.nudLetra.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLetra.ValueChanged += new System.EventHandler(this.nudLetra_ValueChanged);
            // 
            // LLetra
            // 
            this.LLetra.AutoSize = true;
            this.LLetra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LLetra.Location = new System.Drawing.Point(368, 167);
            this.LLetra.Name = "LLetra";
            this.LLetra.Size = new System.Drawing.Size(67, 20);
            this.LLetra.TabIndex = 5;
            this.LLetra.Text = "Algerian";
            // 
            // BColor
            // 
            this.BColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BColor.Location = new System.Drawing.Point(238, 227);
            this.BColor.Name = "BColor";
            this.BColor.Size = new System.Drawing.Size(233, 32);
            this.BColor.TabIndex = 6;
            this.BColor.Text = "Cambio de &Color";
            this.BColor.UseVisualStyleBackColor = true;
            this.BColor.Click += new System.EventHandler(this.BColor_Click);
            // 
            // BTamanioMenos
            // 
            this.BTamanioMenos.Enabled = false;
            this.BTamanioMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTamanioMenos.Location = new System.Drawing.Point(238, 299);
            this.BTamanioMenos.Name = "BTamanioMenos";
            this.BTamanioMenos.Size = new System.Drawing.Size(101, 32);
            this.BTamanioMenos.TabIndex = 7;
            this.BTamanioMenos.Text = "&< Tamaño";
            this.BTamanioMenos.UseVisualStyleBackColor = true;
            this.BTamanioMenos.Click += new System.EventHandler(this.BTamanioMenos_Click);
            // 
            // BTamanioMas
            // 
            this.BTamanioMas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTamanioMas.Location = new System.Drawing.Point(363, 299);
            this.BTamanioMas.Name = "BTamanioMas";
            this.BTamanioMas.Size = new System.Drawing.Size(106, 32);
            this.BTamanioMas.TabIndex = 8;
            this.BTamanioMas.Text = "&> Tamaño";
            this.BTamanioMas.UseVisualStyleBackColor = true;
            this.BTamanioMas.Click += new System.EventHandler(this.BTamanioMas_Click);
            // 
            // BSalir
            // 
            this.BSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BSalir.Location = new System.Drawing.Point(0, 396);
            this.BSalir.Name = "BSalir";
            this.BSalir.Size = new System.Drawing.Size(711, 32);
            this.BSalir.TabIndex = 9;
            this.BSalir.Text = "&Salir";
            this.BSalir.UseVisualStyleBackColor = true;
            this.BSalir.Visible = false;
            // 
            // FEtiqueta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BSalir;
            this.ClientSize = new System.Drawing.Size(711, 428);
            this.Controls.Add(this.BSalir);
            this.Controls.Add(this.BTamanioMas);
            this.Controls.Add(this.BTamanioMenos);
            this.Controls.Add(this.BColor);
            this.Controls.Add(this.LLetra);
            this.Controls.Add(this.nudLetra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TTexto);
            this.Controls.Add(this.LEtiqueta);
            this.Name = "FEtiqueta";
            this.Text = "Etiqueta";
            ((System.ComponentModel.ISupportInitialize)(this.nudLetra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LEtiqueta;
        private System.Windows.Forms.TextBox TTexto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudLetra;
        private System.Windows.Forms.Label LLetra;
        private System.Windows.Forms.Button BColor;
        private System.Windows.Forms.Button BTamanioMenos;
        private System.Windows.Forms.Button BTamanioMas;
        private System.Windows.Forms.Button BSalir;
    }
}

