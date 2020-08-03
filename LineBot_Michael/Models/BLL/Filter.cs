using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace LineBot_Michael.Models.BLL
{
    public static class Filter
    {
        private static string[] Month = { "1", "3", "5", "7", "9", "11" };

        public static string getInvoice()
        {
            string lastMonth = DateTime.Now.AddMonths(-1).Month.ToString();
            string MatchMonth = "";
            bool flag = false;
            for (int i = 0; i < Month.Length; i++)
            {
                if(Month[i] == lastMonth)
                {
                    flag = true;
                    MatchMonth = Month[i-1];
                    break;
                }
            }

            if (flag)
            {
                string Url = "https://www.etax.nat.gov.tw/etw-main/web/ETW183W2_1080" + MatchMonth +"/"; //3,4月範例
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
                //聲明一個HttpWebRequest請求
                request.Timeout = 30000;
                //設置連接逾時時間
                request.Headers.Set("Pragma", "no-cache");
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream streamReceive = response.GetResponseStream();
                StreamReader sr = new StreamReader(streamReceive, Encoding.UTF8);
                string htmlStr = sr.ReadToEnd();
                var Matches = Regex.Matches(htmlStr, @"(?<=number)(.*?)(?=<\/td)");
                string specialPrize = GetNumber(Matches[0].Value);
                string grandPrize = GetNumber(Matches[1].Value);
                string firstPrize = GetNumber(Matches[2].Value);
                string addSixPrize = GetNumber(Matches[3].Value);
                return "特別獎: " + specialPrize + "\r\n" + "特獎: " + grandPrize + "\r\n" + "頭獎: " + firstPrize + "\r\n" + "增開六獎: " + addSixPrize;
            }
            else
            {
                return "現在還不是兌獎月哦~";
            }
        }

        private static string GetNumber(string str)
        {
            string Str="";
            var Matches = Regex.Matches(str, @"\d+");
            for (int i = 0; i < Matches.Count; i++)
            {
                Str += Matches[i] + ",";
            }
            return Str;
        }
    }
}