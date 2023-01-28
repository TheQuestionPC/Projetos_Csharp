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
    public partial class FRM_Geografia : Form
    {
        string msg, titulo, tipo;
        MessageBoxButtons botoes;
        MessageBoxIcon icone;
        MessageBoxDefaultButton definido;
        //geografia
        private String[] palavrasgeografia;
        private String[] dicasgeografia;
        private String[] descricaogeografia;
        private int posiçaopalavrageografia;
        private String palavradatela;

        private String palavra;
        private String descriçao;
        private int tentativas;

        public FRM_Geografia()
        {
            InitializeComponent();
        }

        private void GEOGRAFIA()
        {
            palavrasgeografia = new String[15];
            dicasgeografia = new String[15];
            descricaogeografia = new String[15];

            palavrasgeografia[0] = "Nordeste";
            dicasgeografia[0] = "Região";
            descricaogeografia[0] = "A Região Nordeste é uma das cinco regiões do Brasil definidas pelo IBGE, é formada por 9 estados :Alagoas, Bahia, Ceará, Maranhão, Paraíba, Pernambuco, Piauí, Rio Grande do Norte e Sergipe.";

            palavrasgeografia[1] = "Argentina";
            dicasgeografia[1] = "País Sul-Americano";
            descricaogeografia[1] = "A Argentina é um país da América do Sul, seu idioma oficial é o espanhol";

            palavrasgeografia[2] = "Alemanha";
            dicasgeografia[2] = "País da Europa";
            descricaogeografia[2] = "A Alemanha é um país da Europa, seu idioma oficial é o alemão";

            palavrasgeografia[3] = "Austrália";
            dicasgeografia[3] = "País da Oceania";
            descricaogeografia[3] = "A Austrália é um país da Oceania, seu idioma, seu idioma oficial é o inglês";

            palavrasgeografia[4] = "planetas";
            dicasgeografia[4] = "Corpos celestes";
            descricaogeografia[4] = "Planetas são corpos celestes sem luz e calor próprios, sólidos e arredondados.";

            palavrasgeografia[5] = "floresta";
            dicasgeografia[5] = "conjunto de árvores";
            descricaogeografia[5] = "Floresta é uma área com alta densidade de árvores.";

            palavrasgeografia[6] = "vegetação";
            dicasgeografia[6] = "Conjunto de plantas de uma determinada área ou região";
            descricaogeografia[6] = "Vegetaçã é um termo geral para a vida vegetal de uma região";

            palavrasgeografia[7] = "petróleo";
            dicasgeografia[7] = "Usado para fazer plástico";
            descricaogeografia[7] = "Petróleo é um combustível fóssil que é utilizado para a confecção do plástico";

            palavrasgeografia[8] = "desmatamento";
            dicasgeografia[8] = "Desflorestamento";
            descricaogeografia[8] = "O desmatamento ou desflorestamento refere-se à eliminação total ou parcial de qualquer tipo de cobertura vegetal.";

            palavrasgeografia[9] = "transportes";
            dicasgeografia[9] = "Veículos";
            descricaogeografia[9] = "Há diversos tipos de meios de transportes, ou seja, os terrestres, aquáticos, dutoviários e aéreos.";

            palavrasgeografia[10] = "paisagem";
            dicasgeografia[10] = "Pedaço do espaço geográfico que enxermgameos";
            descricaogeografia[10] = "Paisagem são as sensações que determinado local nos transmitem.";

            palavrasgeografia[11] = "agricultura";
            dicasgeografia[11] = "Cultivação de plantas";
            descricaogeografia[11] = "Agricultura é o conjunto de técnicas utilizadas para cultivar plantas com o objetivo de obter alimentos, bebidas, fibras, energia, matéria-prima para roupas, construções, medicamentos, ferramentas, ou apenas para contemplação estética.";

            palavrasgeografia[12] = "urbanização";
            dicasgeografia[12] = "Transformação do espaço rural em espaço urbano";
            descricaogeografia[12] = "Urbanização é o crescimento da população em uma determinada cidade.";

            palavrasgeografia[13] = "sociedade";
            dicasgeografia[13] = "Agrupamento de seres";
            descricaogeografia[13] = "Sociedade é o conjunto de pessoas que compartilham propósitos, gostos, preocupações e costumes, e que interagem entre si constituindo uma comunidade.";

            palavrasgeografia[14] = "vulcanismo";
            dicasgeografia[14] = "Atividades vulcânicas";
            descricaogeografia[14] = "O vulcanismo é um fenômeno geológico natural determinado pelas atividades vulcânicas.";


        }
        private void IniciaGeografia()
        {
          
                Random geografia = new Random();
                posiçaopalavrageografia = geografia.Next(0, 14);
                palavra = palavrasgeografia[posiçaopalavrageografia];
                descriçao = descricaogeografia[posiçaopalavrageografia];
                palavradatela = "";
                for (int i = 0; i < palavra.Length; i++)
                {
                    palavradatela = palavradatela + "#";
                }
                TXT_Palavra.Text = palavradatela;
                lbl_dica.Text = dicasgeografia[posiçaopalavrageografia];
   
        }

        private void resetar()
        {
            lbl_dica.Text = "Dica palavra:";
            PBX_Forca.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\g.png");
            TXT_Dletras.Clear();
            tentativas = 7;
            TXT_Palavra.Clear();

        }
        private void FRM_Geografia_Load(object sender, EventArgs e)
        {
            this.GEOGRAFIA();
            btn_verificar.Enabled = false;
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
                if (encontrou = false)
                {
                    tentativas--;
                }
                if (TXT_Palavra.Text.IndexOf('#') == -1)
                {
                    MessageBox.Show("Parabéns, você ganhou" + "\nAprenda um pouco mais sobre " + palavra + "\n" + descriçao, "RESULTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.resetar();
                }
                if (encontrou == true)
                {
                    tentativas = tentativas + 1;
                }
                if (encontrou == false)
                {
                    tentativas = tentativas - 1;
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
                    MessageBox.Show("Infelizmente, você não acertou a palavra" + "\nA palavra correta é: " + palavra + "\n" + descriçao, "resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.resetar();
                }
            }
            catch
            {
                MessageBox.Show("Insira uma letra");
                return;
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

        private void BTN_Iniciar_Click(object sender, EventArgs e)
        {
            this.IniciaGeografia();
            btn_verificar.Enabled = true;
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
      
    }
}
