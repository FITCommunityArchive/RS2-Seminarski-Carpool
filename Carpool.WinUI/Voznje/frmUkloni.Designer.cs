﻿namespace Carpool.WinUI.Voznje
{
    partial class frmUkloni
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
            this.btnUkloni = new System.Windows.Forms.Button();
            this.btnPregledRez = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUkloni
            // 
            this.btnUkloni.Location = new System.Drawing.Point(52, 57);
            this.btnUkloni.Name = "btnUkloni";
            this.btnUkloni.Size = new System.Drawing.Size(148, 23);
            this.btnUkloni.TabIndex = 0;
            this.btnUkloni.Text = "Ukloni vožnju";
            this.btnUkloni.UseVisualStyleBackColor = true;
            this.btnUkloni.Click += new System.EventHandler(this.btnUkloni_Click);
            // 
            // btnPregledRez
            // 
            this.btnPregledRez.Location = new System.Drawing.Point(52, 28);
            this.btnPregledRez.Name = "btnPregledRez";
            this.btnPregledRez.Size = new System.Drawing.Size(148, 23);
            this.btnPregledRez.TabIndex = 1;
            this.btnPregledRez.Text = "Pregled rezervacija";
            this.btnPregledRez.UseVisualStyleBackColor = true;
            this.btnPregledRez.Click += new System.EventHandler(this.btnPregledRez_Click);
            // 
            // frmUkloni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 110);
            this.Controls.Add(this.btnPregledRez);
            this.Controls.Add(this.btnUkloni);
            this.Name = "frmUkloni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ukloni";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUkloni;
        private System.Windows.Forms.Button btnPregledRez;
    }
}