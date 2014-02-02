﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SymbolList;

namespace DownloadData
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {

            SymbolList.SymbolList sl = new SymbolList.SymbolList("NASDAQ");

            this.urlTextBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.urlTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            collection.AddRange(sl.getlist());

            this.urlTextBox.AutoCompleteCustomSource = collection;


        }

        private static bool changeUrl_clicked = false; // when changeUrl_clicked equal false means the default.

        private void changeUrl_Click(object sender, EventArgs e) {
            if (!changeUrl_clicked) {
                this.urlTextBox.Enabled = true;
                this.changeUrl.Text = "Save";
                changeUrl_clicked = true;
            } else {
                this.urlTextBox.Enabled = false;
                this.changeUrl.Text = "Change URL";
                changeUrl_clicked = false;
            }
        }

        private void download_Click(object sender, EventArgs e) {
            string url = urlTextBox.Text + "?s=";
            string[] split = stockSymbols.Text.Split(new Char[] { ' ', ',', ':', '\t', '+', '\n' });
            for (int i = 0; i < split.Length; i++) {
                url += (split[i]+'+');
            }
            url += ("&f="+specialTags.Text);

            System.Diagnostics.Process.Start(url);
        }
    }
}
