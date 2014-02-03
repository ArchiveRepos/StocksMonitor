using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//added namespaces
using DownloadData;
using SymbolList;
using System.Net;

namespace StocksMonitor
{
    public partial class window : Form
    {
        public window()
        {
            InitializeComponent();
        }

        private void downloadDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dialogue d = new Dialogue();
            d.show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            AboutBox ab = new AboutBox();
            ab.ShowDialog();
        }

        private static List<String> column_watcher = new List<string>() {"Stock Name","Price"};
        private static List<String> column_rules = new List<string>() { "Item", " ", "Value" };
        private static string[] comboBoxItem = SymbolList.SymbolList.readItemNames(@"SymbolList\");

        //check if connect to the Interenet
        public static bool IsConnectedToInternet {
            get {
                try {
                    HttpWebRequest hwebRequest = (HttpWebRequest)WebRequest.Create("http://www.google.com"); //may not work in China mainland
                    hwebRequest.Timeout = 10000;
                    HttpWebResponse hWebResponse = (HttpWebResponse)hwebRequest.GetResponse();
                    if (hWebResponse.StatusCode == HttpStatusCode.OK) {
                        return true;
                    } else return false;
                } catch { return false; }
            }
        }

        private void setAutocomplete(ref TextBox tb, string filename) {
            SymbolList.SymbolList sl = new SymbolList.SymbolList(filename);
            tb.AutoCompleteMode = AutoCompleteMode.Suggest;
            tb.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            collection.AddRange(sl.getlist());
            tb.AutoCompleteCustomSource = collection;
        }

        private void window_Load(object sender, EventArgs e) {
            //initial process for main form
            column_watcher.ForEach(name => stock_listView.Columns.Add(name));
            column_rules.ForEach(name => rules_listView.Columns.Add(name));
            log_richTextBox.Text = DateTime.Now.ToString() + " Welcome to StocksMonitor.";

            //initial exchange_comboBox
            exchange_comboBox.Items.Clear();
            foreach (string fname in comboBoxItem) {
                exchange_comboBox.Items.Add(fname);
            }
            exchange_comboBox.SelectedIndex = 0;

            //set auto complete in stock_textBox
            this.setAutocomplete(ref this.stock_textBox, this.exchange_comboBox.Text);

            //check internet connectivity
            if (IsConnectedToInternet) {
                this.internet_status.Image = Properties.Resources.green;
            } else {
                this.internet_status.Image = Properties.Resources.red;
                log_richTextBox.Text = "Internet Status: Not Connected.\n" + log_richTextBox.Text;
            }

        }

        private void exchangeChanged(object sender, EventArgs e) {
            this.setAutocomplete(ref this.stock_textBox, this.exchange_comboBox.Text);
        }

        private void remove_rules_Click(object sender, EventArgs e) {
            foreach (ListViewItem eachItem in this.rules_listView.SelectedItems) {
                this.rules_listView.Items.Remove(eachItem);
            }
        }

        private bool compare_listViewItems(ListViewItem first, ListViewItem second) {
            if (first == null && second == null) {
                return true;
            } else if ((first == null && second != null) || (first != null && second == null)) {
                return false;
            } else if (first.SubItems.Count!=second.SubItems.Count) {
                return false;
            } else {
                for (int i = 0; i < first.SubItems.Count; i++) {
                    if (!first.SubItems[i].Text.Equals(second.SubItems[i].Text))
                        return false;
                }
                return true;
            }
        }

        private void blinking_listViewItem(ref ListViewItem it, int R, int G, int B, int times = 10) {
            if ((R > 255 || R < 0) || (G > 255 || G < 0) || (B > 255 || B < 0)) {
                throw new System.Exception("Parameter not within range");
            }

            int step_R = (255-R)/times;
            int step_G = (255-G)/times;
            int step_B = (255-B)/times;

            Color origin = it.BackColor;

            for (int i = 0; i < times; i++) {
                it.BackColor = Color.FromArgb(R + step_R * i, G + step_G * i, B + step_R * i);
                System.Threading.Thread.Sleep(20);
            }

            it.BackColor = origin;
        }

        private void add_rules_Click(object sender, EventArgs e) {
            WatchRules wr = new WatchRules();
            wr.ShowDialog();
            if (wr.DialogResult == DialogResult.OK) {
               ListViewItem it = new ListViewItem(new[] { Rules.long2short(Rules.items, Rules.items_short, wr.item), Rules.long2short(Rules.creteria, Rules.creteria_short, wr.creteria), wr.value });
               for (int i =0; i< rules_listView.Items.Count; i++) {
                    if (this.compare_listViewItems(rules_listView.Items[i],it)) {
                        //this.blinking_listViewItem(ref rules_listView.Items[i], 255, 165, 0);
                        Color origin = rules_listView.Items[i].BackColor;
                        rules_listView.Items[i].BackColor = Color.FromKnownColor(KnownColor.Khaki);
                        System.Threading.Thread.Sleep(500);
                        rules_listView.Items[i].BackColor = origin;
                        return;
                    }
                }
               this.rules_listView.Items.Add(it);
            }

        }
    }
}
