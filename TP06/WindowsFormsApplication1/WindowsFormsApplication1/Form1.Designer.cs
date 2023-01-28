namespace WindowsFormsApplication1{

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Principal));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.MNU_Ordenar = new System.Windows.Forms.ToolStripMenuItem();
            this.MNU_Limpar = new System.Windows.Forms.ToolStripMenuItem();
            this.MNU_Sobre = new System.Windows.Forms.ToolStripMenuItem();
            this.TXT_Quantidade = new System.Windows.Forms.TextBox();
            this.TXT_Numero = new System.Windows.Forms.TextBox();
            this.LTB_Ordenado = new System.Windows.Forms.ListBox();
            this.LTB_Fornecido = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LTB_Primo = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.LBL_posiçãonumerica = new System.Windows.Forms.Label();
            this.BTN_Envia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LBL_Limite = new System.Windows.Forms.Label();
            this.mnuPrincipal.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MNU_Ordenar,
            this.MNU_Limpar,
            this.MNU_Sobre});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(432, 24);
            this.mnuPrincipal.TabIndex = 0;
            this.mnuPrincipal.Text = "menuStrip1";
            // 
            // MNU_Ordenar
            // 
            this.MNU_Ordenar.Name = "MNU_Ordenar";
            this.MNU_Ordenar.Size = new System.Drawing.Size(62, 20);
            this.MNU_Ordenar.Text = "&Ordenar";
            this.MNU_Ordenar.Click += new System.EventHandler(this.MNU_Ordenar_Click);
            // 
            // MNU_Limpar
            // 
            this.MNU_Limpar.Name = "MNU_Limpar";
            this.MNU_Limpar.Size = new System.Drawing.Size(56, 20);
            this.MNU_Limpar.Text = "&Limpar";
            this.MNU_Limpar.Click += new System.EventHandler(this.MNU_Limpar_Click);
            // 
            // MNU_Sobre
            // 
            this.MNU_Sobre.Name = "MNU_Sobre";
            this.MNU_Sobre.Size = new System.Drawing.Size(49, 20);
            this.MNU_Sobre.Text = "&Sobre";
            this.MNU_Sobre.Click += new System.EventHandler(this.MNU_Sobre_Click);
            // 
            // TXT_Quantidade
            // 
            this.TXT_Quantidade.Location = new System.Drawing.Point(89, 46);
            this.TXT_Quantidade.MaxLength = 2;
            this.TXT_Quantidade.Name = "TXT_Quantidade";
            this.TXT_Quantidade.Size = new System.Drawing.Size(59, 23);
            this.TXT_Quantidade.TabIndex = 1;
            this.TXT_Quantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_Quantidade_KeyPress);
            this.TXT_Quantidade.Validating += new System.ComponentModel.CancelEventHandler(this.TXT_Quantidade_Validating);
            // 
            // TXT_Numero
            // 
            this.TXT_Numero.Location = new System.Drawing.Point(25, 46);
            this.TXT_Numero.MaxLength = 2;
            this.TXT_Numero.Name = "TXT_Numero";
            this.TXT_Numero.Size = new System.Drawing.Size(59, 23);
            this.TXT_Numero.TabIndex = 2;
            this.TXT_Numero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_Quantidade_KeyPress);
            this.TXT_Numero.Validating += new System.ComponentModel.CancelEventHandler(this.TXT_Numero_Validating);
            // 
            // LTB_Ordenado
            // 
            this.LTB_Ordenado.FormattingEnabled = true;
            this.LTB_Ordenado.ItemHeight = 15;
            this.LTB_Ordenado.Location = new System.Drawing.Point(6, 26);
            this.LTB_Ordenado.Name = "LTB_Ordenado";
            this.LTB_Ordenado.Size = new System.Drawing.Size(187, 109);
            this.LTB_Ordenado.TabIndex = 3;
            // 
            // LTB_Fornecido
            // 
            this.LTB_Fornecido.FormattingEnabled = true;
            this.LTB_Fornecido.ItemHeight = 15;
            this.LTB_Fornecido.Location = new System.Drawing.Point(6, 26);
            this.LTB_Fornecido.Name = "LTB_Fornecido";
            this.LTB_Fornecido.Size = new System.Drawing.Size(176, 199);
            this.LTB_Fornecido.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LTB_Fornecido);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 253);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Números fornecidos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LTB_Primo);
            this.groupBox2.Controls.Add(this.LTB_Ordenado);
            this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(221, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(199, 253);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Números ordenados";
            // 
            // LTB_Primo
            // 
            this.LTB_Primo.FormattingEnabled = true;
            this.LTB_Primo.ItemHeight = 15;
            this.LTB_Primo.Location = new System.Drawing.Point(6, 153);
            this.LTB_Primo.Name = "LTB_Primo";
            this.LTB_Primo.Size = new System.Drawing.Size(187, 94);
            this.LTB_Primo.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.TXT_Quantidade);
            this.groupBox3.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(198, 82);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Quantidade de números ordenados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Forneça";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.LBL_posiçãonumerica);
            this.groupBox4.Controls.Add(this.BTN_Envia);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.TXT_Numero);
            this.groupBox4.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(221, 31);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(199, 81);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Entrada de dados ";
            // 
            // LBL_posiçãonumerica
            // 
            this.LBL_posiçãonumerica.AutoSize = true;
            this.LBL_posiçãonumerica.Location = new System.Drawing.Point(38, 28);
            this.LBL_posiçãonumerica.Name = "LBL_posiçãonumerica";
            this.LBL_posiçãonumerica.Size = new System.Drawing.Size(14, 15);
            this.LBL_posiçãonumerica.TabIndex = 12;
            this.LBL_posiçãonumerica.Text = "0";
            // 
            // BTN_Envia
            // 
            this.BTN_Envia.Location = new System.Drawing.Point(118, 37);
            this.BTN_Envia.Name = "BTN_Envia";
            this.BTN_Envia.Size = new System.Drawing.Size(75, 38);
            this.BTN_Envia.TabIndex = 11;
            this.BTN_Envia.Text = "&Envia";
            this.BTN_Envia.UseVisualStyleBackColor = true;
            this.BTN_Envia.Click += new System.EventHandler(this.BTN_Envia_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "º número";
            // 
            // LBL_Limite
            // 
            this.LBL_Limite.AutoSize = true;
            this.LBL_Limite.Font = new System.Drawing.Font("Comic Sans MS", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Limite.Location = new System.Drawing.Point(15, 385);
            this.LBL_Limite.Name = "LBL_Limite";
            this.LBL_Limite.Size = new System.Drawing.Size(404, 13);
            this.LBL_Limite.TabIndex = 10;
            this.LBL_Limite.Text = "A quantidade máxima de números que podem ser fornecidos é de 20 e no intervalo de" +
    " 1 a  30 ";
            // 
            // FRM_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(432, 407);
            this.Controls.Add(this.LBL_Limite);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.mnuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuPrincipal;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordenação numérica";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRM_Principal_FormClosing);
            this.Load += new System.EventHandler(this.FRM_Principal_Load);
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.TextBox TXT_Quantidade;
        private System.Windows.Forms.TextBox TXT_Numero;
        private System.Windows.Forms.ListBox LTB_Ordenado;
        private System.Windows.Forms.ListBox LTB_Fornecido;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LBL_posiçãonumerica;
        private System.Windows.Forms.Button BTN_Envia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBL_Limite;
        private System.Windows.Forms.ToolStripMenuItem MNU_Ordenar;
        private System.Windows.Forms.ToolStripMenuItem MNU_Limpar;
        private System.Windows.Forms.ToolStripMenuItem MNU_Sobre;
        private System.Windows.Forms.ListBox LTB_Primo;
    }
}

