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

namespace JogoDaForca
{
    public partial class FRM_Historia : Form
    {
        string msg, titulo, tipo;
        MessageBoxButtons botoes;
        MessageBoxIcon icone;
        MessageBoxDefaultButton definido;
        //historia
        private String[] palavrashistoria;
        private String[] dicashistoria;
        private String[] descricaohistoria;
        private int posiçaopalavrahistoria;
        private String palavradatela;

        private String palavra;
        private String descriçao;
        private int tentativas;
        public FRM_Historia()
        {
            InitializeComponent();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            msg = "Tem certeza?";
            titulo = "Sair do programa...";
            botoes = MessageBoxButtons.YesNo;
            icone = MessageBoxIcon.Question;
            definido = MessageBoxDefaultButton.Button3;
            if (MessageBox.Show(msg, titulo, botoes, icone, definido) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FRM_Historia_Load(object sender, EventArgs e)
        {
            this.HISTORIA();
            btn_verificar.Enabled = false;
        }

        private void HISTORIA()
        {
            palavrashistoria = new String[15];
            dicashistoria = new String[15];
            descricaohistoria = new String[15];

            palavrashistoria[0] = "escravos";
            dicashistoria[0] = "Vive de trabalho sem receber algo em troca";
            descricaohistoria[0] = "Os escravos eram pessoas que eram forçados a trabalhar para outras pessoas e recebiam apenas comida em troca";

            palavrashistoria[1] = "portugueses";
            dicashistoria[1] = "Povo de Portugal";
            descricaohistoria[1] = "Os portugueses são povos que vieram de Portugal, são conhecidos por terem colonizado o Brasil";

            palavrashistoria[2] = "imigrantes";
            dicashistoria[2] = "Pessoa que saiu de seu país de origem";
            descricaohistoria[2] = "Imigrantes são indivíduos que saíram de seu país de origem para procurar melhores condições de vida";

            palavrashistoria[3] = "indígenas";
            dicashistoria[3] = "Nascido no país em que vive antes de ser colonizado";
            descricaohistoria[3] = "Os povos indígenas do Brasil vivem em várias regiões do país e possuem diversos modos de vida. Atualmente, muitos estão sofrendo com a invasão e a perda de suas terras, das quais dependem para sobreviver.";

            palavrashistoria[4] = "navegações";
            dicashistoria[4] = "Viagem pelo mar / plural";
            descricaohistoria[4] = "As navegações eram práticas principalmente dominadas pelos portugueses, que foram pioneiros na Era dos descobrimentos";

            palavrashistoria[5] = "carnaval";
            dicashistoria[5] = "Data comemorativa";
            descricaohistoria[5] = "Carnaval é um festival muito conhecido no Brasil pelo samba e carros alegóricos";

            palavrashistoria[6] = "revolução";
            dicashistoria[6] = "Transformação radical";
            descricaohistoria[6] = "Revolução é transformação radical de uma determinada estrutura política, social, econômica, cultural ou tecnológica.";

            palavrashistoria[7] = "culturas";
            dicashistoria[7] = "Modo de vida dos povos ou nações";
            descricaohistoria[7] = "Cultura é o modo de vida de um povo ou nação, expressando o seu modo de sentir, pensar e agir";

            palavrashistoria[8] = "Industrialização";
            dicashistoria[8] = "Aplicação de indústrias";
            descricaohistoria[8] = "Industrialização é tornar a indústria como o setor mais importante da economia";

            palavrashistoria[9] = "imperatriz";
            dicashistoria[9] = "Mulher do imperador";
            descricaohistoria[9] = "Imperatriz é a mulher que governa um império";

            palavrashistoria[10] = "preconceito";
            dicashistoria[10] = "Péssimo ato de discriminar alguém";
            descricaohistoria[10] = "Preconceito é um sentimento hostil que todos devemos combater";

            palavrashistoria[11] = "Cristianismo";
            dicashistoria[11] = "Religião";
            descricaohistoria[11] = "O Cristianismo baseia-se na fé em Jesus Cristo e surge no século I, na Palestina.";

            palavrashistoria[12] = "economia";
            dicashistoria[12] = "dinheiro controlado";
            descricaohistoria[12] = "Economia é o conjunto dos setores: primário, secundário e terciário";

            palavrashistoria[13] = "imperialismo";
            dicashistoria[13] = "domínio territorial";
            descricaohistoria[13] = "Imperialismo consiste numa política de expansão e o domínio territorial, cultural e econômico de uma nação sobre outras.";

            palavrashistoria[14] = "religião";
            dicashistoria[14] = "Ter fé no que é sagrado";
            descricaohistoria[14] = "Religião é tudo aquilo que nos religa ao sagrado. Os gregos e os romanos foram os primeiros a terem reflexões religiosas.";


        }
        private void IniciaHistoria()
        {
            Random historia = new Random();
            posiçaopalavrahistoria = historia.Next(0, 14);
            palavra = palavrashistoria[posiçaopalavrahistoria];
            descriçao = descricaohistoria[posiçaopalavrahistoria];
            palavradatela = "";
            for (int i = 0; i < palavra.Length; i++)
            {
                palavradatela = palavradatela + "#";
            }
            TXT_Palavra.Text = palavradatela;
            lbl_dica.Text = dicashistoria[posiçaopalavrahistoria];
            tentativas = 7;
        }

        private void TXT_Letra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsDigit(e.KeyChar)) || (char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void BTN_Iniciar_Click(object sender, EventArgs e)
        {
            this.IniciaHistoria();
            btn_verificar.Enabled = true;
        }

        private void TXT_Dletras_TextChanged(object sender, EventArgs e)
        {

        }

        private void resetar()
        {
            lbl_dica.Text = "Dica palavra:";
            PBX_Forca.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\g.png");
            TXT_Dletras.Clear();
            tentativas = 7;
            TXT_Palavra.Clear();

        }
        private void Btn_verificar_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean encontrou = false;
                //int posiçãoletra = 0;
                Char letra = Convert.ToChar(TXT_Letra.Text);
                TXT_Dletras.Text = TXT_Dletras.Text + TXT_Letra.Text;
                string txt = "";
                for (int i = 0; i < palavra.Length; i++)
                {
                    if (palavra[i] == letra)
                    {
                        encontrou = true;
                        //posiçãoletra = i;

                        txt = txt + TXT_Letra.Text;
                    }
                    else
                    {
                        txt = txt + palavradatela[i];
                        encontrou = false;
                    }

                }
                palavradatela = txt;
                TXT_Palavra.Text = palavradatela;
                TXT_Letra.Clear();
                if(encontrou == true)
                {
                    tentativas = tentativas + 1;
                }
                if (encontrou == false)
                {
                    tentativas = tentativas -1;
                }
                if(TXT_Palavra.Text.IndexOf('#') == -1)
                {
                    MessageBox.Show("Parabéns, você ganhou" + "\nAprenda um pouco mais sobre " + palavra + "\n" + descriçao, "RESULTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.resetar();
                }

                if(tentativas == 6)
                {
                    PBX_Forca.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\f.png");
                }
                else if(tentativas == 5)
                {
                    PBX_Forca.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\e.png");
                }
                else if (tentativas == 4)
                {
                    PBX_Forca.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\d.png");
                }
                else if (tentativas == 3)
                {
                    PBX_Forca.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\c.png");
                }
                else if (tentativas == 2)
                {
                    PBX_Forca.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\a.png");
                }
                else if (tentativas == 1)
                {
                    PBX_Forca.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\b.png");
                }
                else if (tentativas == 0)
                {
                    MessageBox.Show("Infelizmente, você não acertou a palavra" + "\nA palavra correta é: " + palavra + "\n" + descriçao, "resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.resetar();
                }
            }
            catch
            {
                MessageBox.Show("insira uma letra.");
            }
        }

    }
}
