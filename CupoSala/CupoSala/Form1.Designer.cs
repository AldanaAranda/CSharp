namespace CupoSala
{
    partial class FSala
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
            this.tCupo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tCantidad = new System.Windows.Forms.TextBox();
            this.bPorcentaje = new System.Windows.Forms.Button();
            this.bIngreso = new System.Windows.Forms.Button();
            this.bSalida = new System.Windows.Forms.Button();
            this.bCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cupo total de la sala:";
            // 
            // tCupo
            // 
            this.tCupo.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tCupo.Location = new System.Drawing.Point(384, 99);
            this.tCupo.Name = "tCupo";
            this.tCupo.Size = new System.Drawing.Size(166, 26);
            this.tCupo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad de personas actualmente:";
            // 
            // tCantidad
            // 
            this.tCantidad.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tCantidad.Location = new System.Drawing.Point(384, 153);
            this.tCantidad.Name = "tCantidad";
            this.tCantidad.Size = new System.Drawing.Size(166, 26);
            this.tCantidad.TabIndex = 3;
            // 
            // bPorcentaje
            // 
            this.bPorcentaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(212)))), ((int)(((byte)(242)))));
            this.bPorcentaje.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bPorcentaje.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPorcentaje.Location = new System.Drawing.Point(122, 232);
            this.bPorcentaje.Name = "bPorcentaje";
            this.bPorcentaje.Size = new System.Drawing.Size(119, 32);
            this.bPorcentaje.TabIndex = 4;
            this.bPorcentaje.Text = "Porcentaje";
            this.bPorcentaje.UseVisualStyleBackColor = false;
            this.bPorcentaje.Click += new System.EventHandler(this.bPorcentaje_Click);
            // 
            // bIngreso
            // 
            this.bIngreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(212)))), ((int)(((byte)(242)))));
            this.bIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bIngreso.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bIngreso.Location = new System.Drawing.Point(297, 232);
            this.bIngreso.Name = "bIngreso";
            this.bIngreso.Size = new System.Drawing.Size(119, 32);
            this.bIngreso.TabIndex = 5;
            this.bIngreso.Text = "Ingreso";
            this.bIngreso.UseVisualStyleBackColor = false;
            this.bIngreso.Click += new System.EventHandler(this.bIngreso_Click);
            // 
            // bSalida
            // 
            this.bSalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(212)))), ((int)(((byte)(242)))));
            this.bSalida.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bSalida.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSalida.Location = new System.Drawing.Point(465, 232);
            this.bSalida.Name = "bSalida";
            this.bSalida.Size = new System.Drawing.Size(119, 32);
            this.bSalida.TabIndex = 6;
            this.bSalida.Text = "Salida";
            this.bSalida.UseVisualStyleBackColor = false;
            this.bSalida.Click += new System.EventHandler(this.bSalida_Click);
            // 
            // bCerrar
            // 
            this.bCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(212)))), ((int)(((byte)(242)))));
            this.bCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bCerrar.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCerrar.Location = new System.Drawing.Point(586, 352);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(119, 32);
            this.bCerrar.TabIndex = 7;
            this.bCerrar.Text = "Cerrar";
            this.bCerrar.UseVisualStyleBackColor = false;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // FSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(178)))), ((int)(((byte)(188)))));
            this.ClientSize = new System.Drawing.Size(717, 396);
            this.Controls.Add(this.bCerrar);
            this.Controls.Add(this.bSalida);
            this.Controls.Add(this.bIngreso);
            this.Controls.Add(this.bPorcentaje);
            this.Controls.Add(this.tCantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tCupo);
            this.Controls.Add(this.label1);
            this.Name = "FSala";
            this.Text = "Sala";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tCupo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tCantidad;
        private System.Windows.Forms.Button bPorcentaje;
        private System.Windows.Forms.Button bIngreso;
        private System.Windows.Forms.Button bSalida;
        private System.Windows.Forms.Button bCerrar;
    }
}

