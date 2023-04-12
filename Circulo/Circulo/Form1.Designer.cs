namespace Circulo
{
    partial class fCirculo
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
            this.label4 = new System.Windows.Forms.Label();
            this.tCentimetros = new System.Windows.Forms.TextBox();
            this.tMetros = new System.Windows.Forms.TextBox();
            this.tKilometros = new System.Windows.Forms.TextBox();
            this.bArea = new System.Windows.Forms.Button();
            this.bPerimetro = new System.Windows.Forms.Button();
            this.bCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el radio del circulo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(409, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Centimetros";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(409, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Metros";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(409, 209);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kilometros";
            // 
            // tCentimetros
            // 
            this.tCentimetros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tCentimetros.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tCentimetros.Location = new System.Drawing.Point(232, 96);
            this.tCentimetros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tCentimetros.Multiline = true;
            this.tCentimetros.Name = "tCentimetros";
            this.tCentimetros.Size = new System.Drawing.Size(159, 36);
            this.tCentimetros.TabIndex = 4;
            this.tCentimetros.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tMetros
            // 
            this.tMetros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tMetros.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tMetros.Location = new System.Drawing.Point(232, 153);
            this.tMetros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tMetros.Multiline = true;
            this.tMetros.Name = "tMetros";
            this.tMetros.Size = new System.Drawing.Size(159, 36);
            this.tMetros.TabIndex = 5;
            this.tMetros.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tKilometros
            // 
            this.tKilometros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tKilometros.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tKilometros.Location = new System.Drawing.Point(232, 209);
            this.tKilometros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tKilometros.Multiline = true;
            this.tKilometros.Name = "tKilometros";
            this.tKilometros.Size = new System.Drawing.Size(159, 36);
            this.tKilometros.TabIndex = 6;
            this.tKilometros.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bArea
            // 
            this.bArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(195)))));
            this.bArea.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bArea.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bArea.Location = new System.Drawing.Point(151, 284);
            this.bArea.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bArea.Name = "bArea";
            this.bArea.Size = new System.Drawing.Size(173, 37);
            this.bArea.TabIndex = 7;
            this.bArea.Text = "CALCULAR AREA";
            this.bArea.UseVisualStyleBackColor = false;
            this.bArea.Click += new System.EventHandler(this.bArea_Click);
            // 
            // bPerimetro
            // 
            this.bPerimetro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(195)))));
            this.bPerimetro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bPerimetro.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPerimetro.ForeColor = System.Drawing.Color.Black;
            this.bPerimetro.Location = new System.Drawing.Point(393, 284);
            this.bPerimetro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bPerimetro.Name = "bPerimetro";
            this.bPerimetro.Size = new System.Drawing.Size(223, 37);
            this.bPerimetro.TabIndex = 8;
            this.bPerimetro.Text = "CALCULAR PERIMETRO";
            this.bPerimetro.UseVisualStyleBackColor = false;
            this.bPerimetro.Click += new System.EventHandler(this.bPerimetro_Click);
            // 
            // bCerrar
            // 
            this.bCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(225)))), ((int)(((byte)(195)))));
            this.bCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bCerrar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCerrar.Location = new System.Drawing.Point(655, 362);
            this.bCerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(100, 37);
            this.bCerrar.TabIndex = 9;
            this.bCerrar.Text = "CERRAR";
            this.bCerrar.UseVisualStyleBackColor = false;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // fCirculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(157)))), ((int)(((byte)(122)))));
            this.ClientSize = new System.Drawing.Size(791, 425);
            this.Controls.Add(this.bCerrar);
            this.Controls.Add(this.bPerimetro);
            this.Controls.Add(this.bArea);
            this.Controls.Add(this.tKilometros);
            this.Controls.Add(this.tMetros);
            this.Controls.Add(this.tCentimetros);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fCirculo";
            this.Text = "Circulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tCentimetros;
        private System.Windows.Forms.TextBox tMetros;
        private System.Windows.Forms.TextBox tKilometros;
        private System.Windows.Forms.Button bArea;
        private System.Windows.Forms.Button bPerimetro;
        private System.Windows.Forms.Button bCerrar;
    }
}

