
namespace EmpresaABC
{
    partial class frmSimples
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSimples));
            this.lblVariavel1 = new System.Windows.Forms.Label();
            this.lblVariavel2 = new System.Windows.Forms.Label();
            this.txtVariavel1 = new System.Windows.Forms.TextBox();
            this.txtVariavel2 = new System.Windows.Forms.TextBox();
            this.gpbOperador = new System.Windows.Forms.GroupBox();
            this.rdbDivisao = new System.Windows.Forms.RadioButton();
            this.rdbMultiplicacao = new System.Windows.Forms.RadioButton();
            this.rdbSubtracao = new System.Windows.Forms.RadioButton();
            this.rdbAdicao = new System.Windows.Forms.RadioButton();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblValorresultado = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.gpbOperador.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVariavel1
            // 
            this.lblVariavel1.AutoSize = true;
            this.lblVariavel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVariavel1.Location = new System.Drawing.Point(47, 59);
            this.lblVariavel1.Name = "lblVariavel1";
            this.lblVariavel1.Size = new System.Drawing.Size(105, 24);
            this.lblVariavel1.TabIndex = 0;
            this.lblVariavel1.Text = "1° Número:";
            this.lblVariavel1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblVariavel2
            // 
            this.lblVariavel2.AutoSize = true;
            this.lblVariavel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVariavel2.Location = new System.Drawing.Point(47, 136);
            this.lblVariavel2.Name = "lblVariavel2";
            this.lblVariavel2.Size = new System.Drawing.Size(105, 24);
            this.lblVariavel2.TabIndex = 1;
            this.lblVariavel2.Text = "2° Número:";
            // 
            // txtVariavel1
            // 
            this.txtVariavel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVariavel1.Location = new System.Drawing.Point(150, 58);
            this.txtVariavel1.MaxLength = 6;
            this.txtVariavel1.Name = "txtVariavel1";
            this.txtVariavel1.Size = new System.Drawing.Size(69, 29);
            this.txtVariavel1.TabIndex = 0;
            this.txtVariavel1.TextChanged += new System.EventHandler(this.txtVariavel1_TextChanged);
            this.txtVariavel1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVariavel1_KeyDown);
            // 
            // txtVariavel2
            // 
            this.txtVariavel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVariavel2.Location = new System.Drawing.Point(150, 133);
            this.txtVariavel2.MaxLength = 6;
            this.txtVariavel2.Name = "txtVariavel2";
            this.txtVariavel2.Size = new System.Drawing.Size(69, 29);
            this.txtVariavel2.TabIndex = 1;
            this.txtVariavel2.TextChanged += new System.EventHandler(this.txtVariavel2_TextChanged);
            this.txtVariavel2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVariavel2_KeyDown);
            // 
            // gpbOperador
            // 
            this.gpbOperador.AutoSize = true;
            this.gpbOperador.Controls.Add(this.rdbDivisao);
            this.gpbOperador.Controls.Add(this.rdbMultiplicacao);
            this.gpbOperador.Controls.Add(this.rdbSubtracao);
            this.gpbOperador.Controls.Add(this.rdbAdicao);
            this.gpbOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbOperador.Location = new System.Drawing.Point(287, 59);
            this.gpbOperador.Name = "gpbOperador";
            this.gpbOperador.Size = new System.Drawing.Size(200, 215);
            this.gpbOperador.TabIndex = 2;
            this.gpbOperador.TabStop = false;
            this.gpbOperador.Text = "Tipo de Cálculo:";
            // 
            // rdbDivisao
            // 
            this.rdbDivisao.AutoSize = true;
            this.rdbDivisao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rdbDivisao.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rdbDivisao.Location = new System.Drawing.Point(21, 146);
            this.rdbDivisao.Name = "rdbDivisao";
            this.rdbDivisao.Size = new System.Drawing.Size(116, 29);
            this.rdbDivisao.TabIndex = 5;
            this.rdbDivisao.TabStop = true;
            this.rdbDivisao.Text = "Divisão (/)";
            this.rdbDivisao.UseVisualStyleBackColor = false;
            this.rdbDivisao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rdbDivisao_KeyDown);
            // 
            // rdbMultiplicacao
            // 
            this.rdbMultiplicacao.AutoSize = true;
            this.rdbMultiplicacao.Location = new System.Drawing.Point(21, 112);
            this.rdbMultiplicacao.Name = "rdbMultiplicacao";
            this.rdbMultiplicacao.Size = new System.Drawing.Size(161, 28);
            this.rdbMultiplicacao.TabIndex = 4;
            this.rdbMultiplicacao.TabStop = true;
            this.rdbMultiplicacao.Text = "Multiplicação (*)";
            this.rdbMultiplicacao.UseVisualStyleBackColor = true;
            this.rdbMultiplicacao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rdbMultiplicacao_KeyDown);
            // 
            // rdbSubtracao
            // 
            this.rdbSubtracao.AutoSize = true;
            this.rdbSubtracao.Location = new System.Drawing.Point(21, 78);
            this.rdbSubtracao.Name = "rdbSubtracao";
            this.rdbSubtracao.Size = new System.Drawing.Size(136, 28);
            this.rdbSubtracao.TabIndex = 3;
            this.rdbSubtracao.TabStop = true;
            this.rdbSubtracao.Text = "Subtração (-)";
            this.rdbSubtracao.UseVisualStyleBackColor = true;
            this.rdbSubtracao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rdbSubtracao_KeyDown);
            // 
            // rdbAdicao
            // 
            this.rdbAdicao.AutoSize = true;
            this.rdbAdicao.Location = new System.Drawing.Point(21, 44);
            this.rdbAdicao.Name = "rdbAdicao";
            this.rdbAdicao.Size = new System.Drawing.Size(115, 28);
            this.rdbAdicao.TabIndex = 2;
            this.rdbAdicao.TabStop = true;
            this.rdbAdicao.Text = "Adição (+)";
            this.rdbAdicao.UseVisualStyleBackColor = true;
            this.rdbAdicao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rdbAdicao_KeyDown);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(526, 58);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(99, 24);
            this.lblResultado.TabIndex = 12;
            this.lblResultado.Text = "Resultado:";
            // 
            // lblValorresultado
            // 
            this.lblValorresultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblValorresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorresultado.Location = new System.Drawing.Point(530, 103);
            this.lblValorresultado.Name = "lblValorresultado";
            this.lblValorresultado.Size = new System.Drawing.Size(223, 57);
            this.lblValorresultado.TabIndex = 13;
            this.lblValorresultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblValorresultado.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalcular.Location = new System.Drawing.Point(530, 224);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(223, 63);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpar.Location = new System.Drawing.Point(530, 293);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(223, 63);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Maroon;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSair.Location = new System.Drawing.Point(530, 362);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(223, 63);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "&Voltar";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmSimples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblValorresultado);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.gpbOperador);
            this.Controls.Add(this.txtVariavel2);
            this.Controls.Add(this.txtVariavel1);
            this.Controls.Add(this.lblVariavel2);
            this.Controls.Add(this.lblVariavel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSimples";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora ";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.gpbOperador.ResumeLayout(false);
            this.gpbOperador.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVariavel1;
        private System.Windows.Forms.Label lblVariavel2;
        private System.Windows.Forms.TextBox txtVariavel1;
        private System.Windows.Forms.TextBox txtVariavel2;
        private System.Windows.Forms.GroupBox gpbOperador;
        private System.Windows.Forms.RadioButton rdbDivisao;
        private System.Windows.Forms.RadioButton rdbMultiplicacao;
        private System.Windows.Forms.RadioButton rdbSubtracao;
        private System.Windows.Forms.RadioButton rdbAdicao;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblValorresultado;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}

