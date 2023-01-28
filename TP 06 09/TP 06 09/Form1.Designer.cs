namespace TP_06_09
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Principal));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTN_Sair = new System.Windows.Forms.Button();
            this.BTN_Limpar = new System.Windows.Forms.Button();
            this.BTN_Calcular = new System.Windows.Forms.Button();
            this.groupbox = new System.Windows.Forms.GroupBox();
            this.TXT_Passo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TXT_Frequencia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TXT_Capacitor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_Amplificação = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LTB_C2 = new System.Windows.Forms.ListBox();
            this.LTB_R3 = new System.Windows.Forms.ListBox();
            this.LTB_R2 = new System.Windows.Forms.ListBox();
            this.LTB_R1 = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PBX_Imagem = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupbox.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_Imagem)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTN_Sair);
            this.groupBox1.Controls.Add(this.BTN_Limpar);
            this.groupBox1.Controls.Add(this.BTN_Calcular);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 229);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(115, 196);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Comandos";
            // 
            // BTN_Sair
            // 
            this.BTN_Sair.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTN_Sair.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Sair.Image")));
            this.BTN_Sair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Sair.Location = new System.Drawing.Point(6, 133);
            this.BTN_Sair.Name = "BTN_Sair";
            this.BTN_Sair.Size = new System.Drawing.Size(102, 50);
            this.BTN_Sair.TabIndex = 2;
            this.BTN_Sair.Text = "&Sair";
            this.BTN_Sair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Sair.UseVisualStyleBackColor = false;
            this.BTN_Sair.Click += new System.EventHandler(this.BTN_Sair_Click);
            // 
            // BTN_Limpar
            // 
            this.BTN_Limpar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTN_Limpar.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Limpar.Image")));
            this.BTN_Limpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Limpar.Location = new System.Drawing.Point(7, 76);
            this.BTN_Limpar.Name = "BTN_Limpar";
            this.BTN_Limpar.Size = new System.Drawing.Size(102, 51);
            this.BTN_Limpar.TabIndex = 1;
            this.BTN_Limpar.Text = "&Limpar";
            this.BTN_Limpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Limpar.UseVisualStyleBackColor = false;
            this.BTN_Limpar.Click += new System.EventHandler(this.BTN_Limpar_Click);
            // 
            // BTN_Calcular
            // 
            this.BTN_Calcular.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTN_Calcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_Calcular.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Calcular.Image")));
            this.BTN_Calcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Calcular.Location = new System.Drawing.Point(7, 21);
            this.BTN_Calcular.Name = "BTN_Calcular";
            this.BTN_Calcular.Size = new System.Drawing.Size(103, 49);
            this.BTN_Calcular.TabIndex = 0;
            this.BTN_Calcular.Text = "&Calcular";
            this.BTN_Calcular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Calcular.UseVisualStyleBackColor = false;
            this.BTN_Calcular.Click += new System.EventHandler(this.BTN_Calcular_Click);
            // 
            // groupbox
            // 
            this.groupbox.Controls.Add(this.TXT_Passo);
            this.groupbox.Controls.Add(this.label10);
            this.groupbox.Controls.Add(this.label5);
            this.groupbox.Controls.Add(this.TXT_Frequencia);
            this.groupbox.Controls.Add(this.label2);
            this.groupbox.Controls.Add(this.label4);
            this.groupbox.Controls.Add(this.TXT_Capacitor);
            this.groupbox.Controls.Add(this.label3);
            this.groupbox.Controls.Add(this.TXT_Amplificação);
            this.groupbox.Controls.Add(this.label1);
            this.groupbox.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbox.Location = new System.Drawing.Point(133, 229);
            this.groupbox.Name = "groupbox";
            this.groupbox.Size = new System.Drawing.Size(222, 195);
            this.groupbox.TabIndex = 2;
            this.groupbox.TabStop = false;
            this.groupbox.Text = "Entrada de dados";
            // 
            // TXT_Passo
            // 
            this.TXT_Passo.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Passo.Location = new System.Drawing.Point(132, 145);
            this.TXT_Passo.MaxLength = 3;
            this.TXT_Passo.Name = "TXT_Passo";
            this.TXT_Passo.Size = new System.Drawing.Size(45, 26);
            this.TXT_Passo.TabIndex = 10;
            this.TXT_Passo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_Passo_KeyPress);
            this.TXT_Passo.Validating += new System.ComponentModel.CancelEventHandler(this.TXT_Passo_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 18);
            this.label10.TabIndex = 9;
            this.label10.Text = "Variação do passo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(146, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "(Hz)";
            // 
            // TXT_Frequencia
            // 
            this.TXT_Frequencia.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Frequencia.Location = new System.Drawing.Point(94, 103);
            this.TXT_Frequencia.MaxLength = 3;
            this.TXT_Frequencia.Name = "TXT_Frequencia";
            this.TXT_Frequencia.Size = new System.Drawing.Size(46, 26);
            this.TXT_Frequencia.TabIndex = 7;
            this.TXT_Frequencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Verifica);
            this.TXT_Frequencia.Validating += new System.ComponentModel.CancelEventHandler(this.TXT_Frequencia_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Frequência";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(146, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "(µF)";
            // 
            // TXT_Capacitor
            // 
            this.TXT_Capacitor.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Capacitor.Location = new System.Drawing.Point(94, 70);
            this.TXT_Capacitor.MaxLength = 3;
            this.TXT_Capacitor.Name = "TXT_Capacitor";
            this.TXT_Capacitor.Size = new System.Drawing.Size(46, 26);
            this.TXT_Capacitor.TabIndex = 4;
            this.TXT_Capacitor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Verifica);
            this.TXT_Capacitor.Validating += new System.ComponentModel.CancelEventHandler(this.TXT_Capacitor_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Capacitor";
            // 
            // TXT_Amplificação
            // 
            this.TXT_Amplificação.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_Amplificação.Location = new System.Drawing.Point(172, 32);
            this.TXT_Amplificação.MaxLength = 1;
            this.TXT_Amplificação.Name = "TXT_Amplificação";
            this.TXT_Amplificação.Size = new System.Drawing.Size(46, 26);
            this.TXT_Amplificação.TabIndex = 1;
            this.TXT_Amplificação.TextChanged += new System.EventHandler(this.TXT_Amplificação_TextChanged);
            this.TXT_Amplificação.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_Amplificação_KeyPress);
            this.TXT_Amplificação.Validating += new System.ComponentModel.CancelEventHandler(this.TXT_Amplificação_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amplificação do circuito";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LTB_C2);
            this.groupBox3.Controls.Add(this.LTB_R3);
            this.groupBox3.Controls.Add(this.LTB_R2);
            this.groupBox3.Controls.Add(this.LTB_R1);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(361, 229);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(334, 195);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultados";
            // 
            // LTB_C2
            // 
            this.LTB_C2.FormattingEnabled = true;
            this.LTB_C2.ItemHeight = 15;
            this.LTB_C2.Location = new System.Drawing.Point(255, 57);
            this.LTB_C2.Name = "LTB_C2";
            this.LTB_C2.Size = new System.Drawing.Size(77, 124);
            this.LTB_C2.TabIndex = 7;
            // 
            // LTB_R3
            // 
            this.LTB_R3.FormattingEnabled = true;
            this.LTB_R3.ItemHeight = 15;
            this.LTB_R3.Location = new System.Drawing.Point(172, 57);
            this.LTB_R3.Name = "LTB_R3";
            this.LTB_R3.Size = new System.Drawing.Size(77, 124);
            this.LTB_R3.TabIndex = 6;
            // 
            // LTB_R2
            // 
            this.LTB_R2.FormattingEnabled = true;
            this.LTB_R2.ItemHeight = 15;
            this.LTB_R2.Location = new System.Drawing.Point(6, 57);
            this.LTB_R2.Name = "LTB_R2";
            this.LTB_R2.Size = new System.Drawing.Size(77, 124);
            this.LTB_R2.TabIndex = 5;
            // 
            // LTB_R1
            // 
            this.LTB_R1.FormattingEnabled = true;
            this.LTB_R1.ItemHeight = 15;
            this.LTB_R1.Location = new System.Drawing.Point(89, 57);
            this.LTB_R1.Name = "LTB_R1";
            this.LTB_R1.Size = new System.Drawing.Size(77, 124);
            this.LTB_R1.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(286, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 18);
            this.label9.TabIndex = 3;
            this.label9.Text = "C2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(195, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 18);
            this.label8.TabIndex = 2;
            this.label8.Text = "R3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(113, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "R2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "R1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PBX_Imagem
            // 
            this.PBX_Imagem.Location = new System.Drawing.Point(32, 24);
            this.PBX_Imagem.Name = "PBX_Imagem";
            this.PBX_Imagem.Size = new System.Drawing.Size(639, 199);
            this.PBX_Imagem.TabIndex = 3;
            this.PBX_Imagem.TabStop = false;
            // 
            // FRM_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(707, 437);
            this.ControlBox = false;
            this.Controls.Add(this.PBX_Imagem);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupbox);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo do circuito eletrônico";
            this.Load += new System.EventHandler(this.FRM_Principal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupbox.ResumeLayout(false);
            this.groupbox.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_Imagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTN_Sair;
        private System.Windows.Forms.Button BTN_Limpar;
        private System.Windows.Forms.Button BTN_Calcular;
        private System.Windows.Forms.GroupBox groupbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXT_Frequencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXT_Capacitor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXT_Amplificação;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox TXT_Passo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox LTB_C2;
        private System.Windows.Forms.ListBox LTB_R3;
        private System.Windows.Forms.ListBox LTB_R2;
        private System.Windows.Forms.ListBox LTB_R1;
        private System.Windows.Forms.PictureBox PBX_Imagem;
    }
}

