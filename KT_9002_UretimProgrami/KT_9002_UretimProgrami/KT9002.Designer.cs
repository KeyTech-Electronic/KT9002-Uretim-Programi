namespace KT_9002_UretimProgrami
{
    partial class KT9002
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
            this.cbComPort = new System.Windows.Forms.ComboBox();
            this.btnBaglan = new System.Windows.Forms.Button();
            this.btnFWyukle = new System.Windows.Forms.Button();
            this.btnFabrikaAyarlarinaGeriDon = new System.Windows.Forms.Button();
            this.btnAktivasyonIptalEt = new System.Windows.Forms.Button();
            this.txtSeriNo = new System.Windows.Forms.TextBox();
            this.btnSeriNoGonder = new System.Windows.Forms.Button();
            this.btnPublicKeyGonder = new System.Windows.Forms.Button();
            this.mtxtPublicKey = new System.Windows.Forms.MaskedTextBox();
            this.btnKonsolTemizle = new System.Windows.Forms.Button();
            this.rtxtKonsol = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdKonsol = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // cbComPort
            // 
            this.cbComPort.DropDownHeight = 130;
            this.cbComPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbComPort.FormattingEnabled = true;
            this.cbComPort.IntegralHeight = false;
            this.cbComPort.ItemHeight = 16;
            this.cbComPort.Location = new System.Drawing.Point(104, 105);
            this.cbComPort.Name = "cbComPort";
            this.cbComPort.Size = new System.Drawing.Size(276, 24);
            this.cbComPort.TabIndex = 0;
            // 
            // btnBaglan
            // 
            this.btnBaglan.BackColor = System.Drawing.Color.SandyBrown;
            this.btnBaglan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaglan.Location = new System.Drawing.Point(386, 105);
            this.btnBaglan.Name = "btnBaglan";
            this.btnBaglan.Size = new System.Drawing.Size(135, 24);
            this.btnBaglan.TabIndex = 1;
            this.btnBaglan.Text = "Bağlan";
            this.btnBaglan.UseVisualStyleBackColor = false;
            this.btnBaglan.Click += new System.EventHandler(this.btnBaglan_Click);
            // 
            // btnFWyukle
            // 
            this.btnFWyukle.BackColor = System.Drawing.Color.SandyBrown;
            this.btnFWyukle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFWyukle.Location = new System.Drawing.Point(102, 140);
            this.btnFWyukle.Name = "btnFWyukle";
            this.btnFWyukle.Size = new System.Drawing.Size(135, 40);
            this.btnFWyukle.TabIndex = 2;
            this.btnFWyukle.Text = "FW Yükle";
            this.btnFWyukle.UseVisualStyleBackColor = false;
            this.btnFWyukle.Click += new System.EventHandler(this.btnFWyukle_Click);
            // 
            // btnFabrikaAyarlarinaGeriDon
            // 
            this.btnFabrikaAyarlarinaGeriDon.BackColor = System.Drawing.Color.SandyBrown;
            this.btnFabrikaAyarlarinaGeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFabrikaAyarlarinaGeriDon.Location = new System.Drawing.Point(245, 140);
            this.btnFabrikaAyarlarinaGeriDon.Name = "btnFabrikaAyarlarinaGeriDon";
            this.btnFabrikaAyarlarinaGeriDon.Size = new System.Drawing.Size(135, 40);
            this.btnFabrikaAyarlarinaGeriDon.TabIndex = 3;
            this.btnFabrikaAyarlarinaGeriDon.Text = "Fabrika Ayarlarına Geri Dön";
            this.btnFabrikaAyarlarinaGeriDon.UseVisualStyleBackColor = false;
            this.btnFabrikaAyarlarinaGeriDon.Click += new System.EventHandler(this.btnFabrikaAyarlarinaGeriDon_Click);
            // 
            // btnAktivasyonIptalEt
            // 
            this.btnAktivasyonIptalEt.BackColor = System.Drawing.Color.SandyBrown;
            this.btnAktivasyonIptalEt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAktivasyonIptalEt.Location = new System.Drawing.Point(386, 140);
            this.btnAktivasyonIptalEt.Name = "btnAktivasyonIptalEt";
            this.btnAktivasyonIptalEt.Size = new System.Drawing.Size(135, 40);
            this.btnAktivasyonIptalEt.TabIndex = 4;
            this.btnAktivasyonIptalEt.Text = "Aktivasyon İptal Et";
            this.btnAktivasyonIptalEt.UseVisualStyleBackColor = false;
            this.btnAktivasyonIptalEt.Click += new System.EventHandler(this.btnAktivasyonIptalEt_Click);
            // 
            // txtSeriNo
            // 
            this.txtSeriNo.Location = new System.Drawing.Point(102, 194);
            this.txtSeriNo.MaxLength = 10;
            this.txtSeriNo.Multiline = true;
            this.txtSeriNo.Name = "txtSeriNo";
            this.txtSeriNo.Size = new System.Drawing.Size(276, 25);
            this.txtSeriNo.TabIndex = 5;
            this.txtSeriNo.Enter += new System.EventHandler(this.txtSeriNo_Enter);
            // 
            // btnSeriNoGonder
            // 
            this.btnSeriNoGonder.BackColor = System.Drawing.Color.SandyBrown;
            this.btnSeriNoGonder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeriNoGonder.Location = new System.Drawing.Point(386, 192);
            this.btnSeriNoGonder.Name = "btnSeriNoGonder";
            this.btnSeriNoGonder.Size = new System.Drawing.Size(135, 27);
            this.btnSeriNoGonder.TabIndex = 6;
            this.btnSeriNoGonder.Text = "Gönder";
            this.btnSeriNoGonder.UseVisualStyleBackColor = false;
            this.btnSeriNoGonder.Click += new System.EventHandler(this.btnSeriNoGonder_Click);
            // 
            // btnPublicKeyGonder
            // 
            this.btnPublicKeyGonder.BackColor = System.Drawing.Color.SandyBrown;
            this.btnPublicKeyGonder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPublicKeyGonder.Location = new System.Drawing.Point(386, 230);
            this.btnPublicKeyGonder.Name = "btnPublicKeyGonder";
            this.btnPublicKeyGonder.Size = new System.Drawing.Size(135, 27);
            this.btnPublicKeyGonder.TabIndex = 8;
            this.btnPublicKeyGonder.Text = "Gönder";
            this.btnPublicKeyGonder.UseVisualStyleBackColor = false;
            this.btnPublicKeyGonder.Click += new System.EventHandler(this.btnPublicKeyGonder_Click);
            // 
            // mtxtPublicKey
            // 
            this.mtxtPublicKey.Culture = new System.Globalization.CultureInfo("en-US");
            this.mtxtPublicKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.mtxtPublicKey.Location = new System.Drawing.Point(102, 232);
            this.mtxtPublicKey.Name = "mtxtPublicKey";
            this.mtxtPublicKey.Size = new System.Drawing.Size(276, 24);
            this.mtxtPublicKey.TabIndex = 9;
            // 
            // btnKonsolTemizle
            // 
            this.btnKonsolTemizle.BackColor = System.Drawing.Color.SandyBrown;
            this.btnKonsolTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKonsolTemizle.Location = new System.Drawing.Point(384, 273);
            this.btnKonsolTemizle.Name = "btnKonsolTemizle";
            this.btnKonsolTemizle.Size = new System.Drawing.Size(135, 35);
            this.btnKonsolTemizle.TabIndex = 10;
            this.btnKonsolTemizle.Text = "Temizle (Konsol Temizle)";
            this.btnKonsolTemizle.UseVisualStyleBackColor = false;
            this.btnKonsolTemizle.Click += new System.EventHandler(this.btnKonsolTemizle_Click);
            // 
            // rtxtKonsol
            // 
            this.rtxtKonsol.BackColor = System.Drawing.Color.Black;
            this.rtxtKonsol.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtxtKonsol.ForeColor = System.Drawing.SystemColors.Control;
            this.rtxtKonsol.Location = new System.Drawing.Point(11, 314);
            this.rtxtKonsol.Name = "rtxtKonsol";
            this.rtxtKonsol.Size = new System.Drawing.Size(510, 319);
            this.rtxtKonsol.TabIndex = 11;
            this.rtxtKonsol.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.label1.Location = new System.Drawing.Point(35, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 44);
            this.label1.TabIndex = 12;
            this.label1.Text = "KT-9002 Üretim Programı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(6, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Seri No :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(5, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Public Key : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(6, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Com Port :";
            // 
            // cmdKonsol
            // 
            this.cmdKonsol.BackColor = System.Drawing.Color.Black;
            this.cmdKonsol.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmdKonsol.ForeColor = System.Drawing.SystemColors.Control;
            this.cmdKonsol.Location = new System.Drawing.Point(9, 639);
            this.cmdKonsol.Name = "cmdKonsol";
            this.cmdKonsol.Size = new System.Drawing.Size(510, 325);
            this.cmdKonsol.TabIndex = 16;
            this.cmdKonsol.Text = "";
            // 
            // KT9002
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(534, 967);
            this.Controls.Add(this.cmdKonsol);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtxtKonsol);
            this.Controls.Add(this.btnKonsolTemizle);
            this.Controls.Add(this.mtxtPublicKey);
            this.Controls.Add(this.btnPublicKeyGonder);
            this.Controls.Add(this.btnSeriNoGonder);
            this.Controls.Add(this.txtSeriNo);
            this.Controls.Add(this.btnAktivasyonIptalEt);
            this.Controls.Add(this.btnFabrikaAyarlarinaGeriDon);
            this.Controls.Add(this.btnFWyukle);
            this.Controls.Add(this.btnBaglan);
            this.Controls.Add(this.cbComPort);
            this.Name = "KT9002";
            this.Text = "KT-9002 Üretim Programı";
            this.Load += new System.EventHandler(this.KT9002_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbComPort;
        private System.Windows.Forms.Button btnBaglan;
        private System.Windows.Forms.Button btnFWyukle;
        private System.Windows.Forms.Button btnFabrikaAyarlarinaGeriDon;
        private System.Windows.Forms.Button btnAktivasyonIptalEt;
        private System.Windows.Forms.TextBox txtSeriNo;
        private System.Windows.Forms.Button btnSeriNoGonder;
        private System.Windows.Forms.Button btnPublicKeyGonder;
        private System.Windows.Forms.MaskedTextBox mtxtPublicKey;
        private System.Windows.Forms.Button btnKonsolTemizle;
        private System.Windows.Forms.RichTextBox rtxtKonsol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox cmdKonsol;
    }
}

