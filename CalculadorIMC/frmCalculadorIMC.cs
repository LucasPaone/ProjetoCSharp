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

namespace CalculadorIMC
{
    public partial class frmCalculadorIMC : Form
    {

        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmCalculadorIMC()
        {
            InitializeComponent();


        }

        private void frmCalculadorIMC_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void calcularIMC()
        {
            double peso, altura, preresultado, resultado = 0;

            try
            {
                peso = Convert.ToDouble(txtPeso.Text);
                altura = Convert.ToDouble(txtAltura.Text);

                if (txtPeso.Text != "" && txtAltura.Text != "")
                {

                    resultado = peso / (altura * altura);


                }

                if (resultado < 18.5)
                {
                    lblRespostaclassificacao.Text = "Magreza";
                    lblGrauobesidade.Text = "0";
                    lblGrauobesidade.BackColor = Color.LightBlue;
                    lblGrauobesidade.ForeColor = Color.Black;
                }
                else if (resultado >= 18.5 && resultado <= 24.9)
                {
                    lblRespostaclassificacao.Text = "Normal";
                    lblGrauobesidade.Text = "0";
                    lblGrauobesidade.BackColor = Color.Green;
                    lblGrauobesidade.ForeColor = Color.Black;
                }
                else if (resultado >= 25 && resultado <= 29.9)
                {
                    lblRespostaclassificacao.Text = "Sobrepeso";
                    lblGrauobesidade.Text = "|";
                    lblGrauobesidade.BackColor = Color.Yellow;
                    lblGrauobesidade.ForeColor = Color.Black;
                }
                else if (resultado >= 30 && resultado <= 39.9)
                {
                    lblRespostaclassificacao.Text = "Obesidade";
                    lblGrauobesidade.Text = "||";
                    lblGrauobesidade.BackColor = Color.OrangeRed;
                    lblGrauobesidade.ForeColor = Color.White;
                }
                else if (resultado >= 40)
                {
                    lblRespostaclassificacao.Text = "Obesidade Grave";
                    lblGrauobesidade.Text = "|||";
                    lblGrauobesidade.BackColor = Color.Red;
                    lblGrauobesidade.ForeColor = Color.White;
                }





                lblResposta.Text = string.Format("{0:n2}", resultado);






            }
            catch (Exception)
            {
                MessageBox.Show("Você precisa colocar o peso e a altura",
                     "Erro", MessageBoxButtons.OK,
                     MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                txtPeso.Clear();
                txtAltura.Clear();
                lblResposta.Text = "";
                lblRespostaclassificacao.Text = "";
                lblGrauobesidade.Text = "";
                txtPeso.Focus();
                lblGrauobesidade.BackColor = Color.White;
            }
        }

        

        private void limparCampos()
        {
            txtPeso.Clear();
            txtAltura.Clear();
            lblResposta.Text = "";
            lblRespostaclassificacao.Text = "";
            lblGrauobesidade.Text = "";
            txtPeso.Focus();
            lblGrauobesidade.BackColor = Color.White;


        }


        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void lblResposta_Click(object sender, EventArgs e)
        {

        }

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblRespostaclassificacao_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            calcularIMC();
        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void txtPeso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtAltura.Focus();
            }
        }

        private void txtAltura_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                calcularIMC();
            }
        }
    }
}
