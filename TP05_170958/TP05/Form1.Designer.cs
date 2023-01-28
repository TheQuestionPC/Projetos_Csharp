namespace TP05
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
            this.TXT_Controles = new System.Windows.Forms.TextBox();
            this.PBX_Cenario = new System.Windows.Forms.PictureBox();
            this.PBX_Avatar = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_Cenario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // TXT_Controles
            // 
            this.TXT_Controles.Location = new System.Drawing.Point(494, 28);
            this.TXT_Controles.Name = "TXT_Controles";
            this.TXT_Controles.Size = new System.Drawing.Size(33, 20);
            this.TXT_Controles.TabIndex = 0;
            this.TXT_Controles.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_Controles_KeyPress);
            // 
            // PBX_Cenario
            // 
            this.PBX_Cenario.Image = ((System.Drawing.Image)(resources.GetObject("PBX_Cenario.Image")));
            this.PBX_Cenario.InitialImage = null;
            this.PBX_Cenario.Location = new System.Drawing.Point(12, 12);
            this.PBX_Cenario.Name = "PBX_Cenario";
            this.PBX_Cenario.Size = new System.Drawing.Size(381, 215);
            this.PBX_Cenario.TabIndex = 1;
            this.PBX_Cenario.TabStop = false;
            // 
            // PBX_Avatar
            // 
            this.PBX_Avatar.Image = ((System.Drawing.Image)(resources.GetObject("PBX_Avatar.Image")));
            this.PBX_Avatar.InitialImage = null;
            this.PBX_Avatar.Location = new System.Drawing.Point(350, 28);
            this.PBX_Avatar.Name = "PBX_Avatar";
            this.PBX_Avatar.Size = new System.Drawing.Size(24, 27);
            this.PBX_Avatar.TabIndex = 2;
            this.PBX_Avatar.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(413, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "W = Sobe          A = Esquerda          S = Desce          D = Direita     ";
            // 
            // FRM_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 254);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PBX_Avatar);
            this.Controls.Add(this.PBX_Cenario);
            this.Controls.Add(this.TXT_Controles);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Labirinto";
            ((System.ComponentModel.ISupportInitialize)(this.PBX_Cenario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_Avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXT_Controles;
        private System.Windows.Forms.PictureBox PBX_Cenario;
        private System.Windows.Forms.PictureBox PBX_Avatar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
    }
}

