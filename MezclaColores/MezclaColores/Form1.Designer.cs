namespace MezclaColores
{
    partial class FColores
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
            this.BAmarillo = new System.Windows.Forms.Button();
            this.BRojo = new System.Windows.Forms.Button();
            this.BAzul = new System.Windows.Forms.Button();
            this.bCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BAmarillo
            // 
            this.BAmarillo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAmarillo.Location = new System.Drawing.Point(109, 138);
            this.BAmarillo.Name = "BAmarillo";
            this.BAmarillo.Size = new System.Drawing.Size(98, 35);
            this.BAmarillo.TabIndex = 0;
            this.BAmarillo.Text = "&Amarillo";
            this.BAmarillo.UseVisualStyleBackColor = true;
            this.BAmarillo.Click += new System.EventHandler(this.BAmarillo_Click);
            // 
            // BRojo
            // 
            this.BRojo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRojo.Location = new System.Drawing.Point(257, 138);
            this.BRojo.Name = "BRojo";
            this.BRojo.Size = new System.Drawing.Size(98, 35);
            this.BRojo.TabIndex = 1;
            this.BRojo.Text = "&Rojo";
            this.BRojo.UseVisualStyleBackColor = true;
            this.BRojo.Click += new System.EventHandler(this.BRojo_Click);
            // 
            // BAzul
            // 
            this.BAzul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAzul.Location = new System.Drawing.Point(403, 138);
            this.BAzul.Name = "BAzul";
            this.BAzul.Size = new System.Drawing.Size(98, 35);
            this.BAzul.TabIndex = 2;
            this.BAzul.Text = "A&zul";
            this.BAzul.UseVisualStyleBackColor = true;
            this.BAzul.Click += new System.EventHandler(this.BAzul_Click);
            // 
            // bCerrar
            // 
            this.bCerrar.Enabled = false;
            this.bCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCerrar.Location = new System.Drawing.Point(505, 264);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(98, 35);
            this.bCerrar.TabIndex = 3;
            this.bCerrar.Text = "&Cerrar";
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Visible = false;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // FColores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 331);
            this.Controls.Add(this.bCerrar);
            this.Controls.Add(this.BAzul);
            this.Controls.Add(this.BRojo);
            this.Controls.Add(this.BAmarillo);
            this.Name = "FColores";
            this.Text = "Mezcla de Colores";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BAmarillo;
        private System.Windows.Forms.Button BRojo;
        private System.Windows.Forms.Button BAzul;
        private System.Windows.Forms.Button bCerrar;
    }
}

