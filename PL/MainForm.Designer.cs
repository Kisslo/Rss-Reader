using System.Windows.Forms;

namespace Podden.PL
{
    partial class PodcastForm : Form
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
            this.lbKategorier = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTabortKategori = new System.Windows.Forms.Button();
            this.btnSparaKategori = new System.Windows.Forms.Button();
            this.btnNyKategori = new System.Windows.Forms.Button();
            this.tbKategori = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rtbBeskrivning = new System.Windows.Forms.RichTextBox();
            this.lvAvsnitt = new System.Windows.Forms.ListView();
            this.btnTabortPodcast = new System.Windows.Forms.Button();
            this.btnSparaPodcast = new System.Windows.Forms.Button();
            this.lblUFrekvens = new System.Windows.Forms.Label();
            this.lblUrl = new System.Windows.Forms.Label();
            this.cbKategori = new System.Windows.Forms.ComboBox();
            this.cbUpdFreq = new System.Windows.Forms.ComboBox();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.Frekvens = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Avsnitt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kategori = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Namn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnNyPodcast = new System.Windows.Forms.Button();
            this.lblKategori = new System.Windows.Forms.Label();
            this.lvPodcasts = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lbKategorier
            // 
            this.lbKategorier.FormattingEnabled = true;
            this.lbKategorier.Location = new System.Drawing.Point(467, 23);
            this.lbKategorier.Margin = new System.Windows.Forms.Padding(2);
            this.lbKategorier.Name = "lbKategorier";
            this.lbKategorier.Size = new System.Drawing.Size(281, 173);
            this.lbKategorier.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(442, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1, 435);
            this.label4.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(447, 264);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 1);
            this.label3.TabIndex = 39;
            // 
            // btnTabortKategori
            // 
            this.btnTabortKategori.Location = new System.Drawing.Point(648, 231);
            this.btnTabortKategori.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnTabortKategori.Name = "btnTabortKategori";
            this.btnTabortKategori.Size = new System.Drawing.Size(69, 19);
            this.btnTabortKategori.TabIndex = 38;
            this.btnTabortKategori.Text = "Ta bort";
            this.btnTabortKategori.UseVisualStyleBackColor = true;
            // 
            // btnSparaKategori
            // 
            this.btnSparaKategori.Location = new System.Drawing.Point(575, 231);
            this.btnSparaKategori.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSparaKategori.Name = "btnSparaKategori";
            this.btnSparaKategori.Size = new System.Drawing.Size(69, 19);
            this.btnSparaKategori.TabIndex = 37;
            this.btnSparaKategori.Text = "Spara";
            this.btnSparaKategori.UseVisualStyleBackColor = true;
            // 
            // btnNyKategori
            // 
            this.btnNyKategori.Location = new System.Drawing.Point(501, 231);
            this.btnNyKategori.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnNyKategori.Name = "btnNyKategori";
            this.btnNyKategori.Size = new System.Drawing.Size(69, 19);
            this.btnNyKategori.TabIndex = 36;
            this.btnNyKategori.Text = "Ny...";
            this.btnNyKategori.UseVisualStyleBackColor = true;
            this.btnNyKategori.Click += new System.EventHandler(this.btnNyKategori_Click);
            // 
            // tbKategori
            // 
            this.tbKategori.Location = new System.Drawing.Point(467, 205);
            this.tbKategori.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbKategori.Name = "tbKategori";
            this.tbKategori.Size = new System.Drawing.Size(281, 20);
            this.tbKategori.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(464, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Kategorier:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 296);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Avsnitt";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Titel";
            this.columnHeader2.Width = 300;
            // 
            // rtbBeskrivning
            // 
            this.rtbBeskrivning.Location = new System.Drawing.Point(467, 283);
            this.rtbBeskrivning.Margin = new System.Windows.Forms.Padding(2);
            this.rtbBeskrivning.Name = "rtbBeskrivning";
            this.rtbBeskrivning.Size = new System.Drawing.Size(281, 159);
            this.rtbBeskrivning.TabIndex = 41;
            this.rtbBeskrivning.Text = "";
            // 
            // lvAvsnitt
            // 
            this.lvAvsnitt.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.lvAvsnitt.HideSelection = false;
            this.lvAvsnitt.Location = new System.Drawing.Point(52, 314);
            this.lvAvsnitt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lvAvsnitt.Name = "lvAvsnitt";
            this.lvAvsnitt.Size = new System.Drawing.Size(365, 128);
            this.lvAvsnitt.TabIndex = 32;
            this.lvAvsnitt.UseCompatibleStateImageBehavior = false;
            this.lvAvsnitt.View = System.Windows.Forms.View.Details;
            // 
            // btnTabortPodcast
            // 
            this.btnTabortPodcast.Location = new System.Drawing.Point(270, 264);
            this.btnTabortPodcast.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnTabortPodcast.Name = "btnTabortPodcast";
            this.btnTabortPodcast.Size = new System.Drawing.Size(69, 19);
            this.btnTabortPodcast.TabIndex = 31;
            this.btnTabortPodcast.Text = "Ta bort";
            this.btnTabortPodcast.UseVisualStyleBackColor = true;
            // 
            // btnSparaPodcast
            // 
            this.btnSparaPodcast.Location = new System.Drawing.Point(197, 264);
            this.btnSparaPodcast.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSparaPodcast.Name = "btnSparaPodcast";
            this.btnSparaPodcast.Size = new System.Drawing.Size(69, 19);
            this.btnSparaPodcast.TabIndex = 30;
            this.btnSparaPodcast.Text = "Spara";
            this.btnSparaPodcast.UseVisualStyleBackColor = true;
            // 
            // lblUFrekvens
            // 
            this.lblUFrekvens.AutoSize = true;
            this.lblUFrekvens.Location = new System.Drawing.Point(206, 207);
            this.lblUFrekvens.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUFrekvens.Name = "lblUFrekvens";
            this.lblUFrekvens.Size = new System.Drawing.Size(114, 13);
            this.lblUFrekvens.TabIndex = 27;
            this.lblUFrekvens.Text = "Uppdateringsfrekvens:";
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(52, 207);
            this.lblUrl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(32, 13);
            this.lblUrl.TabIndex = 26;
            this.lblUrl.Text = "URL:";
            // 
            // cbKategori
            // 
            this.cbKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Location = new System.Drawing.Point(326, 229);
            this.cbKategori.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(92, 21);
            this.cbKategori.TabIndex = 25;
            // 
            // cbUpdFreq
            // 
            this.cbUpdFreq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUpdFreq.FormattingEnabled = true;
            this.cbUpdFreq.Items.AddRange(new object[] {
            "2 minuter",
            "5 minuter",
            "10 minuter",
            "30 minuter"});
            this.cbUpdFreq.Location = new System.Drawing.Point(208, 229);
            this.cbUpdFreq.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbUpdFreq.Name = "cbUpdFreq";
            this.cbUpdFreq.Size = new System.Drawing.Size(109, 21);
            this.cbUpdFreq.TabIndex = 24;
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(52, 229);
            this.tbUrl.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(147, 20);
            this.tbUrl.TabIndex = 23;
            // 
            // Frekvens
            // 
            this.Frekvens.Text = "Frekvens";
            // 
            // Avsnitt
            // 
            this.Avsnitt.Text = "Avsnitt";
            // 
            // Kategori
            // 
            this.Kategori.Text = "Kategori";
            // 
            // Namn
            // 
            this.Namn.Text = "Namn";
            this.Namn.Width = 100;
            // 
            // btnNyPodcast
            // 
            this.btnNyPodcast.Location = new System.Drawing.Point(124, 264);
            this.btnNyPodcast.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnNyPodcast.Name = "btnNyPodcast";
            this.btnNyPodcast.Size = new System.Drawing.Size(68, 19);
            this.btnNyPodcast.TabIndex = 29;
            this.btnNyPodcast.Text = "Ny...";
            this.btnNyPodcast.UseVisualStyleBackColor = true;
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Location = new System.Drawing.Point(324, 207);
            this.lblKategori.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(49, 13);
            this.lblKategori.TabIndex = 28;
            this.lblKategori.Text = "Kategori:";
            // 
            // lvPodcasts
            // 
            this.lvPodcasts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Namn,
            this.Kategori,
            this.Avsnitt,
            this.Frekvens});
            this.lvPodcasts.HideSelection = false;
            this.lvPodcasts.Location = new System.Drawing.Point(55, 8);
            this.lvPodcasts.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lvPodcasts.Name = "lvPodcasts";
            this.lvPodcasts.Size = new System.Drawing.Size(365, 190);
            this.lvPodcasts.TabIndex = 22;
            this.lvPodcasts.UseCompatibleStateImageBehavior = false;
            this.lvPodcasts.View = System.Windows.Forms.View.Details;
            this.lvPodcasts.SelectedIndexChanged += new System.EventHandler(this.lvPodcasts_SelectedIndexChanged);
            // 
            // PodcastForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbKategorier);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTabortKategori);
            this.Controls.Add(this.btnSparaKategori);
            this.Controls.Add(this.btnNyKategori);
            this.Controls.Add(this.tbKategori);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbBeskrivning);
            this.Controls.Add(this.lvAvsnitt);
            this.Controls.Add(this.btnTabortPodcast);
            this.Controls.Add(this.btnSparaPodcast);
            this.Controls.Add(this.lblUFrekvens);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.cbKategori);
            this.Controls.Add(this.cbUpdFreq);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.btnNyPodcast);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.lvPodcasts);
            this.Name = "PodcastForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbKategorier;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTabortKategori;
        private System.Windows.Forms.Button btnSparaKategori;
        private System.Windows.Forms.Button btnNyKategori;
        private System.Windows.Forms.TextBox tbKategori;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.RichTextBox rtbBeskrivning;
        private System.Windows.Forms.ListView lvAvsnitt;
        private System.Windows.Forms.Button btnTabortPodcast;
        private System.Windows.Forms.Button btnSparaPodcast;
        private System.Windows.Forms.Label lblUFrekvens;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.ComboBox cbKategori;
        private System.Windows.Forms.ComboBox cbUpdFreq;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.ColumnHeader Frekvens;
        private System.Windows.Forms.ColumnHeader Avsnitt;
        private System.Windows.Forms.ColumnHeader Kategori;
        private System.Windows.Forms.ColumnHeader Namn;
        private System.Windows.Forms.Button btnNyPodcast;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.ListView lvPodcasts;
    }
}