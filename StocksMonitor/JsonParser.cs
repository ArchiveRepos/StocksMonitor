using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json.Linq;

namespace StocksMonitor {
    class JsonParser {
        //map words into YQL keywords
        private static Dictionary<string, string> name2Json = new Dictionary<string,string>();
        public static void generateDictionary(string[] l, string[] s) { //set this to forms initialization (window.Form.window_Load())
            if (l.Length != s.Length)
                return;
            else {
                for (int i = 0; i < l.Length; i++)
                    name2Json.Add(s[i], l[i]);
            }
        }

        private JArray jsonArray;

        private JsonParser(){
            if (name2Json.Count == 0)
                throw new System.Data.DataException("Please make sure call JsonParser.generateDictionary(string, string) first.");
        }

        public JsonParser(string json):this() {
            parser_YQLstock(json);
        }

        private void parser_YQLstock(string json) {
            JObject dataObject = JObject.Parse(json);
            jsonArray = (JArray)dataObject["query"]["results"]["quote"]; //suitable for yahoo.finance.quotes
        }
        
        

        
    }
}
