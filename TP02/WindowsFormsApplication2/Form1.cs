using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class FRM_Principal : Form
    {
        #region variaveis globais
        string msg, titulo;
        MessageBoxButtons botoes;
        MessageBoxIcon icone;
        MessageBoxDefaultButton definido;
        #endregion
        public FRM_Principal()
        {
            InitializeComponent();
            TXT_VelocidadeInicial.Select();
        }
        #region  Desabilitar botões
        private void FRM_Principal_Load(object sender, EventArgs e)
        {
            //Desabilitar os botões calcular e limpar
            BTN_Calcular.Enabled = false;
            BTN_Limpar.Enabled = false;
        }
        #endregion

        #region gerando consistencia numérica
        private void TXT_VelocidadeInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            //verificar se comandos são válidos
            if (e.KeyChar == 8 || e.KeyChar == 44 || (e.KeyChar > 47 && e.KeyChar < 58))
            {
                e.KeyChar = e.KeyChar;
            }
            else
            {
                e.KeyChar = Convert.ToChar(0);
            }
        }
        #endregion

        #region Entrada dados velocidade inicial
        private void TXT_VelocidadeInicial_TextChanged(object sender, EventArgs e)
        {
            //Texto digitado
            BTN_Calcular.Enabled = VFCampo();
            BTN_Limpar.Enabled = VFCampo();
        }
        #endregion

        #region Função controle
        Boolean VFCampo()
        {
            if (TXT_VelocidadeInicial.TextLength > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region botão calcular
        private void BTN_Calcular_Click(object sender, EventArgs e)
        {
            Double V0, A, T, V;
            //V0 - velocidade inicial               //A - aceleração
            //T - intervalo de tempo                //V - velocidade 
            //M - tipo de movimento

            try
            {
                V0 = Convert.ToDouble(TXT_VelocidadeInicial.Text);
                A = Convert.ToDouble(TXT_Aceleração.Text);
                T = Convert.ToDouble(TXT_IntervaloTempo.Text);
                if (T <= 0)
                {
                    MessageBox.Show("Tempo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    T = 0;
                    TXT_IntervaloTempo.Clear();
                    TXT_IntervaloTempo.Focus();
                }
                else
                {
                    if (A == 0)
                    {
                        V = V0 + A * T;
                        V = V0;
                        TXT_Movimento.Text = "Movimento uniforme";
                    }
                    else
                    {
                        if (A < 0)
                        {
                            V = V0;
                            TXT_Movimento.Text = "Movimento retardado";
                        }
                        else
                        {
                            V = V0 + A * T;
                            TXT_Movimento.Text = "Movimento Avançado";
                        }
                    }
                    TXT_ResultadoVelocidade.Text = V.ToString("##0000.00000");
                }

            }
            catch
            {
                MessageBox.Show("Erro nos cálculos ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;            
            }
        }
        #endregion

        #region botao limpar
        private void BTN_Limpar_Click(object sender, EventArgs e)
        {
            msg = "Limpar?";
            titulo = "Limpar dados...";
            botoes = MessageBoxButtons.YesNo;
            icone = MessageBoxIcon.Exclamation;
            definido = MessageBoxDefaultButton.Button1;
            if (MessageBox.Show(msg, titulo, botoes, icone, definido) == DialogResult.Yes)
            {
                TXT_Aceleração.Clear();
                TXT_IntervaloTempo.Clear();
                TXT_Movimento.Clear();
                TXT_ResultadoVelocidade.Clear();
                TXT_VelocidadeInicial.Clear();
                TXT_VelocidadeInicial.Focus();
            }
        }
        #endregion

        #region botao sair
        private void BTN_Sair_Click(object sender, EventArgs e)
        {
            msg = "Sair?";
            titulo = "Fechar programa";
            botoes = MessageBoxButtons.YesNo;
            icone = MessageBoxIcon.Question;
            definido = MessageBoxDefaultButton.Button2;
            if (MessageBox.Show(msg, titulo, botoes, icone, definido) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        #endregion
    }

}
   