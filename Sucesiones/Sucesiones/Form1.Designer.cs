namespace Sucesiones
{
    partial class FSucesiones
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
            this.nudTabla = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudFibonacci = new System.Windows.Forms.NumericUpDown();
            this.BFibonacci = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.nudDesde = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudHasta = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nudCada = new System.Windows.Forms.NumericUpDown();
            this.bSerie = new System.Windows.Forms.Button();
            this.bCerrar = new System.Windows.Forms.Button();
            this.BTablaMultiplicar = new System.Windows.Forms.Button();
            this.LRespuesta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudTabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFibonacci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDesde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCada)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tabla del";
            // 
            // nudTabla
            // 
            this.nudTabla.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTabla.Location = new System.Drawing.Point(231, 53);
            this.nudTabla.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudTabla.Name = "nudTabla";
            this.nudTabla.Size = new System.Drawing.Size(49, 24);
            this.nudTabla.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(126, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Fibonacci de";
            // 
            // nudFibonacci
            // 
            this.nudFibonacci.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudFibonacci.Location = new System.Drawing.Point(231, 145);
            this.nudFibonacci.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudFibonacci.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudFibonacci.Name = "nudFibonacci";
            this.nudFibonacci.Size = new System.Drawing.Size(49, 24);
            this.nudFibonacci.TabIndex = 2;
            this.nudFibonacci.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // BFibonacci
            // 
            this.BFibonacci.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BFibonacci.Location = new System.Drawing.Point(130, 187);
            this.BFibonacci.Name = "BFibonacci";
            this.BFibonacci.Size = new System.Drawing.Size(150, 28);
            this.BFibonacci.TabIndex = 3;
            this.BFibonacci.Text = "&Fibonacci";
            this.BFibonacci.UseVisualStyleBackColor = true;
            this.BFibonacci.Click += new System.EventHandler(this.BFibonacci_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(165, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Desde:";
            // 
            // nudDesde
            // 
            this.nudDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDesde.Location = new System.Drawing.Point(231, 240);
            this.nudDesde.Name = "nudDesde";
            this.nudDesde.Size = new System.Drawing.Size(49, 24);
            this.nudDesde.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(169, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Hasta:";
            // 
            // nudHasta
            // 
            this.nudHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudHasta.Location = new System.Drawing.Point(231, 282);
            this.nudHasta.Name = "nudHasta";
            this.nudHasta.Size = new System.Drawing.Size(49, 24);
            this.nudHasta.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(174, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Cada:";
            // 
            // nudCada
            // 
            this.nudCada.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCada.Location = new System.Drawing.Point(231, 327);
            this.nudCada.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCada.Name = "nudCada";
            this.nudCada.Size = new System.Drawing.Size(49, 24);
            this.nudCada.TabIndex = 6;
            this.nudCada.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bSerie
            // 
            this.bSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSerie.Location = new System.Drawing.Point(130, 378);
            this.bSerie.Name = "bSerie";
            this.bSerie.Size = new System.Drawing.Size(150, 28);
            this.bSerie.TabIndex = 7;
            this.bSerie.Text = "&Serie";
            this.bSerie.UseVisualStyleBackColor = true;
            this.bSerie.Click += new System.EventHandler(this.bSerie_Click);
            // 
            // bCerrar
            // 
            this.bCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCerrar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCerrar.Location = new System.Drawing.Point(0, 490);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(666, 28);
            this.bCerrar.TabIndex = 8;
            this.bCerrar.Text = "&Cerrar";
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // BTablaMultiplicar
            // 
            this.BTablaMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTablaMultiplicar.Location = new System.Drawing.Point(130, 99);
            this.BTablaMultiplicar.Name = "BTablaMultiplicar";
            this.BTablaMultiplicar.Size = new System.Drawing.Size(150, 28);
            this.BTablaMultiplicar.TabIndex = 16;
            this.BTablaMultiplicar.Text = "&Tabla de multiplicar";
            this.BTablaMultiplicar.UseVisualStyleBackColor = true;
            this.BTablaMultiplicar.Click += new System.EventHandler(this.BTablaMultiplicar_Click);
            // 
            // LRespuesta
            // 
            this.LRespuesta.AutoSize = true;
            this.LRespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRespuesta.Location = new System.Drawing.Point(386, 53);
            this.LRespuesta.Name = "LRespuesta";
            this.LRespuesta.Size = new System.Drawing.Size(0, 20);
            this.LRespuesta.TabIndex = 9;
            this.LRespuesta.Click += new System.EventHandler(this.LRespuesta_Click);
            // 
            // FSucesiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 518);
            this.Controls.Add(this.BTablaMultiplicar);
            this.Controls.Add(this.LRespuesta);
            this.Controls.Add(this.bCerrar);
            this.Controls.Add(this.bSerie);
            this.Controls.Add(this.nudCada);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudHasta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudDesde);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BFibonacci);
            this.Controls.Add(this.nudFibonacci);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudTabla);
            this.Controls.Add(this.label1);
            this.Name = "FSucesiones";
            this.Text = "Sucesiones";
            ((System.ComponentModel.ISupportInitialize)(this.nudTabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFibonacci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDesde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudTabla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudFibonacci;
        private System.Windows.Forms.Button BFibonacci;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudDesde;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudHasta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudCada;
        private System.Windows.Forms.Button bSerie;
        private System.Windows.Forms.Button bCerrar;
        private System.Windows.Forms.Button BTablaMultiplicar;
        private System.Windows.Forms.Label LRespuesta;
    }
}

