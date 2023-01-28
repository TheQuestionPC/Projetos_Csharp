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
    public partial class FRM_Portugues : Form
    {

        string msg, titulo, tipo;
        MessageBoxButtons botoes;
        MessageBoxIcon icone;
        MessageBoxDefaultButton definido;

        //portugues
        private String[] palavrasportugues;
        private String[] dicasportugues;
        private String[] descriçaoportugues;

        private String palavra;
        private String tela;
        private int posiçaopalavraportugues;
        private String descriçao;
        private int tentativas;

        public FRM_Portugues()
        {
            InitializeComponent();
        }

        private void FRM_Portugues_Load(object sender, EventArgs e)
        {

            this.PORTUGUES();
        }

        private void PORTUGUES()
        {
            palavrasportugues = new String[15];
            dicasportugues = new String[15];
            descriçaoportugues = new String[15];

            palavrasportugues[0] = "corajoso";
            dicasportugues[0] = "adjetivo";
            descriçaoportugues[0] = "Corajoso é aquele que enfrenta os obstáculos apesar do própio medo";

            palavrasportugues[1] = "estudioso";
            dicasportugues[1] = "adjetivo ";
            descriçaoportugues[1] = "Estudioso é aquele que faz as coisas com estudo, atenção e perfeição ";

            palavrasportugues[2] = "adorável";
            dicasportugues[2] = "adjetivo ";
            descriçaoportugues[2] = "Adorável é aquele que encanta, que é admirável ";

            palavrasportugues[3] = "engraçado ";
            dicasportugues[3] = "adjetivo ";
            descriçaoportugues[3] = "Engraçado é aquele que tem bom humor e que nos faz rir ";

            palavrasportugues[4] = " inteligente";
            dicasportugues[4] = "adjetivo ";
            descriçaoportugues[4] = "Inteligente é aquele que expressa genialidade ";

            palavrasportugues[5] = " carinhoso";
            dicasportugues[5] = "adjetivo ";
            descriçaoportugues[5] = "Carinhoso é aquele que demonstra carinho, amor e atenção ";

            palavrasportugues[6] = "comunicar ";
            dicasportugues[6] = "verbo ";
            descriçaoportugues[6] = "Comunicar é transmitir e receber ideias ";

            palavrasportugues[7] = "responder ";
            dicasportugues[7] = "verbo ";
            descriçaoportugues[7] = "Responder é contestar uma pergunta ";

            palavrasportugues[8] = "respeitar ";
            dicasportugues[8] = "verbo ";
            descriçaoportugues[8] = "O respeito é um dos valores mais importantes do ser humano e tem grande importância na interação social. O respeito impede que uma pessoa tenha atitudes reprováveis em relação a outra. ";

            palavrasportugues[9] = "agradecer ";
            dicasportugues[9] = "verbo ";
            descriçaoportugues[9] = "Agradecer é demonstrar gratidão; oferecer graças; reconhecer um bem feito por outra pessoa ";

            palavrasportugues[10] = "explicar ";
            dicasportugues[10] = "verbo ";
            descriçaoportugues[10] = "Explicar é fazer com que fique claro e compreensível ";

            palavrasportugues[11] = "perguntar ";
            dicasportugues[11] = "verbo ";
            descriçaoportugues[11] = "Perguntar é questionar através de perguntas, tirar as próprias dúvidas ";

            palavrasportugues[12] = "alfabeto ";
            dicasportugues[12] = "abecedario ";
            descriçaoportugues[12] = "Alfabeto é um conjunto de letras utilizadas para escrever ";

            palavrasportugues[13] = "substantivos ";
            dicasportugues[13] = "classe de palavras ";
            descriçaoportugues[13] = "Substantivo é uma classe de palavras com que se atribui nome aos seres, ações, objetos, características, sentimentos e estados. ";

            palavrasportugues[14] = "adjetivos ";
            dicasportugues[14] = "palavra que qualifica ";
            descriçaoportugues[14] = "Adjetivo é uma palavra que qualifica, caracteriza ou classifica um substantivo ";
        }

        private void IniciaPortugues()
        {
            Random portugues = new Random();
            posiçaopalavraportugues = portugues.Next(0, 15);
            palavra = palavrasportugues[posiçaopalavraportugues];
            descriçao = descriçaoportugues[posiçaopalavraportugues];
            tela = "";
            for (int i = 0; i < palavra.Length; i++)
            {
                tela = tela + "#";
            }
            TXT_Palavra.Text = tela;
            lbl_dica.Text = dicasportugues[posiçaopalavraportugues];
            tentativas = 7;

        }

        private void TXT_Letra_TextChanged_1(object sender, EventArgs e)
        {
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

        private void TXT_Letra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsDigit(e.KeyChar)) || (char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }
        private void resetar()
        {
            lbl_dica.Text = "Dica palavra:";
            PBX_Forca.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\g.png");
            TXT_Dletras.Clear();
            tentativas = 7;
            TXT_Palavra.Clear();

        }

        private void TXT_Dletras_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTN_Iniciar_Click(object sender, EventArgs e)
        {
            this.IniciaPortugues();
        }

        private void Btn_verificar_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean encontrou= true;
                int posiçãoletra = 0;
                Char letra = Convert.ToChar(TXT_Letra.Text);
                TXT_Dletras.Text = TXT_Dletras.Text + TXT_Letra.Text;
                string txt = "";
                for (int i = 0; i < palavra.Length; i++)
                {
                    if (palavra[i] == letra)
                    {
                        encontrou = true;
                        posiçãoletra = i;
                        tentativas = tentativas;
                        txt = txt + TXT_Letra.Text;
                    }
                    else
                    {
                        txt = txt + tela[i];
                        encontrou = false;
                    }

                }
                tela = txt;
                TXT_Palavra.Text = tela;
                TXT_Letra.Clear();
                if (encontrou == false)
                {
                    tentativas--;
                }

                if (TXT_Palavra.Text.IndexOf('#') == -1)
                {
                    MessageBox.Show("Parabéns, você ganhou" + "\nAprenda um pouco mais sobre " + palavra + "\n" + descriçao, "RESULTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.resetar();
                }

                if (tentativas == 6)
                {
                    PBX_Forca.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\f.png");
                }
                else if (tentativas == 5)
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
                    MessageBox.Show("Infelizmente, você não acertou a palavra" + "\nA palavra correta é: " + palavra + "\n" + descriçao, "RESULTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
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