﻿using Carpool.Model.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carpool.WinUI.Automobili
{
    public partial class frmDodajAutomobil : Form
    {
        private readonly APIService _apiService = new APIService("automobil");
        private int? _id = null;
        public frmDodajAutomobil(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }

        private async void frmDodaj_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var result = await _apiService.GetById<Model.Automobil>(_id);

                txtNaziv.Text = result.Naziv;
                txtModel.Text = result.Model;
                txtRegOznake.Text = result.BrojRegOznaka;
                txtGodiste.Text = result.Godiste;
                dtmDatumIstekaReg.Value = result.DatumIstekaRegistracije;

                pictureBox.Image = ByteToImage(result.Slika);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        AutomobilInsertRequest request = new AutomobilInsertRequest();
        private async void btnSpremi_Click(object sender, EventArgs e)
        {
            request.Naziv = txtNaziv.Text;
            request.Model = txtModel.Text;
            request.BrojRegOznaka = txtRegOznake.Text;
            request.Godiste = txtGodiste.Text;
            request.DatumIstekaRegistracije = dtmDatumIstekaReg.Value;
         
            if (_id.HasValue)
            {

                await _apiService.Update<Model.Automobil>((int)_id, request);
            }
            else
            {
                await _apiService.Insert<Model.Automobil>(request);
            }

            MessageBox.Show("Uspješno dodavanje");
            this.Close();
        }

        private void btnDodajSliku_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();

            if(result == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;

                var file = File.ReadAllBytes(fileName);

                request.Slika = file;
                request.SlikaThumb = file;

                txtSlika.Text = fileName;

                Image image = Image.FromFile(fileName);
                pictureBox.Image = image;
            }
        }

        private async void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
               var auto = await _apiService.Delete<Model.Automobil>((int)_id);
                if (auto != null)
                {
                    MessageBox.Show("Uspješno obrisan automobil");
                }
             
                this.Close();
            }
            catch (Exception)
            {

            }
        }
    }
}
