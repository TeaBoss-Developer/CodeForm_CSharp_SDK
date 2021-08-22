﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK.Enum
{
    // 事件类型
    public enum EventTypeEnum
    {
        // 好友事件_被好友删除
        /// <summary>
        /// 好友事件_被好友删除
        /// </summary>
        Friend_Removed = 100,
        // 好友事件_签名变更
        /// <summary>
        /// 好友事件_签名变更
        /// </summary>
        Friend_SignatureChanged = 101,
        // 好友事件_昵称改变
        /// <summary>
        /// 好友事件_昵称改变
        /// </summary>
        Friend_NameChanged = 102,
        // 好友事件_某人撤回事件
        /// <summary>
        /// 好友事件_某人撤回事件
        /// </summary>
        Friend_UserUndid = 103,
        // 好友事件_有新好友
        /// <summary>
        /// 好友事件_有新好友
        /// </summary>
        Friend_NewFriend = 104,
        // 好友事件_好友请求
        /// <summary>
        /// 好友事件_好友请求
        /// </summary>
        Friend_FriendRequest = 105,
        // 好友事件_对方同意了您的好友请求
        /// <summary>
        /// 好友事件_对方同意了您的好友请求
        /// </summary>
        Friend_FriendRequestAccepted = 106,
        // 好友事件_对方拒绝了您的好友请求
        /// <summary>
        /// 好友事件_对方拒绝了您的好友请求
        /// </summary>
        Friend_FriendRequestRefused = 107,
        // 好友事件_资料卡点赞
        /// <summary>
        /// 好友事件_资料卡点赞
        /// </summary>
        Friend_InformationLiked = 108,
        // 好友事件_签名点赞
        /// <summary>
        /// 好友事件_签名点赞
        /// </summary>
        Friend_SignatureLiked = 109,
        // 好友事件_签名回复
        /// <summary>
        /// 好友事件_签名回复
        /// </summary>
        Friend_SignatureReplied = 110,
        // 好友事件_个性标签点赞
        /// <summary>
        /// 好友事件_个性标签点赞
        /// </summary>
        Friend_TagLiked = 111,
        // 好友事件_随心贴回复
        /// <summary>
        /// 好友事件_随心贴回复
        /// </summary>
        Friend_StickerLiked = 112,
        // 好友事件_随心贴增添
        /// <summary>
        /// 好友事件_随心贴增添
        /// </summary>
        Friend_StickerAdded = 113,
        /// <summary>
        /// 好友事件_系统提示
        /// </summary>
        Friend_SystmHint = 114,
        /// <summary>
        /// 好友事件_随心贴点赞
        /// </summary>
        Friend_link = 115,
        /// <summary>
        /// 好友事件_匿名提问_被提问
        /// </summary>
        Friend_AnonymousQuestioned = 116,
        /// <summary>
        /// 好友事件_匿名提问_被点赞
        /// </summary>
        Friend_Anonymouslink = 117,
        /// <summary>
        /// 好友事件_匿名提问_被回复
        /// </summary>
        Friend_AnonymousResponded = 118,
        /// <summary>
        /// 好友事件_输入状态
        /// </summary>
        Friend_inputStatus = 119,



        // 群事件_我被邀请加入群
        /// <summary>
        /// 群事件_我被邀请加入群
        /// </summary>
        Group_Invited = 1,
        // 群事件_某人加入了群
        /// <summary>
        /// 群事件_某人加入了群
        /// </summary>
        Group_MemberJoined = 2,
        // 群事件_某人申请加群
        /// <summary>
        /// 群事件_某人申请加群
        /// </summary>
        Group_MemberVerifying = 3,
        // 群事件_群被解散
        /// <summary>
        /// 群事件_群被解散
        /// </summary>
        Group_GroupDissolved = 4,
        // 群事件_某人退出了群
        /// <summary>
        /// 群事件_某人退出了群
        /// </summary>
        Group_MemberQuit = 5,
        // 群事件_某人被踢出群
        /// <summary>
        /// 群事件_某人被踢出群
        /// </summary>
        Group_MemberKicked = 6,
        // 群事件_某人被禁言
        /// <summary>
        /// 群事件_某人被禁言
        /// </summary>
        Group_MemberShutUp = 7,
        // 群事件_某人撤回事件
        /// <summary>
        /// 群事件_某人撤回事件
        /// </summary>
        Group_MemberUndid = 8,
        // 群事件_某人被取消管理
        /// <summary>
        /// 群事件_某人被取消管理
        /// </summary>
        Group_AdministratorTook = 9,
        // 群事件_某人被赋予管理
        /// <summary>
        /// 群事件_某人被赋予管理
        /// </summary>
        Group_AdministratorGave = 10,
        // 群事件_开启全员禁言
        /// <summary>
        /// 群事件_开启全员禁言
        /// </summary>
        Group_EnableAllShutUp = 11,
        // 群事件_关闭全员禁言
        /// <summary>
        /// 群事件_关闭全员禁言
        /// </summary>
        Group_DisableAllShutUp = 12,
        // 群事件_开启匿名聊天
        /// <summary>
        /// 群事件_开启匿名聊天
        /// </summary>
        Group_EnableAnonymous = 13,
        // 群事件_关闭匿名聊天
        /// <summary>
        /// 群事件_关闭匿名聊天
        /// </summary>
        Group_DisableAnonymous = 14,
        // 群事件_开启坦白说
        /// <summary>
        /// 群事件_开启坦白说
        /// </summary>
        Group_EnableChatFrankly = 15,
        // 群事件_关闭坦白说
        /// <summary>
        /// 群事件_关闭坦白说
        /// </summary>
        Group_DisableChatFrankly = 16,
        // 群事件_允许群临时会话
        /// <summary>
        /// 群事件_允许群临时会话
        /// </summary>
        Group_AllowGroupTemporary = 17,
        // 群事件_禁止群临时会话
        /// <summary>
        /// 群事件_禁止群临时会话
        /// </summary>
        Group_ForbidGroupTemporary = 18,
        // 群事件_允许发起新的群聊
        /// <summary>
        /// 群事件_允许发起新的群聊
        /// </summary>
        Group_AllowCreateGroup = 19,
        // 群事件_禁止发起新的群聊
        /// <summary>
        /// 群事件_禁止发起新的群聊
        /// </summary>
        Group_ForbidCreateGroup = 20,
        // 群事件_允许上传群文件
        /// <summary>
        /// 群事件_允许上传群文件
        /// </summary>
        Group_AllowUploadFile = 21,
        // 群事件_禁止上传群文件
        /// <summary>
        /// 群事件_禁止上传群文件
        /// </summary>
        Group_ForbidUploadFile = 22,
        // 群事件_允许上传相册
        /// <summary>
        /// 群事件_允许上传相册
        /// </summary>
        Group_AllowUploadPicture = 23,
        // 群事件_禁止上传相册
        /// <summary>
        /// 群事件_禁止上传相册
        /// </summary>
        Group_ForbidUploadPicture = 24,
        // 群事件_某人被邀请入群
        /// <summary>
        /// 群事件_某人被邀请入群
        /// </summary>
        Group_MemberInvited = 25,
        // 群事件_展示成员群头衔
        /// <summary>
        /// 群事件_展示成员群头衔
        /// </summary>
        Group_ShowMemberTitle = 26,
        // 群事件_隐藏成员群头衔
        /// <summary>
        /// 群事件_隐藏成员群头衔
        /// </summary>
        Group_HideMemberTitle = 27,
        // 群事件_某人被解除禁言
        /// <summary>
        /// 群事件_某人被解除禁言
        /// </summary>
        Group_MemberNotShutUp = 28,
        // 空间事件_与我相关
        /// <summary>
        /// 空间事件_与我相关
        /// </summary>
        QZone_Related = 29,
        /// <summary>
        /// 群事件_我被踢出
        /// </summary>
        [Obsolete("3.5.2取消，可通过【群事件_某人被踢出群】来判断自己是否被踢出", false)]
        Group_MemberKickOut = 30,
        /// <summary>
        /// 群事件_群名变更
        /// </summary>
        Group_GroupNameUpdate = 32,
        /// <summary>
        /// 群事件_系统提示
        /// </summary>
        Group_SystmHint = 33,
        /// <summary>
        /// 群事件_群头像事件
        /// </summary>
        Group_Face = 34,
        /// <summary>
        /// 群事件_入场特效
        /// </summary>
        Group_AdmissionSpecialEffects = 35,
        /// <summary>
        /// 群事件_修改群名片
        /// </summary>
        Group_ModifyBusinessCard = 36,
        /// <summary>
        /// 群事件_群被转让
        /// </summary>
        Group_Transfer = 37,
        /// <summary>
        /// 群事件_匿名被禁言
        /// </summary>
        Group_AnonymityIsForbidden = 40,
        /// <summary>
        /// 群事件_匿名被解除禁言
        /// </summary>
        Group_AnonymityWsLifted = 41,
        /// <summary>
        /// 群事件_某人的加群申请被拒绝
        /// </summary>
        Group_JoinByRejected = 42,


        // 框架事件_登录成功
        /// <summary>
        /// 框架事件_登录成功
        /// </summary>
        This_SignInSuccess = 31,
        /// <summary>
        /// 框架事件_登录失败
        /// </summary>
        This_LoginFailed = 38,
        /// <summary>
        /// 框架事件_即将重启更新自身
        /// </summary>
        This_Reboot = 39,

        


        /// <summary>
        /// 登录事件_电脑上线
        /// </summary>
        login_pcOnline = 200,
        /// <summary>
        /// 登录事件_电脑下线
        /// </summary>
        login_pcOffline = 201,
        /// <summary>
        /// 登录事件_移动设备上线
        /// </summary>
        login_mobileOnline = 202,
        /// <summary>
        /// 登录事件_移动设备下线
        /// </summary>
        login_mobileOffline = 203,
        /// <summary>
        /// PCQQ登录验证请求
        /// </summary>
        login_PCVerification = 204,

        /// <summary>
        /// 讨论组事件_讨论组名变更
        /// </summary>
        Discussion_NameChange = 300,
        /// <summary>
        /// 讨论组事件_某人撤回事件
        /// </summary>
        Discussion_Withdraw = 301,
        /// <summary>
        /// 讨论组事件_某人被邀请入群
        /// </summary>
        Discussion_beInvited = 302,
        /// <summary>
        /// 讨论组事件_某人退出了群
        /// </summary>
        Discussion_Out = 303,
        /// <summary>
        /// 讨论组事件_某人被踢出群
        /// </summary>
        Discussion_KickedOut = 304,

    }
}
