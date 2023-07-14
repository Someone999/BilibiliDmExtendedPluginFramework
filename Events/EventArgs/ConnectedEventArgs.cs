namespace BilibiliDmExtendedPluginFramework.Events.EventArgs
{
    public class ConnectedEventArgs : SystemEventArgs
    {
        public ConnectedEventArgs(int roomId)
        {
            RoomId = roomId;
        }

        public int RoomId { get; }
    }
}