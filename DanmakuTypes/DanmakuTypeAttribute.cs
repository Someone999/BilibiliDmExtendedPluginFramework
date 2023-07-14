using System;
using BilibiliDM_PluginFramework;

namespace BilibiliDmExtendedPluginFramework.DanmakuTypes
{
    public class DanmakuTypeAttribute : Attribute
    {
        public DanmakuTypeAttribute(MsgTypeEnum danmakuType)
        {
            DanmakuType = danmakuType;
        }

        public MsgTypeEnum DanmakuType { get; }
    }
}