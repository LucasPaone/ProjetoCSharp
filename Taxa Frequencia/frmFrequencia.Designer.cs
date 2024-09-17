
namespace Taxa_Frequencia
{
    partial class frmFrequencia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFrequencia));
            this.txtAcidentes = new System.Windows.Forms.TextBox();
            this.lbltextAcidentes = new System.Windows.Forms.Label();
            this.gpbDados = new System.Windows.Forms.GroupBox();
            this.lbltexhoras = new System.Windows.Forms.Label();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.lbltextfuncionarios = new System.Windows.Forms.Label();
            this.txtFuncionarios = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.gpbResultado = new System.Windows.Forms.GroupBox();
            this.lblParametro = new System.Windows.Forms.Label();
            this.lbltextresultadoparametro = new System.Windows.Forms.Label();
            this.lblTF = new System.Windows.Forms.Label();
            this.lbltextresultadotf = new System.Windows.Forms.Label();
            this.gpbDados.SuspendLayout();
            this.gpbResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAcidentes
            // 
            this.txtAcidentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcidentes.Location = new System.Drawing.Point(242, 33);
            this.txtAcidentes.MaxLength = 4;
            this.txtAcidentes.Name = "txtAcidentes";
            this.txtAcidentes.Size = new System.Drawing.Size(464, 26);
            this.txtAcidentes.TabIndex = 0;
            this.txtAcidentes.TextChanged += new System.EventHandler(this.txtAcidentes_TextChanged);
            this.txtAcidentes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAcidentes_KeyDown);
            // 
            // lbltextAcidentes
            // 
            this.lbltextAcidentes.AutoSize = true;
            this.lbltextAcidentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltextAcidentes.Location = new System.Drawing.Point(14, 36);
            this.lbltextAcidentes.Name = "lbltextAcidentes";
            this.lbltextAcidentes.Size = new System.Drawing.Size(222, 20);
            this.lbltextAcidentes.TabIndex = 1;
            this.lbltextAcidentes.Text = "Número de Acidentes no mês:";
            // 
            // gpbDados
            // 
            this.gpbDados.Controls.Add(this.lbltexhoras);
            this.gpbDados.Controls.Add(this.txtHoras);
            this.gpbDados.Controls.Add(this.lbltextfuncionarios);
            this.gpbDados.Controls.Add(this.txtFuncionarios);
            this.gpbDados.Controls.Add(this.lbltextAcidentes);
            this.gpbDados.Controls.Add(this.txtAcidentes);
            this.gpbDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDados.Location = new System.Drawing.Point(25, 31);
            this.gpbDados.Name = "gpbDados";
            this.gpbDados.Size = new System.Drawing.Size(724, 172);
            this.gpbDados.TabIndex = 2;
            this.gpbDados.TabStop = false;
            this.gpbDados.Text = "Dados:";
            this.gpbDados.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbltexhoras
            // 
            this.lbltexhoras.AutoSize = true;
            this.lbltexhoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltexhoras.Location = new System.Drawing.Point(14, 122);
            this.lbltexhoras.Name = "lbltexhoras";
            this.lbltexhoras.Size = new System.Drawing.Size(275, 20);
            this.lbltexhoras.TabIndex = 5;
            this.lbltexhoras.Text = "Horas individuais trabalhadas mensal:";
            // 
            // txtHoras
            // 
            this.txtHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoras.Location = new System.Drawing.Point(292, 119);
            this.txtHoras.MaxLength = 5;
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(414, 26);
            this.txtHoras.TabIndex = 4;
            this.txtHoras.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtHoras_KeyDown);
            // 
            // lbltextfuncionarios
            // 
            this.lbltextfuncionarios.AutoSize = true;
            this.lbltextfuncionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltextfuncionarios.Location = new System.Drawing.Point(14, 77);
            this.lbltextfuncionarios.Name = "lbltextfuncionarios";
            this.lbltextfuncionarios.Size = new System.Drawing.Size(213, 20);
            this.lbltextfuncionarios.TabIndex = 3;
            this.lbltextfuncionarios.Text = "Quantidade de Fúncionários:";
            this.lbltextfuncionarios.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtFuncionarios
            // 
            this.txtFuncionarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuncionarios.Location = new System.Drawing.Point(233, 74);
            this.txtFuncionarios.MaxLength = 10;
            this.txtFuncionarios.Name = "txtFuncionarios";
            this.txtFuncionarios.Size = new System.Drawing.Size(473, 26);
            this.txtFuncionarios.TabIndex = 2;
            this.txtFuncionarios.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFuncionarios_KeyDown);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpar.Location = new System.Drawing.Point(288, 220);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(264, 63);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Maroon;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSair.Location = new System.Drawing.Point(558, 220);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(191, 63);
            this.btnSair.TabIndex = 14;
            this.btnSair.Text = "&Voltar";
            this.btnSair.UseVisualStyleBackColor = false;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalcular.Location = new System.Drawing.Point(25, 220);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(257, 63);
            this.btnCalcular.TabIndex = 12;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // gpbResultado
            // 
            this.gpbResultado.Controls.Add(this.lblParametro);
            this.gpbResultado.Controls.Add(this.lbltextresultadoparametro);
            this.gpbResultado.Controls.Add(this.lblTF);
            this.gpbResultado.Controls.Add(this.lbltextresultadotf);
            this.gpbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbResultado.Location = new System.Drawing.Point(25, 301);
            this.gpbResultado.Name = "gpbResultado";
            this.gpbResultado.Size = new System.Drawing.Size(724, 143);
            this.gpbResultado.TabIndex = 15;
            this.gpbResultado.TabStop = false;
            this.gpbResultado.Text = "Resultado:";
            // 
            // lblParametro
            // 
            this.lblParametro.BackColor = System.Drawing.Color.White;
            this.lblParametro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblParametro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblParametro.Location = new System.Drawing.Point(369, 77);
            this.lblParametro.Name = "lblParametro";
            this.lblParametro.Size = new System.Drawing.Size(332, 43);
            this.lblParametro.TabIndex = 9;
            this.lblParametro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbltextresultadoparametro
            // 
            this.lbltextresultadoparametro.AutoSize = true;
            this.lbltextresultadoparametro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltextresultadoparametro.Location = new System.Drawing.Point(367, 59);
            this.lbltextresultadoparametro.Name = "lbltextresultadoparametro";
            this.lbltextresultadoparametro.Size = new System.Drawing.Size(68, 15);
            this.lbltextresultadoparametro.TabIndex = 8;
            this.lbltextresultadoparametro.Text = "Parâmetro:";
            // 
            // lblTF
            // 
            this.lblTF.BackColor = System.Drawing.Color.White;
            this.lblTF.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTF.Location = new System.Drawing.Point(16, 77);
            this.lblTF.Name = "lblTF";
            this.lblTF.Size = new System.Drawing.Size(332, 43);
            this.lblTF.TabIndex = 7;
            this.lblTF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbltextresultadotf
            // 
            this.lbltextresultadotf.AutoSize = true;
            this.lbltextresultadotf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltextresultadotf.Location = new System.Drawing.Point(14, 59);
            this.lbltextresultadotf.Name = "lbltextresultadotf";
            this.lbltextresultadotf.Size = new System.Drawing.Size(119, 15);
            this.lbltextresultadotf.TabIndex = 6;
            this.lbltextresultadotf.Text = "Taxa de Frequência:";
            // 
            // frmFrequencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.gpbResultado);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.gpbDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmFrequencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.frmFrequencia_Load);
            this.gpbDados.ResumeLayout(false);
            this.gpbDados.PerformLayout();
            this.gpbResultado.ResumeLayout(false);
            this.gpbResultado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtAcidentes;
        private System.Windows.Forms.Label lbltextAcidentes;
        private System.Windows.Forms.GroupBox gpbDados;
        private System.Windows.Forms.Label lbltextfuncionarios;
        private System.Windows.Forms.TextBox txtFuncionarios;
        private System.Windows.Forms.Label lbltexhoras;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox gpbResultado;
        private System.Windows.Forms.Label lblParametro;
        private System.Windows.Forms.Label lbltextresultadoparametro;
        private System.Windows.Forms.Label lblTF;
        private System.Windows.Forms.Label lbltextresultadotf;
    }
}

