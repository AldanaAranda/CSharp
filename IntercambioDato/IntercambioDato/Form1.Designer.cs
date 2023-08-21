namespace IntercambioDato
{
    partial class fIntercambio
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
            this.label1 = new System.Windows.Forms.Label();
            this.tNum1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tNum2 = new System.Windows.Forms.TextBox();
            this.bIntercambiar = new System.Windows.Forms.Button();
            this.bCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese un número:";
            // 
            // tNum1
            // 
            this.tNum1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tNum1.Location = new System.Drawing.Point(270, 96);
            this.tNum1.Name = "tNum1";
            this.tNum1.Size = new System.Drawing.Size(129, 27);
            this.tNum1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese otro número:";
            // 
            // tNum2
            // 
            this.tNum2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tNum2.Location = new System.Drawing.Point(270, 160);
            this.tNum2.Name = "tNum2";
            this.tNum2.Size = new System.Drawing.Size(129, 27);
            this.tNum2.TabIndex = 3;
            // 
            // bIntercambiar
            // 
            this.bIntercambiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(191)))), ((int)(((byte)(161)))));
            this.bIntercambiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bIntercambiar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bIntercambiar.Location = new System.Drawing.Point(192, 225);
            this.bIntercambiar.Name = "bIntercambiar";
            this.bIntercambiar.Size = new System.Drawing.Size(121, 29);
            this.bIntercambiar.TabIndex = 4;
            this.bIntercambiar.Text = "Intercambiar";
            this.bIntercambiar.UseVisualStyleBackColor = false;
            this.bIntercambiar.Click += new System.EventHandler(this.bIntercambiar_Click);
            // 
            // bCerrar
            // 
            this.bCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(191)))), ((int)(((byte)(161)))));
            this.bCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bCerrar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCerrar.Location = new System.Drawing.Point(438, 316);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(70, 27);
            this.bCerrar.TabIndex = 5;
            this.bCerrar.Text = "Cerrar";
            this.bCerrar.UseVisualStyleBackColor = false;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // fIntercambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(152)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(533, 366);
            this.Controls.Add(this.bCerrar);
            this.Controls.Add(this.bIntercambiar);
            this.Controls.Add(this.tNum2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tNum1);
            this.Controls.Add(this.label1);
            this.Name = "fIntercambio";
            this.Text = "Intercambio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tNum1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tNum2;
        private System.Windows.Forms.Button bIntercambiar;
        private System.Windows.Forms.Button bCerrar;
    }
}

