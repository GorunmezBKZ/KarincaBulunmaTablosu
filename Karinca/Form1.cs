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
    public partial class Form1 : Form
    {
        public List<ListBox> Tb = new List<ListBox>();

        public List<string> Cinsler = new List<string>();
        public List<string> Aylar = new List<string>();
        public List<string> Sehirler = new List<string>();
        public List<string> Saatler = new List<string>();
        public List<string> Bilgiler = new List<string>();
        public List<string> Linkler = new List<string>();
        
        Form2 formYeni;

        public Form1()
        {
            InitializeComponent();
        }

        public void bilgileriGetir()
        {
            string path = @"tablo.txt";

            FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
            Encoding encodeUTF = Encoding.UTF8;
            //Encoding encodeISO = Encoding.GetEncoding("iso-8859-9");
            StreamReader oku = new StreamReader(fs, encodeUTF, false);

            Tb.Add(LboxCins);
            Tb.Add(LboxAy);
            Tb.Add(LboxSaat);
            Tb.Add(LboxSehir);
            Tb.Add(LboxBilgi);
            Tb.Add(LboxLink);

            string yazi = "";
            string b = "";
            int a;


            while (yazi != null)
            {
                yazi = oku.ReadLine();

                if (yazi == null)
                    break;
                a = 0;
                b = "";
                bool bas = true;

                for (int i = 0; i < yazi.Length; i++)
                {
                    if (yazi[i] == ',')
                    {
                        if (b != "")
                        {
                            Tb[a++].Items.Add(b);
                            b = "";
                        }
                        else
                        {
                            Tb[a++].Items.Add("Bilgi Yok");
                            b = "";
                        }
                        bas = true;
                    }
                    else if (yazi[i] == ' ' && bas)
                    {

                    }
                    else
                    {
                        bas = false;
                        b += yazi[i];
                    }
                }
                Tb[5].Items.Add(b);
                b = "";

            }
            oku.Close();
            
        }

        private string duzenle(string m)
        {
            string a = m;

            for(int i = 0;i<m.Length;i++)
            {
                a.Replace(' ', 'a');
            }            
            return a;
        }

        private void labelKonumAyarla()
        {
            LbCins.Left = LboxCins.Left + (LboxCins.Width / 2) - (LbCins.Width/2); 
            LbAy.Left = LboxAy.Left + (LboxAy.Width / 2) - (LbAy.Width / 2);
            LbSaat.Left = LboxSaat.Left + (LboxSaat.Width / 2) - (LbSaat.Width / 2);
            LbSehir.Left = LboxSehir.Left + (LboxSehir.Width / 2) - (LbSehir.Width / 2);
            LbBilgi.Left = LboxBilgi.Left + (LboxBilgi.Width / 2) - (LbBilgi.Width / 2);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 1; i < Tb.Count; i++)
                Tb[i].SelectedIndex = Tb[0].SelectedIndex;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < Tb.Count; i++)
                Tb[i].SelectedIndex = Tb[1].SelectedIndex;
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < Tb.Count; i++)
                Tb[i].SelectedIndex = Tb[2].SelectedIndex;
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < Tb.Count; i++)
                Tb[i].SelectedIndex = Tb[3].SelectedIndex;
        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < Tb.Count; i++)
                Tb[i].SelectedIndex = Tb[4].SelectedIndex;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string URL = "";
            try
            {
                URL = Tb[5].SelectedItem.ToString();
            }catch { MessageBox.Show("Önce bir konu seçin."); }
            

            if(URL != "")
            try
            {
                System.Diagnostics.Process.Start(URL);
            }
            catch { System.Diagnostics.Process.Start("chrome.exe", URL); }
            }

        private void Form1_Load(object sender, EventArgs e)
        {
            bilgileriGetir();
            bilgiTut();
            
            int maxLenght = 0;
            //ListBox5
            for (int i = 0; i < Tb.Count - 1; i++)
            {
                maxLenght = 0;
                for (int j = 1; j < Tb[i].Items.Count; j++)
                {
                    if (Tb[i].Items[j].ToString().Length > maxLenght)
                        maxLenght = Tb[i].Items[j].ToString().Length;

                }
                if(Tb[i].Width < maxLenght * 7)
                Tb[i].Width = maxLenght * 7;

                Tb[i + 1].Left = Tb[i].Left + Tb[i].Width + 5;
            }
            
            int LboxSayisi = Tb.Count - 2;
            // PANEL KONUMU
            panel1.Left = Tb[LboxSayisi].Left + Tb[LboxSayisi].Width + 5;
            this.Width = panel1.Left + panel1.Width + 20;

            cinsleriCBoxYaz(cBoxCins);
            cBoxCins.SelectedIndex = 0;
            labelKonumAyarla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formYeni = new Form2(this);
            formYeni.Show();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            List<string> yeniDosya = kayitKaldir(LboxCins.SelectedIndex);

            FileStream dosya = File.Create("tablo.txt");
            dosya.Close();

            File.AppendAllLines("tablo.txt", yeniDosya);
            
            try
            {
                for (int i = 0; i < Tb.Count; i++)
                    Tb[i].Items.Clear();
                bilgileriGetir();
            }
            catch { }
            
        }

        private List<string> kayitKaldir(int index)
        {
            string[] tempFile;
            List<string> tempList = new List<string>();

 
            tempFile = File.ReadAllLines("tablo.txt");
            

            for (int i = 0;i<tempFile.Length;i++)
            {
                if (i != index)
                    tempList.Add(tempFile[i]);
            }

            return tempList;
        }

        private void btnSirala_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < Tb.Count; i++)
                Tb[i].Items.Clear();

            //
                for (int i = 0; i < Cinsler.Count; i++)
                {
                    if (Cinsler[i].Contains(cBoxCins.SelectedItem.ToString()))
                    {
                        LboxCins.Items.Add(Cinsler[i]);
                        LboxAy.Items.Add(Aylar[i]);
                        LboxSaat.Items.Add(Saatler[i]);
                        LboxSehir.Items.Add(Sehirler[i]);
                        LboxBilgi.Items.Add(Bilgiler[i]);
                        LboxLink.Items.Add(Linkler[i]);
                    }
                    else if(cBoxCins.SelectedItem.ToString() == "Tümü")
                     {
                        LboxCins.Items.Add(Cinsler[i]);
                        LboxAy.Items.Add(Aylar[i]);
                        LboxSaat.Items.Add(Saatler[i]);
                        LboxSehir.Items.Add(Sehirler[i]);
                        LboxBilgi.Items.Add(Bilgiler[i]);
                        LboxLink.Items.Add(Linkler[i]);
                }
                
            }
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            List<string> tur = new List<string>();

            for(int i = 0;i<LboxCins.Items.Count;i++)
            {
                if (LboxCins.Items[i].ToString().Contains(cBoxCins.SelectedItem.ToString()))
                    tur.Add(LboxCins.Items[i].ToString());
            }

            LboxCins.Items.Clear();
            for (int i = 0; i < tur.Count; i++)
                LboxCins.Items.Add(tur[i]);
        }
        
        private string cinsDondur(string cins)
        {
           
            string[] tut = new string[2];
                
            tut = cins.Split(' ');
            return tut[0];

        }

        private void cinsleriCBoxYaz(ComboBox cBox)
        {
            bool ayni = false;

            if (Cinsler.Count > 0)
            {
                string[] tut = new string[2];

                for (int i = 0; i < Cinsler.Count; i++)
                {
                    ayni = false;
                    tut = Cinsler[i].Split(' ');
                    for (int j = 0; j < cBoxCins.Items.Count; j++)
                    {
                        if (cBoxCins.Items[j].ToString().Contains(tut[0]))
                        {
                            ayni = true;
                            break;
                        }
                    }
                    if (!ayni)
                        cBoxCins.Items.Add(tut[0]);
                }
            }
        }

        private void bilgiTut()
        {
            if (LboxCins.Items.Count > 0)

                for (int i = 0; i < LboxCins.Items.Count; i++)
                { 
                    Cinsler.Add(LboxCins.Items[i].ToString());
                    Aylar.Add(LboxAy.Items[i].ToString());
                    Saatler.Add(LboxSaat.Items[i].ToString());
                    Sehirler.Add(LboxSehir.Items[i].ToString());
                    Bilgiler.Add(LboxBilgi.Items[i].ToString());
                    Linkler.Add(LboxLink.Items[i].ToString());
                }
        }
        
        private void button2_Click_1(object sender, EventArgs e)
        {
            bool ayni = false;

            if (LboxCins.Items.Count > 0)
            {
                string[] tut = new string[2];

                for (int i = 0; i < LboxCins.Items.Count; i++)
                {
                    ayni = false;
                    tut = LboxCins.Items[i].ToString().Split(' ');
                    for(int j = 0;j<cBoxCins.Items.Count;j++)
                    {
                        if(cBoxCins.Items[j].ToString().Contains(tut[0]))
                        {
                            ayni = true;
                            break;
                        }
                    }
                    if(!ayni)
                        cBoxCins.Items.Add(tut[0]);
                }
            }
        }
    }
}
