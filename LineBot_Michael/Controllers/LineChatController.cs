using LineBot_Michael.Models.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LineBot_Michael.Controllers
{
    public class LineChatController : ApiController
    {
        [HttpPost]
        //[Route("api/linePost")]
        public IHttpActionResult POST()
        {
            //輸入自己的token
            string ChannelAccessToken = "";
            try
            {
                //取得 http Post RawData(should be JSON)
                string postData = Request.Content.ReadAsStringAsync().Result;
                //剖析JSON
                var ReceivedMessage = isRock.LineBot.Utility.Parsing(postData);
                //回覆訊息
                string Message;
                if(ReceivedMessage.events[0].message.text == "統一發票")
                {
                    Message = Filter.getInvoice();
                }
                else
                {
                    Message = "預設回傳回聲:" + ReceivedMessage.events[0].message.text;
                }
                //回覆用戶
                isRock.LineBot.Utility.ReplyMessage(ReceivedMessage.events[0].replyToken, Message, ChannelAccessToken);
                //回覆API OK
                return Ok();
            }
            catch (Exception ex)
            {
                return Ok();
            }
        }  
    }
}
