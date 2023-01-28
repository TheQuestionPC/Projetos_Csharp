namespace TP08
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
            this.TXT_TEleitoral = new System.Windows.Forms.TextBox();
            this.LBL_Confirma = new System.Windows.Forms.Label();
            this.BTN_Verifica = new System.Windows.Forms.Button();
            this.BTN_Limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TXT_TEleitoral
            // 
            this.TXT_TEleitoral.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_TEleitoral.Location = new System.Drawing.Point(38, 42);
            this.TXT_TEleitoral.MaxLength = 25;
            this.TXT_TEleitoral.Name = "TXT_TEleitoral";
            this.TXT_TEleitoral.Size = new System.Drawing.Size(171, 35);
            this.TXT_TEleitoral.TabIndex = 0;
            // 
            // LBL_Confirma
            // 
            this.LBL_Confirma.AutoSize = true;
            this.LBL_Confirma.Location = new System.Drawing.Point(79, 91);
            this.LBL_Confirma.Name = "LBL_Confirma";
            this.LBL_Confirma.Size = new System.Drawing.Size(0, 13);
            this.LBL_Confirma.TabIndex = 1;
            // 
            // BTN_Verifica
            // 
            this.BTN_Verifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Verifica.Location = new System.Drawing.Point(239, 12);
            this.BTN_Verifica.Name = "BTN_Verifica";
            this.BTN_Verifica.Size = new System.Drawing.Size(75, 35);
            this.BTN_Verifica.TabIndex = 2;
            this.BTN_Verifica.Text = "&Verifica";
            this.BTN_Verifica.UseVisualStyleBackColor = true;
            this.BTN_Verifica.Click += new System.EventHandler(this.BTN_Verifica_Click);
            // 
            // BTN_Limpar
            // 
            this.BTN_Limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Limpar.Location = new System.Drawing.Point(239, 69);
            this.BTN_Limpar.Name = "BTN_Limpar";
            this.BTN_Limpar.Size = new System.Drawing.Size(75, 35);
            this.BTN_Limpar.TabIndex = 3;
            this.BTN_Limpar.Text = "&Limpar";
            this.BTN_Limpar.UseCompatibleTextRendering = true;
            this.BTN_Limpar.UseVisualStyleBackColor = true;
            this.BTN_Limpar.Click += new System.EventHandler(this.BTN_Limpar_Click);
            // 
            // FRM_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(347, 130);
            this.Controls.Add(this.BTN_Limpar);
            this.Controls.Add(this.BTN_Verifica);
            this.Controls.Add(this.LBL_Confirma);
            this.Controls.Add(this.TXT_TEleitoral);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verifica titulo eleitoral";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRM_Principal_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXT_TEleitoral;
        private System.Windows.Forms.Label LBL_Confirma;
        private System.Windows.Forms.Button BTN_Verifica;
        private System.Windows.Forms.Button BTN_Limpar;
    }
}

