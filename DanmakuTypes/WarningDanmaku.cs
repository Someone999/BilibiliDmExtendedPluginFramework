using BilibiliDM_PluginFramework;

namespace BilibiliDmExtendedPluginFramework.DanmakuTypes
{
    [DanmakuType(MsgTypeEnum.Warning)]
    public class WarningDanmaku : Danmaku
    {
        public WarningDanmaku(DanmakuModel danmakuModel) : base(danmakuModel)
        {
            Comment = danmakuModel.CommentText;
        }
        
        public string Comment { get; }
    }
}