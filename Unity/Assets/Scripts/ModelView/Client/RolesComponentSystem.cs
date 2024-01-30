namespace ET.Client
{
    [EntitySystemOf(typeof(RolesComponent))]
    [FriendOf(typeof(RolesComponent))]
    public static partial class RolesComponentSystem
    {
        [EntitySystem]
        private static void Awake(this RolesComponent self)
        {
            
        }

        public static void Invoke(this RolesComponent self)
        {
            Log.Debug($"{self.MaxCount.ToString()}");
        }
    }
}
