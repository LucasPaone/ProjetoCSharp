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

namespace Calculador_Combustível
{
    public partial class frmCombustivel : Form
    {

        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmCombustivel()
        {
            InitializeComponent();
            txtConsumo.Enabled = false;
            txtPreco.Enabled = false;
        }

        

        private void txtDistancia_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtDistancia.Text == "")
                {
                    lblQuilometragemresultado.Text = txtDistancia.Text;
                    txtConsumo.Enabled = false;
                    txtConsumo.Text = "";
                    
                }
                else
                {

                    lblQuilometragemresultado.Text = txtDistancia.Text + " Km";
                    Convert.ToDouble(txtDistancia.Text);
                    txtConsumo.Enabled = true;
                }

                
            }
            catch (Exception)
            {
                lblQuilometragemresultado.Text = "";
            }
        }

        private void txtConsumo_TextChanged(object sender, EventArgs e)
        {

            
            


            double num1, num2, resultado = 0;
            try
            {




                num1 = Convert.ToDouble(txtDistancia.Text);
                num2 = Convert.ToDouble(txtConsumo.Text);

                if (txtConsumo.Text != "")
                {
                    txtPreco.Enabled = true;
                }


                resultado = num1 / num2;




                lblcombustivelresultado.Text = string.Format("{0:n2}", resultado);

                

                
            }

            catch (Exception)
            {
                lblcombustivelresultado.Text = "";
            }

            if (txtConsumo.Text == "")
            {
                txtPreco.Enabled = false;
                txtPreco.Text = "";
            }




        }

        private void lblcombustivelresultado_Click(object sender, EventArgs e)
        {

        }

        private void txtPreco_TextChanged(object sender, EventArgs e)
        {
            double num1, num2, num3, resultado = 0;
            try
            {
                num1 = Convert.ToDouble(txtDistancia.Text);
                num2 = Convert.ToDouble(lblcombustivelresultado.Text);
                num3 = Convert.ToDouble(txtPreco.Text);

                resultado = (num1 / num2) * num3;

                lblTotal.Text = string.Format("R$ {0:n2}", resultado);

                



            }
            catch (Exception)
            {
                lblTotal.Text = "";
            }

            if (txtPreco.Text == "")
            {
                lblTotal.Text = "";
            }



        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtConsumo.Text = "";
            txtDistancia.Text = "";
            txtPreco.Text = "";
            lblcombustivelresultado.Text = "";
            lblQuilometragemresultado.Text = "";
            lblTotal.Text = "";
            txtDistancia.Focus();
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void frmCombustivel_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void txtDistancia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtConsumo.Focus();
            }
        }

        private void txtConsumo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPreco.Focus();
            }
        }

        
    }
}
