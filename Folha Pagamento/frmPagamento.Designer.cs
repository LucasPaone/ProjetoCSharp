
namespace Folha_Pagamento
{
    partial class frmPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPagamento));
            this.gpbCamposfolha = new System.Windows.Forms.GroupBox();
            this.rdbClasseC = new System.Windows.Forms.RadioButton();
            this.rdbClasseB = new System.Windows.Forms.RadioButton();
            this.rdbClasseA = new System.Windows.Forms.RadioButton();
            this.txtBruto = new System.Windows.Forms.TextBox();
            this.lbltextcooperativa = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.gpbResultado = new System.Windows.Forms.GroupBox();
            this.lblRespostaLiquido = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblRespostaCooperativa = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRespostaIR = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRespostaINSS = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRespostaBruto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbCamposfolha.SuspendLayout();
            this.gpbResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbCamposfolha
            // 
            this.gpbCamposfolha.Controls.Add(this.rdbClasseC);
            this.gpbCamposfolha.Controls.Add(this.rdbClasseB);
            this.gpbCamposfolha.Controls.Add(this.rdbClasseA);
            this.gpbCamposfolha.Controls.Add(this.txtBruto);
            this.gpbCamposfolha.Controls.Add(this.lbltextcooperativa);
            this.gpbCamposfolha.Controls.Add(this.lblText);
            this.gpbCamposfolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCamposfolha.Location = new System.Drawing.Point(21, 51);
            this.gpbCamposfolha.Name = "gpbCamposfolha";
            this.gpbCamposfolha.Size = new System.Drawing.Size(403, 233);
            this.gpbCamposfolha.TabIndex = 0;
            this.gpbCamposfolha.TabStop = false;
            this.gpbCamposfolha.Text = "Folha de pagamento:";
            // 
            // rdbClasseC
            // 
            this.rdbClasseC.AutoSize = true;
            this.rdbClasseC.Location = new System.Drawing.Point(131, 176);
            this.rdbClasseC.Name = "rdbClasseC";
            this.rdbClasseC.Size = new System.Drawing.Size(230, 24);
            this.rdbClasseC.TabIndex = 5;
            this.rdbClasseC.TabStop = true;
            this.rdbClasseC.Text = "Classe C - 10% de Desconto";
            this.rdbClasseC.UseVisualStyleBackColor = true;
            this.rdbClasseC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rdbClasseC_KeyDown);
            // 
            // rdbClasseB
            // 
            this.rdbClasseB.AutoSize = true;
            this.rdbClasseB.Location = new System.Drawing.Point(130, 140);
            this.rdbClasseB.Name = "rdbClasseB";
            this.rdbClasseB.Size = new System.Drawing.Size(230, 24);
            this.rdbClasseB.TabIndex = 4;
            this.rdbClasseB.TabStop = true;
            this.rdbClasseB.Text = "Classe B - 20% de Desconto";
            this.rdbClasseB.UseVisualStyleBackColor = true;
            this.rdbClasseB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rdbClasseB_KeyDown);
            // 
            // rdbClasseA
            // 
            this.rdbClasseA.AutoSize = true;
            this.rdbClasseA.Location = new System.Drawing.Point(130, 101);
            this.rdbClasseA.Name = "rdbClasseA";
            this.rdbClasseA.Size = new System.Drawing.Size(230, 24);
            this.rdbClasseA.TabIndex = 3;
            this.rdbClasseA.TabStop = true;
            this.rdbClasseA.Text = "Classe A - 30% de Desconto";
            this.rdbClasseA.UseVisualStyleBackColor = true;
            this.rdbClasseA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rdbClasseA_KeyDown);
            // 
            // txtBruto
            // 
            this.txtBruto.Location = new System.Drawing.Point(130, 45);
            this.txtBruto.MaxLength = 10;
            this.txtBruto.Name = "txtBruto";
            this.txtBruto.Size = new System.Drawing.Size(248, 26);
            this.txtBruto.TabIndex = 2;
            this.txtBruto.TextChanged += new System.EventHandler(this.txtBruto_TextChanged);
            this.txtBruto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBruto_KeyDown);
            // 
            // lbltextcooperativa
            // 
            this.lbltextcooperativa.AutoSize = true;
            this.lbltextcooperativa.Location = new System.Drawing.Point(18, 101);
            this.lbltextcooperativa.Name = "lbltextcooperativa";
            this.lbltextcooperativa.Size = new System.Drawing.Size(98, 20);
            this.lbltextcooperativa.TabIndex = 1;
            this.lbltextcooperativa.Text = "Cooperativa:";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(18, 47);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(105, 20);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Salário Bruto:";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Maroon;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSair.Location = new System.Drawing.Point(21, 435);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(403, 63);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "&Voltar";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpar.Location = new System.Drawing.Point(21, 366);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(403, 63);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalcular.Location = new System.Drawing.Point(21, 297);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(403, 63);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // gpbResultado
            // 
            this.gpbResultado.Controls.Add(this.lblRespostaLiquido);
            this.gpbResultado.Controls.Add(this.label6);
            this.gpbResultado.Controls.Add(this.lblRespostaCooperativa);
            this.gpbResultado.Controls.Add(this.label5);
            this.gpbResultado.Controls.Add(this.lblRespostaIR);
            this.gpbResultado.Controls.Add(this.label4);
            this.gpbResultado.Controls.Add(this.lblRespostaINSS);
            this.gpbResultado.Controls.Add(this.label3);
            this.gpbResultado.Controls.Add(this.lblRespostaBruto);
            this.gpbResultado.Controls.Add(this.label1);
            this.gpbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbResultado.Location = new System.Drawing.Point(444, 51);
            this.gpbResultado.Name = "gpbResultado";
            this.gpbResultado.Size = new System.Drawing.Size(328, 448);
            this.gpbResultado.TabIndex = 1;
            this.gpbResultado.TabStop = false;
            this.gpbResultado.Text = "Resultado:";
            // 
            // lblRespostaLiquido
            // 
            this.lblRespostaLiquido.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblRespostaLiquido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRespostaLiquido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRespostaLiquido.Location = new System.Drawing.Point(17, 357);
            this.lblRespostaLiquido.Name = "lblRespostaLiquido";
            this.lblRespostaLiquido.Size = new System.Drawing.Size(290, 68);
            this.lblRespostaLiquido.TabIndex = 15;
            this.lblRespostaLiquido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Salário Líquido:";
            // 
            // lblRespostaCooperativa
            // 
            this.lblRespostaCooperativa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRespostaCooperativa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRespostaCooperativa.Location = new System.Drawing.Point(17, 285);
            this.lblRespostaCooperativa.Name = "lblRespostaCooperativa";
            this.lblRespostaCooperativa.Size = new System.Drawing.Size(290, 48);
            this.lblRespostaCooperativa.TabIndex = 13;
            this.lblRespostaCooperativa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cooperativa:";
            // 
            // lblRespostaIR
            // 
            this.lblRespostaIR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRespostaIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRespostaIR.Location = new System.Drawing.Point(16, 218);
            this.lblRespostaIR.Name = "lblRespostaIR";
            this.lblRespostaIR.Size = new System.Drawing.Size(290, 43);
            this.lblRespostaIR.TabIndex = 11;
            this.lblRespostaIR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Imposto de Renda:";
            // 
            // lblRespostaINSS
            // 
            this.lblRespostaINSS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRespostaINSS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRespostaINSS.Location = new System.Drawing.Point(16, 148);
            this.lblRespostaINSS.Name = "lblRespostaINSS";
            this.lblRespostaINSS.Size = new System.Drawing.Size(290, 43);
            this.lblRespostaINSS.TabIndex = 9;
            this.lblRespostaINSS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "INSS:";
            // 
            // lblRespostaBruto
            // 
            this.lblRespostaBruto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRespostaBruto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRespostaBruto.Location = new System.Drawing.Point(16, 77);
            this.lblRespostaBruto.Name = "lblRespostaBruto";
            this.lblRespostaBruto.Size = new System.Drawing.Size(290, 43);
            this.lblRespostaBruto.TabIndex = 7;
            this.lblRespostaBruto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Salário Bruto:";
            // 
            // frmPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.gpbResultado);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.gpbCamposfolha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.frmPagamento_Load);
            this.gpbCamposfolha.ResumeLayout(false);
            this.gpbCamposfolha.PerformLayout();
            this.gpbResultado.ResumeLayout(false);
            this.gpbResultado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbCamposfolha;
        private System.Windows.Forms.TextBox txtBruto;
        private System.Windows.Forms.Label lbltextcooperativa;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox gpbResultado;
        private System.Windows.Forms.RadioButton rdbClasseC;
        private System.Windows.Forms.RadioButton rdbClasseB;
        private System.Windows.Forms.RadioButton rdbClasseA;
        private System.Windows.Forms.Label lblRespostaBruto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRespostaLiquido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblRespostaCooperativa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRespostaIR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRespostaINSS;
        private System.Windows.Forms.Label label3;
    }
}

