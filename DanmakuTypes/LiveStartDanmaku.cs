using BilibiliDM_PluginFramework;

namespace BilibiliDmExtendedPluginFramework.DanmakuTypes
{
    [DanmakuType(MsgTypeEnum.LiveStart)]
    public class LiveStartDanmaku : Danmaku
    {
        public LiveStartDanmaku(DanmakuModel danmakuModel) : base(danmakuModel)
        {
            RoomId = danmakuModel.roomID;
        }
        
        public string RoomId { get; }
    }
}