using System.Collections.Generic;
using BilibiliDM_PluginFramework;

namespace BilibiliDmExtendedPluginFramework.DanmakuTypes
{
    [DanmakuType(MsgTypeEnum.GiftTop)]
    public class GiftTopDanmaku  : Danmaku
    {
        public GiftTopDanmaku(DanmakuModel danmakuModel) : base(danmakuModel)
        {
            GiftRanks = danmakuModel.GiftRanking;
        }

        private List<GiftRank> GiftRanks { get; }
    }
}