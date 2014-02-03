using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json.Linq;

namespace StocksMonitor {
    class JsonParser {
        //map words into YQL keywords
        private static Dictionary<string, string> name2Json = null;
        public static void generateDictionary(string[] l, string[] s) {
            if (l.Length != s.Length)
                return;
            else {
                for (int i = 0; i < l.Length; i++)
                    name2Json.Add(s[i], l[i]);
            }
        }

        public JsonParser(){
            if (name2Json.Count == 0)
                throw new System.Data.DataException("Please make sure call JsonParser.generateDictionary(string, string) first.");
        }

        public static JArray parser_YQLstock(string json) {
            JObject dataObject = JObject.Parse(json);
            JArray jsonArray = (JArray)dataObject["query"]["results"]["quote"]; //suitable for yahoo.finance.quotes
            return jsonArray;
        }
    }
}
