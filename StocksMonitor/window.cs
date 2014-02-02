using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DownloadData;
using SymbolList;

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
            ab.Show();
        }

        private static List<String> column = new List<string>() {"Stock Name","Price"};
        private static string[] comboBoxItem = SymbolList.SymbolList.readItemNames(@"SymbolList\");

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
            column.ForEach(name => stock_listView.Columns.Add(name));
            log_richTextBox.Text = DateTime.Now.ToString() + " Welcome to StocksMonitor.";

            //initial exchange_comboBox
            exchange_comboBox.Items.Clear();
            foreach (string fname in comboBoxItem) {
                exchange_comboBox.Items.Add(fname);
            }
            exchange_comboBox.SelectedIndex = 0;

            //set auto complete in stock_textBox
            this.setAutocomplete(ref this.stock_textBox, this.exchange_comboBox.Text);

        }

        private void exchangeChanged(object sender, EventArgs e) {
            this.setAutocomplete(ref this.stock_textBox, this.exchange_comboBox.Text);
        }
    }
}
