using BilibiliDM_PluginFramework;

namespace BilibiliDmExtendedPluginFramework.DanmakuTypes
{
    [DanmakuType(MsgTypeEnum.GuardBuy)]
    public class GuardBuyDanmaku : Danmaku
    {
        public GuardBuyDanmaku(DanmakuModel danmakuModel) : base(danmakuModel)
        {
            GiftCount = danmakuModel.GiftCount;
        }
        
        public int GiftCount { get; }
    }
}