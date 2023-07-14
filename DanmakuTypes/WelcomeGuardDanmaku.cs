using BilibiliDM_PluginFramework;

namespace BilibiliDmExtendedPluginFramework.DanmakuTypes
{
    [DanmakuType(MsgTypeEnum.WelcomeGuard)]
    public class WelcomeGuardDanmaku : Danmaku
    {
        public WelcomeGuardDanmaku(DanmakuModel danmakuModel) : base(danmakuModel)
        {
        }
        
    }
}