using System.Collections.Generic;
using System.Linq;
using BilibiliDM_PluginFramework;
using BilibiliDmExtendedPluginFramework.DanmakuTypes;
using BilibiliDmExtendedPluginFramework.Events.EventArgs;
using BilibiliDmExtendedPluginFramework.Events.EventRegistrations;
using HsManPluginFramework.Events;
using HsManPluginFramework.Events.EventRegistrations;

namespace BilibiliDmExtendedPluginFramework.Events
{
    public class EventManager
    {
        private List<EventRegistration> _eventRegistrations = new List<EventRegistration>();

        public void RegisterDanmakuEvent<TDanmaku>(MsgTypeEnum supportedType, InteractTypeEnum supportedInteractType,
            PluginEventHandler<TDanmaku> handler) where TDanmaku : Danmaku
        {
            EventRegistration registration = new DanmakuEventRegistration(EventType.DanmakuEvent, handler)
            {
                SupportedMessageType = supportedType,
                SupportedInteractType = supportedType == MsgTypeEnum.Interact ? supportedInteractType : 0,
            };

            if (_eventRegistrations.Any(r => r.IsSameRegistration(registration)))
            {
                return;
            }

            _eventRegistrations.Add(registration);
        }

        public void RegisterSystemEvent<TEventArgs>(PluginEventHandler<TEventArgs> eventHandler)
            where TEventArgs : SystemEventArgs
        {
            EventRegistration eventRegistration =
                new SystemEventRegistration(EventType.SystemEvent, eventHandler, typeof(TEventArgs));

            if (_eventRegistrations.Any(r => r.IsSameRegistration(eventRegistration)))
            {
                return;
            }

            _eventRegistrations.Add(eventRegistration);

        }

        internal EventRegistration GetDanmakuEvent(MsgTypeEnum msgType, InteractTypeEnum interactType)
        {
            return _eventRegistrations.FirstOrDefault
            (r =>
            {
                if (!(r is DanmakuEventRegistration danmakuEventRegistration))
                {
                    return false;
                }

                return danmakuEventRegistration.SupportedInteractType == interactType &&
                       danmakuEventRegistration.SupportedMessageType == msgType;
            });
        }


        internal EventRegistration GetSystemEvent<TEventArgs>()
        {
            return _eventRegistrations.FirstOrDefault
            (r =>
            {
                if (!(r is SystemEventRegistration systemEventRegistration))
                {
                    return false;
                }

                return systemEventRegistration.SystemEventArgType == typeof(TEventArgs);
            });
        }

        internal void RaiseDanmakuEvent(MsgTypeEnum msgType, InteractTypeEnum interactType, Danmaku danmaku)
        {
            GetDanmakuEvent(msgType, interactType)?.EventHandler?.DynamicInvoke(danmaku);
        }

        internal void RaiseSystemEvent<TEventArgs>(TEventArgs eventArgs)
            where TEventArgs : SystemEventArgs
        {
            GetSystemEvent<TEventArgs>()?.EventHandler?.DynamicInvoke(eventArgs);
        }

    }
}