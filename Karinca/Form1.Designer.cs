namespace Karinca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LbCins = new System.Windows.Forms.Label();
            this.LbAy = new System.Windows.Forms.Label();
            this.LbSaat = new System.Windows.Forms.Label();
            this.LbSehir = new System.Windows.Forms.Label();
            this.LbBilgi = new System.Windows.Forms.Label();
            this.LboxCins = new System.Windows.Forms.ListBox();
            this.LboxAy = new System.Windows.Forms.ListBox();
            this.LboxSaat = new System.Windows.Forms.ListBox();
            this.LboxSehir = new System.Windows.Forms.ListBox();
            this.LboxBilgi = new System.Windows.Forms.ListBox();
            this.btnKonu = new System.Windows.Forms.Button();
            this.LboxLink = new System.Windows.Forms.ListBox();
            this.btnYeni = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnSirala = new System.Windows.Forms.Button();
            this.cBoxCins = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LbCins
            // 
            this.LbCins.AutoSize = true;
            this.LbCins.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LbCins.Location = new System.Drawing.Point(49, 14);
            this.LbCins.Name = "LbCins";
            this.LbCins.Size = new System.Drawing.Size(52, 25);
            this.LbCins.TabIndex = 2;
            this.LbCins.Text = "Cins";
            // 
            // LbAy
            // 
            this.LbAy.AutoSize = true;
            this.LbAy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LbAy.Location = new System.Drawing.Point(206, 14);
            this.LbAy.Name = "LbAy";
            this.LbAy.Size = new System.Drawing.Size(36, 25);
            this.LbAy.TabIndex = 4;
            this.LbAy.Text = "Ay";
            // 
            // LbSaat
            // 
            this.LbSaat.AutoSize = true;
            this.LbSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LbSaat.Location = new System.Drawing.Point(357, 14);
            this.LbSaat.Name = "LbSaat";
            this.LbSaat.Size = new System.Drawing.Size(53, 25);
            this.LbSaat.TabIndex = 6;
            this.LbSaat.Text = "Saat";
            this.LbSaat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LbSehir
            // 
            this.LbSehir.AutoSize = true;
            this.LbSehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LbSehir.Location = new System.Drawing.Point(505, 14);
            this.LbSehir.Name = "LbSehir";
            this.LbSehir.Size = new System.Drawing.Size(58, 25);
            this.LbSehir.TabIndex = 8;
            this.LbSehir.Text = "Şehir";
            // 
            // LbBilgi
            // 
            this.LbBilgi.AutoSize = true;
            this.LbBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LbBilgi.Location = new System.Drawing.Point(648, 14);
            this.LbBilgi.Name = "LbBilgi";
            this.LbBilgi.Size = new System.Drawing.Size(69, 25);
            this.LbBilgi.TabIndex = 10;
            this.LbBilgi.Text = "Bilgiler";
            // 
            // LboxCins
            // 
            this.LboxCins.BackColor = System.Drawing.Color.Lavender;
            this.LboxCins.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LboxCins.FormattingEnabled = true;
            this.LboxCins.ItemHeight = 15;
            this.LboxCins.Location = new System.Drawing.Point(12, 59);
            this.LboxCins.Name = "LboxCins";
            this.LboxCins.Size = new System.Drawing.Size(145, 199);
            this.LboxCins.TabIndex = 11;
            this.LboxCins.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // LboxAy
            // 
            this.LboxAy.BackColor = System.Drawing.Color.Lavender;
            this.LboxAy.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LboxAy.FormattingEnabled = true;
            this.LboxAy.ItemHeight = 15;
            this.LboxAy.Location = new System.Drawing.Point(163, 59);
            this.LboxAy.Name = "LboxAy";
            this.LboxAy.Size = new System.Drawing.Size(145, 199);
            this.LboxAy.TabIndex = 12;
            this.LboxAy.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // LboxSaat
            // 
            this.LboxSaat.BackColor = System.Drawing.Color.Lavender;
            this.LboxSaat.Cursor = System.Windows.Forms.Cursors.Default;
            this.LboxSaat.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LboxSaat.FormattingEnabled = true;
            this.LboxSaat.ItemHeight = 15;
            this.LboxSaat.Location = new System.Drawing.Point(314, 59);
            this.LboxSaat.Name = "LboxSaat";
            this.LboxSaat.Size = new System.Drawing.Size(145, 199);
            this.LboxSaat.TabIndex = 13;
            this.LboxSaat.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // LboxSehir
            // 
            this.LboxSehir.BackColor = System.Drawing.Color.Lavender;
            this.LboxSehir.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LboxSehir.FormattingEnabled = true;
            this.LboxSehir.ItemHeight = 15;
            this.LboxSehir.Location = new System.Drawing.Point(465, 59);
            this.LboxSehir.Name = "LboxSehir";
            this.LboxSehir.Size = new System.Drawing.Size(145, 199);
            this.LboxSehir.TabIndex = 14;
            this.LboxSehir.SelectedIndexChanged += new System.EventHandler(this.listBox4_SelectedIndexChanged);
            // 
            // LboxBilgi
            // 
            this.LboxBilgi.BackColor = System.Drawing.Color.Lavender;
            this.LboxBilgi.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LboxBilgi.FormattingEnabled = true;
            this.LboxBilgi.ItemHeight = 15;
            this.LboxBilgi.Location = new System.Drawing.Point(616, 59);
            this.LboxBilgi.Name = "LboxBilgi";
            this.LboxBilgi.Size = new System.Drawing.Size(145, 199);
            this.LboxBilgi.TabIndex = 15;
            this.LboxBilgi.SelectedIndexChanged += new System.EventHandler(this.listBox5_SelectedIndexChanged);
            // 
            // btnKonu
            // 
            this.btnKonu.BackColor = System.Drawing.Color.BurlyWood;
            this.btnKonu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnKonu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKonu.Location = new System.Drawing.Point(0, 9);
            this.btnKonu.Name = "btnKonu";
            this.btnKonu.Size = new System.Drawing.Size(154, 41);
            this.btnKonu.TabIndex = 16;
            this.btnKonu.Text = "Konuya Git";
            this.btnKonu.UseVisualStyleBackColor = false;
            this.btnKonu.Click += new System.EventHandler(this.button2_Click);
            // 
            // LboxLink
            // 
            this.LboxLink.Enabled = false;
            this.LboxLink.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LboxLink.FormattingEnabled = true;
            this.LboxLink.ItemHeight = 15;
            this.LboxLink.Location = new System.Drawing.Point(616, 264);
            this.LboxLink.Name = "LboxLink";
            this.LboxLink.Size = new System.Drawing.Size(58, 19);
            this.LboxLink.TabIndex = 17;
            this.LboxLink.Visible = false;
            // 
            // btnYeni
            // 
            this.btnYeni.BackColor = System.Drawing.Color.BurlyWood;
            this.btnYeni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnYeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeni.Location = new System.Drawing.Point(0, 56);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(154, 41);
            this.btnYeni.TabIndex = 18;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = false;
            this.btnYeni.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDuzenle);
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Controls.Add(this.btnKonu);
            this.panel1.Controls.Add(this.btnYeni);
            this.panel1.Location = new System.Drawing.Point(767, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 199);
            this.panel1.TabIndex = 19;
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.BackColor = System.Drawing.Color.BurlyWood;
            this.btnDuzenle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDuzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDuzenle.Location = new System.Drawing.Point(0, 103);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(154, 41);
            this.btnDuzenle.TabIndex = 22;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = false;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.BurlyWood;
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(0, 150);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(154, 41);
            this.btnSil.TabIndex = 19;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnSirala
            // 
            this.btnSirala.BackColor = System.Drawing.Color.BurlyWood;
            this.btnSirala.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSirala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSirala.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSirala.Location = new System.Drawing.Point(465, 262);
            this.btnSirala.Name = "btnSirala";
            this.btnSirala.Size = new System.Drawing.Size(145, 41);
            this.btnSirala.TabIndex = 20;
            this.btnSirala.Text = "Sırala";
            this.btnSirala.UseVisualStyleBackColor = false;
            this.btnSirala.Click += new System.EventHandler(this.btnSirala_Click);
            // 
            // cBoxCins
            // 
            this.cBoxCins.FormattingEnabled = true;
            this.cBoxCins.Items.AddRange(new object[] {
            "Tümü"});
            this.cBoxCins.Location = new System.Drawing.Point(12, 264);
            this.cBoxCins.Name = "cBoxCins";
            this.cBoxCins.Size = new System.Drawing.Size(145, 21);
            this.cBoxCins.TabIndex = 21;
            this.cBoxCins.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(937, 317);
            this.Controls.Add(this.cBoxCins);
            this.Controls.Add(this.btnSirala);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LboxLink);
            this.Controls.Add(this.LboxBilgi);
            this.Controls.Add(this.LboxSehir);
            this.Controls.Add(this.LboxSaat);
            this.Controls.Add(this.LboxAy);
            this.Controls.Add(this.LboxCins);
            this.Controls.Add(this.LbBilgi);
            this.Controls.Add(this.LbSehir);
            this.Controls.Add(this.LbSaat);
            this.Controls.Add(this.LbAy);
            this.Controls.Add(this.LbCins);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Türkiye Karınca Listesi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LbCins;
        private System.Windows.Forms.Label LbAy;
        private System.Windows.Forms.Label LbSaat;
        private System.Windows.Forms.Label LbSehir;
        private System.Windows.Forms.Label LbBilgi;
        private System.Windows.Forms.ListBox LboxCins;
        private System.Windows.Forms.ListBox LboxSaat;
        private System.Windows.Forms.ListBox LboxSehir;
        private System.Windows.Forms.ListBox LboxBilgi;
        private System.Windows.Forms.Button btnKonu;
        private System.Windows.Forms.ListBox LboxLink;
        private System.Windows.Forms.ListBox LboxAy;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnSirala;
        private System.Windows.Forms.ComboBox cBoxCins;
    }
}

