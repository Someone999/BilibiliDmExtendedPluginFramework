using System;
using System.Collections.Generic;
using System.Reflection;
using BilibiliDM_PluginFramework;
using HsManCommonLibrary.Reflections;

namespace BilibiliDmExtendedPluginFramework.DanmakuTypes
{
    public static class DanmakuSelector
    {
        private static Dictionary<MsgTypeEnum, Type> _typesMap;
        private static void Init()
        {
            ReflectionAssemblyManager.AddAssembly(typeof(DanmakuSelector).Assembly);
            var types = ReflectionAssemblyManager.CreateAssemblyTypeCollection().GetSubTypesOf<Danmaku>();
            _typesMap = new Dictionary<MsgTypeEnum, Type>();
            foreach (var type in types)
            {
                var attr = type.GetCustomAttribute<DanmakuTypeAttribute>();
                if (attr == null)
                {
                    throw new InvalidOperationException();
                }
                
                _typesMap.Add(attr.DanmakuType, type);
            }
            
        }

        private static object _staticLocker = new object();
        public static Danmaku SelectByType(MsgTypeEnum msgTypeEnum, DanmakuModel model)
        {
            lock (_staticLocker)
            {
                if (_typesMap == null)
                {
                    Init();
                }
            }

            if (msgTypeEnum == MsgTypeEnum.Unknown)
            {
                return null;
            }
            
            var type = _typesMap?[msgTypeEnum];

            return (Danmaku)type?.
                GetConstructor(new Type[] { typeof(DanmakuModel) })
                ?.Invoke(new object[]{model});
        }
    }
}