
namespace Calculador_Combustível
{
    partial class frmCombustivel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCombustivel));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lblpreco = new System.Windows.Forms.Label();
            this.txtConsumo = new System.Windows.Forms.TextBox();
            this.lblInsiraconsumo = new System.Windows.Forms.Label();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.lbldistancia = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblcombustivelresultado = new System.Windows.Forms.Label();
            this.lblQuilometragemresultado = new System.Windows.Forms.Label();
            this.lblconsumo = new System.Windows.Forms.Label();
            this.lblquilometragem = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPreco);
            this.groupBox1.Controls.Add(this.lblpreco);
            this.groupBox1.Controls.Add(this.txtConsumo);
            this.groupBox1.Controls.Add(this.lblInsiraconsumo);
            this.groupBox1.Controls.Add(this.txtDistancia);
            this.groupBox1.Controls.Add(this.lbldistancia);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(572, 173);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(409, 121);
            this.txtPreco.MaxLength = 5;
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(154, 26);
            this.txtPreco.TabIndex = 5;
            this.txtPreco.TextChanged += new System.EventHandler(this.txtPreco_TextChanged);
            // 
            // lblpreco
            // 
            this.lblpreco.AutoSize = true;
            this.lblpreco.Location = new System.Drawing.Point(16, 124);
            this.lblpreco.Name = "lblpreco";
            this.lblpreco.Size = new System.Drawing.Size(387, 20);
            this.lblpreco.TabIndex = 4;
            this.lblpreco.Text = "Adicione o preço do combustível onde você abastece:";
            // 
            // txtConsumo
            // 
            this.txtConsumo.Location = new System.Drawing.Point(286, 71);
            this.txtConsumo.MaxLength = 5;
            this.txtConsumo.Name = "txtConsumo";
            this.txtConsumo.Size = new System.Drawing.Size(277, 26);
            this.txtConsumo.TabIndex = 3;
            this.txtConsumo.TextChanged += new System.EventHandler(this.txtConsumo_TextChanged);
            this.txtConsumo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtConsumo_KeyDown);
            // 
            // lblInsiraconsumo
            // 
            this.lblInsiraconsumo.AutoSize = true;
            this.lblInsiraconsumo.Location = new System.Drawing.Point(16, 71);
            this.lblInsiraconsumo.Name = "lblInsiraconsumo";
            this.lblInsiraconsumo.Size = new System.Drawing.Size(264, 20);
            this.lblInsiraconsumo.TabIndex = 2;
            this.lblInsiraconsumo.Text = "Insira o consumo do veículo por litro:";
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(326, 22);
            this.txtDistancia.MaxLength = 5;
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(237, 26);
            this.txtDistancia.TabIndex = 1;
            this.txtDistancia.TextChanged += new System.EventHandler(this.txtDistancia_TextChanged);
            this.txtDistancia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDistancia_KeyDown);
            // 
            // lbldistancia
            // 
            this.lbldistancia.AutoSize = true;
            this.lbldistancia.Location = new System.Drawing.Point(16, 22);
            this.lbldistancia.Name = "lbldistancia";
            this.lbldistancia.Size = new System.Drawing.Size(303, 20);
            this.lbldistancia.TabIndex = 0;
            this.lbldistancia.Text = "Insira a distância que irá percorrer em km:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblcombustivelresultado);
            this.groupBox2.Controls.Add(this.lblQuilometragemresultado);
            this.groupBox2.Controls.Add(this.lblconsumo);
            this.groupBox2.Controls.Add(this.lblquilometragem);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(29, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(572, 170);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cálculo:";
            // 
            // lblcombustivelresultado
            // 
            this.lblcombustivelresultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblcombustivelresultado.Location = new System.Drawing.Point(345, 69);
            this.lblcombustivelresultado.Name = "lblcombustivelresultado";
            this.lblcombustivelresultado.Size = new System.Drawing.Size(172, 82);
            this.lblcombustivelresultado.TabIndex = 4;
            this.lblcombustivelresultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblcombustivelresultado.Click += new System.EventHandler(this.lblcombustivelresultado_Click);
            // 
            // lblQuilometragemresultado
            // 
            this.lblQuilometragemresultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblQuilometragemresultado.Location = new System.Drawing.Point(25, 69);
            this.lblQuilometragemresultado.Name = "lblQuilometragemresultado";
            this.lblQuilometragemresultado.Size = new System.Drawing.Size(172, 82);
            this.lblQuilometragemresultado.TabIndex = 3;
            this.lblQuilometragemresultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblconsumo
            // 
            this.lblconsumo.AutoSize = true;
            this.lblconsumo.Location = new System.Drawing.Point(303, 37);
            this.lblconsumo.Name = "lblconsumo";
            this.lblconsumo.Size = new System.Drawing.Size(246, 20);
            this.lblconsumo.TabIndex = 2;
            this.lblconsumo.Text = "Consumo por litro de combustível:";
            // 
            // lblquilometragem
            // 
            this.lblquilometragem.AutoSize = true;
            this.lblquilometragem.Location = new System.Drawing.Point(16, 37);
            this.lblquilometragem.Name = "lblquilometragem";
            this.lblquilometragem.Size = new System.Drawing.Size(196, 20);
            this.lblquilometragem.TabIndex = 0;
            this.lblquilometragem.Text = "Quilometragem percorrida:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblTotal);
            this.groupBox3.Controls.Add(this.lblResultado);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(29, 382);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(572, 100);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultado:";
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Location = new System.Drawing.Point(162, 26);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(387, 55);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(35, 45);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(89, 20);
            this.lblResultado.TabIndex = 0;
            this.lblResultado.Text = "Preço total:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpar.Location = new System.Drawing.Point(625, 18);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(147, 63);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Maroon;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSair.Location = new System.Drawing.Point(625, 87);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(147, 63);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "&Voltar";
            this.btnSair.UseVisualStyleBackColor = false;
            // 
            // frmCombustivel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCombustivel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.frmCombustivel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.Label lbldistancia;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label lblpreco;
        private System.Windows.Forms.TextBox txtConsumo;
        private System.Windows.Forms.Label lblInsiraconsumo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblconsumo;
        private System.Windows.Forms.Label lblquilometragem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblcombustivelresultado;
        private System.Windows.Forms.Label lblQuilometragemresultado;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}

