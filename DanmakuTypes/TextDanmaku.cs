using BilibiliDM_PluginFramework;

namespace BilibiliDmExtendedPluginFramework.DanmakuTypes
{
    [DanmakuType(MsgTypeEnum.Comment)]
    public class TextDanmaku : Danmaku
    {
        public TextDanmaku(DanmakuModel danmakuModel) : base(danmakuModel)
        {
            Content = danmakuModel.CommentText;
        }
        
        public string Content { get; }
    }
}