using System;
using System.Collections.Generic;
using System.IO;

namespace ET.Client
{
    [Event(SceneType.Main)]
    public class EntryEvent3_InitClient: AEvent<Scene, EntryEvent3>
    {
        protected override async ETTask Run(Scene root, EntryEvent3 args)
        {
            GlobalComponent globalComponent = root.AddComponent<GlobalComponent>();
            root.AddComponent<UIGlobalComponent>();
            root.AddComponent<UIComponent>();
            root.AddComponent<ResourcesLoaderComponent>();
            root.AddComponent<PlayerComponent>();
            root.AddComponent<CurrentScenesComponent>();
            root.AddComponent<ComputersComponent>();
            // 根据配置修改掉Main Fiber的SceneType
            SceneType sceneType = EnumHelper.FromString<SceneType>(globalComponent.GlobalConfig.AppType.ToString());
            root.SceneType = sceneType;
            // 所以可以走到AppStartInitFinish了
            await EventSystem.Instance.PublishAsync(root, new AppStartInitFinish());
            Log.Debug("Before TestEventStruct");
            // 类似于上面，抛一下TestEventStruct
            // 用构造函数赋下值
            await EventSystem.Instance.PublishAsync(root, new TestEventStruct()
            {
                TestValue = 1,
            });
            Log.Debug("After TestEventStruct");
        }
    }
}