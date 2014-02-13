namespace StocksMonitor
{
    partial class window_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(window_Form));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exchange_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.remove_rules = new System.Windows.Forms.Button();
            this.add_rules = new System.Windows.Forms.Button();
            this.rules_listView = new System.Windows.Forms.ListView();
            this.Add_to_Watch = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.stock_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.log_richTextBox = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.status = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.internet_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.Watcher_GridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Watcher_GridView)).BeginInit();
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
            this.exchange_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.exchange_comboBox.FormattingEnabled = true;
            this.exchange_comboBox.Location = new System.Drawing.Point(68, 4);
            this.exchange_comboBox.Name = "exchange_comboBox";
            this.exchange_comboBox.Size = new System.Drawing.Size(119, 21);
            this.exchange_comboBox.TabIndex = 1;
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
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.Add_to_Watch);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(13, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 367);
            this.panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.remove_rules);
            this.groupBox1.Controls.Add(this.add_rules);
            this.groupBox1.Controls.Add(this.rules_listView);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 268);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Watch Rules";
            // 
            // remove_rules
            // 
            this.remove_rules.BackgroundImage = global::StocksMonitor.Properties.Resources.minus;
            this.remove_rules.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.remove_rules.Location = new System.Drawing.Point(154, 13);
            this.remove_rules.Name = "remove_rules";
            this.remove_rules.Size = new System.Drawing.Size(27, 23);
            this.remove_rules.TabIndex = 1;
            this.remove_rules.UseVisualStyleBackColor = true;
            this.remove_rules.Click += new System.EventHandler(this.remove_rules_Click);
            // 
            // add_rules
            // 
            this.add_rules.BackgroundImage = global::StocksMonitor.Properties.Resources.Plus;
            this.add_rules.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.add_rules.Location = new System.Drawing.Point(122, 13);
            this.add_rules.Name = "add_rules";
            this.add_rules.Size = new System.Drawing.Size(27, 23);
            this.add_rules.TabIndex = 1;
            this.add_rules.UseVisualStyleBackColor = true;
            this.add_rules.Click += new System.EventHandler(this.add_rules_Click);
            // 
            // rules_listView
            // 
            this.rules_listView.FullRowSelect = true;
            this.rules_listView.Location = new System.Drawing.Point(6, 42);
            this.rules_listView.Name = "rules_listView";
            this.rules_listView.Size = new System.Drawing.Size(180, 226);
            this.rules_listView.TabIndex = 0;
            this.rules_listView.UseCompatibleStateImageBehavior = false;
            this.rules_listView.View = System.Windows.Forms.View.Details;
            // 
            // Add_to_Watch
            // 
            this.Add_to_Watch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Add_to_Watch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_to_Watch.Location = new System.Drawing.Point(0, 344);
            this.Add_to_Watch.Name = "Add_to_Watch";
            this.Add_to_Watch.Size = new System.Drawing.Size(204, 23);
            this.Add_to_Watch.TabIndex = 2;
            this.Add_to_Watch.Text = "Add to Watch";
            this.Add_to_Watch.UseVisualStyleBackColor = true;
            this.Add_to_Watch.Click += new System.EventHandler(this.Add_to_Watch_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.stock_textBox);
            this.panel3.Controls.Add(this.exchange_comboBox);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(6, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(192, 59);
            this.panel3.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stock";
            // 
            // stock_textBox
            // 
            this.stock_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock_textBox.Location = new System.Drawing.Point(45, 31);
            this.stock_textBox.Name = "stock_textBox";
            this.stock_textBox.Size = new System.Drawing.Size(143, 22);
            this.stock_textBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
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
            this.log_richTextBox.TabStop = false;
            this.log_richTextBox.Text = "";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Watcher_GridView);
            this.panel2.Controls.Add(this.log_richTextBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(220, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(540, 368);
            this.panel2.TabIndex = 7;
            // 
            // status
            // 
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.internet_status});
            this.status.Location = new System.Drawing.Point(0, 396);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(770, 22);
            this.status.SizingGrip = false;
            this.status.Stretch = false;
            this.status.TabIndex = 8;
            this.status.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(653, 17);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(86, 17);
            this.toolStripStatusLabel2.Text = "Internet Status:";
            // 
            // internet_status
            // 
            this.internet_status.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.internet_status.Image = global::StocksMonitor.Properties.Resources.grey;
            this.internet_status.Name = "internet_status";
            this.internet_status.Size = new System.Drawing.Size(16, 17);
            this.internet_status.ToolTipText = "Check if this program can properly connect to the Internet";
            // 
            // Watcher_GridView
            // 
            this.Watcher_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Watcher_GridView.Location = new System.Drawing.Point(4, 4);
            this.Watcher_GridView.Name = "Watcher_GridView";
            this.Watcher_GridView.ReadOnly = true;
            this.Watcher_GridView.Size = new System.Drawing.Size(531, 258);
            this.Watcher_GridView.TabIndex = 6;
            // 
            // window_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 418);
            this.Controls.Add(this.status);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "window_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stocks Monitor";
            this.Load += new System.EventHandler(this.window_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Watcher_GridView)).EndInit();
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Add_to_Watch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button add_rules;
        private System.Windows.Forms.ListView rules_listView;
        private System.Windows.Forms.Button remove_rules;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel internet_status;
        private System.Windows.Forms.DataGridView Watcher_GridView;
    }
}

