using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Web;

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

        //make sure the interenet is availible before call this method.
        public static string excuteYQL(string YQL) {
            using (WebClient wc = new WebClient()) {
                return wc.DownloadString(YQL);
            }
        }

    }
}
