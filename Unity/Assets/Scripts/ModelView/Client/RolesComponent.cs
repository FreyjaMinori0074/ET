namespace ET.Client
{
    [ComponentOf(typeof (Scene))]
    public class RolesComponent: Entity, IAwake
    {
        public int MaxCount = 5;
    }
}