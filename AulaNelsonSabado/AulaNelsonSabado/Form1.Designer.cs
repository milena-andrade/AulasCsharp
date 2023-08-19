
namespace AulaNelsonSabado
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
            this.labelSalario = new System.Windows.Forms.Label();
            this.labelHora = new System.Windows.Forms.Label();
            this.labelSalarioTotalMen = new System.Windows.Forms.Label();
            this.labelAulasSemanais = new System.Windows.Forms.Label();
            this.labelHoraAula = new System.Windows.Forms.Label();
            this.labelSalarioBase = new System.Windows.Forms.Label();
            this.labelHoraAtividade = new System.Windows.Forms.Label();
            this.labelDSR = new System.Windows.Forms.Label();
            this.labelSalarioTotalAul = new System.Windows.Forms.Label();
            this.buttonCalcularMensalista = new System.Windows.Forms.Button();
            this.buttonCalcularAulista = new System.Windows.Forms.Button();
            this.textBoxSalarioMes = new System.Windows.Forms.TextBox();
            this.textBoxHoraAtividade = new System.Windows.Forms.TextBox();
            this.textBoxNAulaSemanais = new System.Windows.Forms.TextBox();
            this.textBoxValorHoraAula = new System.Windows.Forms.TextBox();
            this.textBoxDSR = new System.Windows.Forms.TextBox();
            this.textBoxHoraAtividadeAulista = new System.Windows.Forms.TextBox();
            this.textBoxSalarioBase = new System.Windows.Forms.TextBox();
            this.textBoxSalarioTotalMes = new System.Windows.Forms.TextBox();
            this.textBoxSalarioTotalAulista = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSalario
            // 
            this.labelSalario.AutoSize = true;
            this.labelSalario.Location = new System.Drawing.Point(24, 21);
            this.labelSalario.Name = "labelSalario";
            this.labelSalario.Size = new System.Drawing.Size(39, 13);
            this.labelSalario.TabIndex = 0;
            this.labelSalario.Text = "Salário";
            this.labelSalario.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.Location = new System.Drawing.Point(144, 21);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(76, 13);
            this.labelHora.TabIndex = 1;
            this.labelHora.Text = "Hora-atividade";
            // 
            // labelSalarioTotalMen
            // 
            this.labelSalarioTotalMen.AutoSize = true;
            this.labelSalarioTotalMen.Location = new System.Drawing.Point(144, 71);
            this.labelSalarioTotalMen.Name = "labelSalarioTotalMen";
            this.labelSalarioTotalMen.Size = new System.Drawing.Size(62, 13);
            this.labelSalarioTotalMen.TabIndex = 2;
            this.labelSalarioTotalMen.Text = "Salário total";
            // 
            // labelAulasSemanais
            // 
            this.labelAulasSemanais.AutoSize = true;
            this.labelAulasSemanais.Location = new System.Drawing.Point(9, 21);
            this.labelAulasSemanais.Name = "labelAulasSemanais";
            this.labelAulasSemanais.Size = new System.Drawing.Size(109, 13);
            this.labelAulasSemanais.TabIndex = 3;
            this.labelAulasSemanais.Text = "Nº de aulas semanais";
            // 
            // labelHoraAula
            // 
            this.labelHoraAula.AutoSize = true;
            this.labelHoraAula.Location = new System.Drawing.Point(9, 71);
            this.labelHoraAula.Name = "labelHoraAula";
            this.labelHoraAula.Size = new System.Drawing.Size(93, 13);
            this.labelHoraAula.TabIndex = 4;
            this.labelHoraAula.Text = "Valor da hora-aula";
            // 
            // labelSalarioBase
            // 
            this.labelSalarioBase.AutoSize = true;
            this.labelSalarioBase.Location = new System.Drawing.Point(166, 21);
            this.labelSalarioBase.Name = "labelSalarioBase";
            this.labelSalarioBase.Size = new System.Drawing.Size(65, 13);
            this.labelSalarioBase.TabIndex = 5;
            this.labelSalarioBase.Text = "Salário base";
            // 
            // labelHoraAtividade
            // 
            this.labelHoraAtividade.AutoSize = true;
            this.labelHoraAtividade.Location = new System.Drawing.Point(166, 71);
            this.labelHoraAtividade.Name = "labelHoraAtividade";
            this.labelHoraAtividade.Size = new System.Drawing.Size(76, 13);
            this.labelHoraAtividade.TabIndex = 6;
            this.labelHoraAtividade.Text = "Hora-atividade";
            // 
            // labelDSR
            // 
            this.labelDSR.AutoSize = true;
            this.labelDSR.Location = new System.Drawing.Point(166, 119);
            this.labelDSR.Name = "labelDSR";
            this.labelDSR.Size = new System.Drawing.Size(30, 13);
            this.labelDSR.TabIndex = 7;
            this.labelDSR.Text = "DSR";
            // 
            // labelSalarioTotalAul
            // 
            this.labelSalarioTotalAul.AutoSize = true;
            this.labelSalarioTotalAul.Location = new System.Drawing.Point(166, 167);
            this.labelSalarioTotalAul.Name = "labelSalarioTotalAul";
            this.labelSalarioTotalAul.Size = new System.Drawing.Size(62, 13);
            this.labelSalarioTotalAul.TabIndex = 8;
            this.labelSalarioTotalAul.Text = "Salário total";
            // 
            // buttonCalcularMensalista
            // 
            this.buttonCalcularMensalista.Location = new System.Drawing.Point(27, 81);
            this.buttonCalcularMensalista.Name = "buttonCalcularMensalista";
            this.buttonCalcularMensalista.Size = new System.Drawing.Size(75, 23);
            this.buttonCalcularMensalista.TabIndex = 9;
            this.buttonCalcularMensalista.Text = "Calcular";
            this.buttonCalcularMensalista.UseVisualStyleBackColor = true;
            this.buttonCalcularMensalista.Click += new System.EventHandler(this.buttonCalcularMensalista_Click);
            // 
            // buttonCalcularAulista
            // 
            this.buttonCalcularAulista.Location = new System.Drawing.Point(12, 119);
            this.buttonCalcularAulista.Name = "buttonCalcularAulista";
            this.buttonCalcularAulista.Size = new System.Drawing.Size(75, 23);
            this.buttonCalcularAulista.TabIndex = 10;
            this.buttonCalcularAulista.Text = "Calcular";
            this.buttonCalcularAulista.UseVisualStyleBackColor = true;
            this.buttonCalcularAulista.Click += new System.EventHandler(this.buttonCalcularAulista_Click);
            // 
            // textBoxSalarioMes
            // 
            this.textBoxSalarioMes.Location = new System.Drawing.Point(27, 37);
            this.textBoxSalarioMes.Name = "textBoxSalarioMes";
            this.textBoxSalarioMes.Size = new System.Drawing.Size(100, 20);
            this.textBoxSalarioMes.TabIndex = 11;
            this.textBoxSalarioMes.TextChanged += new System.EventHandler(this.textBoxSalarioMes_TextChanged);
            // 
            // textBoxHoraAtividade
            // 
            this.textBoxHoraAtividade.Location = new System.Drawing.Point(147, 37);
            this.textBoxHoraAtividade.Name = "textBoxHoraAtividade";
            this.textBoxHoraAtividade.Size = new System.Drawing.Size(100, 20);
            this.textBoxHoraAtividade.TabIndex = 12;
            // 
            // textBoxNAulaSemanais
            // 
            this.textBoxNAulaSemanais.Location = new System.Drawing.Point(12, 37);
            this.textBoxNAulaSemanais.Name = "textBoxNAulaSemanais";
            this.textBoxNAulaSemanais.Size = new System.Drawing.Size(100, 20);
            this.textBoxNAulaSemanais.TabIndex = 13;
            // 
            // textBoxValorHoraAula
            // 
            this.textBoxValorHoraAula.Location = new System.Drawing.Point(12, 87);
            this.textBoxValorHoraAula.Name = "textBoxValorHoraAula";
            this.textBoxValorHoraAula.Size = new System.Drawing.Size(100, 20);
            this.textBoxValorHoraAula.TabIndex = 14;
            // 
            // textBoxDSR
            // 
            this.textBoxDSR.Location = new System.Drawing.Point(169, 135);
            this.textBoxDSR.Name = "textBoxDSR";
            this.textBoxDSR.Size = new System.Drawing.Size(100, 20);
            this.textBoxDSR.TabIndex = 15;
            // 
            // textBoxHoraAtividadeAulista
            // 
            this.textBoxHoraAtividadeAulista.Location = new System.Drawing.Point(169, 87);
            this.textBoxHoraAtividadeAulista.Name = "textBoxHoraAtividadeAulista";
            this.textBoxHoraAtividadeAulista.Size = new System.Drawing.Size(100, 20);
            this.textBoxHoraAtividadeAulista.TabIndex = 16;
            // 
            // textBoxSalarioBase
            // 
            this.textBoxSalarioBase.Location = new System.Drawing.Point(169, 36);
            this.textBoxSalarioBase.Name = "textBoxSalarioBase";
            this.textBoxSalarioBase.Size = new System.Drawing.Size(100, 20);
            this.textBoxSalarioBase.TabIndex = 17;
            // 
            // textBoxSalarioTotalMes
            // 
            this.textBoxSalarioTotalMes.Location = new System.Drawing.Point(147, 87);
            this.textBoxSalarioTotalMes.Name = "textBoxSalarioTotalMes";
            this.textBoxSalarioTotalMes.Size = new System.Drawing.Size(100, 20);
            this.textBoxSalarioTotalMes.TabIndex = 18;
            // 
            // textBoxSalarioTotalAulista
            // 
            this.textBoxSalarioTotalAulista.Location = new System.Drawing.Point(169, 183);
            this.textBoxSalarioTotalAulista.Name = "textBoxSalarioTotalAulista";
            this.textBoxSalarioTotalAulista.Size = new System.Drawing.Size(100, 20);
            this.textBoxSalarioTotalAulista.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxSalarioTotalAulista);
            this.groupBox1.Controls.Add(this.textBoxSalarioBase);
            this.groupBox1.Controls.Add(this.textBoxHoraAtividadeAulista);
            this.groupBox1.Controls.Add(this.textBoxDSR);
            this.groupBox1.Controls.Add(this.textBoxValorHoraAula);
            this.groupBox1.Controls.Add(this.textBoxNAulaSemanais);
            this.groupBox1.Controls.Add(this.buttonCalcularAulista);
            this.groupBox1.Controls.Add(this.labelSalarioTotalAul);
            this.groupBox1.Controls.Add(this.labelDSR);
            this.groupBox1.Controls.Add(this.labelHoraAtividade);
            this.groupBox1.Controls.Add(this.labelSalarioBase);
            this.groupBox1.Controls.Add(this.labelHoraAula);
            this.groupBox1.Controls.Add(this.labelAulasSemanais);
            this.groupBox1.Location = new System.Drawing.Point(290, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 242);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Professor Aulista";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxSalarioTotalMes);
            this.groupBox2.Controls.Add(this.textBoxHoraAtividade);
            this.groupBox2.Controls.Add(this.textBoxSalarioMes);
            this.groupBox2.Controls.Add(this.buttonCalcularMensalista);
            this.groupBox2.Controls.Add(this.labelSalarioTotalMen);
            this.groupBox2.Controls.Add(this.labelHora);
            this.groupBox2.Controls.Add(this.labelSalario);
            this.groupBox2.Location = new System.Drawing.Point(13, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 128);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Professor Mensalista";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(25, 23);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(50, 13);
            this.lblMatricula.TabIndex = 22;
            this.lblMatricula.Text = "Matricula";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(237, 23);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 23;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(277, 21);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 24;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(78, 21);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(100, 20);
            this.txtMatricula.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 450);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblMatricula);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSalario;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Label labelSalarioTotalMen;
        private System.Windows.Forms.Label labelAulasSemanais;
        private System.Windows.Forms.Label labelHoraAula;
        private System.Windows.Forms.Label labelSalarioBase;
        private System.Windows.Forms.Label labelHoraAtividade;
        private System.Windows.Forms.Label labelDSR;
        private System.Windows.Forms.Label labelSalarioTotalAul;
        private System.Windows.Forms.Button buttonCalcularMensalista;
        private System.Windows.Forms.Button buttonCalcularAulista;
        private System.Windows.Forms.TextBox textBoxSalarioMes;
        private System.Windows.Forms.TextBox textBoxHoraAtividade;
        private System.Windows.Forms.TextBox textBoxNAulaSemanais;
        private System.Windows.Forms.TextBox textBoxValorHoraAula;
        private System.Windows.Forms.TextBox textBoxDSR;
        private System.Windows.Forms.TextBox textBoxHoraAtividadeAulista;
        private System.Windows.Forms.TextBox textBoxSalarioBase;
        private System.Windows.Forms.TextBox textBoxSalarioTotalMes;
        private System.Windows.Forms.TextBox textBoxSalarioTotalAulista;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtMatricula;
    }
}

