using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TP_06_09
{
    public partial class FRM_Principal : Form
    {
        #region variáveis globais
        string msg, titulo;
        MessageBoxButtons botoes;
        MessageBoxIcon icone;
        MessageBoxDefaultButton definido;
        int contador, tipo;
        Double amplificaçao, capacitor, frequencia, passo;
        #endregion
        #region validating amplificação
        private void TXT_Amplificação_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                tipo = 1;
                amplificaçao = Convert.ToDouble(TXT_Amplificação.Text);
                if (amplificaçao <= 0)
                {
                    Tipo(sender, e);
                }
            }
            catch
            {
                Tipo(sender, e);
            }
        }
        #endregion
        #region validating capacitor
        private void TXT_Capacitor_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                tipo = 2;
                capacitor = Convert.ToDouble(TXT_Capacitor.Text);
                if (capacitor <= 0)
                {
                    Tipo(sender, e);
                }
            }
            catch
            {
                Tipo(sender, e);
            }
        }
        #endregion
        #region validating frequencia
        private void TXT_Frequencia_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                tipo = 3;
                frequencia = Convert.ToDouble(TXT_Frequencia.Text);
                if (frequencia <= 0)
                {
                    Tipo(sender, e);
                }
            }
            catch
            {
                Tipo(sender, e);
            }
        }
        #endregion
        #region validating passo
        private void TXT_Passo_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                tipo = 4;
                passo = Convert.ToDouble(TXT_Passo.Text);
                if (passo <= 0)
                {
                    Tipo(sender, e);
                }
            }
            catch
            {
                Tipo(sender, e);
            }
        }
        #endregion
        private void FRM_Principal_Load(object sender, EventArgs e)
        {
            tipo = 0;
            contador = 1;
            BTN_Calcular.Enabled = false;
            BTN_Limpar.Enabled = false;
            BTN_Sair.Enabled = false;
        }

        private void TXT_Amplificação_KeyPress(object sender, KeyPressEventArgs e)
        {
            Verifica(sender, e);
        }

        #region habilita botoes
        private void TXT_Amplificação_TextChanged(object sender, EventArgs e)
        {
            BTN_Calcular.Enabled = TestaCampos();
            BTN_Limpar.Enabled = TestaCampos();
            BTN_Sair.Enabled = TestaCampos();
        }
        #endregion
        #region botao limpar
        private void BTN_Limpar_Click(object sender, EventArgs e)
        {
            TXT_Amplificação.Clear();
            TXT_Capacitor.Clear();
            TXT_Frequencia.Clear();
            TXT_Passo.Clear();
            LTB_C2.Items.Clear();
            LTB_R1.Items.Clear();
            LTB_R2.Items.Clear();
            LTB_R3.Items.Clear();
            TXT_Amplificação.Focus();

        }
        #endregion
        #region botao sair
        private void BTN_Sair_Click(object sender, EventArgs e)
        {
            msg = "Sair do programa?";
            titulo = "Sair...";
            botoes = MessageBoxButtons.YesNo;
            icone = MessageBoxIcon.Question;
            definido = MessageBoxDefaultButton.Button2;
            if (MessageBox.Show(msg,titulo,botoes,icone,definido)== DialogResult.Yes)
            {
                this.Close();
            }
        }
        #endregion
        #region botao calcular
        private void BTN_Calcular_Click(object sender, EventArgs e)
        {
            double r1, r2, r3, c2;

           try
            {
                for (int i = 0; i<5; i++)
                {
                    r1 = Math.Sqrt(2) / ((2 * amplificaçao) * (2 * Math.PI) * frequencia * capacitor);
                    LTB_R1.Items.Add(amplificaçao.ToString("#0") + "->" + r1.ToString("#0.0000"));
                    
                    r2 = amplificaçao * r1;
                    LTB_R2.Items.Add(amplificaçao.ToString("#0") + "->" + r2.ToString("#0.0000"));
                    r3 = r2 / (amplificaçao + 1);
                    LTB_R3.Items.Add(amplificaçao.ToString("#0") + "->" + r3.ToString("0.0000"));
                    c2 = 2 * (amplificaçao + 1) * capacitor;
                    LTB_C2.Items.Add(amplificaçao.ToString("#0") + "->" + c2.ToString("#0.0000"));
                    amplificaçao += passo;
                }
            }
            catch
            {
                MessageBox.Show("Erro no cálculo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion

        }
        #region keypress passo
        private void TXT_Passo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || (e.KeyChar > 47 && e.KeyChar < 58))
            {
                e.KeyChar = e.KeyChar;
            }
            else
            {
                e.KeyChar = Convert.ToChar(0);
            }
        }
        #endregion
        public FRM_Principal()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            contador = contador % 9 + 1; //atualização do contador
            PBX_Imagem.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\res0" + Convert.ToString(contador) + ".bmp"); //chamada respectiva imagem

        }

        #region rotina tratamento valor numérico
        private void Verifica (object sender, KeyPressEventArgs e)
        {
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
        private void Tipo (object sender, CancelEventArgs e)
        {
            if (tipo == 1)
            {
                MessageBox.Show("Erro na amplificação", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TXT_Amplificação.Clear();
                TXT_Amplificação.Focus();
            }
            else if (tipo == 2)
            {
                MessageBox.Show("Erro no capacitor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TXT_Capacitor.Clear();
                TXT_Capacitor.Focus();
            }
            else if (tipo == 3)
            {
                MessageBox.Show("Erro na frequência", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TXT_Frequencia.Clear();
                TXT_Frequencia.Focus();
            }
            else
            {
                MessageBox.Show("Erro no passo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TXT_Passo.Clear();
                TXT_Passo.Focus();
            }
        }
        #region funçao controle para amplificaçao
        Boolean TestaCampos()
        {
            if (TXT_Amplificação.Text.Length > 0)
            {
                return true;    
            }
            else
            {
                return false;
            }
        }
        #endregion

    }
}
