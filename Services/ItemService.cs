using System.Collections.Generic;

namespace sp_bmexportal.Services
{
    public class ItemService : IItemService
    {
		private readonly BitMEXApi BitMEXApi = new BitMEXApi(sp_bmexportal.Models.Credentials.ApiKey, 
															 sp_bmexportal.Models.Credentials.ApiSecret);
		/*
		private readonly Dictionary<string, int> ApiItemStorage = new Dictionary<string, int>
		{
			{"message", 1 },
			{"test", 2 }
		};*/


		public object GetPosition(PositionRequest itemModel)
		{
			var response = BitMEXApi.GetPosition(itemModel.Contract);
			return response;
		}

		public void GetItems()
		{
		}
    }
}