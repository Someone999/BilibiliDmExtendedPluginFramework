namespace BilibiliDmExtendedPluginFramework.Events.EventArgs
{
    public class ReceivedRoomCountEventArgs : SystemEventArgs
    {
        public ReceivedRoomCountEventArgs(int userCount)
        {
            UserCount = userCount;
        }

        public int UserCount { get; }
    }
}