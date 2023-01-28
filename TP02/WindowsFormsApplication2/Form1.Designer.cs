namespace WindowsFormsApplication2
{
    partial class FRM_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Principal));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_VelocidadeInicial = new System.Windows.Forms.TextBox();
            this.TXT_Aceleração = new System.Windows.Forms.TextBox();
            this.TXT_IntervaloTempo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TXT_ResultadoVelocidade = new System.Windows.Forms.TextBox();
            this.TXT_Movimento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTN_Calcular = new System.Windows.Forms.Button();
            this.BTN_Limpar = new System.Windows.Forms.Button();
            this.BTN_Sair = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TXT_IntervaloTempo);
            this.groupBox1.Controls.Add(this.TXT_Aceleração);
            this.groupBox1.Controls.Add(this.TXT_VelocidadeInicial);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(162, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 155);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entrada de dados";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Velocidade inicial (m/s)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Aceleração (m/s²)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Intervalo de tempo (s)";
            // 
            // TXT_VelocidadeInicial
            // 
            this.TXT_VelocidadeInicial.Location = new System.Drawing.Point(168, 30);
            this.TXT_VelocidadeInicial.MaxLength = 4;
            this.TXT_VelocidadeInicial.Name = "TXT_VelocidadeInicial";
            this.TXT_VelocidadeInicial.Size = new System.Drawing.Size(41, 20);
            this.TXT_VelocidadeInicial.TabIndex = 3;
            this.TXT_VelocidadeInicial.TextChanged += new System.EventHandler(this.TXT_VelocidadeInicial_TextChanged);
            this.TXT_VelocidadeInicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_VelocidadeInicial_KeyPress);
            // 
            // TXT_Aceleração
            // 
            this.TXT_Aceleração.Location = new System.Drawing.Point(168, 58);
            this.TXT_Aceleração.MaxLength = 4;
            this.TXT_Aceleração.Name = "TXT_Aceleração";
            this.TXT_Aceleração.Size = new System.Drawing.Size(41, 20);
            this.TXT_Aceleração.TabIndex = 4;
            this.TXT_Aceleração.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_VelocidadeInicial_KeyPress);
            // 
            // TXT_IntervaloTempo
            // 
            this.TXT_IntervaloTempo.Location = new System.Drawing.Point(168, 84);
            this.TXT_IntervaloTempo.MaxLength = 4;
            this.TXT_IntervaloTempo.Name = "TXT_IntervaloTempo";
            this.TXT_IntervaloTempo.Size = new System.Drawing.Size(41, 20);
            this.TXT_IntervaloTempo.TabIndex = 5;
            this.TXT_IntervaloTempo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_VelocidadeInicial_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TXT_Movimento);
            this.groupBox2.Controls.Add(this.TXT_ResultadoVelocidade);
            this.groupBox2.Location = new System.Drawing.Point(12, 188);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 95);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultados";
            // 
            // TXT_ResultadoVelocidade
            // 
            this.TXT_ResultadoVelocidade.Location = new System.Drawing.Point(198, 29);
            this.TXT_ResultadoVelocidade.Name = "TXT_ResultadoVelocidade";
            this.TXT_ResultadoVelocidade.ReadOnly = true;
            this.TXT_ResultadoVelocidade.Size = new System.Drawing.Size(128, 20);
            this.TXT_ResultadoVelocidade.TabIndex = 6;
            // 
            // TXT_Movimento
            // 
            this.TXT_Movimento.Location = new System.Drawing.Point(198, 55);
            this.TXT_Movimento.Name = "TXT_Movimento";
            this.TXT_Movimento.ReadOnly = true;
            this.TXT_Movimento.Size = new System.Drawing.Size(128, 20);
            this.TXT_Movimento.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Velocidade (m/s)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tipo de movimento";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 170);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // BTN_Calcular
            // 
            this.BTN_Calcular.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTN_Calcular.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_Calcular.BackgroundImage")));
            this.BTN_Calcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTN_Calcular.Location = new System.Drawing.Point(27, 14);
            this.BTN_Calcular.Name = "BTN_Calcular";
            this.BTN_Calcular.Size = new System.Drawing.Size(71, 73);
            this.BTN_Calcular.TabIndex = 0;
            this.BTN_Calcular.Text = "&Calcular";
            this.BTN_Calcular.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_Calcular.UseVisualStyleBackColor = false;
            this.BTN_Calcular.Click += new System.EventHandler(this.BTN_Calcular_Click);
            // 
            // BTN_Limpar
            // 
            this.BTN_Limpar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTN_Limpar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_Limpar.BackgroundImage")));
            this.BTN_Limpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_Limpar.Location = new System.Drawing.Point(150, 14);
            this.BTN_Limpar.Name = "BTN_Limpar";
            this.BTN_Limpar.Size = new System.Drawing.Size(71, 73);
            this.BTN_Limpar.TabIndex = 1;
            this.BTN_Limpar.Text = "&Limpar";
            this.BTN_Limpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_Limpar.UseVisualStyleBackColor = false;
            this.BTN_Limpar.Click += new System.EventHandler(this.BTN_Limpar_Click);
            // 
            // BTN_Sair
            // 
            this.BTN_Sair.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTN_Sair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_Sair.BackgroundImage")));
            this.BTN_Sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTN_Sair.Location = new System.Drawing.Point(274, 14);
            this.BTN_Sair.Name = "BTN_Sair";
            this.BTN_Sair.Size = new System.Drawing.Size(71, 73);
            this.BTN_Sair.TabIndex = 2;
            this.BTN_Sair.Text = "&Sair";
            this.BTN_Sair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_Sair.UseVisualStyleBackColor = false;
            this.BTN_Sair.Click += new System.EventHandler(this.BTN_Sair_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.BTN_Sair);
            this.panel1.Controls.Add(this.BTN_Limpar);
            this.panel1.Controls.Add(this.BTN_Calcular);
            this.panel1.Location = new System.Drawing.Point(12, 297);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 100);
            this.panel1.TabIndex = 0;
            // 
            // FRM_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(396, 409);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estudo do movimento de um corpo";
            this.Load += new System.EventHandler(this.FRM_Principal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TXT_IntervaloTempo;
        private System.Windows.Forms.TextBox TXT_Aceleração;
        private System.Windows.Forms.TextBox TXT_VelocidadeInicial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXT_Movimento;
        private System.Windows.Forms.TextBox TXT_ResultadoVelocidade;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BTN_Calcular;
        private System.Windows.Forms.Button BTN_Limpar;
        private System.Windows.Forms.Button BTN_Sair;
        private System.Windows.Forms.Panel panel1;
    }
}

