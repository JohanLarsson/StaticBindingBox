namespace StaticBindingBox
{
    using System.Windows;

    public static class Keys
    {
        public static ComponentResourceKey CurrentValueKey { get; } = new ComponentResourceKey(typeof(Keys),"CurrentValue");
    }
}
