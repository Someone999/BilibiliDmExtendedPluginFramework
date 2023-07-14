using BilibiliDM_PluginFramework;

namespace BilibiliDmExtendedPluginFramework.DanmakuTypes
{
    [DanmakuType(MsgTypeEnum.WatchedChange)]
    public class WatchedChangeDanmaku : Danmaku
    {
        public WatchedChangeDanmaku(DanmakuModel danmakuModel) : base(danmakuModel)
        {
            WatchedCount = danmakuModel.WatchedCount;
        }
        
        public long WatchedCount { get; }
    }
}