using BilibiliDM_PluginFramework;

namespace BilibiliDmExtendedPluginFramework.Utils
{
    public static class DanmakuUtils
    {
        public static bool HasUserBasicInfo(DanmakuModel model)
        {
            var msgType = model.MsgType;
            return msgType == MsgTypeEnum.Comment ||
                   msgType == MsgTypeEnum.Interact ||
                   msgType == MsgTypeEnum.GiftSend ||
                   msgType == MsgTypeEnum.GuardBuy ||
                   msgType == MsgTypeEnum.Welcome ||
                   msgType == MsgTypeEnum.WelcomeGuard;
        }
        
        public static bool HasUserAdminInfo(DanmakuModel model)
        {
            var msgType = model.MsgType;
            return msgType == MsgTypeEnum.Comment ||
                   msgType == MsgTypeEnum.GiftSend;
        }
        
        public static bool HasUserVipInfo(DanmakuModel model)
        {
            var msgType = model.MsgType;
            return msgType == MsgTypeEnum.Comment ||
                   msgType == MsgTypeEnum.Welcome;
        }
        
        public static bool HasUserGuardInfo(DanmakuModel model)
        {
            var msgType = model.MsgType;
            return msgType == MsgTypeEnum.Comment ||
                   msgType == MsgTypeEnum.WelcomeGuard ||
                   msgType == MsgTypeEnum.GuardBuy;
        }
    }
}