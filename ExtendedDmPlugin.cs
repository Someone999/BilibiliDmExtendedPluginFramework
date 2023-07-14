using System;
using System.Runtime.InteropServices;
using BilibiliDM_PluginFramework;
using BilibiliDmExtendedPluginFramework.DanmakuTypes;
using BilibiliDmExtendedPluginFramework.Events;
using BilibiliDmExtendedPluginFramework.Events.EventArgs;
using HsManPluginFramework.Plugins;

namespace BilibiliDmExtendedPluginFramework
{
    public class ExtendedDmPlugin : DMPlugin
    {
        private PluginManager _pluginManager = new PluginManager();
        private EventDispatcher _eventDispatcher = new EventDispatcher();

        [DllImport("kernel32")]
        private static extern bool AllocConsole();
        public ExtendedDmPlugin()
        {
            try
            {
                AllocConsole();
                PluginName = "二次开发sdk插件的加载器";
                PluginCont = "QQ: 2668585799 B站: HS_Man";
                PluginAuth = "HS_Man";
                PluginVer = "1.0.0";
                _pluginManager.LoadPlugins();
                ReceivedDanmaku += (sender, args) =>
                {
                    
                    foreach (var pluginDomain in _pluginManager.GetPluginDomains())
                    {
                        Danmaku danmaku = DanmakuSelector.SelectByType(args.Danmaku.MsgType, args.Danmaku);
                        if (danmaku == null)
                        {
                            return;
                        }
                        
                        _eventDispatcher.DispatchDanmakuEvent
                            (pluginDomain.CurrentPlugin, args.Danmaku.MsgType, args.Danmaku.InteractType, danmaku);
                    }
                };
            
                ReceivedRoomCount += (sender, args) =>
                {
                    foreach (var pluginDomain in _pluginManager.GetPluginDomains())
                    {
                        _eventDispatcher.DispatchSystemEvent(pluginDomain.CurrentPlugin, new ReceivedRoomCountEventArgs((int)args.UserCount));
                    }
                };
            
                Connected += (sender, args) =>
                {
                    foreach (var pluginDomain in _pluginManager.GetPluginDomains())
                    {
                        _eventDispatcher.DispatchSystemEvent(pluginDomain.CurrentPlugin, new ConnectedEventArgs(args.roomid));
                    }
                };
            
                Disconnected += (sender, args) =>
                {
                    foreach (var pluginDomain in _pluginManager.GetPluginDomains())
                    {
                        _eventDispatcher.DispatchSystemEvent(pluginDomain.CurrentPlugin, new DisconnectedEventArgs(args.Error));
                    }
                };
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
           
        }
        
        
        
    }
}