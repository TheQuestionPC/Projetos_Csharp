namespace JogoDaForca
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PBX_Geografia = new System.Windows.Forms.PictureBox();
            this.PBX_Historia = new System.Windows.Forms.PictureBox();
            this.PBX_Portugues = new System.Windows.Forms.PictureBox();
            this.PBX_Ciencias = new System.Windows.Forms.PictureBox();
            this.LBL_Tema = new System.Windows.Forms.Label();
            this.BTN_Voltar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PBX_Geografia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_Historia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_Portugues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_Ciencias)).BeginInit();
            this.SuspendLayout();
            // 
            // PBX_Geografia
            // 
            this.PBX_Geografia.BackColor = System.Drawing.Color.Transparent;
            this.PBX_Geografia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBX_Geografia.Image = global::JogoDaForca.Properties.Resources.BotaoGeografia;
            this.PBX_Geografia.Location = new System.Drawing.Point(107, 106);
            this.PBX_Geografia.Name = "PBX_Geografia";
            this.PBX_Geografia.Size = new System.Drawing.Size(199, 69);
            this.PBX_Geografia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBX_Geografia.TabIndex = 0;
            this.PBX_Geografia.TabStop = false;
            this.PBX_Geografia.Click += new System.EventHandler(this.PBX_Geografia_Click);
            // 
            // PBX_Historia
            // 
            this.PBX_Historia.BackColor = System.Drawing.Color.Transparent;
            this.PBX_Historia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBX_Historia.Image = global::JogoDaForca.Properties.Resources.BotaoHistoriaDefinitivo;
            this.PBX_Historia.Location = new System.Drawing.Point(107, 185);
            this.PBX_Historia.Name = "PBX_Historia";
            this.PBX_Historia.Size = new System.Drawing.Size(199, 69);
            this.PBX_Historia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBX_Historia.TabIndex = 1;
            this.PBX_Historia.TabStop = false;
            this.PBX_Historia.Click += new System.EventHandler(this.PBX_Historia_Click);
            // 
            // PBX_Portugues
            // 
            this.PBX_Portugues.BackColor = System.Drawing.Color.Transparent;
            this.PBX_Portugues.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBX_Portugues.Image = global::JogoDaForca.Properties.Resources.logoportugues;
            this.PBX_Portugues.Location = new System.Drawing.Point(107, 264);
            this.PBX_Portugues.Name = "PBX_Portugues";
            this.PBX_Portugues.Size = new System.Drawing.Size(199, 69);
            this.PBX_Portugues.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBX_Portugues.TabIndex = 2;
            this.PBX_Portugues.TabStop = false;
            this.PBX_Portugues.Click += new System.EventHandler(this.PBX_Portugues_Click);
            // 
            // PBX_Ciencias
            // 
            this.PBX_Ciencias.BackColor = System.Drawing.Color.Transparent;
            this.PBX_Ciencias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBX_Ciencias.Image = global::JogoDaForca.Properties.Resources.cienciasdanaturezalogo;
            this.PBX_Ciencias.Location = new System.Drawing.Point(107, 343);
            this.PBX_Ciencias.Name = "PBX_Ciencias";
            this.PBX_Ciencias.Size = new System.Drawing.Size(199, 69);
            this.PBX_Ciencias.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBX_Ciencias.TabIndex = 3;
            this.PBX_Ciencias.TabStop = false;
            this.PBX_Ciencias.Click += new System.EventHandler(this.PBX_Ciencias_Click);
            // 
            // LBL_Tema
            // 
            this.LBL_Tema.AutoSize = true;
            this.LBL_Tema.BackColor = System.Drawing.Color.Transparent;
            this.LBL_Tema.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Tema.ForeColor = System.Drawing.Color.Black;
            this.LBL_Tema.Location = new System.Drawing.Point(75, 25);
            this.LBL_Tema.Name = "LBL_Tema";
            this.LBL_Tema.Size = new System.Drawing.Size(283, 41);
            this.LBL_Tema.TabIndex = 4;
            this.LBL_Tema.Text = "Escolha a matéria:";
            // 
            // BTN_Voltar
            // 
            this.BTN_Voltar.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Voltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Voltar.ForeColor = System.Drawing.Color.Black;
            this.BTN_Voltar.Location = new System.Drawing.Point(166, 448);
            this.BTN_Voltar.Name = "BTN_Voltar";
            this.BTN_Voltar.Size = new System.Drawing.Size(78, 35);
            this.BTN_Voltar.TabIndex = 5;
            this.BTN_Voltar.Text = "Voltar";
            this.BTN_Voltar.UseVisualStyleBackColor = false;
            this.BTN_Voltar.Click += new System.EventHandler(this.BTN_Voltar_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JogoDaForca.Properties.Resources.wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(412, 495);
            this.ControlBox = false;
            this.Controls.Add(this.BTN_Voltar);
            this.Controls.Add(this.LBL_Tema);
            this.Controls.Add(this.PBX_Ciencias);
            this.Controls.Add(this.PBX_Portugues);
            this.Controls.Add(this.PBX_Historia);
            this.Controls.Add(this.PBX_Geografia);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tema da Forca ";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBX_Geografia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_Historia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_Portugues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_Ciencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBX_Geografia;
        private System.Windows.Forms.PictureBox PBX_Historia;
        private System.Windows.Forms.PictureBox PBX_Portugues;
        private System.Windows.Forms.PictureBox PBX_Ciencias;
        private System.Windows.Forms.Label LBL_Tema;
        private System.Windows.Forms.Button BTN_Voltar;
        private System.Windows.Forms.Timer timer1;
    }
}