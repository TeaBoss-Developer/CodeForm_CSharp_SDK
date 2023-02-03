using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using SDK;
using SDK.Events;
using SDK.Interface;
using SDK.Model;

namespace MsTool
{
    public class RecGroupMsg : IGroupMessage
    {
        public void ReceviceGroupMsg(GroupMessageEvent e)
        {
            if (e.SenderQQ == 1000032 || e.ThisQQ == e.SenderQQ)//不处理匿名信息和自己
            {
                return;
            }
            if (e.MessageContent.Equals("群签到"))
            {
                Common.xlzAPI.GroupSigninEvent(e.ThisQQ, e.MessageGroupQQ);
            }
            if (e.MessageContent.Equals("群打卡"))
            {
                Common.xlzAPI.GroupTurnOn(e.ThisQQ, e.MessageGroupQQ);
            }
            if (e.MessageContent.Equals("群送礼"))
            {
                Common.xlzAPI.SendFreeGiftEvent(e.ThisQQ, e.MessageGroupQQ,2674931578,SDK.Enum.FreeGiftEnum.Gift_285);
            }
            if (e.MessageContent.Equals("取群应用列表"))
            {
                Common.xlzAPI.GetGroupApps_(e.ThisQQ, e.MessageGroupQQ);
            }
            if (e.MessageContent.Equals("查收款"))
            {
                PendingPayerinfo p = new PendingPayerinfo() { QQ = 1403875823, Amount = 2 };
                List<PendingPayerinfo> pp = new List<PendingPayerinfo>() { p};
                string ordernum = "5021052104147250481442793577";
                Common.xlzAPI.SelectGroupCollectionStatus_(e.ThisQQ, ordernum);
            }
            if (e.MessageContent.Equals("文本解析"))
            {
                XLZTextCodecnalysis xLZText = Common.xlzAPI.TextCodeAnalysis_();
                EarrayList[] earrayLists = new EarrayList[1];
            }
            if (e.MessageContent.Contains("翻译"))
            {
                string result = string.Empty;
                string ret = Common.xlzAPI.Translate_(e.ThisQQ, "zh", "en", e.MessageContent.Substring("翻译".Length), ref result);
                Common.xlzAPI.SendGroupMessage(e.ThisQQ, e.MessageGroupQQ, result);
            }
            if (e.MessageContent.Contains("文字转语音"))
            {
                byte[] result = new byte[1024 * 100];
                string ret = Common.xlzAPI.Text2speech_(e.ThisQQ, e.MessageContent, ref result);
                string audioret = Common.xlzAPI.UploadGroupAudio(e.ThisQQ, e.MessageGroupQQ, SDK.Enum.AudioTypeEnum.Normal, "", result);
                Common.xlzAPI.SendGroupMessage(e.ThisQQ, e.MessageGroupQQ, audioret);
            }
        }
    }
}
