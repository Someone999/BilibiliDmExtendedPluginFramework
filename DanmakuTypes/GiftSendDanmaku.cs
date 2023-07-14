using BilibiliDM_PluginFramework;

namespace BilibiliDmExtendedPluginFramework.DanmakuTypes
{
    [DanmakuType(MsgTypeEnum.GiftSend)]
    public class GiftSendDanmaku : Danmaku
    {
        public GiftSendDanmaku(DanmakuModel danmakuModel) : base(danmakuModel)
        {
            GiftCount = danmakuModel.GiftCount;
            GiftName = danmakuModel.GiftName;
        }
        
        public int GiftCount { get; }
        public string GiftName { get; }
        
    }
}