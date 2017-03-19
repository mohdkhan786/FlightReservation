using Microsoft.Bot.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservation.Flight.BusinessLogic
{
    public class Common
    {
        public static async Task<APIResponse> DisplayBotMessage(Activity activity, string strMessage)
        {
            bool messageTyped = false;
            try
            {
                ConnectorClient connector = new ConnectorClient(new Uri(activity.ServiceUrl));

                // return our reply to the user
                Activity reply = activity.CreateReply($"{strMessage}");
                if (!messageTyped)
                {
                    messageTyped = true;
                    return await connector.Conversations.ReplyToActivityAsync(reply);
                }
                else
                    return null;

            }
            catch (Exception ex)
            {
                return null;
            }

        }
    }
}