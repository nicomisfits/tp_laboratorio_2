﻿namespace FormEstante
{
    partial class Form1
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnExe = new System.Windows.Forms.Button();
            this.btnOrdernar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(139, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(217, 238);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnExe
            // 
            this.btnExe.Location = new System.Drawing.Point(40, 80);
            this.btnExe.Name = "btnExe";
            this.btnExe.Size = new System.Drawing.Size(75, 23);
            this.btnExe.TabIndex = 1;
            this.btnExe.Text = "Ejecutar";
            this.btnExe.UseVisualStyleBackColor = true;
            this.btnExe.Click += new System.EventHandler(this.btnExe_Click);
            // 
            // btnOrdernar
            // 
            this.btnOrdernar.Location = new System.Drawing.Point(40, 156);
            this.btnOrdernar.Name = "btnOrdernar";
            this.btnOrdernar.Size = new System.Drawing.Size(75, 23);
            this.btnOrdernar.TabIndex = 2;
            this.btnOrdernar.Text = "Ordenar";
            this.btnOrdernar.UseVisualStyleBackColor = true;
            this.btnOrdernar.Click += new System.EventHandler(this.btnOrdernar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 262);
            this.Controls.Add(this.btnOrdernar);
            this.Controls.Add(this.btnExe);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Listado";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnExe;
        private System.Windows.Forms.Button btnOrdernar;
    }
}

