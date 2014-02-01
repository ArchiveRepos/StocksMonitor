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
    }
}
