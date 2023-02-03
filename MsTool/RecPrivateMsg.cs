using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using SDK;
using SDK.Events;
using SDK.Interface;

namespace MsTool
{
    public class RecPrivateMsg : IRecvicetPrivateMessage
    {
        public void RecvicetPrivateMsg(PrivateMessageEvent e)
        {
            if (e.MessageContent.Equals("取钱包"))
            {
                Common.xlzAPI.GetQQWalletPersonalInformationEvent(e.ThisQQ);
            }
            if (e.MessageContent.Equals("删成员"))
            {
                Common.xlzAPI.DelGroupMemberByBatch(e.ThisQQ, 480325208, new List<long>() { 2403875843, 2261002716 }, false);
            }
            if (e.MessageContent.Equals("简略"))
            {
                Common.xlzAPI.GetGroupMemberBriefInfoEvent(e.ThisQQ, 480325208);
            }
            string picpath = System.Environment.CurrentDirectory + "\\logo.png";
            if (e.MessageContent.Equals("发图"))
            {
                Common.xlzAPI.SendFriendImage(e.ThisQQ, e.SenderQQ, picpath, false);
            }
        }  
    }
}
