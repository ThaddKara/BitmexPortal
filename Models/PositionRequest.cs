namespace sp_bmexportal.Services
{
	public class PositionRequest
	{
		[JsonProperty("symbol")]
		public string Symbol { get; set; }

		[JsonProperty("side")]
		public string Side { get; set; }

		[JsonProperty("orderQty")]
		public int OrderQty { get; set; }

		[JsonProperty("ordType")]
		public string OrderType { get; set; }
	}
}