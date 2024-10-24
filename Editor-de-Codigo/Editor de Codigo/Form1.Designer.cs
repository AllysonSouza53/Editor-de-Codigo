namespace Editor_de_Codigo
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Texto = new System.Windows.Forms.TextBox();
            this.Exercutar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Texto
            // 
            this.Texto.Location = new System.Drawing.Point(154, 63);
            this.Texto.Multiline = true;
            this.Texto.Name = "Texto";
            this.Texto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Texto.Size = new System.Drawing.Size(634, 375);
            this.Texto.TabIndex = 0;
            // 
            // Exercutar
            // 
            this.Exercutar.Location = new System.Drawing.Point(29, 415);
            this.Exercutar.Name = "Exercutar";
            this.Exercutar.Size = new System.Drawing.Size(75, 23);
            this.Exercutar.TabIndex = 1;
            this.Exercutar.Text = "Executar";
            this.Exercutar.UseVisualStyleBackColor = true;
            this.Exercutar.Click += new System.EventHandler(this.Exercutar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exercutar);
            this.Controls.Add(this.Texto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Texto;
        private System.Windows.Forms.Button Exercutar;
        private System.Windows.Forms.Label label1;
    }
}

