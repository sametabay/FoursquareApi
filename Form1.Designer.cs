namespace FoursquareApi
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
            this.btnGetir = new System.Windows.Forms.Button();
            this.lstFirmlar = new System.Windows.Forms.ListBox();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.lblHereNow = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblFirmaAdi = new System.Windows.Forms.Label();
            this.lblKategori = new System.Windows.Forms.Label();
            this.btnHaritadaGoster = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetir
            // 
            this.btnGetir.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetir.Location = new System.Drawing.Point(233, 3);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(119, 83);
            this.btnGetir.TabIndex = 0;
            this.btnGetir.Text = "Getir de getirelim";
            this.btnGetir.UseVisualStyleBackColor = true;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // lstFirmlar
            // 
            this.lstFirmlar.FormattingEnabled = true;
            this.lstFirmlar.Location = new System.Drawing.Point(3, 29);
            this.lstFirmlar.Name = "lstFirmlar";
            this.lstFirmlar.Size = new System.Drawing.Size(224, 368);
            this.lstFirmlar.TabIndex = 1;
            this.lstFirmlar.SelectedIndexChanged += new System.EventHandler(this.lstFirmlar_SelectedIndexChanged);
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(3, 3);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(224, 20);
            this.txtArama.TabIndex = 2;
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            // 
            // lblHereNow
            // 
            this.lblHereNow.AutoSize = true;
            this.lblHereNow.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHereNow.Location = new System.Drawing.Point(233, 212);
            this.lblHereNow.Name = "lblHereNow";
            this.lblHereNow.Size = new System.Drawing.Size(172, 27);
            this.lblHereNow.TabIndex = 3;
            this.lblHereNow.Text = "şuan kaç kişi var";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdres.Location = new System.Drawing.Point(233, 162);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(67, 27);
            this.lblAdres.TabIndex = 4;
            this.lblAdres.Text = "Adres";
            // 
            // lblFirmaAdi
            // 
            this.lblFirmaAdi.AutoSize = true;
            this.lblFirmaAdi.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFirmaAdi.Location = new System.Drawing.Point(233, 112);
            this.lblFirmaAdi.Name = "lblFirmaAdi";
            this.lblFirmaAdi.Size = new System.Drawing.Size(99, 27);
            this.lblFirmaAdi.TabIndex = 5;
            this.lblFirmaAdi.Text = "firma adı";
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKategori.Location = new System.Drawing.Point(233, 262);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(94, 27);
            this.lblKategori.TabIndex = 3;
            this.lblKategori.Text = "Kategori";
            // 
            // btnHaritadaGoster
            // 
            this.btnHaritadaGoster.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHaritadaGoster.Location = new System.Drawing.Point(358, 3);
            this.btnHaritadaGoster.Name = "btnHaritadaGoster";
            this.btnHaritadaGoster.Size = new System.Drawing.Size(119, 83);
            this.btnHaritadaGoster.TabIndex = 0;
            this.btnHaritadaGoster.Text = "Haritada Göster";
            this.btnHaritadaGoster.UseVisualStyleBackColor = true;
            this.btnHaritadaGoster.Click += new System.EventHandler(this.btnHaritadaGoster_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(341, 431);
            this.webBrowser1.TabIndex = 6;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtArama);
            this.splitContainer1.Panel1.Controls.Add(this.btnGetir);
            this.splitContainer1.Panel1.Controls.Add(this.lblKategori);
            this.splitContainer1.Panel1.Controls.Add(this.btnHaritadaGoster);
            this.splitContainer1.Panel1.Controls.Add(this.lblHereNow);
            this.splitContainer1.Panel1.Controls.Add(this.lstFirmlar);
            this.splitContainer1.Panel1.Controls.Add(this.lblAdres);
            this.splitContainer1.Panel1.Controls.Add(this.lblFirmaAdi);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainer1.Size = new System.Drawing.Size(843, 431);
            this.splitContainer1.SplitterDistance = 498;
            this.splitContainer1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 431);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.ListBox lstFirmlar;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Label lblHereNow;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblFirmaAdi;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Button btnHaritadaGoster;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

