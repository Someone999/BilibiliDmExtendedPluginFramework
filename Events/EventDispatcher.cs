using BilibiliDM_PluginFramework;
using BilibiliDmExtendedPluginFramework.DanmakuTypes;
using BilibiliDmExtendedPluginFramework.Events.EventArgs;
using BilibiliDmExtendedPluginFramework.Events.EventRegistrations;
using HsManPluginFramework.Plugins;

namespace BilibiliDmExtendedPluginFramework.Events
{
    class EventDispatcher
    {
        public void DispatchDanmakuEvent(Plugin plugin, MsgTypeEnum msgTypeEnum, InteractTypeEnum interactTypeEnum,
            Danmaku danmaku)
        {
            var registration = plugin
                .PluginDomain
                .EventManager
                .GetEventRegistration<DanmakuEventRegistration>(r =>
                    r.SupportedInteractType == interactTypeEnum && r.SupportedMessageType == msgTypeEnum);

            registration?.EventHandler?.DynamicInvoke(danmaku);
        }

        public void DispatchSystemEvent<TEventArgs>(Plugin plugin, TEventArgs eventArgs)
            where TEventArgs : SystemEventArgs
        {
            var registration = plugin
                .PluginDomain
                .EventManager
                .GetEventRegistration<SystemEventRegistration>(
                    r => r.SystemEventArgType == typeof(TEventArgs));
            
            registration?.EventHandler?.DynamicInvoke(eventArgs);
        }
    }
}