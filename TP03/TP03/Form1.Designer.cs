namespace TP03
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
            this.RDB_Icosaedro = new System.Windows.Forms.RadioButton();
            this.RDB_Dodecaedro = new System.Windows.Forms.RadioButton();
            this.RDB_Octaedro = new System.Windows.Forms.RadioButton();
            this.RDB_Cubo = new System.Windows.Forms.RadioButton();
            this.RDB_Tetaedro = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LBL_Raio = new System.Windows.Forms.Label();
            this.TXT_Aresta = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BTN_Sair = new System.Windows.Forms.Button();
            this.BTN_Limpar = new System.Windows.Forms.Button();
            this.BTN_Calcular = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXT_Volume = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LBL_Solido = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_Area = new System.Windows.Forms.TextBox();
            this.LBL_ResultadoSolido = new System.Windows.Forms.Label();
            this.PBX_Solido = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_Solido)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RDB_Icosaedro);
            this.groupBox1.Controls.Add(this.RDB_Dodecaedro);
            this.groupBox1.Controls.Add(this.RDB_Octaedro);
            this.groupBox1.Controls.Add(this.RDB_Cubo);
            this.groupBox1.Controls.Add(this.RDB_Tetaedro);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 94);
            this.groupBox1.TabIndex = 100;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo do sólido";
            // 
            // RDB_Icosaedro
            // 
            this.RDB_Icosaedro.AutoSize = true;
            this.RDB_Icosaedro.Location = new System.Drawing.Point(150, 66);
            this.RDB_Icosaedro.Name = "RDB_Icosaedro";
            this.RDB_Icosaedro.Size = new System.Drawing.Size(88, 22);
            this.RDB_Icosaedro.TabIndex = 105;
            this.RDB_Icosaedro.TabStop = true;
            this.RDB_Icosaedro.Text = "Icosaedro";
            this.RDB_Icosaedro.UseVisualStyleBackColor = true;
            this.RDB_Icosaedro.CheckedChanged += new System.EventHandler(this.RDB_Icosaedro_CheckedChanged);
            // 
            // RDB_Dodecaedro
            // 
            this.RDB_Dodecaedro.AutoSize = true;
            this.RDB_Dodecaedro.Location = new System.Drawing.Point(8, 66);
            this.RDB_Dodecaedro.Name = "RDB_Dodecaedro";
            this.RDB_Dodecaedro.Size = new System.Drawing.Size(99, 22);
            this.RDB_Dodecaedro.TabIndex = 104;
            this.RDB_Dodecaedro.TabStop = true;
            this.RDB_Dodecaedro.Text = "Dodecaedro";
            this.RDB_Dodecaedro.UseVisualStyleBackColor = true;
            this.RDB_Dodecaedro.CheckedChanged += new System.EventHandler(this.RDB_Dodecaedro_CheckedChanged);
            // 
            // RDB_Octaedro
            // 
            this.RDB_Octaedro.AutoSize = true;
            this.RDB_Octaedro.Location = new System.Drawing.Point(267, 25);
            this.RDB_Octaedro.Name = "RDB_Octaedro";
            this.RDB_Octaedro.Size = new System.Drawing.Size(83, 22);
            this.RDB_Octaedro.TabIndex = 103;
            this.RDB_Octaedro.TabStop = true;
            this.RDB_Octaedro.Text = "Octaedro";
            this.RDB_Octaedro.UseVisualStyleBackColor = true;
            this.RDB_Octaedro.CheckedChanged += new System.EventHandler(this.RDB_Octaedro_CheckedChanged);
            // 
            // RDB_Cubo
            // 
            this.RDB_Cubo.AutoSize = true;
            this.RDB_Cubo.Location = new System.Drawing.Point(150, 25);
            this.RDB_Cubo.Name = "RDB_Cubo";
            this.RDB_Cubo.Size = new System.Drawing.Size(56, 22);
            this.RDB_Cubo.TabIndex = 102;
            this.RDB_Cubo.TabStop = true;
            this.RDB_Cubo.Text = "Cubo";
            this.RDB_Cubo.UseVisualStyleBackColor = true;
            this.RDB_Cubo.CheckedChanged += new System.EventHandler(this.RDB_Cubo_CheckedChanged);
            // 
            // RDB_Tetaedro
            // 
            this.RDB_Tetaedro.AutoSize = true;
            this.RDB_Tetaedro.Location = new System.Drawing.Point(8, 25);
            this.RDB_Tetaedro.Name = "RDB_Tetaedro";
            this.RDB_Tetaedro.Size = new System.Drawing.Size(82, 22);
            this.RDB_Tetaedro.TabIndex = 101;
            this.RDB_Tetaedro.TabStop = true;
            this.RDB_Tetaedro.Text = "Tetaedro";
            this.RDB_Tetaedro.UseVisualStyleBackColor = true;
            this.RDB_Tetaedro.CheckedChanged += new System.EventHandler(this.RDB_Tetaedro_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LBL_Raio);
            this.groupBox2.Controls.Add(this.TXT_Aresta);
            this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(11, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 82);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Entrada de dados (cm)";
            // 
            // LBL_Raio
            // 
            this.LBL_Raio.AutoSize = true;
            this.LBL_Raio.Location = new System.Drawing.Point(90, 44);
            this.LBL_Raio.Name = "LBL_Raio";
            this.LBL_Raio.Size = new System.Drawing.Size(48, 18);
            this.LBL_Raio.TabIndex = 3;
            this.LBL_Raio.Text = "Aresta";
            // 
            // TXT_Aresta
            // 
            this.TXT_Aresta.Location = new System.Drawing.Point(164, 41);
            this.TXT_Aresta.MaxLength = 3;
            this.TXT_Aresta.Name = "TXT_Aresta";
            this.TXT_Aresta.Size = new System.Drawing.Size(43, 26);
            this.TXT_Aresta.TabIndex = 109;
            this.TXT_Aresta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_Aresta_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BTN_Sair);
            this.groupBox3.Controls.Add(this.BTN_Limpar);
            this.groupBox3.Controls.Add(this.BTN_Calcular);
            this.groupBox3.Location = new System.Drawing.Point(12, 200);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(355, 93);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // BTN_Sair
            // 
            this.BTN_Sair.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTN_Sair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_Sair.BackgroundImage")));
            this.BTN_Sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTN_Sair.Location = new System.Drawing.Point(250, 15);
            this.BTN_Sair.Name = "BTN_Sair";
            this.BTN_Sair.Size = new System.Drawing.Size(72, 72);
            this.BTN_Sair.TabIndex = 2;
            this.BTN_Sair.Text = "&Sair";
            this.BTN_Sair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_Sair.UseVisualStyleBackColor = false;
            this.BTN_Sair.Click += new System.EventHandler(this.BTN_Sair_Click);
            // 
            // BTN_Limpar
            // 
            this.BTN_Limpar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTN_Limpar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_Limpar.BackgroundImage")));
            this.BTN_Limpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTN_Limpar.Location = new System.Drawing.Point(143, 15);
            this.BTN_Limpar.Name = "BTN_Limpar";
            this.BTN_Limpar.Size = new System.Drawing.Size(74, 72);
            this.BTN_Limpar.TabIndex = 1;
            this.BTN_Limpar.Text = "&Limpar";
            this.BTN_Limpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_Limpar.UseVisualStyleBackColor = false;
            this.BTN_Limpar.Click += new System.EventHandler(this.BTN_Limpar_Click);
            // 
            // BTN_Calcular
            // 
            this.BTN_Calcular.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTN_Calcular.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_Calcular.BackgroundImage")));
            this.BTN_Calcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTN_Calcular.Location = new System.Drawing.Point(26, 15);
            this.BTN_Calcular.Name = "BTN_Calcular";
            this.BTN_Calcular.Size = new System.Drawing.Size(74, 72);
            this.BTN_Calcular.TabIndex = 0;
            this.BTN_Calcular.Text = "&Calcular";
            this.BTN_Calcular.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_Calcular.UseVisualStyleBackColor = false;
            this.BTN_Calcular.Click += new System.EventHandler(this.BTN_Calcular_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.TXT_Volume);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.LBL_Solido);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.TXT_Area);
            this.groupBox4.Controls.Add(this.LBL_ResultadoSolido);
            this.groupBox4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(373, 153);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(168, 140);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Resultado do volume";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "cm²";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "cm³";
            // 
            // TXT_Volume
            // 
            this.TXT_Volume.Location = new System.Drawing.Point(32, 62);
            this.TXT_Volume.Name = "TXT_Volume";
            this.TXT_Volume.ReadOnly = true;
            this.TXT_Volume.Size = new System.Drawing.Size(98, 26);
            this.TXT_Volume.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "V=";
            // 
            // LBL_Solido
            // 
            this.LBL_Solido.AutoSize = true;
            this.LBL_Solido.Location = new System.Drawing.Point(9, 29);
            this.LBL_Solido.Name = "LBL_Solido";
            this.LBL_Solido.Size = new System.Drawing.Size(0, 18);
            this.LBL_Solido.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "A=";
            // 
            // TXT_Area
            // 
            this.TXT_Area.Location = new System.Drawing.Point(32, 90);
            this.TXT_Area.Name = "TXT_Area";
            this.TXT_Area.ReadOnly = true;
            this.TXT_Area.Size = new System.Drawing.Size(98, 26);
            this.TXT_Area.TabIndex = 1;
            // 
            // LBL_ResultadoSolido
            // 
            this.LBL_ResultadoSolido.AutoSize = true;
            this.LBL_ResultadoSolido.Location = new System.Drawing.Point(17, 32);
            this.LBL_ResultadoSolido.Name = "LBL_ResultadoSolido";
            this.LBL_ResultadoSolido.Size = new System.Drawing.Size(0, 18);
            this.LBL_ResultadoSolido.TabIndex = 0;
            // 
            // PBX_Solido
            // 
            this.PBX_Solido.Location = new System.Drawing.Point(405, 12);
            this.PBX_Solido.Name = "PBX_Solido";
            this.PBX_Solido.Size = new System.Drawing.Size(110, 135);
            this.PBX_Solido.TabIndex = 101;
            this.PBX_Solido.TabStop = false;
            // 
            // FRM_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(550, 305);
            this.ControlBox = false;
            this.Controls.Add(this.PBX_Solido);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sólidos geométricos";
            this.Load += new System.EventHandler(this.FRM_Principal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_Solido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RDB_Octaedro;
        private System.Windows.Forms.RadioButton RDB_Cubo;
        private System.Windows.Forms.RadioButton RDB_Tetaedro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LBL_Raio;
        private System.Windows.Forms.TextBox TXT_Aresta;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BTN_Sair;
        private System.Windows.Forms.Button BTN_Limpar;
        private System.Windows.Forms.Button BTN_Calcular;
        private System.Windows.Forms.TextBox TXT_Area;
        private System.Windows.Forms.Label LBL_ResultadoSolido;
        private System.Windows.Forms.PictureBox PBX_Solido;
        private System.Windows.Forms.RadioButton RDB_Icosaedro;
        private System.Windows.Forms.RadioButton RDB_Dodecaedro;
        private System.Windows.Forms.TextBox TXT_Volume;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LBL_Solido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}

