using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP08
{
    public partial class FRM_Principal : Form
    {
        public FRM_Principal()
        {
            InitializeComponent();
        }

        private void FRM_Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Sair...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        #region verifica
        private void BTN_Verifica_Click(object sender, EventArgs e)
        {
            if (clsTitulo.ValidaTitulo(TXT_TEleitoral.Text) == true)
            {
                LBL_Confirma.Text = "Correto";
            }
            else
            {
                LBL_Confirma.Text = "Errado";
            }
        }
       #endregion

        private void BTN_Limpar_Click(object sender, EventArgs e)
        {
            TXT_TEleitoral.Clear();
            LBL_Confirma.Text = "";
        }
    }
}
