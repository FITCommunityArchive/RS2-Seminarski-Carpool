﻿namespace Carpool.WinUI.Obavijesti
{
    partial class frmDetaljiObavijesti
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
            this.dgvObavijestiList = new System.Windows.Forms.DataGridView();
            this.btnDodajObavijest = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnTrazi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObavijestiList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvObavijestiList
            // 
            this.dgvObavijestiList.AllowUserToAddRows = false;
            this.dgvObavijestiList.AllowUserToDeleteRows = false;
            this.dgvObavijestiList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObavijestiList.Location = new System.Drawing.Point(12, 188);
            this.dgvObavijestiList.Name = "dgvObavijestiList";
            this.dgvObavijestiList.ReadOnly = true;
            this.dgvObavijestiList.Size = new System.Drawing.Size(759, 250);
            this.dgvObavijestiList.TabIndex = 0;
            // 
            // btnDodajObavijest
            // 
            this.btnDodajObavijest.Location = new System.Drawing.Point(651, 150);
            this.btnDodajObavijest.Name = "btnDodajObavijest";
            this.btnDodajObavijest.Size = new System.Drawing.Size(120, 23);
            this.btnDodajObavijest.TabIndex = 1;
            this.btnDodajObavijest.Text = "Dodaj obavijest";
            this.btnDodajObavijest.UseVisualStyleBackColor = true;
            this.btnDodajObavijest.Click += new System.EventHandler(this.btnDodajObavijest_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(44, 130);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(164, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // btnTrazi
            // 
            this.btnTrazi.Location = new System.Drawing.Point(214, 128);
            this.btnTrazi.Name = "btnTrazi";
            this.btnTrazi.Size = new System.Drawing.Size(75, 23);
            this.btnTrazi.TabIndex = 3;
            this.btnTrazi.Text = "Traži";
            this.btnTrazi.UseVisualStyleBackColor = true;
            this.btnTrazi.Click += new System.EventHandler(this.btnTrazi_Click);
            // 
            // frmDetaljiObavijesti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTrazi);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnDodajObavijest);
            this.Controls.Add(this.dgvObavijestiList);
            this.Name = "frmDetaljiObavijesti";
            this.Text = "frmDetaljiObavijesti";
            this.Load += new System.EventHandler(this.frmDetaljiObavijesti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObavijestiList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvObavijestiList;
        private System.Windows.Forms.Button btnDodajObavijest;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnTrazi;
    }
}