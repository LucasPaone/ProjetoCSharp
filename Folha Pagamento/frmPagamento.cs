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

namespace Folha_Pagamento
{
    public partial class frmPagamento : Form
    {

        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmPagamento()
        {
            InitializeComponent();
            txtBruto.Focus();
        }

        private void frmPagamento_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void CalcularCampos()
        {


            try
            {
                double bruto, cooperativa, ir, inss, liquido = 0;

                if (txtBruto.Text != "" && rdbClasseA.Checked || rdbClasseB.Checked || rdbClasseC.Checked)
                {


                    bruto = Convert.ToDouble(txtBruto.Text);

                    cooperativa = 0;

                    if (rdbClasseA.Checked)
                    {
                        cooperativa = bruto * 30 / 100;


                    }
                    else if (rdbClasseB.Checked)
                    {
                        cooperativa = bruto * 20 / 100;

                    }
                    else if (rdbClasseC.Checked)
                    {
                        cooperativa = bruto * 10 / 100;

                    }



                    lblRespostaBruto.Text = string.Format("R$ {0:n2}", bruto);

                    lblRespostaCooperativa.Text = string.Format("R$ {0:n2}", cooperativa);




                    inss = 0;


                    if (bruto > 1412.00 && bruto <= 2666.68)
                    {
                        inss = bruto * 9 / 100;

                    }
                    else if (bruto > 2666.68 && bruto <= 4000.03)
                    {
                        inss = bruto * 12 / 100;

                    }
                    else if (bruto > 4000.03 && bruto <= 7786.02)
                    {
                        inss = bruto * 14 / 100;

                    }
                    else if (bruto > 7786.02)
                    {
                        inss = bruto * 14 / 100;

                    }

                    lblRespostaINSS.Text = string.Format("R$ {0:n2}", inss);

                    if (bruto <= 1412.00)
                    {
                        lblRespostaINSS.Text = "O INSS Não é cobrado!";
                    }


                    ir = 0;



                    if (bruto > 2112.00 && bruto <= 2826.65)
                    {
                        ir = bruto * 7.5 / 100;

                    }

                    if (bruto > 2826.65 && bruto <= 3751.05)
                    {
                        ir = bruto * 15 / 100;

                    }

                    if (bruto > 3751.05 && bruto <= 4664.68)
                    {
                        ir = bruto * 22.5 / 100;

                    }
                    else if (bruto > 4664.68)
                    {
                        ir = bruto * 22.5 / 100;

                    }

                    lblRespostaIR.Text = string.Format("R$ {0:n2}", ir);

                    if (bruto <= 2112.00)
                    {
                        lblRespostaIR.Text = "O IR Não é cobrado!";
                    }

                    liquido = bruto - cooperativa - inss - ir;

                    lblRespostaLiquido.Text = string.Format("R$ {0:n2}", liquido);



                    // }





                }
                else
                {
                    MessageBox.Show("Preencha todos os campos",
                     "Erro", MessageBoxButtons.OK,
                     MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                    txtBruto.Clear();
                    rdbClasseA.Checked = false;
                    rdbClasseB.Checked = false;
                    rdbClasseC.Checked = false;
                    lblRespostaBruto.Text = "";
                    lblRespostaCooperativa.Text = "";
                    lblRespostaINSS.Text = "";
                    lblRespostaIR.Text = "";
                    lblRespostaLiquido.Text = "";
                    txtBruto.Focus();
                }







            }
            catch (Exception)
            {
                MessageBox.Show("Utilize apenas números",
                     "Erro", MessageBoxButtons.OK,
                     MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                txtBruto.Clear();
                rdbClasseA.Checked = false;
                rdbClasseB.Checked = false;
                rdbClasseC.Checked = false;
                lblRespostaBruto.Text = "";
                lblRespostaCooperativa.Text = "";
                lblRespostaINSS.Text = "";
                lblRespostaIR.Text = "";
                lblRespostaLiquido.Text = "";
                txtBruto.Focus();

            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            CalcularCampos();
        }

        private void txtBruto_TextChanged(object sender, EventArgs e)
        {

        }

        private void limparCampos()
        {
            txtBruto.Clear();
            rdbClasseA.Checked = false;
            rdbClasseB.Checked = false;
            rdbClasseC.Checked = false;
            lblRespostaBruto.Text = "";
            lblRespostaCooperativa.Text = "";
            lblRespostaINSS.Text = "";
            lblRespostaIR.Text = "";
            lblRespostaLiquido.Text = "";
            txtBruto.Focus();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void txtBruto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                rdbClasseA.Focus();
            }
        }

        private void rdbClasseA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CalcularCampos();
            }
        }

        private void rdbClasseB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CalcularCampos();
            }
        }

        private void rdbClasseC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CalcularCampos();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {

        }
    }
}
