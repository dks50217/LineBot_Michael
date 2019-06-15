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
            string ChannelAccessToken = "UG8Tmeddm7pnamwfyg3Gk/jmAdu4XfJPcGfR5LZLDgc90v+VOGgBvMPu/5vMGeJ6zcF72IjqbuFsUCPy6X2PcWOloS20338leBBXbTve8O2GlG6N1VL6u9M4JSCgImZX6bU4QU4dDvTrfofX/ANcjgdB04t89/1O/w1cDnyilFU=";
            try
            {
                //取得 http Post RawData(should be JSON)
                string postData = Request.Content.ReadAsStringAsync().Result;
                //剖析JSON
                var ReceivedMessage = isRock.LineBot.Utility.Parsing(postData);
                //回覆訊息
                string Message;
                Message = "你說了:" + ReceivedMessage.events[0].message.text;
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
