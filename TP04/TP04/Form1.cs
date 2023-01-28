using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // para acessar as imagens 

namespace TP04
{
    public partial class FRM_Principal : Form
    {
        #region variáveis globais
        string msg, titulo;
        MessageBoxButtons botoes;
        MessageBoxIcon icone;
        MessageBoxDefaultButton definido;
        int contador, tipo;
        double PRESSAO, TEMPERATURA;
        #endregion

        #region botão sair
        private void BTN_Sair_Click(object sender, EventArgs e)
        {
            msg = "Sair?";
            titulo = "Sair do programa...";
            botoes = MessageBoxButtons.YesNo;
            icone = MessageBoxIcon.Question;
            definido = MessageBoxDefaultButton.Button2;
            if(MessageBox.Show(msg, titulo, botoes, icone, definido) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        #endregion

        #region load principal
        private void FRM_Principal_Load(object sender, EventArgs e)
        {
            contador = 1;
            tipo = 0;
            BTN_Calcular.Enabled = false;
            BTN_Limpar.Enabled = false;

        }

        #endregion

        #region Rotina  de tratamento de valor numérico
        private void Verifica(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || e.KeyChar == 44 || e.KeyChar == 45 || (e.KeyChar > 47 && e.KeyChar < 58))
            {
                e.KeyChar = e.KeyChar;
            }
            else
            {
                e.KeyChar = Convert.ToChar(0);
            }
        }
#endregion 
        
        #region caixa de erros
        private void Tipo(object sender, CancelEventArgs e)
        {
            if (tipo == 1)
            {
                MessageBox.Show("Pressão incorreta", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TXT_Pressão.Clear();
                TXT_Pressão.Focus();
            }
            else
            {
                MessageBox.Show("Temperatura incorreta", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TXT_Temperatura.Clear();
                TXT_Temperatura.Focus();
            }
        }
        #endregion
        public FRM_Principal()
        {
            InitializeComponent();
        }

        #region botão limpar
        private void BTN_Limpar_Click(object sender, EventArgs e)
        {
            msg = "Confirma";
            titulo = "Limpar...";
            botoes = MessageBoxButtons.YesNo;
            icone = MessageBoxIcon.Asterisk;
            definido = MessageBoxDefaultButton.Button1;
            if (MessageBox.Show(msg, titulo, botoes, icone, definido) == DialogResult.Yes)
            {
                TXT_Pressão.Clear();
                TXT_Temperatura.Clear();
                PBX_Animação.Image = null;
                LTB_Resultado.Items.Clear();
            }

        }
        #endregion

        #region validar pressao
        private void TXT_Pressão_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                tipo = 1;
                PRESSAO = Convert.ToDouble(TXT_Pressão.Text);
                if (PRESSAO <= 0)
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

        #region controle conteúdo - pressão

        Boolean TestaCampos()
        {
            if (TXT_Pressão.Text.Length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region habilita botões calcular e limpar
        private void TXT_Pressão_TextChanged(object sender, EventArgs e)
        {
            BTN_Calcular.Enabled = TestaCampos();
            BTN_Limpar.Enabled = TestaCampos();
        }

        #endregion 

        #region timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            //timer controlando atualizaçao do contador
            contador = contador % 9 + 1;
            //chamar imagem no diretório
            PBX_Animação.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\CH" + Convert.ToString(contador) + ".bmp");
        }
        #endregion

        private void BTN_Calcular_Click(object sender, EventArgs e)
        {
            double volumefinal;
            TEMPERATURA = Convert.ToDouble(TXT_Temperatura.Text);
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    volumefinal = ((0.082 / PRESSAO) * (TEMPERATURA)) + 273;
                
                    LTB_Resultado.Items.Add("V.final para  " + TEMPERATURA + (" graus celsius = ") + volumefinal.ToString("#0.0000"));
                    TEMPERATURA += 2;
                }
            }
            catch
            {
                MessageBox.Show("Erro no cálculo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
        }

    }
}
