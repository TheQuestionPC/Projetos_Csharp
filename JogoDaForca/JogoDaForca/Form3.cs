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
    public partial class Form3 : Form
    {
        public Form3()
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
    }
}
