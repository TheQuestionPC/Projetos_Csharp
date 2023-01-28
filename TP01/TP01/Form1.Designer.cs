namespace TP01
{
    partial class FRM_ConversãoDeCircuitos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_ConversãoDeCircuitos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BTN_Sair = new System.Windows.Forms.Button();
            this.BTN_Limpar = new System.Windows.Forms.Button();
            this.BTN_Calcular = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_R3 = new System.Windows.Forms.TextBox();
            this.TXT_R2 = new System.Windows.Forms.TextBox();
            this.TXT_R1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LBL_R4 = new System.Windows.Forms.Label();
            this.LBL_R5 = new System.Windows.Forms.Label();
            this.LBL_R6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.BTN_Sair);
            this.panel1.Controls.Add(this.BTN_Limpar);
            this.panel1.Controls.Add(this.BTN_Calcular);
            this.panel1.Location = new System.Drawing.Point(440, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(102, 265);
            this.panel1.TabIndex = 0;
            // 
            // BTN_Sair
            // 
            this.BTN_Sair.BackColor = System.Drawing.Color.White;
            this.BTN_Sair.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Sair.Image")));
            this.BTN_Sair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTN_Sair.Location = new System.Drawing.Point(13, 179);
            this.BTN_Sair.Name = "BTN_Sair";
            this.BTN_Sair.Size = new System.Drawing.Size(77, 70);
            this.BTN_Sair.TabIndex = 2;
            this.BTN_Sair.Text = "&Sair";
            this.BTN_Sair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTN_Sair.UseVisualStyleBackColor = false;
            this.BTN_Sair.Click += new System.EventHandler(this.BTN_Sair_Click);
            // 
            // BTN_Limpar
            // 
            this.BTN_Limpar.BackColor = System.Drawing.Color.White;
            this.BTN_Limpar.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Limpar.Image")));
            this.BTN_Limpar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTN_Limpar.Location = new System.Drawing.Point(13, 94);
            this.BTN_Limpar.Name = "BTN_Limpar";
            this.BTN_Limpar.Size = new System.Drawing.Size(77, 70);
            this.BTN_Limpar.TabIndex = 1;
            this.BTN_Limpar.Text = "&Limpar";
            this.BTN_Limpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTN_Limpar.UseVisualStyleBackColor = false;
            this.BTN_Limpar.Click += new System.EventHandler(this.BTN_Limpar_Click);
            // 
            // BTN_Calcular
            // 
            this.BTN_Calcular.BackColor = System.Drawing.Color.White;
            this.BTN_Calcular.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Calcular.Image")));
            this.BTN_Calcular.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTN_Calcular.Location = new System.Drawing.Point(13, 12);
            this.BTN_Calcular.Name = "BTN_Calcular";
            this.BTN_Calcular.Size = new System.Drawing.Size(77, 70);
            this.BTN_Calcular.TabIndex = 0;
            this.BTN_Calcular.Text = "&Calcular";
            this.BTN_Calcular.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_Calcular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTN_Calcular.UseVisualStyleBackColor = false;
            this.BTN_Calcular.Click += new System.EventHandler(this.BTN_Calcular_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TXT_R3);
            this.groupBox1.Controls.Add(this.TXT_R2);
            this.groupBox1.Controls.Add(this.TXT_R1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 156);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entrada dos valores das resistências";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "R3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "R2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "R1";
            // 
            // TXT_R3
            // 
            this.TXT_R3.Location = new System.Drawing.Point(40, 101);
            this.TXT_R3.Name = "TXT_R3";
            this.TXT_R3.Size = new System.Drawing.Size(105, 30);
            this.TXT_R3.TabIndex = 3;
            // 
            // TXT_R2
            // 
            this.TXT_R2.Location = new System.Drawing.Point(40, 65);
            this.TXT_R2.Name = "TXT_R2";
            this.TXT_R2.Size = new System.Drawing.Size(105, 30);
            this.TXT_R2.TabIndex = 2;
            // 
            // TXT_R1
            // 
            this.TXT_R1.Location = new System.Drawing.Point(40, 29);
            this.TXT_R1.Name = "TXT_R1";
            this.TXT_R1.Size = new System.Drawing.Size(105, 30);
            this.TXT_R1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(172, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 109);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LBL_R4
            // 
            this.LBL_R4.AutoSize = true;
            this.LBL_R4.Location = new System.Drawing.Point(6, 26);
            this.LBL_R4.Name = "LBL_R4";
            this.LBL_R4.Size = new System.Drawing.Size(31, 23);
            this.LBL_R4.TabIndex = 7;
            this.LBL_R4.Text = "R4";
            // 
            // LBL_R5
            // 
            this.LBL_R5.AutoSize = true;
            this.LBL_R5.Location = new System.Drawing.Point(5, 49);
            this.LBL_R5.Name = "LBL_R5";
            this.LBL_R5.Size = new System.Drawing.Size(31, 23);
            this.LBL_R5.TabIndex = 8;
            this.LBL_R5.Text = "R5";
            // 
            // LBL_R6
            // 
            this.LBL_R6.AutoSize = true;
            this.LBL_R6.Location = new System.Drawing.Point(5, 72);
            this.LBL_R6.Name = "LBL_R6";
            this.LBL_R6.Size = new System.Drawing.Size(31, 23);
            this.LBL_R6.TabIndex = 9;
            this.LBL_R6.Text = "R6";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LBL_R5);
            this.groupBox2.Controls.Add(this.LBL_R6);
            this.groupBox2.Controls.Add(this.LBL_R4);
            this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(417, 114);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Respostas";
            // 
            // FRM_ConversãoDeCircuitos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(554, 291);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_ConversãoDeCircuitos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculador de conversão de circuitos";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BTN_Sair;
        private System.Windows.Forms.Button BTN_Limpar;
        private System.Windows.Forms.Button BTN_Calcular;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_R3;
        private System.Windows.Forms.TextBox TXT_R2;
        private System.Windows.Forms.TextBox TXT_R1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LBL_R4;
        private System.Windows.Forms.Label LBL_R6;
        private System.Windows.Forms.Label LBL_R5;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

