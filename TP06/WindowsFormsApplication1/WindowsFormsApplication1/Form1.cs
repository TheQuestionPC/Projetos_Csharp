using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FRM_Principal : Form
    {
        #region variaveis globais
        int[] x = new int[20];
        int i, j, aux, quantidade;

        Boolean muda;
        #endregion
        public FRM_Principal()
        {
            InitializeComponent();
        }

        #region botão limpar
        private void MNU_Limpar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Limpar...", "Tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                TXT_Numero.Clear();
                TXT_Quantidade.Clear();
                LBL_posiçãonumerica.Text = Convert.ToString("0");
                LTB_Ordenado.Items.Clear();
                LTB_Fornecido.Items.Clear();
                LTB_Primo.Items.Clear();
                TXT_Numero.Enabled = true;
                BTN_Envia.Enabled = true;
                LBL_posiçãonumerica.Enabled = false;
                i = 1;
 
            }
        }
        #endregion

        #region sobre
        private void MNU_Sobre_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Autoria: Lucas 170958", "Sobre...",MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                return;
            }
        }
        #endregion

        #region botao ordenar

        private void MNU_Ordenar_Click(object sender, EventArgs e)
        {
            for (i = 1; i<= quantidade - 1; i++)
                for (j = i+1; j<=quantidade; j++)
                    if (x[i] > x[j])
                    {
                        aux = x[i];
                        x[i] = x[j];
                        x[j]=aux;
                    }
            for (i = 1; i <= quantidade; i++)
            {
                LTB_Ordenado.Items.Add(Convert.ToString(x[i]));
            }
        }
        #endregion

        #region consistencia numerica   
        private void TXT_Quantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || e.KeyChar == 45 || (e.KeyChar > 47 && e.KeyChar < 58))
            {
                e.KeyChar = e.KeyChar;
            }
            else
            {
                e.KeyChar = Convert.ToChar(0);
            }
        }
        #endregion

        #region mudar cor mensagem
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (muda == true)
            {
                LBL_Limite.ForeColor = Color.Red;
                muda = false;
            }
            else
            {
                LBL_Limite.ForeColor = Color.Black;
                muda = true;
            }
        }
        #endregion

        #region validating do numero e adiciona no listbox
        private void TXT_Numero_Validating(object sender, CancelEventArgs e)
        {
            Int16 numero = Convert.ToInt16(TXT_Numero.Text);
            if (numero <= 0)
            {
                TXT_Numero.Clear();
                TXT_Numero.Focus();
            }
            if (numero > 30)
            {
                MessageBox.Show("Apenas números no intervalo de 1 a 30", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TXT_Numero.Clear();
            }
            if (TXT_Numero.Text != "")
            {
                LBL_posiçãonumerica.Text = Convert.ToString(i);
                if (i < quantidade)
                {
                    x[i] = int.Parse(TXT_Numero.Text);
                    i++;
                }
                else
                {
                    x[quantidade] = int.Parse(TXT_Numero.Text);
                    LBL_posiçãonumerica.Enabled = false;
                    TXT_Numero.Enabled = false;
                    BTN_Envia.Enabled = false;
                    for (i = 1; i <= quantidade; i++)
                    {
                        int divisivel = 0;

                        for (int num = 1; num <= x[i]; num++)
                        {
                            if (x[i] % num == 0)
                            {
                                divisivel++;
                            }
                        }
                        if (divisivel == 2)
                        {

                            {
                                LTB_Primo.Items.Add(Convert.ToString(x[i]) + " - primo");
                                LTB_Fornecido.Items.Add(Convert.ToString(x[i]));
                            }
                        }
                        else
                        {
                            LTB_Fornecido.Items.Add(Convert.ToString(x[i]));
                        }
                    }
          
                }
            }
            else
            {
                return;
            }
        }
        #region fechar
        private void FRM_Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Tem certeza?", "Sair...",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.No)
                e.Cancel = true;

        }
        #endregion

        #region validating txt quantidade
        private void TXT_Quantidade_Validating(object sender, CancelEventArgs e)
        {
            if (TXT_Quantidade.Text == "")
            {
                MessageBox.Show("Preencha o campo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TXT_Quantidade.Focus();
            }
            else
            {
                quantidade = Convert.ToInt16(TXT_Quantidade.Text);
                if (quantidade == 0)
                {
                    MessageBox.Show("Quantidade incorreta", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TXT_Quantidade.Clear();
                    TXT_Quantidade.Focus();
                }
                if (quantidade > 20)
                {
                    MessageBox.Show("Quantidade incorreta \n valor superior ao limite (20)", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TXT_Quantidade.Clear();
                    TXT_Quantidade.Focus();
                }
                LBL_posiçãonumerica.Text = Convert.ToString(i);
            }
        }
        #endregion

        #region load
        private void FRM_Principal_Load(object sender, EventArgs e)
        {
            i = 1;
            muda = true;
        }
        #endregion

        #region botao enviar
        private void BTN_Envia_Click(object sender, EventArgs e)
        {
            TXT_Numero.Clear();
            TXT_Numero.Focus();
        }
    }
}
        #endregion

