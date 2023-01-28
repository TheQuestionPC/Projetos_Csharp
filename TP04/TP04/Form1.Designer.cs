namespace TP04
{
    partial class FRM_Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Principal));
            this.PBX_Animação = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTN_Sair = new System.Windows.Forms.Button();
            this.BTN_Limpar = new System.Windows.Forms.Button();
            this.BTN_Calcular = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TXT_Temperatura = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_Pressão = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LTB_Resultado = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PBX_Animação)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PBX_Animação
            // 
            this.PBX_Animação.Location = new System.Drawing.Point(12, 12);
            this.PBX_Animação.Name = "PBX_Animação";
            this.PBX_Animação.Size = new System.Drawing.Size(115, 129);
            this.PBX_Animação.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBX_Animação.TabIndex = 0;
            this.PBX_Animação.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTN_Sair);
            this.groupBox1.Controls.Add(this.BTN_Limpar);
            this.groupBox1.Controls.Add(this.BTN_Calcular);
            this.groupBox1.Location = new System.Drawing.Point(12, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(115, 196);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // BTN_Sair
            // 
            this.BTN_Sair.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTN_Sair.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Sair.Image")));
            this.BTN_Sair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Sair.Location = new System.Drawing.Point(5, 137);
            this.BTN_Sair.Name = "BTN_Sair";
            this.BTN_Sair.Size = new System.Drawing.Size(101, 52);
            this.BTN_Sair.TabIndex = 2;
            this.BTN_Sair.Text = "&Sair";
            this.BTN_Sair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Sair.UseVisualStyleBackColor = false;
            this.BTN_Sair.Click += new System.EventHandler(this.BTN_Sair_Click);
            // 
            // BTN_Limpar
            // 
            this.BTN_Limpar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTN_Limpar.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Limpar.Image")));
            this.BTN_Limpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Limpar.Location = new System.Drawing.Point(5, 79);
            this.BTN_Limpar.Name = "BTN_Limpar";
            this.BTN_Limpar.Size = new System.Drawing.Size(102, 52);
            this.BTN_Limpar.TabIndex = 1;
            this.BTN_Limpar.Text = "&Limpar";
            this.BTN_Limpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Limpar.UseVisualStyleBackColor = false;
            this.BTN_Limpar.Click += new System.EventHandler(this.BTN_Limpar_Click);
            // 
            // BTN_Calcular
            // 
            this.BTN_Calcular.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTN_Calcular.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BTN_Calcular.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Calcular.Image")));
            this.BTN_Calcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_Calcular.Location = new System.Drawing.Point(6, 19);
            this.BTN_Calcular.Name = "BTN_Calcular";
            this.BTN_Calcular.Size = new System.Drawing.Size(103, 54);
            this.BTN_Calcular.TabIndex = 0;
            this.BTN_Calcular.Text = "&Calcular";
            this.BTN_Calcular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_Calcular.UseVisualStyleBackColor = false;
            this.BTN_Calcular.Click += new System.EventHandler(this.BTN_Calcular_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TXT_Temperatura);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TXT_Pressão);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(143, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 129);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Entrada de dados";
            // 
            // TXT_Temperatura
            // 
            this.TXT_Temperatura.Location = new System.Drawing.Point(81, 59);
            this.TXT_Temperatura.MaxLength = 3;
            this.TXT_Temperatura.Name = "TXT_Temperatura";
            this.TXT_Temperatura.Size = new System.Drawing.Size(89, 20);
            this.TXT_Temperatura.TabIndex = 5;
            this.TXT_Temperatura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Verifica);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "(celsius)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Temp. final";
            // 
            // TXT_Pressão
            // 
            this.TXT_Pressão.Location = new System.Drawing.Point(70, 29);
            this.TXT_Pressão.MaxLength = 3;
            this.TXT_Pressão.Name = "TXT_Pressão";
            this.TXT_Pressão.Size = new System.Drawing.Size(100, 20);
            this.TXT_Pressão.TabIndex = 2;
            this.TXT_Pressão.TextChanged += new System.EventHandler(this.TXT_Pressão_TextChanged);
            this.TXT_Pressão.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Verifica);
            this.TXT_Pressão.Validating += new System.ComponentModel.CancelEventHandler(this.TXT_Pressão_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "(atm)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pressão";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LTB_Resultado);
            this.groupBox3.Location = new System.Drawing.Point(143, 147);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(229, 194);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultado";
            // 
            // LTB_Resultado
            // 
            this.LTB_Resultado.FormattingEnabled = true;
            this.LTB_Resultado.Location = new System.Drawing.Point(6, 62);
            this.LTB_Resultado.Name = "LTB_Resultado";
            this.LTB_Resultado.Size = new System.Drawing.Size(215, 95);
            this.LTB_Resultado.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FRM_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(384, 353);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PBX_Animação);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Principal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo do volume final";
            this.Load += new System.EventHandler(this.FRM_Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBX_Animação)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PBX_Animação;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTN_Sair;
        private System.Windows.Forms.Button BTN_Limpar;
        private System.Windows.Forms.Button BTN_Calcular;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TXT_Temperatura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXT_Pressão;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox LTB_Resultado;
        private System.Windows.Forms.Timer timer1;
    }
}

