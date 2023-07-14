using HsManCommonLibrary.ValueHolders;

namespace BilibiliDmExtendedPluginFramework.Users
{
    public class User
    {
        public long UserId { get; internal set; }
        public string UserName { get;  internal set; }
        public ValueHolder<bool> IsVip { get; internal set; } = new ValueHolder<bool>();
        public ValueHolder<bool> IsAdmin { get; internal set; } = new ValueHolder<bool>();
        public ValueHolder<UserGuardLevel> GuardLevel { get; internal set; }
    }
}