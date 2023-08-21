namespace ViajeEnAuto
{
    partial class FViaje
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
            this.tDistancia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tVelocidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bCalcular = new System.Windows.Forms.Button();
            this.bCerrar = new System.Windows.Forms.Button();
            this.tLugar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lugar a viajar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Distancia a recorrer:";
            // 
            // tDistancia
            // 
            this.tDistancia.Font = new System.Drawing.Font("MS Reference Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tDistancia.Location = new System.Drawing.Point(304, 124);
            this.tDistancia.Multiline = true;
            this.tDistancia.Name = "tDistancia";
            this.tDistancia.Size = new System.Drawing.Size(113, 25);
            this.tDistancia.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(423, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kilometros";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(81, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Velocidad del auto:";
            // 
            // tVelocidad
            // 
            this.tVelocidad.Font = new System.Drawing.Font("MS Reference Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tVelocidad.Location = new System.Drawing.Point(304, 184);
            this.tVelocidad.Multiline = true;
            this.tVelocidad.Name = "tVelocidad";
            this.tVelocidad.Size = new System.Drawing.Size(113, 25);
            this.tVelocidad.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(423, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "Km/h";
            // 
            // bCalcular
            // 
            this.bCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(198)))), ((int)(((byte)(234)))));
            this.bCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bCalcular.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCalcular.Location = new System.Drawing.Point(260, 258);
            this.bCalcular.Name = "bCalcular";
            this.bCalcular.Size = new System.Drawing.Size(157, 35);
            this.bCalcular.TabIndex = 8;
            this.bCalcular.Text = "CALCULAR TIEMPO";
            this.bCalcular.UseVisualStyleBackColor = false;
            this.bCalcular.Click += new System.EventHandler(this.bCalcular_Click);
            // 
            // bCerrar
            // 
            this.bCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(198)))), ((int)(((byte)(234)))));
            this.bCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bCerrar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCerrar.Location = new System.Drawing.Point(564, 357);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(89, 28);
            this.bCerrar.TabIndex = 9;
            this.bCerrar.Text = "CERRAR";
            this.bCerrar.UseVisualStyleBackColor = false;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // tLugar
            // 
            this.tLugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tLugar.Location = new System.Drawing.Point(304, 65);
            this.tLugar.Name = "tLugar";
            this.tLugar.Size = new System.Drawing.Size(260, 26);
            this.tLugar.TabIndex = 11;
            // 
            // FViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(125)))), ((int)(((byte)(188)))));
            this.ClientSize = new System.Drawing.Size(685, 406);
            this.Controls.Add(this.tLugar);
            this.Controls.Add(this.bCerrar);
            this.Controls.Add(this.bCalcular);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tVelocidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tDistancia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FViaje";
            this.Text = "Viaje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tDistancia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tVelocidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bCalcular;
        private System.Windows.Forms.Button bCerrar;
        private System.Windows.Forms.TextBox tLugar;
    }
}

