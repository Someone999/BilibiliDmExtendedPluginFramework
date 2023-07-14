using System;
using HsManPluginFramework.Events;
using HsManPluginFramework.Events.EventRegistrations;

namespace BilibiliDmExtendedPluginFramework.Events.EventRegistrations
{
    class SystemEventRegistration : EventRegistration
    {
        public Type SystemEventArgType { get; internal set; }

        public override bool IsSameRegistration(EventRegistration registration)
        {
            if (!(registration is SystemEventRegistration systemEventRegistration))
            {
                return false;
            }

            return systemEventRegistration.SystemEventArgType == SystemEventArgType;
        }

        public SystemEventRegistration(EventType eventType, Delegate eventHandler, Type systemEventArgType) : base(
            eventType, eventHandler)
        {
            SystemEventArgType = systemEventArgType;
        }
    }
}