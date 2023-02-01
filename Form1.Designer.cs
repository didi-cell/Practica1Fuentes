namespace Practica1Fuentes
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
            this.labelTexto = new System.Windows.Forms.Label();
            this.bNegrita = new System.Windows.Forms.Button();
            this.bCursiva = new System.Windows.Forms.Button();
            this.bSubrayada = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTexto
            // 
            this.labelTexto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTexto.AutoSize = true;
            this.labelTexto.Location = new System.Drawing.Point(240, 165);
            this.labelTexto.MaximumSize = new System.Drawing.Size(0, 60);
            this.labelTexto.Name = "labelTexto";
            this.labelTexto.Size = new System.Drawing.Size(166, 16);
            this.labelTexto.TabIndex = 0;
            this.labelTexto.Text = "En un lugar de la Mancha...";
            this.labelTexto.Click += new System.EventHandler(this.label1_Click);
            // 
            // bNegrita
            // 
            this.bNegrita.Location = new System.Drawing.Point(136, 217);
            this.bNegrita.Name = "bNegrita";
            this.bNegrita.Size = new System.Drawing.Size(107, 53);
            this.bNegrita.TabIndex = 1;
            this.bNegrita.Text = "Negrita";
            this.bNegrita.UseVisualStyleBackColor = true;
            this.bNegrita.Click += new System.EventHandler(this.bNegrita_Click);
            // 
            // bCursiva
            // 
            this.bCursiva.Location = new System.Drawing.Point(291, 217);
            this.bCursiva.Name = "bCursiva";
            this.bCursiva.Size = new System.Drawing.Size(97, 53);
            this.bCursiva.TabIndex = 2;
            this.bCursiva.Text = "Cursiva";
            this.bCursiva.UseVisualStyleBackColor = true;
            this.bCursiva.Click += new System.EventHandler(this.bCursiva_Click);
            // 
            // bSubrayada
            // 
            this.bSubrayada.Location = new System.Drawing.Point(438, 217);
            this.bSubrayada.Name = "bSubrayada";
            this.bSubrayada.Size = new System.Drawing.Size(99, 53);
            this.bSubrayada.TabIndex = 3;
            this.bSubrayada.Text = "Subrayada";
            this.bSubrayada.UseVisualStyleBackColor = true;
            this.bSubrayada.Click += new System.EventHandler(this.bSubrayada_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bSubrayada);
            this.Controls.Add(this.bCursiva);
            this.Controls.Add(this.bNegrita);
            this.Controls.Add(this.labelTexto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTexto;
        private System.Windows.Forms.Button bNegrita;
        private System.Windows.Forms.Button bCursiva;
        private System.Windows.Forms.Button bSubrayada;
    }
}

