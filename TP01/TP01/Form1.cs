using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP01
{
    public partial class FRM_ConversãoDeCircuitos : Form
    {
        #region Variáveis globais
        string msg, titulo;
        MessageBoxButtons botoes;
        MessageBoxIcon icone;
        MessageBoxDefaultButton definido;
        #endregion

        #region Form/inicializar
        public FRM_ConversãoDeCircuitos()
        {
            InitializeComponent();
            TXT_R1.Select();
        }
        #endregion

        #region botão calcular
        private void BTN_Calcular_Click(object sender, EventArgs e)
{
            #region Eventual erro
            try
            {
                if (TXT_R1.Text == "")
                {
                    msg = "Entre com os valores !!!";
                    titulo = "Erro";
                    botoes = MessageBoxButtons.OK;
                    icone = MessageBoxIcon.Error;
                    definido = MessageBoxDefaultButton.Button1;
                    if (MessageBox.Show(msg, titulo, botoes, icone, definido) == DialogResult.OK)
                    {
                        TXT_R1.Focus();
                        TXT_R1.Select();
                        return; 
                    }
                }
                else
                {
                    if (TXT_R2.Text == "")
                    {
                        msg = "Entre com os valores !!!";
                        titulo = "Erro";
                        botoes = MessageBoxButtons.OK;
                        icone = MessageBoxIcon.Error;
                        definido = MessageBoxDefaultButton.Button1;
                        if (MessageBox.Show(msg, titulo, botoes, icone, definido) == DialogResult.OK)
                        {
                            TXT_R2.Focus();
                            TXT_R2.Select();
                            return;
                        }
                    }
                    else
                    {
                        if (TXT_R3.Text == "")
                        {
                            msg = "Entre com os valores !!!";
                            titulo = "Erro";
                            botoes = MessageBoxButtons.OK;
                            icone = MessageBoxIcon.Error;
                            definido = MessageBoxDefaultButton.Button1;
                            if (MessageBox.Show(msg, titulo, botoes, icone, definido) == DialogResult.OK)
                            {
                                TXT_R3.Focus();
                                TXT_R3.Select();
                                return;
                            }
                        }
                        #endregion
                        else
                        {
                            float r4, r5, r6;
                            r4 = (float.Parse(TXT_R1.Text) + float.Parse(TXT_R2.Text)) / (float.Parse(TXT_R1.Text) + float.Parse(TXT_R2.Text) + float.Parse(TXT_R3.Text));
                            r5 = (float.Parse(TXT_R2.Text) + float.Parse(TXT_R3.Text)) / (float.Parse(TXT_R1.Text) + float.Parse(TXT_R2.Text) + float.Parse(TXT_R3.Text));
                            r6 = (float.Parse(TXT_R3.Text) + float.Parse(TXT_R1.Text)) / (float.Parse(TXT_R1.Text) + float.Parse(TXT_R2.Text) + float.Parse(TXT_R3.Text));
                            LBL_R4.Text = "O valor calculado de R4 foi de " + r4.ToString("F") + " Ohm/Ohms";
                            LBL_R5.Text = "O valor calculado de R5 foi de " + r5.ToString("F") + " Ohm/Ohms";
                            LBL_R6.Text = "O valor calculado de R6 foi de " + r6.ToString("F") + " Ohm/Ohms";
                        



                        }
                    }
                }
            }
            catch
            {
                msg = "Use os valores correspondentes às resistências";
                titulo = "Erro";
                botoes = MessageBoxButtons.OK;
                icone = MessageBoxIcon.Stop;
                definido = MessageBoxDefaultButton.Button1;
                if (MessageBox.Show(msg, titulo, botoes, icone, definido) == DialogResult.OK)
                {
                    TXT_R1.Focus();
                    TXT_R1.Select();
                    return;
                }
            }
}
        #endregion

        #region botão limpar
        private void BTN_Limpar_Click(object sender, EventArgs e)
        {
            msg = "Limpar dados?";
            titulo = "Confirmar ação";
            botoes = MessageBoxButtons.YesNo;
            icone = MessageBoxIcon.Question;
            definido = MessageBoxDefaultButton.Button1;
            if (MessageBox.Show(msg, titulo, botoes, icone, definido) == DialogResult.Yes)
            {
                TXT_R1.Clear();
                TXT_R2.Clear();
                TXT_R3.Clear();
                LBL_R4.Text = "R4";
                LBL_R5.Text = "R5";
                LBL_R6.Text = "R6";
                TXT_R1.Focus();
            }
        }

        #endregion

        #region botão sair
        private void BTN_Sair_Click(object sender, EventArgs e)
        {
            msg = "Confirmar saída do programa";
            titulo = "Sair";
            botoes = MessageBoxButtons.OKCancel;
            icone = MessageBoxIcon.Exclamation;
            definido = MessageBoxDefaultButton.Button2;
            if (MessageBox.Show(msg, titulo, botoes, icone, definido) == DialogResult.OK)
            {
                this.Close();
            }

        }
        #endregion
    }
}
