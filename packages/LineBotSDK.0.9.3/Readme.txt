===============================================================
LineBot SDK for .NET (Line Messaging API, Line Login, Line Notify, Liff App supported)
This is an .net version SDK for LINE/LINE Bot developers 
Minimum supported version  is .NET 4.5.1
===============================================================
Example of Usage:
https://github.com/isdaviddong/LineBotSdkExample
https://github.com/isdaviddong/Line_Login_Example
https://github.com/isdaviddong/Line_Notify_Example
https://github.com/isdaviddong/Linebot-Demo-CopyCat
https://github.com/isdaviddong/Linebot-Demo-AccountBook

LINE Bot Example - Personal accounting
https://github.com/isdaviddong/Linebot-Demo-AccountBook
LINE Bot Example - Face Recognition
https://github.com/isdaviddong/Linebot-Demo-FaceRecognition

How to use (Chinese):
http://studyhost.blogspot.tw/search/label/LineBot

Supported:
> Push and Reply Messages
> text, image, sticker, template messages, ... etc.
> Group / Chat Room Talk
> LineWebHookControllerBase
> LineNotify, LineLogin
> Flex Message
> Liff App
> QuickReply

===================== Easy to use ==================
Push Message : 
isRock.LineBot.Utility.PushMessage (user id, text message, AccessToken);

Parsing Receieved Message (Parsing received JSON):
var ReceivedMessage = isRock.LineBot.Utility.Parsing (postData);

Reply Message  
isRock.LineBot.Utility.ReplyMessage (ReplyToken, text message, AccessToken);

=================================================== 
History:
2018/5/7		0.7.1	support Get Content/User Info  in WebHook BaseController
2018/5/16	0.7.2	Add MS QnA Macker Helper
2018/5/27	0.7.3	update MS QnA Macker  Helper For GA
2018/8/24    0.7.6	Add Issue short-live Channel Access Token  API support
								Add Liff Server API Support
2018/9/13	0.7.8	Fix QnA Maker call for GA version
2018/9/15	0.8.0	QuickReply supported
2018/10/4	0.8.3	fix QnA Services bug
2018/10/31	0.8.4    support Tempalte Message in MessageBase
2018/11/16  0.8.5	    udpate models for Member Join/Leave Events
								ref: https://developers.line.me/en/news/2018/11/15/
2018/12/16	0.8.52  Bug Fix
2019/01/21	0.8.6	Bug Fix

中文說明:
================================================
LineBot SDK for .NET (Line@ Messaging API supported)
這是用來開發LineBot的.net  SDK
最低.net版本支援為 .net 4.5.1
================================================

使用範例:
https://github.com/isdaviddong/LineBotSdkExample

如何使用請參考套件公開說明書:
http://studyhost.blogspot.tw/search/label/LineBot

簡易使用說明:
Push Message(主動發訊息給用戶):
isRock.LineBot.Utility.PushMessage(用戶id, 文字訊息, AccessToken);

Parsing Receieved Message(Parsing 收到的JSON): 
var ReceivedMessage = isRock.LineBot.Utility.Parsing(postData);

Reply Message(回覆用戶的訊息):
isRock.LineBot.Utility.ReplyMessage(ReplyToken, 文字訊息, AccessToken);

==================================================
C# Examples:

LINE Bot 範例 - 小P記帳
https://github.com/isdaviddong/Linebot-Demo-AccountBook

LINE Bot 範例 - 人臉辨識
https://github.com/isdaviddong/Linebot-Demo-FaceRecognition

LineBotSdk範例，包含純文字訊息、貼圖、圖片發送
https://github.com/isdaviddong/LineBotSdkExample

Line_Notify_Example
https://github.com/isdaviddong/Line_Notify_Example

Line_Login_Example
https://github.com/isdaviddong/Line_Login_Example

展示如何建立一個可以接收檔案的Line WebHook 
https://github.com/isdaviddong/LineExample_WebHookGetPicture

Carousel Template Example
https://github.com/isdaviddong/LinePushCarouselTemplateExample

Line bot 連續對談機制:
https://github.com/isdaviddong/LinebotConversationExample

Line bot 群組對談範例程式碼:
https://github.com/isdaviddong/LinebotInTheGroup

