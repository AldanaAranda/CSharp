namespace VueltoCompra
{
    partial class fVuelto
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tCliente = new System.Windows.Forms.TextBox();
            this.tCompra = new System.Windows.Forms.TextBox();
            this.tPago = new System.Windows.Forms.TextBox();
            this.bCalcular = new System.Windows.Forms.Button();
            this.bCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(60, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor de la compra:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(99, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor del pago:";
            // 
            // tCliente
            // 
            this.tCliente.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tCliente.Location = new System.Drawing.Point(255, 89);
            this.tCliente.Name = "tCliente";
            this.tCliente.Size = new System.Drawing.Size(155, 23);
            this.tCliente.TabIndex = 3;
            // 
            // tCompra
            // 
            this.tCompra.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.tCompra.Location = new System.Drawing.Point(255, 137);
            this.tCompra.Name = "tCompra";
            this.tCompra.Size = new System.Drawing.Size(155, 23);
            this.tCompra.TabIndex = 4;
            // 
            // tPago
            // 
            this.tPago.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.tPago.Location = new System.Drawing.Point(255, 182);
            this.tPago.Name = "tPago";
            this.tPago.Size = new System.Drawing.Size(155, 23);
            this.tPago.TabIndex = 5;
            // 
            // bCalcular
            // 
            this.bCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(192)))), ((int)(((byte)(205)))));
            this.bCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bCalcular.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.bCalcular.Location = new System.Drawing.Point(197, 249);
            this.bCalcular.Name = "bCalcular";
            this.bCalcular.Size = new System.Drawing.Size(96, 27);
            this.bCalcular.TabIndex = 6;
            this.bCalcular.Text = "CALCULAR";
            this.bCalcular.UseVisualStyleBackColor = false;
            this.bCalcular.Click += new System.EventHandler(this.bCalcular_Click);
            // 
            // bCerrar
            // 
            this.bCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(192)))), ((int)(((byte)(205)))));
            this.bCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bCerrar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F);
            this.bCerrar.Location = new System.Drawing.Point(413, 314);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(96, 27);
            this.bCerrar.TabIndex = 7;
            this.bCerrar.Text = "CERRAR";
            this.bCerrar.UseVisualStyleBackColor = false;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // fVuelto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(153)))), ((int)(((byte)(148)))));
            this.ClientSize = new System.Drawing.Size(533, 362);
            this.Controls.Add(this.bCerrar);
            this.Controls.Add(this.bCalcular);
            this.Controls.Add(this.tPago);
            this.Controls.Add(this.tCompra);
            this.Controls.Add(this.tCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fVuelto";
            this.Text = "Vuelto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tCliente;
        private System.Windows.Forms.TextBox tCompra;
        private System.Windows.Forms.TextBox tPago;
        private System.Windows.Forms.Button bCalcular;
        private System.Windows.Forms.Button bCerrar;
    }
}

