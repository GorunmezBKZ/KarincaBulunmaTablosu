using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Karinca
{
    public partial class Form2 : Form
    {
        private Form1 form1;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent();

        }

        private void formTemizle()
        {
            txtCins.Clear();
            cBoxAy.SelectedIndex = -1;
            cBoxSaat.SelectedIndex = -1;
            cBoxSehir.SelectedIndex = -1;
            txtBilgi.Clear();
            txtLink.Clear();
        }

        private void yeniEkle()
        {
            string fileName = "tablo.txt";
            string cins, ay, saat, sehir, bilgi, link;
            //CİNS
            cins = txtCins.Text;
            //AY-Saat-Sehir
            try
            {
                ay = cBoxAy.SelectedItem.ToString();
            } catch (System.NullReferenceException)
            {
                ay = "";
            }
            try
            {
                saat = cBoxSaat.SelectedItem.ToString();
            }
            catch (System.NullReferenceException)
            {
                saat = "";
            }
            try
            {
                sehir = cBoxSehir.SelectedItem.ToString();
            }
            catch (System.NullReferenceException)
            {
                sehir = "";
            }
            //BİLGİ
            if (txtBilgi.Text.Contains("En fazla 35"))
                bilgi = "";
            else
                bilgi = txtBilgi.Text;
            //LİNK
            link = txtLink.Text;

            string eklenecekBilgi = cins + ", " + ay + ", " + saat + ", " + sehir + ", " + bilgi + ", " + link;

            if (eklenecekBilgi == ", , , , , ")
            {
                MessageBox.Show("Lütfen bilgi girin.");
            }
            else {
                File.AppendAllText(fileName,
                 eklenecekBilgi + Environment.NewLine);
            }


        }


        private void button1_Click(object sender, EventArgs e)
        {
            formTemizle();
            this.Close();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            if (txtBilgi.Text.Length <= 35)
            {
                yeniEkle();

                formTemizle();
            }
            else {
                MessageBox.Show("Bilgi bölümü 35 karakterden az olmalı.");
            }
        }

        private void txtBilgi_Click(object sender, EventArgs e)
        {
            if (txtBilgi.Text == "En fazla 35 karakter")
                txtBilgi.Text = "";
        }

        
        private void txtBilgi_Leave(object sender, EventArgs e)
        {
            if (txtBilgi.Text == "")
                txtBilgi.Text = "En fazla 35 karakter";
          
        }


        

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            ListBoxTemizle(form1.Tb);
            form1.bilgileriGetir();
        }

        public void ListBoxTemizle(List<ListBox> Liste)
        {
            for (int i = 0; i < Liste.Count; i++)
            {
                Liste[i].Items.Clear();
            }
        }


        private void txtBilgi_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtBilgi.Text.Length > 35)
            {
                txtBilgi.AppendText("");
                e.SuppressKeyPress = true;
                
            }
        }

        private void txtCins_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',')
                e.KeyChar = '\0';
                
        }
    }
}
