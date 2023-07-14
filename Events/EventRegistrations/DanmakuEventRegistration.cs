using System;
using BilibiliDM_PluginFramework;
using HsManPluginFramework.Events;
using HsManPluginFramework.Events.EventRegistrations;

namespace BilibiliDmExtendedPluginFramework.Events.EventRegistrations
{
    public class DanmakuEventRegistration : EventRegistration
    {
        public MsgTypeEnum SupportedMessageType { get; set; }
        public InteractTypeEnum SupportedInteractType { get; set; }

        public override bool IsSameRegistration(EventRegistration registration)
        {
            if (!(registration is DanmakuEventRegistration danmakuEventRegistration))
            {
                return false;
            }

            var equals = danmakuEventRegistration.SupportedMessageType == SupportedMessageType;

            if (danmakuEventRegistration.SupportedMessageType == MsgTypeEnum.Interact)
            {
                equals = equals && danmakuEventRegistration.SupportedInteractType == SupportedInteractType;
            }

            return equals;
        }

        public DanmakuEventRegistration(EventType eventType, Delegate eventHandler) : base(eventType, eventHandler)
        {
        }
    }
}