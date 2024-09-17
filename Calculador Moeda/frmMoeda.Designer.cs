
namespace Calculador_Moeda
{
    partial class frmMoeda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMoeda));
            this.gpbDados = new System.Windows.Forms.GroupBox();
            this.txtMoeda = new System.Windows.Forms.TextBox();
            this.lblMoeda = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbPeso = new System.Windows.Forms.RadioButton();
            this.rdbEuro = new System.Windows.Forms.RadioButton();
            this.rdbIene = new System.Windows.Forms.RadioButton();
            this.rdbDollar = new System.Windows.Forms.RadioButton();
            this.lblDescReal = new System.Windows.Forms.Label();
            this.txtReais = new System.Windows.Forms.TextBox();
            this.lblReais = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbltextvalor = new System.Windows.Forms.Label();
            this.lblRespostaMoeda = new System.Windows.Forms.Label();
            this.lbltextmoeda = new System.Windows.Forms.Label();
            this.lblResposta = new System.Windows.Forms.Label();
            this.gpbDados.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbDados
            // 
            this.gpbDados.Controls.Add(this.txtMoeda);
            this.gpbDados.Controls.Add(this.lblMoeda);
            this.gpbDados.Controls.Add(this.label1);
            this.gpbDados.Controls.Add(this.rdbPeso);
            this.gpbDados.Controls.Add(this.rdbEuro);
            this.gpbDados.Controls.Add(this.rdbIene);
            this.gpbDados.Controls.Add(this.rdbDollar);
            this.gpbDados.Controls.Add(this.lblDescReal);
            this.gpbDados.Controls.Add(this.txtReais);
            this.gpbDados.Controls.Add(this.lblReais);
            this.gpbDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDados.Location = new System.Drawing.Point(23, 24);
            this.gpbDados.Name = "gpbDados";
            this.gpbDados.Size = new System.Drawing.Size(460, 303);
            this.gpbDados.TabIndex = 0;
            this.gpbDados.TabStop = false;
            this.gpbDados.Text = "Dados:";
            // 
            // txtMoeda
            // 
            this.txtMoeda.Location = new System.Drawing.Point(176, 248);
            this.txtMoeda.MaxLength = 10;
            this.txtMoeda.Name = "txtMoeda";
            this.txtMoeda.Size = new System.Drawing.Size(264, 26);
            this.txtMoeda.TabIndex = 9;
            this.txtMoeda.TextChanged += new System.EventHandler(this.txtMoeda_TextChanged);
            this.txtMoeda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMoeda_KeyDown);
            // 
            // lblMoeda
            // 
            this.lblMoeda.AutoSize = true;
            this.lblMoeda.Location = new System.Drawing.Point(21, 250);
            this.lblMoeda.Name = "lblMoeda";
            this.lblMoeda.Size = new System.Drawing.Size(149, 20);
            this.lblMoeda.TabIndex = 8;
            this.lblMoeda.Text = "Selecione a moeda:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Qual moeda quer converter:";
            // 
            // rdbPeso
            // 
            this.rdbPeso.AutoSize = true;
            this.rdbPeso.Location = new System.Drawing.Point(206, 190);
            this.rdbPeso.Name = "rdbPeso";
            this.rdbPeso.Size = new System.Drawing.Size(124, 24);
            this.rdbPeso.TabIndex = 6;
            this.rdbPeso.TabStop = true;
            this.rdbPeso.Text = "Peso (ARS $)";
            this.rdbPeso.UseVisualStyleBackColor = true;
            this.rdbPeso.CheckedChanged += new System.EventHandler(this.rdbPeso_CheckedChanged);
            this.rdbPeso.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rdbPeso_KeyDown);
            // 
            // rdbEuro
            // 
            this.rdbEuro.AutoSize = true;
            this.rdbEuro.Location = new System.Drawing.Point(23, 190);
            this.rdbEuro.Name = "rdbEuro";
            this.rdbEuro.Size = new System.Drawing.Size(84, 24);
            this.rdbEuro.TabIndex = 5;
            this.rdbEuro.TabStop = true;
            this.rdbEuro.Text = "Euro (€)";
            this.rdbEuro.UseVisualStyleBackColor = true;
            this.rdbEuro.CheckedChanged += new System.EventHandler(this.rdbEuro_CheckedChanged);
            this.rdbEuro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rdbEuro_KeyDown);
            // 
            // rdbIene
            // 
            this.rdbIene.AutoSize = true;
            this.rdbIene.Location = new System.Drawing.Point(206, 147);
            this.rdbIene.Name = "rdbIene";
            this.rdbIene.Size = new System.Drawing.Size(82, 24);
            this.rdbIene.TabIndex = 4;
            this.rdbIene.TabStop = true;
            this.rdbIene.Text = "Iêne (¥)";
            this.rdbIene.UseVisualStyleBackColor = true;
            this.rdbIene.CheckedChanged += new System.EventHandler(this.rdbIene_CheckedChanged);
            this.rdbIene.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rdbIene_KeyDown);
            // 
            // rdbDollar
            // 
            this.rdbDollar.AutoSize = true;
            this.rdbDollar.Location = new System.Drawing.Point(23, 147);
            this.rdbDollar.Name = "rdbDollar";
            this.rdbDollar.Size = new System.Drawing.Size(171, 24);
            this.rdbDollar.TabIndex = 3;
            this.rdbDollar.TabStop = true;
            this.rdbDollar.Text = "Dollar Americano ($)";
            this.rdbDollar.UseVisualStyleBackColor = true;
            this.rdbDollar.CheckedChanged += new System.EventHandler(this.rdbDollar_CheckedChanged);
            this.rdbDollar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rdbDollar_KeyDown);
            // 
            // lblDescReal
            // 
            this.lblDescReal.AutoSize = true;
            this.lblDescReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescReal.Location = new System.Drawing.Point(203, 76);
            this.lblDescReal.Name = "lblDescReal";
            this.lblDescReal.Size = new System.Drawing.Size(0, 13);
            this.lblDescReal.TabIndex = 2;
            // 
            // txtReais
            // 
            this.txtReais.Location = new System.Drawing.Point(206, 47);
            this.txtReais.MaxLength = 10;
            this.txtReais.Name = "txtReais";
            this.txtReais.Size = new System.Drawing.Size(234, 26);
            this.txtReais.TabIndex = 1;
            this.txtReais.TextChanged += new System.EventHandler(this.txtReais_TextChanged);
            this.txtReais.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtReais_KeyDown);
            // 
            // lblReais
            // 
            this.lblReais.AutoSize = true;
            this.lblReais.Location = new System.Drawing.Point(19, 48);
            this.lblReais.Name = "lblReais";
            this.lblReais.Size = new System.Drawing.Size(180, 20);
            this.lblReais.TabIndex = 0;
            this.lblReais.Text = "Quantos reais você tem:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpar.Location = new System.Drawing.Point(23, 411);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(749, 63);
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
            this.btnSair.Location = new System.Drawing.Point(23, 480);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(749, 63);
            this.btnSair.TabIndex = 14;
            this.btnSair.Text = "&Voltar";
            this.btnSair.UseVisualStyleBackColor = false;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalcular.Location = new System.Drawing.Point(23, 342);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(749, 63);
            this.btnCalcular.TabIndex = 12;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbltextvalor);
            this.groupBox1.Controls.Add(this.lblRespostaMoeda);
            this.groupBox1.Controls.Add(this.lbltextmoeda);
            this.groupBox1.Controls.Add(this.lblResposta);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(489, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 303);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultado:";
            // 
            // lbltextvalor
            // 
            this.lbltextvalor.AutoSize = true;
            this.lbltextvalor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbltextvalor.Location = new System.Drawing.Point(18, 195);
            this.lbltextvalor.Name = "lbltextvalor";
            this.lbltextvalor.Size = new System.Drawing.Size(0, 13);
            this.lbltextvalor.TabIndex = 12;
            this.lbltextvalor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRespostaMoeda
            // 
            this.lblRespostaMoeda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRespostaMoeda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespostaMoeda.Location = new System.Drawing.Point(17, 211);
            this.lblRespostaMoeda.Name = "lblRespostaMoeda";
            this.lblRespostaMoeda.Size = new System.Drawing.Size(249, 62);
            this.lblRespostaMoeda.TabIndex = 11;
            this.lblRespostaMoeda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbltextmoeda
            // 
            this.lbltextmoeda.AutoSize = true;
            this.lbltextmoeda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbltextmoeda.Location = new System.Drawing.Point(16, 32);
            this.lbltextmoeda.Name = "lbltextmoeda";
            this.lbltextmoeda.Size = new System.Drawing.Size(0, 13);
            this.lbltextmoeda.TabIndex = 10;
            this.lbltextmoeda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResposta
            // 
            this.lblResposta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblResposta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResposta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblResposta.Location = new System.Drawing.Point(17, 47);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(249, 131);
            this.lblResposta.TabIndex = 0;
            this.lblResposta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMoeda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.gpbDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMoeda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.frmMoeda_Load);
            this.gpbDados.ResumeLayout(false);
            this.gpbDados.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDados;
        private System.Windows.Forms.TextBox txtReais;
        private System.Windows.Forms.Label lblReais;
        private System.Windows.Forms.Label lblDescReal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbPeso;
        private System.Windows.Forms.RadioButton rdbEuro;
        private System.Windows.Forms.RadioButton rdbIene;
        private System.Windows.Forms.RadioButton rdbDollar;
        private System.Windows.Forms.TextBox txtMoeda;
        private System.Windows.Forms.Label lblMoeda;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbltextvalor;
        private System.Windows.Forms.Label lblRespostaMoeda;
        private System.Windows.Forms.Label lbltextmoeda;
        private System.Windows.Forms.Label lblResposta;
    }
}

