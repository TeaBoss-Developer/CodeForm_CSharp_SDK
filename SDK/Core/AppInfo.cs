﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SDK.Core
{
    public class AppInfo
    {
        /// <summary>
        /// SDK版本
        /// </summary>
        public string sdkv = "";
        /// <summary>
        /// 应用名
        /// </summary>
        public string appname = "";
        /// <summary>
        /// 应用作者
        /// </summary>
        public string author = "";
        /// <summary>
        /// 应用说明
        /// </summary>
        public string describe = string.Concat(new string[] 
        { 
            "这是一个测试插件"
        });
        /// <summary>
        /// 应用版本
        /// </summary>
        public string appv = "1.0.0";
        //public long groupmsaddres
        /// <summary>
        /// 群消息处理函数
        /// </summary>
        public long groupmsaddres { get; set; }
        /// <summary>
        /// 私聊消息处理函数
        /// </summary>
        public long friendmsaddres { get; set; }
        /// <summary>
        /// 事件消息处理函数
        /// </summary>
        public long eventmsaddres { get; set; }
        /// <summary>
        /// 将被卸载处理函数
        /// </summary>
        public long unitproaddres { get; set; }
        /// <summary>
        /// 点击插件设置处理函数
        /// </summary>
        public long setproaddres { get; set; }
        /// <summary>
        /// 插件被启用处理函数
        /// </summary>
        public long useproaddres { get; set; }
        /// <summary>
        /// 插件被禁用处理函数
        /// </summary>
        public long banproaddres { get; set; }
        //public List<Needapilist> needapilist { get; set; }
        /// <summary>
        /// 置短信验证码处理函数
        /// </summary>
        public long getvefcodeaddres { get; set; }
        /// <summary>
        /// 置滑块处理函
        /// </summary>
        public long getticketaddres { get; set; }
        /// <summary>
        /// 短信验证
        /// </summary>
        public long SMSVerification { get; set; }
        /// <summary>
        /// 滑块验证
        /// </summary>
        public long SliderR { get; set; }

        public string Info(AppInfo appInfo)
        {
            //AppInfo appInfo = new AppInfo();
            return Newtonsoft.Json.JsonConvert.SerializeObject(appInfo);
        }

        public string SetPermission(int permissionNum, string desc,string json)
        {
            string outjson = string.Empty;
            string a = $"API[{permissionNum}]";
            if (PermissionConstant.PermiCon.ContainsKey($"API[{permissionNum}]"))
            {
                JObject jObject = JsonConvert.DeserializeObject<JObject>(json);
                string name = PermissionConstant.PermiCon[$"API[{permissionNum}]"];
                string check = "修改指定QQ缓存密码|获取bkn_gtk|sessionkey|cookie|QQ点赞|获取clientkey|获取pskey|获取skey|解散群|删除好友|退群|置屏蔽好友|修改个性签名|修改昵称|上传头像|框架重启|取QQ钱包个人信息|更改群聊消息内容|更改私聊消息内容|下线指定QQ|登录指定QQ";
                JObject jObject0 = new JObject();
                JObject jObject1 = new JObject();
                if (check.Contains(name))
                {
                    //jObject["data.needapilist." + name + ".state"] = "1";
                    //jObject["data.needapilist." + name + ".safe"] = "1";
                    jObject1["state"] = "0";
                    jObject1["safe"] = "0";
                }
                else
                {
                    //jObject["data.needapilist." + name + ".state"] = "0";
                    //jObject["data.needapilist." + name + ".safe"] = "0";
                    jObject1["state"] = "1";
                    jObject1["safe"] = "1";
                }
                //jObject["data.needapilist." + name + ".desc"] = desc;
                jObject1["desc"] = desc;
                jObject0[name] = jObject1;
                if (jObject["data"] == null)
                {
                    jObject["data"] = new JObject();
                }
                if (jObject["data"]["needapilist"] == null)
                {
                    jObject["data"]["needapilist"] = jObject0;
                }
                else
                {
                    jObject["data"]["needapilist"][name] = jObject1;
                }

                outjson = JsonConvert.SerializeObject(jObject);
            }
            else
            {
                outjson = "设置权限出错，请检查PermissionConstant.CS 与AppRun.SetProperty()中的权限一一对应";
            }
            return outjson ;
        } 
    }

    public class Needapilist
    {
        public string state { get; set; }
        public string safe { get; set; }
        public string desc { get; set; }

    }

}
