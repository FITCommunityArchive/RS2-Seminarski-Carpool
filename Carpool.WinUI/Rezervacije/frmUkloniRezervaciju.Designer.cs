﻿namespace Carpool.WinUI.Rezervacije
{
    partial class frmUkloniRezervaciju
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
            this.SuspendLayout();
            // 
            // btnUkloni
            // 
            this.btnUkloni.Location = new System.Drawing.Point(64, 44);
            this.btnUkloni.Name = "btnUkloni";
            this.btnUkloni.Size = new System.Drawing.Size(142, 23);
            this.btnUkloni.TabIndex = 0;
            this.btnUkloni.Text = "Ukloni rezervaciju";
            this.btnUkloni.UseVisualStyleBackColor = true;
            this.btnUkloni.Click += new System.EventHandler(this.btnUkloni_Click);
            // 
            // frmUkloniRezervaciju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 122);
            this.Controls.Add(this.btnUkloni);
            this.Name = "frmUkloniRezervaciju";
            this.Text = "frmUkloniRezervaciju";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUkloni;
    }
}