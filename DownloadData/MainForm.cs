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

            this.testBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.testBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            collection.AddRange(sl.getlist());

            this.testBox.AutoCompleteCustomSource = collection;


        }
    }
}
