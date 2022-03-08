
namespace wLineas
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
            this.txtxInicial = new System.Windows.Forms.TextBox();
            this.txtxFinal = new System.Windows.Forms.TextBox();
            this.txtyInicial = new System.Windows.Forms.TextBox();
            this.txtyFinal = new System.Windows.Forms.TextBox();
            this.xInicial = new System.Windows.Forms.Label();
            this.xFinal = new System.Windows.Forms.Label();
            this.yInicial = new System.Windows.Forms.Label();
            this.yFinal = new System.Windows.Forms.Label();
            this.numeroLineas = new System.Windows.Forms.Label();
            this.txtcantidadLineas = new System.Windows.Forms.TextBox();
            this.btndibujarLineas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtxInicial
            // 
            this.txtxInicial.Location = new System.Drawing.Point(138, 123);
            this.txtxInicial.Name = "txtxInicial";
            this.txtxInicial.Size = new System.Drawing.Size(100, 20);
            this.txtxInicial.TabIndex = 1;
            // 
            // txtxFinal
            // 
            this.txtxFinal.Location = new System.Drawing.Point(138, 180);
            this.txtxFinal.Name = "txtxFinal";
            this.txtxFinal.Size = new System.Drawing.Size(100, 20);
            this.txtxFinal.TabIndex = 2;
            // 
            // txtyInicial
            // 
            this.txtyInicial.Location = new System.Drawing.Point(406, 123);
            this.txtyInicial.Name = "txtyInicial";
            this.txtyInicial.Size = new System.Drawing.Size(100, 20);
            this.txtyInicial.TabIndex = 3;
            // 
            // txtyFinal
            // 
            this.txtyFinal.Location = new System.Drawing.Point(406, 180);
            this.txtyFinal.Name = "txtyFinal";
            this.txtyFinal.Size = new System.Drawing.Size(100, 20);
            this.txtyFinal.TabIndex = 4;
            // 
            // xInicial
            // 
            this.xInicial.AutoSize = true;
            this.xInicial.Location = new System.Drawing.Point(70, 123);
            this.xInicial.Name = "xInicial";
            this.xInicial.Size = new System.Drawing.Size(43, 13);
            this.xInicial.TabIndex = 5;
            this.xInicial.Text = "X inicial";
            // 
            // xFinal
            // 
            this.xFinal.AutoSize = true;
            this.xFinal.Location = new System.Drawing.Point(70, 180);
            this.xFinal.Name = "xFinal";
            this.xFinal.Size = new System.Drawing.Size(36, 13);
            this.xFinal.TabIndex = 6;
            this.xFinal.Text = "X final";
            // 
            // yInicial
            // 
            this.yInicial.AutoSize = true;
            this.yInicial.Location = new System.Drawing.Point(346, 126);
            this.yInicial.Name = "yInicial";
            this.yInicial.Size = new System.Drawing.Size(43, 13);
            this.yInicial.TabIndex = 7;
            this.yInicial.Text = "Y inicial";
            // 
            // yFinal
            // 
            this.yFinal.AutoSize = true;
            this.yFinal.Location = new System.Drawing.Point(346, 183);
            this.yFinal.Name = "yFinal";
            this.yFinal.Size = new System.Drawing.Size(36, 13);
            this.yFinal.TabIndex = 8;
            this.yFinal.Text = "Y final";
            // 
            // numeroLineas
            // 
            this.numeroLineas.AutoSize = true;
            this.numeroLineas.Location = new System.Drawing.Point(378, 286);
            this.numeroLineas.Name = "numeroLineas";
            this.numeroLineas.Size = new System.Drawing.Size(98, 13);
            this.numeroLineas.TabIndex = 9;
            this.numeroLineas.Text = "Cantidad de Lineas";
            // 
            // txtcantidadLineas
            // 
            this.txtcantidadLineas.Location = new System.Drawing.Point(371, 317);
            this.txtcantidadLineas.Name = "txtcantidadLineas";
            this.txtcantidadLineas.Size = new System.Drawing.Size(100, 20);
            this.txtcantidadLineas.TabIndex = 10;
            // 
            // btndibujarLineas
            // 
            this.btndibujarLineas.Location = new System.Drawing.Point(138, 305);
            this.btndibujarLineas.Name = "btndibujarLineas";
            this.btndibujarLineas.Size = new System.Drawing.Size(92, 32);
            this.btndibujarLineas.TabIndex = 0;
            this.btndibujarLineas.Text = "Dibujar Lineas";
            this.btndibujarLineas.UseVisualStyleBackColor = true;
            this.btndibujarLineas.Click += new System.EventHandler(this.btndibujarLineas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(695, 450);
            this.Controls.Add(this.txtcantidadLineas);
            this.Controls.Add(this.numeroLineas);
            this.Controls.Add(this.yFinal);
            this.Controls.Add(this.yInicial);
            this.Controls.Add(this.xFinal);
            this.Controls.Add(this.xInicial);
            this.Controls.Add(this.txtyFinal);
            this.Controls.Add(this.txtyInicial);
            this.Controls.Add(this.txtxFinal);
            this.Controls.Add(this.txtxInicial);
            this.Controls.Add(this.btndibujarLineas);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Name = "Form1";
            this.Text = "Dibujar Lineas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtxInicial;
        private System.Windows.Forms.TextBox txtxFinal;
        private System.Windows.Forms.TextBox txtyInicial;
        private System.Windows.Forms.TextBox txtyFinal;
        private System.Windows.Forms.Label xInicial;
        private System.Windows.Forms.Label xFinal;
        private System.Windows.Forms.Label yInicial;
        private System.Windows.Forms.Label yFinal;
        private System.Windows.Forms.Label numeroLineas;
        private System.Windows.Forms.TextBox txtcantidadLineas;
        private System.Windows.Forms.Button btndibujarLineas;
    }
}

