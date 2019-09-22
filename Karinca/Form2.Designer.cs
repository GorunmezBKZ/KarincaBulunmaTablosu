namespace Karinca
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.txtCins = new System.Windows.Forms.TextBox();
            this.txtBilgi = new System.Windows.Forms.TextBox();
            this.LbCins = new System.Windows.Forms.Label();
            this.LbAy = new System.Windows.Forms.Label();
            this.LbSaat = new System.Windows.Forms.Label();
            this.LbSehir = new System.Windows.Forms.Label();
            this.LbBilgi = new System.Windows.Forms.Label();
            this.LbLink = new System.Windows.Forms.Label();
            this.cBoxAy = new System.Windows.Forms.ComboBox();
            this.cBoxSaat = new System.Windows.Forms.ComboBox();
            this.cBoxSehir = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnYeni = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtLink = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtCins
            // 
            this.txtCins.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCins.Location = new System.Drawing.Point(181, 15);
            this.txtCins.Multiline = true;
            this.txtCins.Name = "txtCins";
            this.txtCins.Size = new System.Drawing.Size(288, 25);
            this.txtCins.TabIndex = 0;
            this.txtCins.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCins_KeyPress);
            // 
            // txtBilgi
            // 
            this.txtBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBilgi.Location = new System.Drawing.Point(181, 148);
            this.txtBilgi.MaxLength = 35;
            this.txtBilgi.Multiline = true;
            this.txtBilgi.Name = "txtBilgi";
            this.txtBilgi.Size = new System.Drawing.Size(288, 37);
            this.txtBilgi.TabIndex = 4;
            this.txtBilgi.Text = "En fazla 35 karakter";
            this.txtBilgi.Click += new System.EventHandler(this.txtBilgi_Click);
            this.txtBilgi.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBilgi_KeyUp);
            this.txtBilgi.Leave += new System.EventHandler(this.txtBilgi_Leave);
            // 
            // LbCins
            // 
            this.LbCins.AutoSize = true;
            this.LbCins.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LbCins.Location = new System.Drawing.Point(53, 14);
            this.LbCins.Name = "LbCins";
            this.LbCins.Size = new System.Drawing.Size(52, 25);
            this.LbCins.TabIndex = 6;
            this.LbCins.Text = "Cins";
            // 
            // LbAy
            // 
            this.LbAy.AutoSize = true;
            this.LbAy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LbAy.Location = new System.Drawing.Point(60, 48);
            this.LbAy.Name = "LbAy";
            this.LbAy.Size = new System.Drawing.Size(36, 25);
            this.LbAy.TabIndex = 7;
            this.LbAy.Text = "Ay";
            // 
            // LbSaat
            // 
            this.LbSaat.AutoSize = true;
            this.LbSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LbSaat.Location = new System.Drawing.Point(52, 79);
            this.LbSaat.Name = "LbSaat";
            this.LbSaat.Size = new System.Drawing.Size(53, 25);
            this.LbSaat.TabIndex = 8;
            this.LbSaat.Text = "Saat";
            // 
            // LbSehir
            // 
            this.LbSehir.AutoSize = true;
            this.LbSehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LbSehir.Location = new System.Drawing.Point(47, 117);
            this.LbSehir.Name = "LbSehir";
            this.LbSehir.Size = new System.Drawing.Size(58, 25);
            this.LbSehir.TabIndex = 9;
            this.LbSehir.Text = "Şehir";
            // 
            // LbBilgi
            // 
            this.LbBilgi.AutoSize = true;
            this.LbBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LbBilgi.Location = new System.Drawing.Point(37, 160);
            this.LbBilgi.Name = "LbBilgi";
            this.LbBilgi.Size = new System.Drawing.Size(97, 25);
            this.LbBilgi.TabIndex = 10;
            this.LbBilgi.Text = "Ek Bilgiler";
            // 
            // LbLink
            // 
            this.LbLink.AutoSize = true;
            this.LbLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LbLink.Location = new System.Drawing.Point(19, 203);
            this.LbLink.Name = "LbLink";
            this.LbLink.Size = new System.Drawing.Size(137, 25);
            this.LbLink.TabIndex = 11;
            this.LbLink.Text = "Konunun Linki";
            // 
            // cBoxAy
            // 
            this.cBoxAy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cBoxAy.FormattingEnabled = true;
            this.cBoxAy.Items.AddRange(new object[] {
            "Ocak",
            "Şubat",
            "Mart",
            "Nisan",
            "Mayıs",
            "Haziran",
            "Temmuz",
            "Ağustos",
            "Eylül",
            "Ekim",
            "Kasım",
            "Aralık"});
            this.cBoxAy.Location = new System.Drawing.Point(181, 46);
            this.cBoxAy.Name = "cBoxAy";
            this.cBoxAy.Size = new System.Drawing.Size(121, 28);
            this.cBoxAy.TabIndex = 12;
            // 
            // cBoxSaat
            // 
            this.cBoxSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cBoxSaat.FormattingEnabled = true;
            this.cBoxSaat.Items.AddRange(new object[] {
            "01:00",
            "02:00",
            "03:00",
            "04:00",
            "05:00",
            "06:00",
            "07:00",
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00",
            "22:00",
            "23:00",
            "24:00"});
            this.cBoxSaat.Location = new System.Drawing.Point(183, 80);
            this.cBoxSaat.Name = "cBoxSaat";
            this.cBoxSaat.Size = new System.Drawing.Size(119, 28);
            this.cBoxSaat.TabIndex = 13;
            // 
            // cBoxSehir
            // 
            this.cBoxSehir.DropDownHeight = 150;
            this.cBoxSehir.DropDownWidth = 50;
            this.cBoxSehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cBoxSehir.FormattingEnabled = true;
            this.cBoxSehir.IntegralHeight = false;
            this.cBoxSehir.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyon",
            "Ağrı",
            "Aksaray",
            "Amasya",
            "Ankara",
            "Antalya",
            "Ardahan",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bartın",
            "Batman",
            "Bayburt",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Düzce",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkari",
            "Hatay",
            "Iğdır",
            "Isparta",
            "İstanbul",
            "İzmir",
            "Kahramanmaraş",
            "Karabük",
            "Karaman",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırıkkale",
            "Kırklareli",
            "Kırşehir",
            "Kilis",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Mardin",
            "Mersin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Osmaniye",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Şanlıurfa",
            "Şırnak",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Uşak",
            "Van",
            "Yalova",
            "Yozgat",
            "Zonguldak"});
            this.cBoxSehir.Location = new System.Drawing.Point(181, 114);
            this.cBoxSehir.Name = "cBoxSehir";
            this.cBoxSehir.Size = new System.Drawing.Size(121, 28);
            this.cBoxSehir.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(162, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(162, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(162, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(162, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(162, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(162, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = ":";
            // 
            // btnYeni
            // 
            this.btnYeni.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnYeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeni.Location = new System.Drawing.Point(76, 234);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(154, 41);
            this.btnYeni.TabIndex = 21;
            this.btnYeni.Text = "Kaydet";
            this.btnYeni.UseVisualStyleBackColor = false;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(236, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 41);
            this.button1.TabIndex = 22;
            this.button1.Text = "İptal";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLink
            // 
            this.txtLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtLink.Location = new System.Drawing.Point(181, 191);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(288, 37);
            this.txtLink.TabIndex = 23;
            this.txtLink.Text = "";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(513, 279);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBoxSehir);
            this.Controls.Add(this.cBoxSaat);
            this.Controls.Add(this.cBoxAy);
            this.Controls.Add(this.LbLink);
            this.Controls.Add(this.LbBilgi);
            this.Controls.Add(this.LbSehir);
            this.Controls.Add(this.LbSaat);
            this.Controls.Add(this.LbAy);
            this.Controls.Add(this.LbCins);
            this.Controls.Add(this.txtBilgi);
            this.Controls.Add(this.txtCins);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Yeni Karınca Ekle";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCins;
        private System.Windows.Forms.TextBox txtBilgi;
        private System.Windows.Forms.Label LbCins;
        private System.Windows.Forms.Label LbAy;
        private System.Windows.Forms.Label LbSaat;
        private System.Windows.Forms.Label LbSehir;
        private System.Windows.Forms.Label LbBilgi;
        private System.Windows.Forms.Label LbLink;
        private System.Windows.Forms.ComboBox cBoxAy;
        private System.Windows.Forms.ComboBox cBoxSaat;
        private System.Windows.Forms.ComboBox cBoxSehir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox txtLink;
    }
}