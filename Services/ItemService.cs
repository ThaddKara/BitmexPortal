using System.Collections.Generic;
using sp_bmexportal.Models;

namespace sp_bmexportal.Services
{
    public class ItemService : IItemService
    {
        private readonly BitMEXApi BitMEXApi = new BitMEXApi(sp_bmexportal.Models.Credentials.ApiKey, sp_bmexportal.Models.Credentials.ApiSecret);


        public object GetPosition(PositionRequest itemModel)
        {
            var response = BitMEXApi.GetPosition(itemModel.Contract);
            return response;
        }

        public void SendOrderRequest(sp_bmexportal.Models.PositionRequest positionRequest)
        {
						BitMEXApi.PostOrder(PositionRequest.s)
        }
    }
}