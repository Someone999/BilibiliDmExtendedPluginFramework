using BilibiliDM_PluginFramework;

namespace BilibiliDmExtendedPluginFramework.DanmakuTypes
{
    [DanmakuType(MsgTypeEnum.Interact)]
    public class InteractDanmaku : Danmaku
    {
        public InteractDanmaku(DanmakuModel danmakuModel) : base(danmakuModel)
        {
            InteractType = danmakuModel.InteractType;
        }
        
        public InteractTypeEnum InteractType { get; }
    }
}