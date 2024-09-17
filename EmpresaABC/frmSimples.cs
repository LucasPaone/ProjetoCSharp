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

namespace EmpresaABC
{
    public partial class frmSimples : Form
    {

        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmSimples()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Calcular()
        {
            double num1, num2, resultado = 0;

            if (txtVariavel1.Text == "" || txtVariavel2.Text == "")
            {
                MessageBox.Show("Prrencha os 2 campos de número",
             "Erro", MessageBoxButtons.OK,
             MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                txtVariavel1.Clear();
                txtVariavel2.Clear();
                rdbAdicao.Checked = false;
                rdbSubtracao.Checked = false;
                rdbMultiplicacao.Checked = false;
                rdbDivisao.Checked = false;
                txtVariavel1.Focus();
            }
            else
            {

                try
                {
                    num1 = Convert.ToDouble(txtVariavel1.Text);
                    num2 = Convert.ToDouble(txtVariavel2.Text);

                    if (txtVariavel1.Text != "" && txtVariavel2.Text != "")
                    {
                        num1 = Convert.ToDouble(txtVariavel1.Text);
                        num2 = Convert.ToDouble(txtVariavel2.Text);
                    }
                    else
                    {
                        MessageBox.Show("Coloque número nos 2 campos para calcular",
                     "Erro", MessageBoxButtons.OK,
                     MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                        txtVariavel1.Clear();
                        txtVariavel2.Clear();
                        rdbAdicao.Checked = false;
                        rdbSubtracao.Checked = false;
                        rdbMultiplicacao.Checked = false;
                        rdbDivisao.Checked = false;
                        txtVariavel1.Focus();
                    }

                    if (rdbAdicao.Checked || rdbDivisao.Checked || rdbMultiplicacao.Checked || rdbSubtracao.Checked)
                    {


                        if (rdbAdicao.Checked)
                        {
                            resultado = num1 + num2;
                        }

                        if (rdbSubtracao.Checked)
                        {
                            resultado = num1 - num2;
                        }

                        if (rdbMultiplicacao.Checked)
                        {

                            resultado = num1 * num2;
                        }

                        if (rdbDivisao.Checked)
                        {
                            if (num2 == 0)
                            {
                                lblValorresultado.Text = 0.ToString();
                                MessageBox.Show("Não é possível dividir um número por 0",
                                "Erro", MessageBoxButtons.OK,
                                 MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                                txtVariavel1.Clear();
                                txtVariavel2.Clear();
                                rdbAdicao.Checked = false;
                                rdbSubtracao.Checked = false;
                                rdbMultiplicacao.Checked = false;
                                rdbDivisao.Checked = false;
                                txtVariavel1.Focus();
                            }
                            else
                            {
                                resultado = num1 / num2;
                            }
                            


                        }

                        lblValorresultado.Text = resultado.ToString();

                    }
                    else
                    {
                        MessageBox.Show("Selecione um dos tipos de cálculo para calcular",
                        "Erro", MessageBoxButtons.OK,
                         MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                        txtVariavel1.Clear();
                        txtVariavel2.Clear();
                        rdbAdicao.Checked = false;
                        rdbSubtracao.Checked = false;
                        rdbMultiplicacao.Checked = false;
                        rdbDivisao.Checked = false;
                        txtVariavel1.Focus();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Os campos não podem ter letras e caracteres especiais, utilize apenas números!",
                     "Erro", MessageBoxButtons.OK,
                     MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    txtVariavel1.Clear();
                    txtVariavel2.Clear();
                    rdbAdicao.Checked = false;
                    rdbSubtracao.Checked = false;
                    rdbMultiplicacao.Checked = false;
                    rdbDivisao.Checked = false;
                    txtVariavel1.Focus();
                }
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            Calcular();

        }

        private void txtVariavel2_TextChanged(object sender, EventArgs e)
        {

        }

        private void limparCampos()
        {
            txtVariavel1.Clear();
            txtVariavel2.Clear();
            rdbAdicao.Checked = false;
            rdbSubtracao.Checked = false;
            rdbMultiplicacao.Checked = false;
            rdbDivisao.Checked = false;
            lblValorresultado.Text = "";
            txtVariavel1.Focus();
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void txtVariavel1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVariavel1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtVariavel2.Focus();
            }
        }

        private void txtVariavel2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                rdbAdicao.Focus();
            }
        }

        private void rdbAdicao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Calcular();
            }
        }

        private void rdbSubtracao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Calcular();
            }
        }

        private void rdbMultiplicacao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Calcular();
            }
        }

        private void rdbDivisao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Calcular();
            }
        }
    }
}
