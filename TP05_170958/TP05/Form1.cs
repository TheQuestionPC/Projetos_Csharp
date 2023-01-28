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

namespace TP05
{
    public partial class FRM_Principal : Form
    {
        #region variáveis globais
        int controle = 0;
        string arquivo = "";
        string msg, titulo;
        MessageBoxButtons botoes;
        MessageBoxIcon icone;
        MessageBoxDefaultButton definido;
        #endregion

        public FRM_Principal()
        {
            InitializeComponent();
        }

        private void TXT_Controles_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 87 || e.KeyChar == 119 ||  // W 
                e.KeyChar == 65 || e.KeyChar == 97 ||   // A 
                e.KeyChar == 83 || e.KeyChar == 115 ||  // S 
                e.KeyChar == 68 || e.KeyChar == 100)    // D 
            {
                controle = e.KeyChar;
                timer1.Start();
            }
            else
            {
                e.KeyChar = Convert.ToChar(0);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = PBX_Avatar.Location.X;
            int y = PBX_Avatar.Location.Y;
            int xf = 0, yf = 0;

            switch (controle)
            {
                case 65:    // esquerda
                case 97:
                    PBX_Avatar.Location = new Point (x - 20, y);
                    xf = PBX_Avatar.Location.X;
                    if(xf == 10 && y == 68 || xf == 10 && y == 88 || xf == 10 && y == 108 || xf == 10 && y == 68 || xf == 10 && y == 128 || xf == 10 && y == 148 || xf == 10 && y == 168)
                    {
                        PBX_Avatar.Location = new Point (30, y);
                    }

                        if (xf == 190 && y == 28 || xf == 190 && y == 48 || xf == 190 && y == 148 || xf == 190 && y == 128) 
                        {
                            PBX_Avatar.Location = new Point(210, y);
                        }
                        if (xf == 130 && y == 28 || xf == 130 && y == 48 || xf == 130 && y == 68 || xf == 130 && y == 88)
                        {
                            PBX_Avatar.Location = new Point(150, y);
                        }
                        if (xf == 70 && y == 28 || xf == 70 && y == 48)
                        {
                            PBX_Avatar.Location = new Point(90, y);
                        }
                        if (xf == 250 && y == 88 || xf == 250 && y == 108)
                        {
                            PBX_Avatar.Location = new Point(270, y);
                        }
                        if (xf == 310 && y == 128)
                        {
                            PBX_Avatar.Location = new Point(330, y);
                        }
                        if (xf == 250 && y == 148 || xf == 250 && y == 168)
                        {
                            PBX_Avatar.Location = new Point(270, y);
                        }
                        if (xf == 10 && y == 188)
                        {  
                            msg = "Você concluiu o labirinto.";
                            titulo = "Parabéns ! ! !";
                            botoes = MessageBoxButtons.OK;
                            icone = MessageBoxIcon.Information;
                            definido = MessageBoxDefaultButton.Button1;
                                if (MessageBox.Show(msg, titulo, botoes, icone, definido) == DialogResult.OK)
                                {
                                this.Close();
                                }
                        }

                    arquivo = "esquerda.bmp";
                    break;
                case 68:   // direita
                case 100:
                    PBX_Avatar.Location = new Point (x + 20, y);
                    xf = PBX_Avatar.Location.X;
                    if (xf > 350)
                    {
                        PBX_Avatar.Location = new Point (350, y);
                    }
                    if (xf == 250 && y == 48)
                    {
                        PBX_Avatar.Location = new Point (230, y);
                    }
                    if (xf == 190 && y == 88)
                    {
                        PBX_Avatar.Location = new Point(170, y);
                    }
                    if (xf == 70 && y == 88)
                    {
                        PBX_Avatar.Location = new Point(50, y);
                    }
                    if (xf == 190 && y == 28 || xf == 190 && y == 48 || xf == 190 && y == 148 || xf == 190 && y == 128)
                    {
                        PBX_Avatar.Location = new Point(170, y);
                    }
                    if (xf == 130 && y == 28 || xf == 130 && y == 48 || xf == 130 && y == 68 || xf == 130 && y == 88)
                    {
                        PBX_Avatar.Location = new Point(110, y);
                    }
                    if (xf == 250 && y == 88 || xf == 250 && y == 108 || xf == 250 && y == 128 || xf == 250 && y == 148 || xf == 250 && y == 168)
                    {
                        PBX_Avatar.Location = new Point(230, y);
                    }
                    if (xf == 70 && y == 128 || xf == 70 && y == 148)
                    {
                        PBX_Avatar.Location = new Point(50, y);
                    }
                    if (xf == 50 && y == 168)
                    {
                        PBX_Avatar.Location = new Point(30, y);
                    }
                    if (xf == 310 && y == 68 || xf == 310 && y == 88 || xf == 310 && y == 168 || xf == 310 && y == 188)
                    {
                        PBX_Avatar.Location = new Point(290, y);
                    }
                    arquivo = "direita.bmp";
                    break;
                case 87: // cima
                case 119:
                    PBX_Avatar.Location = new Point (x, y - 20);
                    yf = PBX_Avatar.Location.Y;
                    if (yf < 28)
                    {
                        PBX_Avatar.Location = new Point (x, 28);
                    }
                    if (x == 50 && yf == 168 || x == 70 && yf == 168 || x == 90 && yf == 168 || x == 110 && yf == 168 || x == 130 && yf == 168 || x == 150 && yf == 168 || x == 170 && yf == 168 || x == 190 && yf == 168 || x == 210 && yf == 168 || x == 230 && yf == 168 || x == 250 && yf == 168)
                    {
                        PBX_Avatar.Location = new Point(x, 188);
                    }
                    if (x == 290 && y == 68 || x == 270 && y == 68 || x == 250 && y == 68)
                    {
                        PBX_Avatar.Location = new Point(x, 68);
                    }
                    if (x == 310 && y == 108 || x == 330 && y == 108 || x == 350 && y == 108)
                    {
                        PBX_Avatar.Location = new Point(x, 108);
                    }
                    if (x == 190 && yf == 48)
                    {
                       PBX_Avatar.Location = new Point(x, 68);
                    }
                    if (x == 70 && yf == 88 || x == 90 && yf == 88 || x == 110 && yf == 88 || x == 130 && yf == 88)
                    {
                        PBX_Avatar.Location = new Point(x, 108);
                    }
                    if (x == 270 && yf == 128 || x == 290 && yf == 128 || x == 310 && yf == 128)
                    {
                        PBX_Avatar.Location = new Point(x, 148);
                    }
                    if (x == 230 && yf == 88 || x == 210 && yf == 88 || x == 190 && yf == 88)
                    {
                        PBX_Avatar.Location = new Point(x, 108);
                    }
                    if (x == 70 && yf == 48 || x == 50 && yf == 48 || x == 30 && yf == 48)
                    {
                        PBX_Avatar.Location = new Point(x, 68);
                    }
                    arquivo = "sobe.bmp";
                    break;
                case 83: //baixo
                case 115:
                     PBX_Avatar.Location = new Point (x, y + 20);
                    yf = PBX_Avatar.Location.Y;
                    if (yf  > 188)
                    {
                        PBX_Avatar.Location = new Point (x, 188);
                    }
                    if (x == 350 && y == 28 || x == 330 && y == 28 || x == 310 && y == 28 || x == 290 && y == 28 || x == 270 && y == 28 || x == 250 && y == 28 )
                    {
                        PBX_Avatar.Location = new Point(x, 28);
                    }
                    if (x == 350 && yf == 168 || x == 330 && yf == 168 || x == 310 && yf == 168)
                    {
                        PBX_Avatar.Location = new Point(x, 148);
                    }
                    if (x == 310 && yf == 128 || x == 290 && yf == 128 || x == 270 && yf == 128 || x == 250 && yf == 128)
                    {
                        PBX_Avatar.Location = new Point(x, 108);
                    }
                    if (x == 190 && yf == 88 || x == 210 && yf == 88 || x == 230 && yf == 88 || x == 250 && yf == 88)
                    {
                        PBX_Avatar.Location = new Point(x, 68);
                    }
                    if (x == 190 && yf == 168 || x == 210 && yf == 168 || x == 230 && yf == 168 || x == 250 && yf == 168)
                    {
                        PBX_Avatar.Location = new Point(x, 148);
                    }
                    if (x == 50 && yf == 168)
                    {
                        PBX_Avatar.Location = new Point(x, 148);
                    }
                    if (x == 70 && yf == 88 || x == 90 && yf == 88 || x == 110 && yf == 88)
                    {
                        PBX_Avatar.Location = new Point(x, 68);
                    }
                    if (x == 190 && yf == 128 || x == 170 && yf == 128 || x == 150 && yf == 128 || x == 130 && yf == 128 || x == 110 && yf == 128 || x == 90 && yf == 128 || x == 70 && yf == 128) 
                    {
                        PBX_Avatar.Location = new Point(x, 108);
                    }
                        arquivo = "desce.bmp";
                    break;
            }
        
            PBX_Avatar.Image = Image.FromFile(Directory.GetCurrentDirectory() + "\\" + arquivo);
            timer1.Stop();

        }
    }
}
