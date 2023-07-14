using BilibiliDM_PluginFramework;

namespace BilibiliDmExtendedPluginFramework.DanmakuTypes
{
    [DanmakuType(MsgTypeEnum.SuperChat)]
    public class SuperChatDanmaku : Danmaku
    {
        public SuperChatDanmaku(DanmakuModel danmakuModel) : base(danmakuModel)
        {
            SuperChatPrice = danmakuModel.Price;
            SuperCahtKeepTime = danmakuModel.SCKeepTime;
        }
        
        public decimal SuperChatPrice { get; }
        public int SuperCahtKeepTime { get; }
        
    }
}