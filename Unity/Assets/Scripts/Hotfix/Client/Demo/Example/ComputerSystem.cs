namespace ET.Client
{
    [EntitySystemOf(typeof(Computer))]
    public static partial class ComputerSystem
    {
        [EntitySystem]
        private static void Awake(this ET.Client.Computer self)
        {

        }
        [EntitySystem]
        private static void Update(this ET.Client.Computer self)
        {

        }
        [EntitySystem]
        private static void Destroy(this ET.Client.Computer self)
        {

        }
    }
}