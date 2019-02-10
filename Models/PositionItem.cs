using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Globalization;

namespace sp_bmexportal.Models
{
	public partial class PositionItem
	{
		[JsonProperty("account")]
		public long Account { get; set; }

		[JsonProperty("symbol")]
		public string Symbol { get; set; }

		[JsonProperty("currency")]
		public string Currency { get; set; }

		[JsonProperty("underlying")]
		public string Underlying { get; set; }

		[JsonProperty("quoteCurrency")]
		public string QuoteCurrency { get; set; }

		[JsonProperty("commission")]
		public long Commission { get; set; }

		[JsonProperty("initMarginReq")]
		public long InitMarginReq { get; set; }

		[JsonProperty("maintMarginReq")]
		public long MaintMarginReq { get; set; }

		[JsonProperty("riskLimit")]
		public long RiskLimit { get; set; }

		[JsonProperty("leverage")]
		public long Leverage { get; set; }

		[JsonProperty("crossMargin")]
		public bool CrossMargin { get; set; }

		[JsonProperty("deleveragePercentile")]
		public long DeleveragePercentile { get; set; }

		[JsonProperty("rebalancedPnl")]
		public long RebalancedPnl { get; set; }

		[JsonProperty("prevRealisedPnl")]
		public long PrevRealisedPnl { get; set; }

		[JsonProperty("prevUnrealisedPnl")]
		public long PrevUnrealisedPnl { get; set; }

		[JsonProperty("prevClosePrice")]
		public long PrevClosePrice { get; set; }

		[JsonProperty("openingTimestamp")]
		public DateTimeOffset OpeningTimestamp { get; set; }

		[JsonProperty("openingQty")]
		public long OpeningQty { get; set; }

		[JsonProperty("openingCost")]
		public long OpeningCost { get; set; }

		[JsonProperty("openingComm")]
		public long OpeningComm { get; set; }

		[JsonProperty("openOrderBuyQty")]
		public long OpenOrderBuyQty { get; set; }

		[JsonProperty("openOrderBuyCost")]
		public long OpenOrderBuyCost { get; set; }

		[JsonProperty("openOrderBuyPremium")]
		public long OpenOrderBuyPremium { get; set; }

		[JsonProperty("openOrderSellQty")]
		public long OpenOrderSellQty { get; set; }

		[JsonProperty("openOrderSellCost")]
		public long OpenOrderSellCost { get; set; }

		[JsonProperty("openOrderSellPremium")]
		public long OpenOrderSellPremium { get; set; }

		[JsonProperty("execBuyQty")]
		public long ExecBuyQty { get; set; }

		[JsonProperty("execBuyCost")]
		public long ExecBuyCost { get; set; }

		[JsonProperty("execSellQty")]
		public long ExecSellQty { get; set; }

		[JsonProperty("execSellCost")]
		public long ExecSellCost { get; set; }

		[JsonProperty("execQty")]
		public long ExecQty { get; set; }

		[JsonProperty("execCost")]
		public long ExecCost { get; set; }

		[JsonProperty("execComm")]
		public long ExecComm { get; set; }

		[JsonProperty("currentTimestamp")]
		public DateTimeOffset CurrentTimestamp { get; set; }

		[JsonProperty("currentQty")]
		public long CurrentQty { get; set; }

		[JsonProperty("currentCost")]
		public long CurrentCost { get; set; }

		[JsonProperty("currentComm")]
		public long CurrentComm { get; set; }

		[JsonProperty("realisedCost")]
		public long RealisedCost { get; set; }

		[JsonProperty("unrealisedCost")]
		public long UnrealisedCost { get; set; }

		[JsonProperty("grossOpenCost")]
		public long GrossOpenCost { get; set; }

		[JsonProperty("grossOpenPremium")]
		public long GrossOpenPremium { get; set; }

		[JsonProperty("grossExecCost")]
		public long GrossExecCost { get; set; }

		[JsonProperty("isOpen")]
		public bool IsOpen { get; set; }

		[JsonProperty("markPrice")]
		public long MarkPrice { get; set; }

		[JsonProperty("markValue")]
		public long MarkValue { get; set; }

		[JsonProperty("riskValue")]
		public long RiskValue { get; set; }

		[JsonProperty("homeNotional")]
		public long HomeNotional { get; set; }

		[JsonProperty("foreignNotional")]
		public long ForeignNotional { get; set; }

		[JsonProperty("posState")]
		public string PosState { get; set; }

		[JsonProperty("posCost")]
		public long PosCost { get; set; }

		[JsonProperty("posCost2")]
		public long PosCost2 { get; set; }

		[JsonProperty("posCross")]
		public long PosCross { get; set; }

		[JsonProperty("posInit")]
		public long PosInit { get; set; }

		[JsonProperty("posComm")]
		public long PosComm { get; set; }

		[JsonProperty("posLoss")]
		public long PosLoss { get; set; }

		[JsonProperty("posMargin")]
		public long PosMargin { get; set; }

		[JsonProperty("posMaint")]
		public long PosMaint { get; set; }

		[JsonProperty("posAllowance")]
		public long PosAllowance { get; set; }

		[JsonProperty("taxableMargin")]
		public long TaxableMargin { get; set; }

		[JsonProperty("initMargin")]
		public long InitMargin { get; set; }

		[JsonProperty("maintMargin")]
		public long MaintMargin { get; set; }

		[JsonProperty("sessionMargin")]
		public long SessionMargin { get; set; }

		[JsonProperty("targetExcessMargin")]
		public long TargetExcessMargin { get; set; }

		[JsonProperty("varMargin")]
		public long VarMargin { get; set; }

		[JsonProperty("realisedGrossPnl")]
		public long RealisedGrossPnl { get; set; }

		[JsonProperty("realisedTax")]
		public long RealisedTax { get; set; }

		[JsonProperty("realisedPnl")]
		public long RealisedPnl { get; set; }

		[JsonProperty("unrealisedGrossPnl")]
		public long UnrealisedGrossPnl { get; set; }

		[JsonProperty("longBankrupt")]
		public long LongBankrupt { get; set; }

		[JsonProperty("shortBankrupt")]
		public long ShortBankrupt { get; set; }

		[JsonProperty("taxBase")]
		public long TaxBase { get; set; }

		[JsonProperty("indicativeTaxRate")]
		public long IndicativeTaxRate { get; set; }

		[JsonProperty("indicativeTax")]
		public long IndicativeTax { get; set; }

		[JsonProperty("unrealisedTax")]
		public long UnrealisedTax { get; set; }

		[JsonProperty("unrealisedPnl")]
		public long UnrealisedPnl { get; set; }

		[JsonProperty("unrealisedPnlPcnt")]
		public long UnrealisedPnlPcnt { get; set; }

		[JsonProperty("unrealisedRoePcnt")]
		public long UnrealisedRoePcnt { get; set; }

		[JsonProperty("simpleQty")]
		public long SimpleQty { get; set; }

		[JsonProperty("simpleCost")]
		public long SimpleCost { get; set; }

		[JsonProperty("simpleValue")]
		public long SimpleValue { get; set; }

		[JsonProperty("simplePnl")]
		public long SimplePnl { get; set; }

		[JsonProperty("simplePnlPcnt")]
		public long SimplePnlPcnt { get; set; }

		[JsonProperty("avgCostPrice")]
		public long AvgCostPrice { get; set; }

		[JsonProperty("avgEntryPrice")]
		public long AvgEntryPrice { get; set; }

		[JsonProperty("breakEvenPrice")]
		public long BreakEvenPrice { get; set; }

		[JsonProperty("marginCallPrice")]
		public long MarginCallPrice { get; set; }

		[JsonProperty("liquidationPrice")]
		public long LiquidationPrice { get; set; }

		[JsonProperty("bankruptPrice")]
		public long BankruptPrice { get; set; }

		[JsonProperty("timestamp")]
		public DateTimeOffset Timestamp { get; set; }

		[JsonProperty("lastPrice")]
		public long LastPrice { get; set; }

		[JsonProperty("lastValue")]
		public long LastValue { get; set; }
	}

	public partial class PositionItem
	{
		public static PositionItem[] FromJson(string json) => JsonConvert.DeserializeObject<PositionItem[]>(json, sp_bmexportal.Models.Converter.Settings);
	}

	public static class Serialize
	{
		public static string ToJson(this PositionItem[] self) => JsonConvert.SerializeObject(self, sp_bmexportal.Models.Converter.Settings);
	}

	internal static class Converter
	{
		public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
		{
			MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
			DateParseHandling = DateParseHandling.None,
			Converters =
			{
				new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
			},
		};
	}

}

