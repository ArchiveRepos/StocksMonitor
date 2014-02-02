namespace DownloadData
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.changeUrl = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.stockSymbols = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.specialTags = new System.Windows.Forms.RichTextBox();
            this.download = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(385, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.download);
            this.panel1.Controls.Add(this.specialTags);
            this.panel1.Controls.Add(this.stockSymbols);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.changeUrl);
            this.panel1.Controls.Add(this.urlTextBox);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 357);
            this.panel1.TabIndex = 1;
            // 
            // urlTextBox
            // 
            this.urlTextBox.Enabled = false;
            this.urlTextBox.Location = new System.Drawing.Point(3, 14);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(252, 20);
            this.urlTextBox.TabIndex = 0;
            this.urlTextBox.Text = "http://finance.yahoo.com/d/quotes.csv";
            // 
            // changeUrl
            // 
            this.changeUrl.Location = new System.Drawing.Point(261, 12);
            this.changeUrl.Name = "changeUrl";
            this.changeUrl.Size = new System.Drawing.Size(91, 23);
            this.changeUrl.TabIndex = 1;
            this.changeUrl.Text = "Change URL";
            this.changeUrl.UseVisualStyleBackColor = true;
            this.changeUrl.Click += new System.EventHandler(this.changeUrl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Stocks\' symbols: ";
            // 
            // stockSymbols
            // 
            this.stockSymbols.Location = new System.Drawing.Point(3, 66);
            this.stockSymbols.Name = "stockSymbols";
            this.stockSymbols.Size = new System.Drawing.Size(349, 152);
            this.stockSymbols.TabIndex = 3;
            this.stockSymbols.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Special tags:";
            // 
            // specialTags
            // 
            this.specialTags.Location = new System.Drawing.Point(3, 253);
            this.specialTags.Name = "specialTags";
            this.specialTags.Size = new System.Drawing.Size(349, 59);
            this.specialTags.TabIndex = 3;
            this.specialTags.Text = "";
            // 
            // download
            // 
            this.download.Location = new System.Drawing.Point(3, 318);
            this.download.Name = "download";
            this.download.Size = new System.Drawing.Size(349, 27);
            this.download.TabIndex = 4;
            this.download.Text = "Download";
            this.download.UseVisualStyleBackColor = true;
            this.download.Click += new System.EventHandler(this.download_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 397);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Download Data";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Button changeUrl;
        private System.Windows.Forms.Button download;
        private System.Windows.Forms.RichTextBox specialTags;
        private System.Windows.Forms.RichTextBox stockSymbols;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}