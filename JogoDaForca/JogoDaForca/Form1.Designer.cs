namespace JogoDaForca
{
    partial class FRM_Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Inicio));
            this.BTN_Iniciar = new System.Windows.Forms.Button();
            this.BTN_Instrucao = new System.Windows.Forms.Button();
            this.BTN_Sobre = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PBX_Sair = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_Sair)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Iniciar
            // 
            this.BTN_Iniciar.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Iniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Iniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.BTN_Iniciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Iniciar.Location = new System.Drawing.Point(290, 164);
            this.BTN_Iniciar.Name = "BTN_Iniciar";
            this.BTN_Iniciar.Size = new System.Drawing.Size(114, 29);
            this.BTN_Iniciar.TabIndex = 2;
            this.BTN_Iniciar.Text = "Iniciar Jogo";
            this.BTN_Iniciar.UseVisualStyleBackColor = false;
            this.BTN_Iniciar.Click += new System.EventHandler(this.BTN_Iniciar_Click);
            // 
            // BTN_Instrucao
            // 
            this.BTN_Instrucao.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Instrucao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Instrucao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.BTN_Instrucao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Instrucao.Location = new System.Drawing.Point(298, 199);
            this.BTN_Instrucao.Name = "BTN_Instrucao";
            this.BTN_Instrucao.Size = new System.Drawing.Size(101, 29);
            this.BTN_Instrucao.TabIndex = 3;
            this.BTN_Instrucao.Text = "Instruções";
            this.BTN_Instrucao.UseVisualStyleBackColor = false;
            this.BTN_Instrucao.Click += new System.EventHandler(this.BTN_Instrucao_Click);
            // 
            // BTN_Sobre
            // 
            this.BTN_Sobre.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Sobre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Sobre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.BTN_Sobre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Sobre.Location = new System.Drawing.Point(312, 234);
            this.BTN_Sobre.Name = "BTN_Sobre";
            this.BTN_Sobre.Size = new System.Drawing.Size(75, 29);
            this.BTN_Sobre.TabIndex = 4;
            this.BTN_Sobre.Text = "Sobre";
            this.BTN_Sobre.UseVisualStyleBackColor = false;
            this.BTN_Sobre.Click += new System.EventHandler(this.BTN_Sobre_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::JogoDaForca.Properties.Resources.Caneta2;
            this.pictureBox1.Location = new System.Drawing.Point(422, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 320);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::JogoDaForca.Properties.Resources.ccc;
            this.pictureBox2.Location = new System.Drawing.Point(197, 49);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(319, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // PBX_Sair
            // 
            this.PBX_Sair.BackColor = System.Drawing.Color.Transparent;
            this.PBX_Sair.Image = global::JogoDaForca.Properties.Resources.close;
            this.PBX_Sair.Location = new System.Drawing.Point(616, 12);
            this.PBX_Sair.Name = "PBX_Sair";
            this.PBX_Sair.Size = new System.Drawing.Size(56, 52);
            this.PBX_Sair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBX_Sair.TabIndex = 7;
            this.PBX_Sair.TabStop = false;
            this.PBX_Sair.Click += new System.EventHandler(this.PBX_Sair_Click);
            // 
            // FRM_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::JogoDaForca.Properties.Resources.wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.PBX_Sair);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTN_Sobre);
            this.Controls.Add(this.BTN_Instrucao);
            this.Controls.Add(this.BTN_Iniciar);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo da Forca";
            this.Load += new System.EventHandler(this.FRM_Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_Sair)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BTN_Iniciar;
        private System.Windows.Forms.Button BTN_Instrucao;
        private System.Windows.Forms.Button BTN_Sobre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox PBX_Sair;
    }
}

