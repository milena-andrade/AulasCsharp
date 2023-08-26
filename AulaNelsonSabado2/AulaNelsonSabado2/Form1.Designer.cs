
namespace AulaNelsonSabado2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMetros = new System.Windows.Forms.TextBox();
            this.btnQuadrado = new System.Windows.Forms.Button();
            this.btnTriangulo = new System.Windows.Forms.Button();
            this.btnRetangulo = new System.Windows.Forms.Button();
            this.txtArea = new System.Windows.Forms.Label();
            this.txtPerimetro = new System.Windows.Forms.Label();
            this.Base = new System.Windows.Forms.Label();
            this.Altura = new System.Windows.Forms.Label();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o valor do lado em metros quadrados:";
            // 
            // txtMetros
            // 
            this.txtMetros.Location = new System.Drawing.Point(242, 52);
            this.txtMetros.Name = "txtMetros";
            this.txtMetros.Size = new System.Drawing.Size(100, 20);
            this.txtMetros.TabIndex = 1;
            // 
            // btnQuadrado
            // 
            this.btnQuadrado.Location = new System.Drawing.Point(14, 149);
            this.btnQuadrado.Name = "btnQuadrado";
            this.btnQuadrado.Size = new System.Drawing.Size(75, 23);
            this.btnQuadrado.TabIndex = 2;
            this.btnQuadrado.Text = "Quadrado";
            this.btnQuadrado.UseVisualStyleBackColor = true;
            this.btnQuadrado.Click += new System.EventHandler(this.btnQuadrado_Click);
            // 
            // btnTriangulo
            // 
            this.btnTriangulo.Location = new System.Drawing.Point(127, 149);
            this.btnTriangulo.Name = "btnTriangulo";
            this.btnTriangulo.Size = new System.Drawing.Size(75, 23);
            this.btnTriangulo.TabIndex = 3;
            this.btnTriangulo.Text = "Triangulo";
            this.btnTriangulo.UseVisualStyleBackColor = true;
            this.btnTriangulo.Click += new System.EventHandler(this.btnTriangulo_Click);
            // 
            // btnRetangulo
            // 
            this.btnRetangulo.Location = new System.Drawing.Point(238, 152);
            this.btnRetangulo.Name = "btnRetangulo";
            this.btnRetangulo.Size = new System.Drawing.Size(75, 23);
            this.btnRetangulo.TabIndex = 4;
            this.btnRetangulo.Text = "Retangulo";
            this.btnRetangulo.UseVisualStyleBackColor = true;
            this.btnRetangulo.Click += new System.EventHandler(this.btnRetangulo_Click);
            // 
            // txtArea
            // 
            this.txtArea.AutoSize = true;
            this.txtArea.Location = new System.Drawing.Point(14, 205);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(29, 13);
            this.txtArea.TabIndex = 5;
            this.txtArea.Text = "Area";
            // 
            // txtPerimetro
            // 
            this.txtPerimetro.AutoSize = true;
            this.txtPerimetro.Location = new System.Drawing.Point(14, 234);
            this.txtPerimetro.Name = "txtPerimetro";
            this.txtPerimetro.Size = new System.Drawing.Size(51, 13);
            this.txtPerimetro.TabIndex = 6;
            this.txtPerimetro.Text = "Perimetro";
            // 
            // Base
            // 
            this.Base.AutoSize = true;
            this.Base.Location = new System.Drawing.Point(24, 78);
            this.Base.Name = "Base";
            this.Base.Size = new System.Drawing.Size(31, 13);
            this.Base.TabIndex = 7;
            this.Base.Text = "Base";
            // 
            // Altura
            // 
            this.Altura.AutoSize = true;
            this.Altura.Location = new System.Drawing.Point(26, 107);
            this.Altura.Name = "Altura";
            this.Altura.Size = new System.Drawing.Size(34, 13);
            this.Altura.TabIndex = 8;
            this.Altura.Text = "Altura";
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(66, 78);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(100, 20);
            this.txtBase.TabIndex = 9;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(66, 104);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 20);
            this.txtAltura.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.Altura);
            this.Controls.Add(this.Base);
            this.Controls.Add(this.txtPerimetro);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.btnRetangulo);
            this.Controls.Add(this.btnTriangulo);
            this.Controls.Add(this.btnQuadrado);
            this.Controls.Add(this.txtMetros);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMetros;
        private System.Windows.Forms.Button btnQuadrado;
        private System.Windows.Forms.Button btnTriangulo;
        private System.Windows.Forms.Button btnRetangulo;
        private System.Windows.Forms.Label txtArea;
        private System.Windows.Forms.Label txtPerimetro;
        private System.Windows.Forms.Label Base;
        private System.Windows.Forms.Label Altura;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.TextBox txtAltura;
    }
}

