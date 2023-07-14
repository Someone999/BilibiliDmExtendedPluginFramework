using System;

namespace BilibiliDmExtendedPluginFramework.Events.EventArgs
{
    public class DisconnectedEventArgs : SystemEventArgs
    {
        public DisconnectedEventArgs(Exception exception)
        {
            Exception = exception;
        }

        public Exception Exception { get; }
    }
}