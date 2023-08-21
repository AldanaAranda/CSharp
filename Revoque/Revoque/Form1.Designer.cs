namespace Revoque
{
    partial class FRevoque
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
            this.tAncho = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tLargo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bCalcular = new System.Windows.Forms.Button();
            this.bCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(731, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calcular cantidad de arena necesaria para revocar una pared:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ancho de la pared:";
            // 
            // tAncho
            // 
            this.tAncho.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tAncho.Location = new System.Drawing.Point(354, 123);
            this.tAncho.Multiline = true;
            this.tAncho.Name = "tAncho";
            this.tAncho.Size = new System.Drawing.Size(148, 28);
            this.tAncho.TabIndex = 2;
            this.tAncho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(519, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Metro/os";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(132, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Largo de la pared:";
            // 
            // tLargo
            // 
            this.tLargo.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tLargo.Location = new System.Drawing.Point(354, 181);
            this.tLargo.Multiline = true;
            this.tLargo.Name = "tLargo";
            this.tLargo.Size = new System.Drawing.Size(148, 28);
            this.tLargo.TabIndex = 5;
            this.tLargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(519, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Metro/os";
            // 
            // bCalcular
            // 
            this.bCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(148)))), ((int)(((byte)(146)))));
            this.bCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bCalcular.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCalcular.Location = new System.Drawing.Point(354, 265);
            this.bCalcular.Name = "bCalcular";
            this.bCalcular.Size = new System.Drawing.Size(108, 31);
            this.bCalcular.TabIndex = 7;
            this.bCalcular.Text = "CALCULAR";
            this.bCalcular.UseVisualStyleBackColor = false;
            this.bCalcular.Click += new System.EventHandler(this.bCalcular_Click);
            // 
            // bCerrar
            // 
            this.bCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(148)))), ((int)(((byte)(146)))));
            this.bCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bCerrar.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCerrar.Location = new System.Drawing.Point(676, 392);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(83, 32);
            this.bCerrar.TabIndex = 8;
            this.bCerrar.Text = "CERRAR";
            this.bCerrar.UseVisualStyleBackColor = false;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // FRevoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(124)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bCerrar);
            this.Controls.Add(this.bCalcular);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tLargo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tAncho);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FRevoque";
            this.Text = "Revoque";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tAncho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tLargo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bCalcular;
        private System.Windows.Forms.Button bCerrar;
    }
}

