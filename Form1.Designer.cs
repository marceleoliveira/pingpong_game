﻿namespace PingPong
{
    partial class Form1
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
            this.panelArea = new System.Windows.Forms.Panel();
            this.panelPlayer1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelPlayer2 = new System.Windows.Forms.Panel();
            this.panelBall = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelArea
            // 
            this.panelArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelArea.Controls.Add(this.panelPlayer2);
            this.panelArea.Controls.Add(this.panelBall);
            this.panelArea.Controls.Add(this.panelPlayer1);
            this.panelArea.Location = new System.Drawing.Point(40, 82);
            this.panelArea.Name = "panelArea";
            this.panelArea.Size = new System.Drawing.Size(610, 362);
            this.panelArea.TabIndex = 0;
            // 
            // panelPlayer1
            // 
            this.panelPlayer1.BackColor = System.Drawing.Color.SlateGray;
            this.panelPlayer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPlayer1.Location = new System.Drawing.Point(8, 120);
            this.panelPlayer1.Name = "panelPlayer1";
            this.panelPlayer1.Size = new System.Drawing.Size(20, 100);
            this.panelPlayer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(46, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pontos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(616, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(520, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Velocidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(111, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "0";
            // 
            // panelPlayer2
            // 
            this.panelPlayer2.BackColor = System.Drawing.Color.SlateGray;
            this.panelPlayer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPlayer2.Location = new System.Drawing.Point(578, 120);
            this.panelPlayer2.Name = "panelPlayer2";
            this.panelPlayer2.Size = new System.Drawing.Size(20, 100);
            this.panelPlayer2.TabIndex = 2;
            // 
            // panelBall
            // 
            this.panelBall.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelBall.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBall.Location = new System.Drawing.Point(289, 154);
            this.panelBall.Name = "panelBall";
            this.panelBall.Size = new System.Drawing.Size(25, 25);
            this.panelBall.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(697, 476);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelArea);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelArea.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelArea;
        private System.Windows.Forms.Panel panelPlayer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelBall;
        private System.Windows.Forms.Panel panelPlayer2;
        private System.Windows.Forms.Timer timer1;
    }
}

