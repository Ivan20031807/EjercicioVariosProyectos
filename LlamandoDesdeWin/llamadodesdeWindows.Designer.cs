namespace LlamandoDesdeWin
{
    partial class FrmLlamadodesdeWindows
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
            this.lblprimernumero = new System.Windows.Forms.Label();
            this.lblsegundonumero = new System.Windows.Forms.Label();
            this.lblnumerofactorial = new System.Windows.Forms.Label();
            this.txtsumarnumero = new System.Windows.Forms.TextBox();
            this.txtssegundonumero = new System.Windows.Forms.TextBox();
            this.txtfactorial = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.lblresultados = new System.Windows.Forms.Label();
            this.lblsuma = new System.Windows.Forms.Label();
            this.lblfactorial = new System.Windows.Forms.Label();
            this.txtsumaresultado = new System.Windows.Forms.TextBox();
            this.txtfactorialresultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblprimernumero
            // 
            this.lblprimernumero.AutoSize = true;
            this.lblprimernumero.Location = new System.Drawing.Point(33, 26);
            this.lblprimernumero.Name = "lblprimernumero";
            this.lblprimernumero.Size = new System.Drawing.Size(162, 13);
            this.lblprimernumero.TabIndex = 0;
            this.lblprimernumero.Text = "Ingrese el primer número a sumar";
            // 
            // lblsegundonumero
            // 
            this.lblsegundonumero.AutoSize = true;
            this.lblsegundonumero.Location = new System.Drawing.Point(33, 57);
            this.lblsegundonumero.Name = "lblsegundonumero";
            this.lblsegundonumero.Size = new System.Drawing.Size(175, 13);
            this.lblsegundonumero.TabIndex = 1;
            this.lblsegundonumero.Text = "Ingrese el segundo número a sumar";
            // 
            // lblnumerofactorial
            // 
            this.lblnumerofactorial.AutoSize = true;
            this.lblnumerofactorial.Location = new System.Drawing.Point(33, 83);
            this.lblnumerofactorial.Name = "lblnumerofactorial";
            this.lblnumerofactorial.Size = new System.Drawing.Size(141, 13);
            this.lblnumerofactorial.TabIndex = 2;
            this.lblnumerofactorial.Text = "Ingrese el número a factoriar";
            // 
            // txtsumarnumero
            // 
            this.txtsumarnumero.Location = new System.Drawing.Point(264, 19);
            this.txtsumarnumero.Name = "txtsumarnumero";
            this.txtsumarnumero.Size = new System.Drawing.Size(100, 20);
            this.txtsumarnumero.TabIndex = 3;
            // 
            // txtssegundonumero
            // 
            this.txtssegundonumero.Location = new System.Drawing.Point(264, 54);
            this.txtssegundonumero.Name = "txtssegundonumero";
            this.txtssegundonumero.Size = new System.Drawing.Size(100, 20);
            this.txtssegundonumero.TabIndex = 4;
            // 
            // txtfactorial
            // 
            this.txtfactorial.Location = new System.Drawing.Point(264, 83);
            this.txtfactorial.Name = "txtfactorial";
            this.txtfactorial.Size = new System.Drawing.Size(100, 20);
            this.txtfactorial.TabIndex = 5;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(251, 123);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(133, 34);
            this.btncalcular.TabIndex = 6;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // lblresultados
            // 
            this.lblresultados.AutoSize = true;
            this.lblresultados.Location = new System.Drawing.Point(33, 211);
            this.lblresultados.Name = "lblresultados";
            this.lblresultados.Size = new System.Drawing.Size(60, 13);
            this.lblresultados.TabIndex = 7;
            this.lblresultados.Text = "Resultados";
            // 
            // lblsuma
            // 
            this.lblsuma.AutoSize = true;
            this.lblsuma.Location = new System.Drawing.Point(33, 252);
            this.lblsuma.Name = "lblsuma";
            this.lblsuma.Size = new System.Drawing.Size(34, 13);
            this.lblsuma.TabIndex = 8;
            this.lblsuma.Text = "Suma";
            // 
            // lblfactorial
            // 
            this.lblfactorial.AutoSize = true;
            this.lblfactorial.Location = new System.Drawing.Point(33, 286);
            this.lblfactorial.Name = "lblfactorial";
            this.lblfactorial.Size = new System.Drawing.Size(47, 13);
            this.lblfactorial.TabIndex = 9;
            this.lblfactorial.Text = "Factorial";
            // 
            // txtsumaresultado
            // 
            this.txtsumaresultado.Location = new System.Drawing.Point(127, 249);
            this.txtsumaresultado.Name = "txtsumaresultado";
            this.txtsumaresultado.Size = new System.Drawing.Size(100, 20);
            this.txtsumaresultado.TabIndex = 10;
            // 
            // txtfactorialresultado
            // 
            this.txtfactorialresultado.Location = new System.Drawing.Point(127, 286);
            this.txtfactorialresultado.Name = "txtfactorialresultado";
            this.txtfactorialresultado.Size = new System.Drawing.Size(100, 20);
            this.txtfactorialresultado.TabIndex = 11;
            // 
            // FrmLlamadodesdeWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtfactorialresultado);
            this.Controls.Add(this.txtsumaresultado);
            this.Controls.Add(this.lblfactorial);
            this.Controls.Add(this.lblsuma);
            this.Controls.Add(this.lblresultados);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtfactorial);
            this.Controls.Add(this.txtssegundonumero);
            this.Controls.Add(this.txtsumarnumero);
            this.Controls.Add(this.lblnumerofactorial);
            this.Controls.Add(this.lblsegundonumero);
            this.Controls.Add(this.lblprimernumero);
            this.Name = "FrmLlamadodesdeWindows";
            this.Text = "Ejercicio de Tarea";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblprimernumero;
        private System.Windows.Forms.Label lblsegundonumero;
        private System.Windows.Forms.Label lblnumerofactorial;
        private System.Windows.Forms.TextBox txtsumarnumero;
        private System.Windows.Forms.TextBox txtssegundonumero;
        private System.Windows.Forms.TextBox txtfactorial;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label lblresultados;
        private System.Windows.Forms.Label lblsuma;
        private System.Windows.Forms.Label lblfactorial;
        private System.Windows.Forms.TextBox txtsumaresultado;
        private System.Windows.Forms.TextBox txtfactorialresultado;
    }
}

