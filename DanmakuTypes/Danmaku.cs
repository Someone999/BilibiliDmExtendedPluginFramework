using BilibiliDM_PluginFramework;
using BilibiliDmExtendedPluginFramework.Users;
using BilibiliDmExtendedPluginFramework.Utils;
using HsManCommonLibrary.ValueHolders;

namespace BilibiliDmExtendedPluginFramework.DanmakuTypes
{
    public abstract class Danmaku
    {
        public DanmakuModel OriginalDanmaku { get; }
        protected Danmaku(DanmakuModel danmakuModel)
        {
            OriginalDanmaku = danmakuModel;
            MessageType = danmakuModel.MsgType;
            if (DanmakuUtils.HasUserBasicInfo(danmakuModel))
            {
                SendUser = new ValueHolder<User>(new User()
                {
                    UserId = danmakuModel.UserID_long,
                    UserName = danmakuModel.UserName,
                });
            }

            if (!SendUser.IsInitialized())
            {
                return;
            }

            if (DanmakuUtils.HasUserAdminInfo(danmakuModel))
            {
                SendUser.Value.IsAdmin.BindValue(danmakuModel.isAdmin);
            }
            
            if (DanmakuUtils.HasUserVipInfo(danmakuModel))
            {
                SendUser.Value.IsVip.BindValue(danmakuModel.isVIP);
            }
            
            if (DanmakuUtils.HasUserGuardInfo(danmakuModel))
            {
                SendUser.Value.GuardLevel.BindValue((UserGuardLevel)danmakuModel.UserGuardLevel);
            }

        }
        public ValueHolder<User> SendUser { get; } = new ValueHolder<User>();
        public MsgTypeEnum MessageType { get; }
    }
}