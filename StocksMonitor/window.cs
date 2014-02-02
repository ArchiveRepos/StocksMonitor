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

        private void window_Load(object sender, EventArgs e) {
            stock_listView.Columns.Add("try");
            column.ForEach(name => stock_listView.Columns.Add(name));
        }
    }
}
