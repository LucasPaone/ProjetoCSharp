using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Calculador_Moeda
{
    public partial class frmMoeda : Form
    {

        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmMoeda()
        {
            InitializeComponent();
            lblDescReal.Text = "R$ ";
            rdbDollar.Enabled = false;
            rdbEuro.Enabled = false;
            rdbIene.Enabled = false;
            rdbPeso.Enabled = false;
            txtMoeda.Enabled = false;
           

        }

        private void txtReais_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtReais.Text != "")
                {
                    double real = 0;

                    real = Convert.ToDouble(txtReais.Text);

                    lblDescReal.Text = "R$ " + txtReais.Text;

                    rdbDollar.Enabled = true;
                    rdbEuro.Enabled = true;
                    rdbIene.Enabled = true;
                    rdbPeso.Enabled = true;
                    txtMoeda.Enabled = true;


                }
                else
                {
                    lblDescReal.Text = "R$ ";
                    rdbDollar.Enabled = false;
                    rdbEuro.Enabled = false;
                    rdbIene.Enabled = false;
                    rdbPeso.Enabled = false;
                    rdbDollar.Checked = false;
                    rdbEuro.Checked = false;
                    rdbIene.Checked = false;
                    rdbPeso.Checked = false;
                    txtMoeda.Enabled = false;

                }

                


            }
            catch (Exception)
            {
                lblDescReal.Text = "Utilize apenas números!";
                rdbDollar.Enabled = false;
                rdbEuro.Enabled = false;
                rdbIene.Enabled = false;
                rdbPeso.Enabled = false;
                rdbDollar.Checked = false;
                rdbEuro.Checked = false;
                rdbIene.Checked = false;
                rdbPeso.Checked = false;
                txtMoeda.Enabled = false;

            }

            


        }

        private void frmMoeda_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void txtMoeda_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void rdbDollar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDollar.Checked )
            {
                txtMoeda.Enabled = true;
                lblMoeda.Text = "Quanto o Dollar vale:";
            }
            else
            {
                txtMoeda.Enabled = false;
            }
        }

        private void rdbIene_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbIene.Checked)
            {
                txtMoeda.Enabled = true;
                lblMoeda.Text = "Quanto o Iêne vale:";

            }
            else
            {
                txtMoeda.Enabled = false;
            }
        }

        private void rdbEuro_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbEuro.Checked)
            {
                txtMoeda.Enabled = true;
                lblMoeda.Text = "Quanto o Euro vale:";

            }
            else
            {
                txtMoeda.Enabled = false;
            }
        }

        private void rdbPeso_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPeso.Checked)
            {
                txtMoeda.Enabled = true;
                lblMoeda.Text = "Quanto o Peso vale:";

            }
            else
            {
                txtMoeda.Enabled = false;
            }
        }


        private void calcularCampos()
        {
            try
            {

                if (txtMoeda.Text != "" && txtReais.Text != "") {
                    double real, resultado, moeda = 0;

                    moeda = Convert.ToDouble(txtMoeda.Text);
                    real = Convert.ToDouble(txtReais.Text);

                    resultado = real / moeda;

                    if (rdbDollar.Checked)
                    {
                        lbltextmoeda.Text = "Você tem (em Dólar):";
                        lbltextvalor.Text = "O Dólar vale:";
                        lblResposta.Text = string.Format("$ {0:n2}", resultado);
                        lblRespostaMoeda.Text = string.Format("$ {0:n2}", moeda);
                    }
                    else if (rdbEuro.Checked)
                    {
                        lbltextmoeda.Text = "Você tem (em Euro):";
                        lbltextvalor.Text = "O Euro vale:";
                        lblResposta.Text = string.Format("€ {0:n2}", resultado);
                        lblRespostaMoeda.Text = string.Format("€ {0:n2}", moeda);
                    }   
                    else if (rdbIene.Checked)
                    {
                        lbltextmoeda.Text = "Você tem (em Iêne):";
                        lbltextvalor.Text = "O Iêne vale:";
                        lblResposta.Text = string.Format("¥ {0:n2}", resultado);
                        lblRespostaMoeda.Text = string.Format("¥ {0:n2}", moeda);
                    }
                    else if (rdbPeso.Checked)
                    {
                        lbltextmoeda.Text = "Você tem (em Peso):";
                        lbltextvalor.Text = "O Peso vale:";
                        lblResposta.Text = string.Format("ARS $ {0:n2}", resultado);
                        lblRespostaMoeda.Text = string.Format("ARS $ {0:n2}", moeda);
                    }

                    

                }
                else
                {
                    MessageBox.Show("Preencha todos os campos",
                     "Erro", MessageBoxButtons.OK,
                     MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Utilize apenas números",
                     "Erro", MessageBoxButtons.OK,
                     MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                txtMoeda.Text = "";
                txtMoeda.Focus();
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            calcularCampos();
        }

        private void limparCampos()
        {
            rdbDollar.Enabled = false;
            rdbEuro.Enabled = false;
            rdbIene.Enabled = false;
            rdbPeso.Enabled = false;
            rdbDollar.Checked = false;
            rdbEuro.Checked = false;
            rdbIene.Checked = false;
            rdbPeso.Checked = false;
            txtMoeda.Enabled = false;
            txtMoeda.Clear();
            txtReais.Clear();
            txtReais.Focus();
            lblResposta.Text = "";
            lblRespostaMoeda.Text = "";
            lbltextvalor.Text = "";
            lbltextmoeda.Text = "";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void txtReais_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                rdbDollar.Focus();
            }
        }

        private void rdbDollar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMoeda.Focus();
            }
        }

        private void rdbIene_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMoeda.Focus();
            }
        }

        private void rdbEuro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMoeda.Focus();
            }
        }

        private void rdbPeso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMoeda.Focus();
            }
        }

        private void txtMoeda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                calcularCampos();
            }
        }
    }
}
