namespace StocksMonitor
{
    partial class window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(window));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exchange_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.stock_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.log_richTextBox = new System.Windows.Forms.RichTextBox();
            this.stock_listView = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(770, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolToolStripMenuItem
            // 
            this.toolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downloadDataToolStripMenuItem});
            this.toolToolStripMenuItem.Name = "toolToolStripMenuItem";
            this.toolToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.toolToolStripMenuItem.Text = "Tool";
            // 
            // downloadDataToolStripMenuItem
            // 
            this.downloadDataToolStripMenuItem.Name = "downloadDataToolStripMenuItem";
            this.downloadDataToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.downloadDataToolStripMenuItem.Text = "Download Data";
            this.downloadDataToolStripMenuItem.Click += new System.EventHandler(this.downloadDataToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exchange_comboBox
            // 
            this.exchange_comboBox.FormattingEnabled = true;
            this.exchange_comboBox.Location = new System.Drawing.Point(77, 3);
            this.exchange_comboBox.Name = "exchange_comboBox";
            this.exchange_comboBox.Size = new System.Drawing.Size(121, 21);
            this.exchange_comboBox.TabIndex = 0;
            this.exchange_comboBox.SelectedIndexChanged += new System.EventHandler(this.exchangeChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Exchange";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.stock_textBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.exchange_comboBox);
            this.panel1.Location = new System.Drawing.Point(13, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 367);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stock";
            // 
            // stock_textBox
            // 
            this.stock_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock_textBox.Location = new System.Drawing.Point(51, 31);
            this.stock_textBox.Name = "stock_textBox";
            this.stock_textBox.Size = new System.Drawing.Size(147, 22);
            this.stock_textBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Log:";
            // 
            // log_richTextBox
            // 
            this.log_richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.log_richTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.log_richTextBox.Enabled = false;
            this.log_richTextBox.Location = new System.Drawing.Point(0, 289);
            this.log_richTextBox.Name = "log_richTextBox";
            this.log_richTextBox.Size = new System.Drawing.Size(538, 77);
            this.log_richTextBox.TabIndex = 5;
            this.log_richTextBox.Text = "";
            // 
            // stock_listView
            // 
            this.stock_listView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stock_listView.Dock = System.Windows.Forms.DockStyle.Top;
            this.stock_listView.Location = new System.Drawing.Point(0, 0);
            this.stock_listView.Name = "stock_listView";
            this.stock_listView.Size = new System.Drawing.Size(538, 255);
            this.stock_listView.TabIndex = 6;
            this.stock_listView.UseCompatibleStateImageBehavior = false;
            this.stock_listView.View = System.Windows.Forms.View.Details;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.stock_listView);
            this.panel2.Controls.Add(this.log_richTextBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(220, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(540, 368);
            this.panel2.TabIndex = 7;
            // 
            // window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 407);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stocks Monitor";
            this.Load += new System.EventHandler(this.window_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ComboBox exchange_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox stock_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox log_richTextBox;
        private System.Windows.Forms.ListView stock_listView;
        private System.Windows.Forms.Panel panel2;
    }
}

