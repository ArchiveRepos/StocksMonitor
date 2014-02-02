using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StocksMonitor {
    public partial class WatchRules : Form {
        public WatchRules() {
            InitializeComponent();
        }

        public string item { get { return item_comboBox.Text; } }
        public string creteria { get {return creteria_comboBox.Text;} }
        public string value { get {return value_textBox.Text;} }

        private void WatchRules_Load(object sender, EventArgs e) {
            //initial item_comboBox
            item_comboBox.Items.Clear();
            foreach (string fname in Rules.items) {
                item_comboBox.Items.Add(fname);
            }
            item_comboBox.SelectedIndex = 0;

            //initial creteria_comboBox
            creteria_comboBox.Items.Clear();
            foreach (string fname in Rules.creteria) {
                creteria_comboBox.Items.Add(fname);
            }
            creteria_comboBox.SelectedIndex = 0;
        }

        private void shakeWindow() {
            var original = this.Location;
            var rnd = new Random(1337);
            const int shake_amplitude = 10;
            for (int i = 0; i < 10; i++) {
                this.Location = new Point(original.X + rnd.Next(-shake_amplitude, shake_amplitude), original.Y + rnd.Next(-shake_amplitude, shake_amplitude));
                System.Threading.Thread.Sleep(20);
            }
            this.Location = original;
        }

        private void Add_Click(object sender, EventArgs e) {
            try {
                Convert.ToDouble(value_textBox.Text);
                this.DialogResult = DialogResult.OK;
                this.Close();
            } catch {
                this.value_textBox.BackColor = Color.FromKnownColor(KnownColor.Yellow) ;
                this.shakeWindow();
                return;
            }
        }

        new private void TextChanged(object sender, EventArgs e) {
            this.value_textBox.BackColor = Color.FromKnownColor(KnownColor.White);
        }
    }
}
