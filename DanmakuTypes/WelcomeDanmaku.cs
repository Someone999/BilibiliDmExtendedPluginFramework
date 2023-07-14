using BilibiliDM_PluginFramework;

namespace BilibiliDmExtendedPluginFramework.DanmakuTypes
{
    [DanmakuType(MsgTypeEnum.Welcome)]
    public class WelcomeDanmaku : Danmaku
    {
        public WelcomeDanmaku(DanmakuModel danmakuModel) : base(danmakuModel)
        {
        }
        
    }
}