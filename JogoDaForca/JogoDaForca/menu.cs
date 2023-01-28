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
    public partial class Form2 : Form
    {
        #region Variaveis Globais
        Boolean muda;
        #endregion
        public Form2()
        {
            InitializeComponent();
        }

        private void BTN_Voltar_Click(object sender, EventArgs e)
        {
            FRM_Inicio newForm1 = new FRM_Inicio();
            newForm1.Show();
            this.Hide();
            newForm1.Closed += (s, args) => this.Close();
            newForm1.Show();
        }

        private void PBX_Geografia_Click(object sender, EventArgs e)
        {
            FRM_Geografia newForm5 = new FRM_Geografia();
            newForm5.Show();
            this.Hide();
            newForm5.Closed += (s, args) => this.Close();
            newForm5.Show();
        }
        #region Mudar cor do label Temas
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (muda == true)
            {
                LBL_Tema.ForeColor = Color.Black;
                muda = false;
            }
            else
            {
                LBL_Tema.ForeColor = Color.Blue;
                muda = true;
            }
        }
        #endregion

        private void Form2_Load(object sender, EventArgs e)
        {
            muda = true;
        }

        private void PBX_Historia_Click(object sender, EventArgs e)
        {
            FRM_Historia newForm6 = new FRM_Historia();
            newForm6.Show();
            this.Hide();
            newForm6.Closed += (s, args) => this.Close();
            newForm6.Show();
        }

        private void PBX_Portugues_Click(object sender, EventArgs e)
        {
            FRM_Portugues newForm7 = new FRM_Portugues();
            newForm7.Show();
            this.Hide();
            newForm7.Closed += (s, args) => this.Close();
            newForm7.Show();
        }

        private void PBX_Ciencias_Click(object sender, EventArgs e)
        {
            FRM_Ciencias newForm8 = new FRM_Ciencias();
            newForm8.Show();
            this.Hide();
            newForm8.Closed += (s, args) => this.Close();
            newForm8.Show();
        }
    }
}
