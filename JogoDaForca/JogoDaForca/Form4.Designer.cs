﻿namespace JogoDaForca
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_Voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(49, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desenvolvedores:\r\n\r\nManuel Cassiano - RA: 172152\r\nLucas Komatsu - RA: 170958";
            // 
            // BTN_Voltar
            // 
            this.BTN_Voltar.BackColor = System.Drawing.Color.Transparent;
            this.BTN_Voltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Voltar.Location = new System.Drawing.Point(113, 180);
            this.BTN_Voltar.Name = "BTN_Voltar";
            this.BTN_Voltar.Size = new System.Drawing.Size(75, 25);
            this.BTN_Voltar.TabIndex = 1;
            this.BTN_Voltar.Text = "Voltar";
            this.BTN_Voltar.UseVisualStyleBackColor = false;
            this.BTN_Voltar.Click += new System.EventHandler(this.BTN_Voltar_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JogoDaForca.Properties.Resources.wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(294, 217);
            this.ControlBox = false;
            this.Controls.Add(this.BTN_Voltar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sobre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_Voltar;
    }
}