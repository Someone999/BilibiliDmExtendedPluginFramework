using System.Diagnostics;

namespace BilibiliDmExtendedPluginFramework
{
    public class Program
    {
        static void Main(string[] args)
        {
            var x = Process.GetProcessById(96444).MainWindowHandle;

        }
    }
}