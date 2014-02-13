using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SymbolList;
using System.Net;

namespace DownloadData
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            //initial components in Main form
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
            if (split.Length == 0 || specialTags.Text.Trim().Length == 0) {
                MessageBox.Show("Not enough information.");
                return;
            }
            for (int i = 0; i < split.Length; i++) {
                url += (split[i]+'+');
            }
            url += ("&f="+specialTags.Text.Trim().ToLower());

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Convert.ToString(Environment.SpecialFolder.MyDocuments);
            saveFileDialog1.Filter = "Comma-separated values (*.CSV)|*.csv|All Files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                WebClient cl = new WebClient();
                Uri u = new Uri(url);
                cl.DownloadFileAsync(u, saveFileDialog1.FileName);
            } 

            //System.Diagnostics.Process.Start(url);
        }
    }
}
