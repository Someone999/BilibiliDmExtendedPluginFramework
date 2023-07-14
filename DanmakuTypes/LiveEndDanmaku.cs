using BilibiliDM_PluginFramework;

namespace BilibiliDmExtendedPluginFramework.DanmakuTypes
{
    [DanmakuType(MsgTypeEnum.LiveEnd)]
    public class LiveEndDanmaku : Danmaku
    {
        public LiveEndDanmaku(DanmakuModel danmakuModel) : base(danmakuModel)
        {
            RoomId = danmakuModel.roomID;
        }

        public string RoomId { get; }
    }
}