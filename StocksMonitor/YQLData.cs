using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using Newtonsoft.Json;

namespace StocksMonitor {
    public class YQLData {
        // A method which get from code project: http://www.codeproject.com/Tips/397574/Use-Csharp-to-get-JSON-Data-from-the-Web-and-Map-i
        // Download Json and deserialize it
        public static T _download_serialized_json_data<T>(string url) where T : new() {
            using (var w = new WebClient()) {
                var json_data = string.Empty;
                // attempt to download JSON data as a string
                try {
                    json_data = w.DownloadString(url);
                } catch (Exception e) { throw e; }
                // if string with JSON data is not empty, deserialize it to class and return its instance 
                return !string.IsNullOrEmpty(json_data) ? JsonConvert.DeserializeObject<T>(json_data) : new T();
            }
        }
    }

    // clean the object variables which may cause the "object reference not set to an instance of object"
     public class Quote {
        [JsonProperty("symbol")]
        public string symbol { get; set; }
        [JsonProperty("Ask")]
        public string Ask { get; set; }
        [JsonProperty("AverageDailyVolume")]
        public string AverageDailyVolume { get; set; }
        [JsonProperty("Bid")]
        public string Bid { get; set; }
        [JsonProperty("AskRealtime")]
        public string AskRealtime { get; set; }
        [JsonProperty("BidRealtime")]
        public string BidRealtime { get; set; }
        [JsonProperty("BookValue")]
        public string BookValue { get; set; }
        [JsonProperty("Change_PercentChange")]
        public string Change_PercentChange { get; set; }
        [JsonProperty("Change")]
        public string Change { get; set; }
        [JsonProperty("ChangeRealtime")]
        public string ChangeRealtime { get; set; }
        [JsonProperty("AfterHoursChangeRealtime")]
        public string AfterHoursChangeRealtime { get; set; }
        [JsonProperty("DividendShare")]
        public string DividendShare { get; set; }
        [JsonProperty("LastTradeDate")]
        public string LastTradeDate { get; set; }
        [JsonProperty("EarningsShare")]
        public string EarningsShare { get; set; }
        [JsonProperty("EPSEstimateCurrentYear")]
        public string EPSEstimateCurrentYear { get; set; }
        [JsonProperty("EPSEstimateNextYear")]
        public string EPSEstimateNextYear { get; set; }
        [JsonProperty("EPSEstimateNextQuarter")]
        public string EPSEstimateNextQuarter { get; set; }
        [JsonProperty("DaysLow")]
        public string DaysLow { get; set; }
        [JsonProperty("DaysHigh")]
        public string DaysHigh { get; set; }
        [JsonProperty("YearLow")]
        public string YearLow { get; set; }
        [JsonProperty("YearHigh")]
        public string YearHigh { get; set; }
        [JsonProperty("HoldingsGainPercent")]
        public string HoldingsGainPercent { get; set; }
        [JsonProperty("HoldingsGainPercentRealtime")]
        public string HoldingsGainPercentRealtime { get; set; }
        [JsonProperty("MoreInfo")]
        public string MoreInfo { get; set; }
        [JsonProperty("MarketCapitalization")]
        public string MarketCapitalization { get; set; }
        [JsonProperty("EBITDA")]
        public string EBITDA { get; set; }
        [JsonProperty("ChangeFromYearLow")]
        public string ChangeFromYearLow { get; set; }
        [JsonProperty("PercentChangeFromYearLow")]
        public string PercentChangeFromYearLow { get; set; }
        [JsonProperty("LastTradeRealtimeWithTime")]
        public string LastTradeRealtimeWithTime { get; set; }
        [JsonProperty("ChangePercentRealtime")]
        public string ChangePercentRealtime { get; set; }
        [JsonProperty("ChangeFromYearHigh")]
        public string ChangeFromYearHigh { get; set; }
        [JsonProperty("PercebtChangeFromYearHigh")]
        public string PercebtChangeFromYearHigh { get; set; }
        [JsonProperty("LastTradeWithTime")]
        public string LastTradeWithTime { get; set; }
        [JsonProperty("LastTradePriceOnly")]
        public string LastTradePriceOnly { get; set; }
        [JsonProperty("DaysRange")]
        public string DaysRange { get; set; }
        [JsonProperty("DaysRangeRealtime")]
        public string DaysRangeRealtime { get; set; }
        [JsonProperty("FiftydayMovingAverage")]
        public string FiftydayMovingAverage { get; set; }
        [JsonProperty("TwoHundreddayMovingAverage")]
        public string TwoHundreddayMovingAverage { get; set; }
        [JsonProperty("ChangeFromTwoHundreddayMovingAverage")]
        public string ChangeFromTwoHundreddayMovingAverage { get; set; }
        [JsonProperty("PercentChangeFromTwoHundreddayMovingAverage")]
        public string PercentChangeFromTwoHundreddayMovingAverage { get; set; }
        [JsonProperty("ChangeFromFiftydayMovingAverage")]
        public string ChangeFromFiftydayMovingAverage { get; set; }
        [JsonProperty("PercentChangeFromFiftydayMovingAverage")]
        public string PercentChangeFromFiftydayMovingAverage { get; set; }
        [JsonProperty("Name")]
        public string Name { get; set; }
        [JsonProperty("Open")]
        public string Open { get; set; }
        [JsonProperty("PreviousClose")]
        public string PreviousClose { get; set; }
        [JsonProperty("ChangeinPercent")]
        public string ChangeinPercent { get; set; }
        [JsonProperty("PriceSales")]
        public string PriceSales { get; set; }
        [JsonProperty("PriceBook")]
        public string PriceBook { get; set; }
        [JsonProperty("ExDividendDate")]
        public string ExDividendDate { get; set; }
        [JsonProperty("PERatio")]
        public string PERatio { get; set; }
        [JsonProperty("DividendPayDate")]
        public string DividendPayDate { get; set; }
        [JsonProperty("PEGRatio")]
        public string PEGRatio { get; set; }
        [JsonProperty("PriceEPSEstimateCurrentYear")]
        public string PriceEPSEstimateCurrentYear { get; set; }
        [JsonProperty("PriceEPSEstimateNextYear")]
        public string PriceEPSEstimateNextYear { get; set; }
        [JsonProperty("Symbol")]
        public string Symbol { get; set; }
        [JsonProperty("ShortRatio")]
        public string ShortRatio { get; set; }
        [JsonProperty("LastTradeTime")]
        public string LastTradeTime { get; set; }
        [JsonProperty("TickerTrend")]
        public string TickerTrend { get; set; }
        [JsonProperty("OneyrTargetPrice")]
        public string OneyrTargetPrice { get; set; }
        [JsonProperty("Volume")]
        public string Volume { get; set; }
        [JsonProperty("YearRange")]
        public string YearRange { get; set; }
        [JsonProperty("DaysValueChange")]
        public string DaysValueChange { get; set; }
        [JsonProperty("DaysValueChangeRealtime")]
        public string DaysValueChangeRealtime { get; set; }
        [JsonProperty("StockExchange")]
        public string StockExchange { get; set; }
        [JsonProperty("DividendYield")]
        public string DividendYield { get; set; }
        [JsonProperty("PercentChange")]
        public string PercentChange { get; set; }
    }

     //Generated from sepcial paste from Json data (in VS2013) 
    public class Rootobject{
       public Query query { get; set; }
    }

    public class Query{
        public int count { get; set; }
        public DateTime created { get; set; }
        public string lang { get; set; }
        public Results results { get; set; }
    }

    public class Results{
      public Quote quote { get; set; }
    }

    /* backup for orginal Quote
    public class Quote {
        [JsonProperty("symbol")]
        public string symbol { get; set; }
        [JsonProperty("Ask")]
        public string Ask { get; set; }
        [JsonProperty("AverageDailyVolume")]
        public string AverageDailyVolume { get; set; }
        [JsonProperty("Bid")]
        public string Bid { get; set; }
        [JsonProperty("AskRealtime")]
        public string AskRealtime { get; set; }
        [JsonProperty("BidRealtime")]
        public string BidRealtime { get; set; }
        [JsonProperty("BookValue")]
        public string BookValue { get; set; }
        [JsonProperty("Change_PercentChange")]
        public string Change_PercentChange { get; set; }
        [JsonProperty("Change")]
        public string Change { get; set; }
        [JsonProperty("Commission")]
        public object Commission { get; set; }
        [JsonProperty("ChangeRealtime")]
        public string ChangeRealtime { get; set; }
        [JsonProperty("AfterHoursChangeRealtime")]
        public string AfterHoursChangeRealtime { get; set; }
        [JsonProperty("DividendShare")]
        public string DividendShare { get; set; }
        [JsonProperty("LastTradeDate")]
        public string LastTradeDate { get; set; }
        [JsonProperty("TradeDate")]
        public object TradeDate { get; set; }
        [JsonProperty("EarningsShare")]
        public string EarningsShare { get; set; }
        [JsonProperty("ErrorIndicationreturnedforsymbolchangedinvalid")]
        public object ErrorIndicationreturnedforsymbolchangedinvalid { get; set; }
        [JsonProperty("EPSEstimateCurrentYear")]
        public string EPSEstimateCurrentYear { get; set; }
        [JsonProperty("EPSEstimateNextYear")]
        public string EPSEstimateNextYear { get; set; }
        [JsonProperty("EPSEstimateNextQuarter")]
        public string EPSEstimateNextQuarter { get; set; }
        [JsonProperty("DaysLow")]
        public string DaysLow { get; set; }
        [JsonProperty("DaysHigh")]
        public string DaysHigh { get; set; }
        [JsonProperty("YearLow")]
        public string YearLow { get; set; }
        [JsonProperty("YearHigh")]
        public string YearHigh { get; set; }
        [JsonProperty("HoldingsGainPercent")]
        public string HoldingsGainPercent { get; set; }
        [JsonProperty("AnnualizedGain")]
        public object AnnualizedGain { get; set; }
        [JsonProperty("HoldingsGain")]
        public object HoldingsGain { get; set; }
        [JsonProperty("HoldingsGainPercentRealtime")]
        public string HoldingsGainPercentRealtime { get; set; }
        [JsonProperty("HoldingsGainRealtime")]
        public object HoldingsGainRealtime { get; set; }
        [JsonProperty("MoreInfo")]
        public string MoreInfo { get; set; }
        [JsonProperty("OrderBookRealtime")]
        public object OrderBookRealtime { get; set; }
        [JsonProperty("MarketCapitalization")]
        public string MarketCapitalization { get; set; }
        [JsonProperty("MarketCapRealtime")]
        public object MarketCapRealtime { get; set; }
        [JsonProperty("EBITDA")]
        public string EBITDA { get; set; }
        [JsonProperty("ChangeFromYearLow")]
        public string ChangeFromYearLow { get; set; }
        [JsonProperty("PercentChangeFromYearLow")]
        public string PercentChangeFromYearLow { get; set; }
        [JsonProperty("LastTradeRealtimeWithTime")]
        public string LastTradeRealtimeWithTime { get; set; }
        [JsonProperty("ChangePercentRealtime")]
        public string ChangePercentRealtime { get; set; }
        [JsonProperty("ChangeFromYearHigh")]
        public string ChangeFromYearHigh { get; set; }
        [JsonProperty("PercebtChangeFromYearHigh")]
        public string PercebtChangeFromYearHigh { get; set; }
        [JsonProperty("LastTradeWithTime")]
        public string LastTradeWithTime { get; set; }
        [JsonProperty("LastTradePriceOnly")]
        public string LastTradePriceOnly { get; set; }
        [JsonProperty("HighLimit")]
        public object HighLimit { get; set; }
        [JsonProperty("LowLimit")]
        public object LowLimit { get; set; }
        [JsonProperty("DaysRange")]
        public string DaysRange { get; set; }
        [JsonProperty("DaysRangeRealtime")]
        public string DaysRangeRealtime { get; set; }
        [JsonProperty("FiftydayMovingAverage")]
        public string FiftydayMovingAverage { get; set; }
        [JsonProperty("TwoHundreddayMovingAverage")]
        public string TwoHundreddayMovingAverage { get; set; }
        [JsonProperty("ChangeFromTwoHundreddayMovingAverage")]
        public string ChangeFromTwoHundreddayMovingAverage { get; set; }
        [JsonProperty("PercentChangeFromTwoHundreddayMovingAverage")]
        public string PercentChangeFromTwoHundreddayMovingAverage { get; set; }
        [JsonProperty("ChangeFromFiftydayMovingAverage")]
        public string ChangeFromFiftydayMovingAverage { get; set; }
        [JsonProperty("PercentChangeFromFiftydayMovingAverage")]
        public string PercentChangeFromFiftydayMovingAverage { get; set; }
        [JsonProperty("Name")]
        public string Name { get; set; }
        [JsonProperty("Notes")]
        public object Notes { get; set; }
        [JsonProperty("Open")]
        public string Open { get; set; }
        [JsonProperty("PreviousClose")]
        public string PreviousClose { get; set; }
        [JsonProperty("PricePaid")]
        public object PricePaid { get; set; }
        [JsonProperty("ChangeinPercent")]
        public string ChangeinPercent { get; set; }
        [JsonProperty("PriceSales")]
        public string PriceSales { get; set; }
        [JsonProperty("PriceBook")]
        public string PriceBook { get; set; }
        [JsonProperty("ExDividendDate")]
        public string ExDividendDate { get; set; }
        [JsonProperty("PERatio")]
        public string PERatio { get; set; }
        [JsonProperty("DividendPayDate")]
        public string DividendPayDate { get; set; }
        [JsonProperty("PERatioRealtime")]
        public object PERatioRealtime { get; set; }
        [JsonProperty("PEGRatio")]
        public string PEGRatio { get; set; }
        [JsonProperty("PriceEPSEstimateCurrentYear")]
        public string PriceEPSEstimateCurrentYear { get; set; }
        [JsonProperty("PriceEPSEstimateNextYear")]
        public string PriceEPSEstimateNextYear { get; set; }
        [JsonProperty("Symbol")]
        public string Symbol { get; set; }
        [JsonProperty("SharesOwned")]
        public object SharesOwned { get; set; }
        [JsonProperty("ShortRatio")]
        public string ShortRatio { get; set; }
        [JsonProperty("LastTradeTime")]
        public string LastTradeTime { get; set; }
        [JsonProperty("TickerTrend")]
        public string TickerTrend { get; set; }
        [JsonProperty("OneyrTargetPrice")]
        public string OneyrTargetPrice { get; set; }
        [JsonProperty("Volume")]
        public string Volume { get; set; }
        [JsonProperty("HoldingsValue")]
        public object HoldingsValue { get; set; }
        [JsonProperty("HoldingsValueRealtime")]
        public object HoldingsValueRealtime { get; set; }
        [JsonProperty("YearRange")]
        public string YearRange { get; set; }
        [JsonProperty("DaysValueChange")]
        public string DaysValueChange { get; set; }
        [JsonProperty("DaysValueChangeRealtime")]
        public string DaysValueChangeRealtime { get; set; }
        [JsonProperty("StockExchange")]
        public string StockExchange { get; set; }
        [JsonProperty("DividendYield")]
        public string DividendYield { get; set; }
        [JsonProperty("PercentChange")]
        public string PercentChange { get; set; }
    } */
}
