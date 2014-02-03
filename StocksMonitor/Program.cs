using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StocksMonitor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new window());
        }
    }

    class Watcher {
        private string stock_name;
        private Rules rule_set;
    }

    class Rules {
        public static string[] items = { "BidRealtime", "AskRealtime" }; //should be key words in YQL results
        public static string[] items_short = { "Bid", "Ask" }; //short words for showing on screan, should have the same amount as above one.
        public static string[] creteria = { "Greater", "Equal", "Less" };
        public static string[] creteria_short = { ">", "=", "<" };

        public static string long2short(string[] l, string[] s, string c) {
            return s[string2ID(l, c)];
        }

        public static string short2long(string[] l, string[] s, string c) {
            return l[string2ID(s, c)];
        }

        private List<string> rules;

        public Rules() {
            //some initialization
            rules = null;
        }

        private static int string2ID(string[] list, string input) {
            int i = 0;
            for (i = 0; i < list.Length; i++)
                if (list[i].Equals(input))
                    break;
            return i;
        }

        private static string ID2string(string[] list, int id) {
            return list[id];
        }

        public void addRule(string it, string cr, string va) {
            rules.Add(string2ID(items, it).ToString() + " " + string2ID(creteria, cr).ToString() + " " + va);
        }
  
        public override string ToString(){
            string output = "";
            foreach (string r in rules) {
                string[] rs = r.Split(' ');
                output+=(ID2string(items,Convert.ToInt32(rs[0]))+ " is "+ID2string(creteria,Convert.ToInt32(rs[1])) + " than " + rs[2]);
            }
            return output;
        }

        public string ToString(int i) {
            if (rules.Count > i) {
                string[] rs = rules[i].Split(' ');
                return ID2string(items, Convert.ToInt32(rs[0])) + " is " + ID2string(creteria, Convert.ToInt32(rs[1])) + " than " + rs[2];
            } else
                return null;            
        }

    }
}
