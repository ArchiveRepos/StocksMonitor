using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Web;
using Newtonsoft.Json.Linq;

namespace StocksMonitor {
    class YQL_connector {

        private static string url_YQL = "http://query.yahooapis.com/v1/public/yql?";
 
        public YQL_connector() {
        }

        private StringBuilder prefix_YQL(string tables, string condition, string column = "*") {
            StringBuilder YQL = new StringBuilder();
            string sql_like = "SELECT " + column + " FROM " + tables + " WHERE " + condition;
            YQL.Append(url_YQL);
            YQL.Append("q=" + System.Web.HttpUtility.UrlEncode(sql_like));
            return YQL;
        }

        public string getYQL_XML(string tables, string condition, string column="*", string diagonstics = "false" ) {
            StringBuilder YQL = prefix_YQL(tables, condition, column);
            YQL.Append("&format=xml");
            YQL.Append("&diagnostics="+diagonstics);
            return YQL.ToString();
        }
        public string getYQL_Json(string tables, string condition, string column = "*", string diagonstics = "false") {
            StringBuilder YQL = prefix_YQL(tables, condition, column);
            YQL.Append("&format=json");
            YQL.Append("&diagnostics=" + diagonstics);
            return YQL.ToString();
        }


    }

    class YQL_stock_connector : YQL_connector {
        //map words into YQL keywords
        private static Dictionary<string, string> name2YQL = null;
        public static void generateDictionary(string[] l, string[] s) {
            if (l.Length != s.Length)
                return;
            else {
                for (int i = 0; i < l.Length; i++)
                    name2YQL.Add(s[i], l[i]);
            }
        }

        public YQL_stock_connector() : base() {
            if (name2YQL.Count == 0)
                throw new System.Data.DataException("Please make sure call generateDictionary(string, string) first.");
        }
    }
}
