using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaForca
{
    public partial class FRM_Inicio : Form
    {
        #region Variaveis Globais
        string msg, titulo, tipo;
        MessageBoxButtons botoes;
        MessageBoxIcon icone;
        MessageBoxDefaultButton definido;
        #endregion
        public FRM_Inicio()
        {
            InitializeComponent();
        }

        private void BTN_Iniciar_Click(object sender, EventArgs e)
        {
            Form2 newForm2 = new Form2();
            newForm2.Show();
            this.Hide();
            newForm2.Closed += (s, args) => this.Close();
            newForm2.Show();
        }

        private void BTN_Instrucao_Click(object sender, EventArgs e)
        {
            Form3 newForm3 = new Form3();
            newForm3.Show();
            this.Hide();
            newForm3.Closed += (s, args) => this.Close();
            newForm3.Show();
        }

        private void BTN_Sobre_Click(object sender, EventArgs e)
        {
            Form4 newForm4 = new Form4();
            newForm4.Show();
            this.Hide();
            newForm4.Closed += (s, args) => this.Close();
            newForm4.Show();
        }

        private void FRM_Inicio_Load(object sender, EventArgs e)
        {
        }

        private void PBX_Sair_Click(object sender, EventArgs e)
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
