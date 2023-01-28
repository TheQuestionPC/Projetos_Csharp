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
    public partial class FRM_Ciencias : Form
    {
        #region Variaveis globais
        string msg, titulo, tipo;
        MessageBoxButtons botoes;
        MessageBoxIcon icone;
        MessageBoxDefaultButton definido;
        //ciencias
        private String[] palavrasciencias;
        private String[] dicasciencias;
        private String[] descricaociencias;
        private int posiçaopalavraciencias;
        private String palavradatela;
        private String palavra;
        private String descriçao;
        private int tentativas;
        #endregion

        public void TXT_Palavra_TextChanged(object sender, EventArgs e)
        {

        }

        private void FRM_Ciencias_Load(object sender, EventArgs e)
        {
            this.CIENCIAS();
            btn_verificar.Enabled = false;
        }

        private void CIENCIAS()
        {
            palavrasciencias = new String[15];
            dicasciencias = new String[15];
            descricaociencias = new String[15];

            palavrasciencias[0] = "margarída";
            dicasciencias[0] = "flor";
            descricaociencias[0] = "Margarida é uma flor muito popular. Ela é muito bonita por isso é bastante usada na decoração de casas e nos jardins.   ";

            palavrasciencias[1] = "girassol";
            dicasciencias[1] = "flor";
            descricaociencias[1] = "O girassol é conhecido por se virar para o sol, suas sementes são utilizadas na alimentação e para fins medicinais";

            palavrasciencias[2] = "orquídea";
            dicasciencias[2] = "Planta conhecida";
            descricaociencias[2] = "A orquídea é uma planta muito valorizada pela beleza e originalidade de suas flores. ";

            palavrasciencias[3] = "mamífero";
            dicasciencias[3] = "Animais que mamam";
            descricaociencias[3] = "Os mamíferos são os animais que amamentam seus filhotes. Este grupo é o mais desenvolvido dentre todas as espécies de animais";

            palavrasciencias[4] = "invertebrados";
            dicasciencias[4] = "Animais que não possuem coluna vertebral";
            descricaociencias[4] = "Invertebrados que são animais que não possuem esqueleto como forma de sustentação do corpo.";

            palavrasciencias[5] = "elefante";
            dicasciencias[5] = "Animal cinza";
            descricaociencias[5] = "Elefantes são os maiores animais terrestres do mundo, pesando toneladas. São herbívoros e se alimentam principalmente de folhas de árvores, ervas, raízes, frutos e gramas";

            palavrasciencias[6] = "cachorro";
            dicasciencias[6] = "Melhor amigo do homem";
            descricaociencias[6] = "O cão, que também chamamos de cachorro, é um dos animais mais estimados do mundo. Ele foi um dos primeiros bichos a serem domesticados pelo homem";

            palavrasciencias[7] = "esqueleto";
            dicasciencias[7] = "Conjunto de ossos";
            descricaociencias[7] = "Conjunto de ossos do corpo dos vertebrados que sustenta os nossos corpos.";

            palavrasciencias[8] = "poluição";
            dicasciencias[8] = "Sujeira no ar/oxigênio";
            descricaociencias[8] = "Poluição é a contaminação do ar por gases tóxicos.";

            palavrasciencias[9] = "vegetais";
            dicasciencias[9] = "Alimentos saudáveis e nutritivos";
            descricaociencias[9] = "Os vegetais são as verduras (acelga, alface, agrião, couve, escarola, espinafre, repolho, rúcula, entre outras) e as flores (alcachofra, brócolis e couve-flor)";

            palavrasciencias[10] = "carnívoros";
            dicasciencias[10] = "Animais que se alimentam principalmente de carne de outros animais.";
            descricaociencias[10] = "Os animais carnívoros são aqueles que se alimentam predominantemente da carne de outros animais. Chamados de predadores, eles são consumidores que podem ser identificados de duas formas diferentes: ";

            palavrasciencias[11] = "ambiente";
            dicasciencias[11] = "Tudo que rodeia ou envolve os seres vivos";
            descricaociencias[11] = "O meio ambiente é o local onde se desenvolve a vida na terra, ou seja, é a natureza com todos os seres vivos e não vivos que nela habitam e interagem.";

            palavrasciencias[12] = "Extinção";
            dicasciencias[12] = "Desaparecimento de uma espécie.";
            descricaociencias[12] = "Animais em extinção são aqueles ameaçados de desaparecerem da face da Terra.";

            palavrasciencias[13] = "oxigênio";
            dicasciencias[13] = "Ar que respiramos";
            descricaociencias[13] = "Oxigênio é o elemento essencial à vida";

            palavrasciencias[14] = "legumes";
            dicasciencias[14] = "Fazem parte de toda alimentação saudável";
            descricaociencias[14] = "Os legumes são os frutos salgados, como por exemplo: feijão, arroz, pimentão, abobrinha, batata, cenoura, cebola, milho e trigo.";


        }
        private void IniciaCiencias()
        {
            Random ciencias = new Random();
            posiçaopalavraciencias = ciencias.Next(0, 14);
            palavra = palavrasciencias[posiçaopalavraciencias];
            descriçao = descricaociencias[posiçaopalavraciencias];
            palavradatela = "";
            for (int i = 0; i < palavra.Length; i++)
            {
                palavradatela = palavradatela + "#";
            }
            TXT_Palavra.Text = palavradatela;
            lbl_dica.Text = dicasciencias[posiçaopalavraciencias];
            tentativas = 7;
        }

        private void BTN_Iniciar_Click(object sender, EventArgs e)
        {
            this.CIENCIAS();
            btn_verificar.Enabled = true;
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
                Boolean encontrou=true;
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

        private void TXT_Letra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsDigit(e.KeyChar)) || (char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        private void TXT_Dletras_TextChanged(object sender, EventArgs e)
        {

        }

        public FRM_Ciencias()
        {
            InitializeComponent();
      
        }

        public void PBX_Sair_Click(object sender, EventArgs e)
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
    }
}
