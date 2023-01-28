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

namespace TP03
{

    public partial class FRM_Principal : Form
    {
        #region variaveis globais
        string msg, titulo, tipo;
        MessageBoxButtons botoes;
        MessageBoxIcon icone;
        MessageBoxDefaultButton definido;
        byte ESCOLHA;
        double ARESTA, AREA, VOLUME;
        #endregion
        public FRM_Principal()
        {
            InitializeComponent();
        }

        #region valores definidos
        private void FRM_Principal_Load(object sender, EventArgs e)
        {
            ESCOLHA = 0;
            RDB_Cubo.Checked = false;
            RDB_Dodecaedro.Checked = false;
            RDB_Icosaedro.Checked = false;
            RDB_Octaedro.Checked = false;
            RDB_Tetaedro.Checked = false;
            BTN_Calcular.Enabled = false;
            BTN_Limpar.Enabled = false;
            TXT_Aresta.Enabled = false;
        }
        #endregion
        #region entrada tetraedro
        private void RDB_Tetaedro_CheckedChanged(object sender, EventArgs e)
        {
            if (RDB_Tetaedro.Checked == true) 
            {
                ESCOLHA = 1;
                RDB_Icosaedro.Checked  = false;
                RDB_Octaedro.Checked = false;
                RDB_Dodecaedro.Checked = false;
                RDB_Cubo.Checked = false;
                PBX_Solido.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\tetraedro.png");
                TXT_Aresta.Enabled = true;
                BTN_Calcular.Enabled = true;
                BTN_Limpar.Enabled = true;
                TXT_Aresta.Focus();
                tipo = RDB_Tetaedro.Text;
            }     
        }
        #endregion
        #region entrada cubo
        private void RDB_Cubo_CheckedChanged(object sender, EventArgs e)
        {
            if (RDB_Cubo.Checked == true)
            {
                ESCOLHA = 2;
                RDB_Tetaedro.Checked = false;
                RDB_Octaedro.Checked = false;
                RDB_Dodecaedro.Checked = false;
                RDB_Icosaedro.Checked = false;
                PBX_Solido.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\cubo.png");
                TXT_Aresta.Enabled = true;
                BTN_Calcular.Enabled = true;
                BTN_Limpar.Enabled = true;
                TXT_Aresta.Focus();
                tipo = RDB_Cubo.Text;
            }     
        }
        #endregion
        #region entrada octaedro
        private void RDB_Octaedro_CheckedChanged(object sender, EventArgs e)
        {
            ESCOLHA = 3;
            RDB_Tetaedro.Checked = false;
            RDB_Cubo.Checked = false;
            RDB_Dodecaedro.Checked = false;
            RDB_Icosaedro.Checked = false;
            PBX_Solido.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\octaedro.png");
            TXT_Aresta.Enabled = true;
            BTN_Calcular.Enabled = true;
            BTN_Limpar.Enabled = true;
            TXT_Aresta.Focus();
            tipo = RDB_Octaedro.Text;

        }
        #endregion
        #region entrada dodcaedro

        private void RDB_Dodecaedro_CheckedChanged(object sender, EventArgs e)
        {
            ESCOLHA = 4;
            RDB_Tetaedro.Checked = false;
            RDB_Octaedro.Checked = false;
            RDB_Cubo.Checked = false;
            RDB_Icosaedro.Checked = false;
            PBX_Solido.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\dodecaedro.png");
            TXT_Aresta.Enabled = true;
            BTN_Calcular.Enabled = true;
            BTN_Limpar.Enabled = true;
            TXT_Aresta.Focus();
            tipo = RDB_Dodecaedro.Text;

        }
        #endregion
        #region entrada icosaedro
        private void RDB_Icosaedro_CheckedChanged(object sender, EventArgs e)
        {
            ESCOLHA = 5;
            RDB_Tetaedro.Checked = false;
            RDB_Octaedro.Checked = false;
            RDB_Dodecaedro.Checked = false;
            RDB_Cubo.Checked = false;
            PBX_Solido.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\icosaedro.png");
            TXT_Aresta.Enabled = true;
            BTN_Calcular.Enabled = true;
            BTN_Limpar.Enabled = true;
            TXT_Aresta.Focus();
            tipo = RDB_Icosaedro.Text;
        }
        #endregion
        #region consiste Aresta
        private void TXT_Aresta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 8 || e.KeyChar == 44 || (e.KeyChar  > 47 && e.KeyChar < 58))
            {
                e.KeyChar = e.KeyChar;
            }
            else
            {
                e.KeyChar = Convert.ToChar(0);
            }
        }
        #endregion
        #region botao limpar
        private void BTN_Limpar_Click(object sender, EventArgs e)
        {
            msg = "Confrima";
            titulo = "Limpar dados?";
            botoes = MessageBoxButtons.YesNo;
            icone = MessageBoxIcon.Question;
            definido = MessageBoxDefaultButton.Button1;
            if (MessageBox.Show(msg, titulo, botoes, icone, definido) == DialogResult.Yes)
            {
                TXT_Aresta.Clear();
                TXT_Area.Clear();
                TXT_Volume.Clear();
                LBL_ResultadoSolido.Text = "";
                RDB_Cubo.Checked = false;
                RDB_Dodecaedro.Checked = false;
                RDB_Icosaedro.Checked = false;
                RDB_Octaedro.Checked = false;
                RDB_Tetaedro.Checked = false;
                BTN_Calcular.Enabled = false;
                BTN_Limpar.Enabled = false;
                TXT_Aresta.Enabled = false;
                PBX_Solido.Image = null;
                ESCOLHA = 0;

            }
        }
        #endregion
        #region botão sair
        private void BTN_Sair_Click(object sender, EventArgs e)
        {
            msg = "Tem certeza?";
            titulo = "Sair do programa...";
            botoes = MessageBoxButtons.YesNo;
            icone = MessageBoxIcon.Question;
            definido = MessageBoxDefaultButton.Button2;
            if (MessageBox.Show(msg, titulo, botoes, icone, definido) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        #endregion
        #region botao calcular
        private void BTN_Calcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (TXT_Aresta.Text == "")
                {
                    MessageBox.Show("Entre com os dados!", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TXT_Aresta.Focus();
                }
                else
                {
                    ARESTA = Convert.ToDouble(TXT_Aresta.Text);
                    if (ARESTA == 0)
                    {
                        MessageBox.Show("Dado incorreto!", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TXT_Aresta.Clear();
                        TXT_Aresta.Focus();
                    }
                    else
                    {
                        switch (ESCOLHA)
                        {
                            case 1:
                                AREA = Math.Sqrt(3 * ARESTA);
                                VOLUME = ((Math.Sqrt(2)) / 12) * (ARESTA * ARESTA * ARESTA);
                                break;
                            case 2:
                                AREA = 6 * ARESTA * ARESTA;
                                VOLUME = ARESTA * ARESTA * ARESTA;
                                break;
                            case 3:
                                AREA = 2 * (Math.Sqrt(3) * ARESTA * ARESTA);
                                VOLUME = 0.333333 * (Math.Sqrt(2 * ARESTA * ARESTA * ARESTA));
                                break;
                            case 4:
                                AREA = 3 * (Math.Sqrt(25 + 10 * (Math.Sqrt(5 * ARESTA * ARESTA))));
                                VOLUME = 0.25 * (15 + (7 * (Math.Sqrt(5)))) * (ARESTA * ARESTA * ARESTA);
                                break;
                            case 5:
                                AREA = 5 * (Math.Sqrt(3 * (ARESTA * ARESTA)));
                                VOLUME = 0.416666667 * (3 + (Math.Sqrt(5))) * (ARESTA * ARESTA * ARESTA);
                                break;
                        }
                        LBL_ResultadoSolido.Text = tipo;
                        TXT_Area.Text = AREA.ToString("###0.00");
                        TXT_Volume.Text = VOLUME.ToString("###0.00");

                    }
                }
            }
            catch
            {
                MessageBox.Show("Erro nos cálculos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
        #endregion

    }
}