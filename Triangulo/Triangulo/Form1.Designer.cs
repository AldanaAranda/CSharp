﻿namespace Triangulo
{
    partial class Form1
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
            this.tLadoA = new System.Windows.Forms.TextBox();
            this.tLadoB = new System.Windows.Forms.TextBox();
            this.tLadoC = new System.Windows.Forms.TextBox();
            this.bCalcular = new System.Windows.Forms.Button();
            this.bCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el lado a:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese el lado b:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(117, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingrese el lado c:";
            // 
            // tLadoA
            // 
            this.tLadoA.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tLadoA.Location = new System.Drawing.Point(279, 55);
            this.tLadoA.Name = "tLadoA";
            this.tLadoA.Size = new System.Drawing.Size(213, 26);
            this.tLadoA.TabIndex = 3;
            // 
            // tLadoB
            // 
            this.tLadoB.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tLadoB.Location = new System.Drawing.Point(279, 112);
            this.tLadoB.Name = "tLadoB";
            this.tLadoB.Size = new System.Drawing.Size(213, 26);
            this.tLadoB.TabIndex = 4;
            // 
            // tLadoC
            // 
            this.tLadoC.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tLadoC.Location = new System.Drawing.Point(279, 168);
            this.tLadoC.Name = "tLadoC";
            this.tLadoC.Size = new System.Drawing.Size(213, 26);
            this.tLadoC.TabIndex = 5;
            // 
            // bCalcular
            // 
            this.bCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCalcular.Location = new System.Drawing.Point(254, 246);
            this.bCalcular.Name = "bCalcular";
            this.bCalcular.Size = new System.Drawing.Size(82, 27);
            this.bCalcular.TabIndex = 6;
            this.bCalcular.Text = "Calcular";
            this.bCalcular.UseVisualStyleBackColor = true;
            this.bCalcular.Click += new System.EventHandler(this.bCalcular_Click);
            // 
            // bCerrar
            // 
            this.bCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCerrar.Location = new System.Drawing.Point(506, 373);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(82, 27);
            this.bCerrar.TabIndex = 7;
            this.bCerrar.Text = "Cerrar";
            this.bCerrar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 450);
            this.Controls.Add(this.bCerrar);
            this.Controls.Add(this.bCalcular);
            this.Controls.Add(this.tLadoC);
            this.Controls.Add(this.tLadoB);
            this.Controls.Add(this.tLadoA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tLadoA;
        private System.Windows.Forms.TextBox tLadoB;
        private System.Windows.Forms.TextBox tLadoC;
        private System.Windows.Forms.Button bCalcular;
        private System.Windows.Forms.Button bCerrar;
    }
}

