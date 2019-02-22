using System;
using System.Collections.Generic;

namespace sp_bmexportal.Services
{
    class ChatService : IChatService
    {
        BitMEXApi bitMEXApi = new BitMEXApi(sp_bmexportal.Models.Credentials.ApiKey, sp_bmexportal.Models.Credentials.ApiSecret);

        string GetMessages(sp_bmexportal.Models.ChatReader chatReader)
        {
            bitMEXApi.GetChatMessages(chatReader.cha)
        }
    }
}