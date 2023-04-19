namespace TemplateDDD.Core.Utility
{
    public class ENV
    {
        public static readonly string INTERSWITCH_WEBHOOK = System.Environment.GetEnvironmentVariable("INTERSWITCH_WEBHOOK", EnvironmentVariableTarget.Machine);
    }
}