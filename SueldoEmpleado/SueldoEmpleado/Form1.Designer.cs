namespace SueldoEmpleado
{
    partial class FEmpleado
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
            this.tEmpleado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tAnio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tTarifa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tHoras = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tDias = new System.Windows.Forms.TextBox();
            this.bSalario = new System.Windows.Forms.Button();
            this.bCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del empleado:";
            // 
            // tEmpleado
            // 
            this.tEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tEmpleado.Location = new System.Drawing.Point(322, 75);
            this.tEmpleado.Name = "tEmpleado";
            this.tEmpleado.Size = new System.Drawing.Size(228, 26);
            this.tEmpleado.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(162, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Año de ingreso:";
            // 
            // tAnio
            // 
            this.tAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tAnio.Location = new System.Drawing.Point(322, 124);
            this.tAnio.Name = "tAnio";
            this.tAnio.Size = new System.Drawing.Size(156, 26);
            this.tAnio.TabIndex = 3;
            this.tAnio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(175, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tarifa horaria:";
            // 
            // tTarifa
            // 
            this.tTarifa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tTarifa.Location = new System.Drawing.Point(322, 170);
            this.tTarifa.Name = "tTarifa";
            this.tTarifa.Size = new System.Drawing.Size(156, 26);
            this.tTarifa.TabIndex = 5;
            this.tTarifa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Horas trabajadas por dia:";
            // 
            // tHoras
            // 
            this.tHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tHoras.Location = new System.Drawing.Point(322, 221);
            this.tHoras.Name = "tHoras";
            this.tHoras.Size = new System.Drawing.Size(156, 26);
            this.tHoras.TabIndex = 7;
            this.tHoras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(74, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(242, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Dias trabajados por mes:";
            // 
            // tDias
            // 
            this.tDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tDias.Location = new System.Drawing.Point(322, 271);
            this.tDias.Name = "tDias";
            this.tDias.Size = new System.Drawing.Size(156, 26);
            this.tDias.TabIndex = 9;
            this.tDias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bSalario
            // 
            this.bSalario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(183)))), ((int)(((byte)(174)))));
            this.bSalario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bSalario.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSalario.Location = new System.Drawing.Point(240, 332);
            this.bSalario.Name = "bSalario";
            this.bSalario.Size = new System.Drawing.Size(128, 29);
            this.bSalario.TabIndex = 10;
            this.bSalario.Text = "Calcular salario";
            this.bSalario.UseVisualStyleBackColor = false;
            this.bSalario.Click += new System.EventHandler(this.bSalario_Click);
            // 
            // bCerrar
            // 
            this.bCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(183)))), ((int)(((byte)(174)))));
            this.bCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bCerrar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCerrar.Location = new System.Drawing.Point(540, 371);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(75, 28);
            this.bCerrar.TabIndex = 11;
            this.bCerrar.Text = "Cerrar";
            this.bCerrar.UseVisualStyleBackColor = false;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // FEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(128)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(644, 421);
            this.Controls.Add(this.bCerrar);
            this.Controls.Add(this.bSalario);
            this.Controls.Add(this.tDias);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tHoras);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tTarifa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tAnio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tEmpleado);
            this.Controls.Add(this.label1);
            this.Name = "FEmpleado";
            this.Text = "Empleado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tEmpleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tAnio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tTarifa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tHoras;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tDias;
        private System.Windows.Forms.Button bSalario;
        private System.Windows.Forms.Button bCerrar;
    }
}

