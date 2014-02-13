using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Web;

namespace StocksMonitor {
    class YQL_connector {

        private static string baseurl_YQL = "http://query.yahooapis.com/v1/public/yql?";
 
        public YQL_connector() {
        }

        private StringBuilder prefix_YQL(string tables, string condition, string column = "*") {
            StringBuilder YQL = new StringBuilder();
            string sql_like = "select " + column + " from " + tables + " where " + condition;
            YQL.Append(baseurl_YQL);
            YQL.Append("q=" + System.Web.HttpUtility.UrlPathEncode(sql_like+"\n"));
            return YQL;
        }

        public string getYQL_url(string tables, string condition, string column = "*", string format = "json", string diagonstics = "false") {
            StringBuilder YQL = prefix_YQL(tables, condition, column);
            YQL.Append(@"&env=store://datatables.org/alltableswithkeys"); //without this parameter will get bad request error.
            YQL.Append("&format="+format);
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
