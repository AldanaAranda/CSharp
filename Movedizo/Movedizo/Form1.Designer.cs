namespace Movedizo
{
    partial class FMovedizo
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
            this.lTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lTitulo
            // 
            this.lTitulo.AutoSize = true;
            this.lTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitulo.Location = new System.Drawing.Point(116, 91);
            this.lTitulo.Name = "lTitulo";
            this.lTitulo.Size = new System.Drawing.Size(50, 20);
            this.lTitulo.TabIndex = 0;
            this.lTitulo.Text = "GRIS";
            // 
            // FMovedizo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(284, 211);
            this.Controls.Add(this.lTitulo);
            this.Name = "FMovedizo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movedizo";
            this.Click += new System.EventHandler(this.FMovedizo_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTitulo;
    }
}

