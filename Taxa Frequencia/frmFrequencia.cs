using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taxa_Frequencia
{
    public partial class frmFrequencia : Form
    {
        public frmFrequencia()
        {
            InitializeComponent();
            txtAcidentes.Focus();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void calcularCampos()
        {
            try
            {

                double acidentes, funcionarios, horas, hht, tf = 0;

                if (txtAcidentes.Text != "" && txtFuncionarios.Text != "" && txtHoras.Text != "")
                {
                    acidentes = Convert.ToDouble(txtAcidentes.Text);
                    funcionarios = Convert.ToDouble(txtFuncionarios.Text);
                    horas = Convert.ToDouble(txtHoras.Text);

                    hht = funcionarios * horas;

                    tf = acidentes * 1000000 / hht;

                    lblTF.Text = string.Format("{0:n2}", tf);

                    if (tf <= 20)
                    {
                        lblParametro.BackColor = Color.Green;
                        lblParametro.ForeColor = Color.White;
                        lblParametro.Text = "Muito bom";
                    }
                    else if (tf > 20 && tf <= 40)
                    {
                        lblParametro.BackColor = Color.YellowGreen;
                        lblParametro.ForeColor = Color.White;
                        lblParametro.Text = "Bom";
                    }
                    else if (tf > 40 && tf <= 60)
                    {
                        lblParametro.BackColor = Color.OrangeRed;
                        lblParametro.ForeColor = Color.White;
                        lblParametro.Text = "Ruim";
                    }
                    else if (tf > 60)
                    {
                        lblParametro.BackColor = Color.Red;
                        lblParametro.ForeColor = Color.White;
                        lblParametro.Text = "Péssima";
                    }


                }
                else
                {
                    MessageBox.Show("Preencha todos os campos!",
                     "Erro", MessageBoxButtons.OK,
                     MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                    txtAcidentes.Clear();
                    txtFuncionarios.Clear();
                    txtHoras.Clear();
                    lblParametro.Text = "";
                    lblParametro.BackColor = Color.White;
                    lblTF.Text = "";
                    txtAcidentes.Focus();

                }

            }
            catch (Exception)
            {
                MessageBox.Show("Utilize apenas números",
                     "Erro", MessageBoxButtons.OK,
                     MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                txtAcidentes.Clear();
                txtFuncionarios.Clear();
                txtHoras.Clear();
                lblParametro.Text = "";
                lblParametro.BackColor = Color.White;
                lblTF.Text = "";
                txtAcidentes.Focus();
            }
        
    }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            calcularCampos();
        }

        private void limparCampos()
        {
            txtAcidentes.Clear();
            txtFuncionarios.Clear();
            txtHoras.Clear();
            lblParametro.Text = "";
            lblParametro.BackColor = Color.White;
            lblTF.Text = "";
            txtAcidentes.Focus();
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void txtAcidentes_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAcidentes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtFuncionarios.Focus();
            }
        }

        private void txtFuncionarios_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtHoras.Focus();
            }
        }

        private void txtHoras_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                calcularCampos();
            }
        }

        private void frmFrequencia_Load(object sender, EventArgs e)
        {

        }
    }
}
