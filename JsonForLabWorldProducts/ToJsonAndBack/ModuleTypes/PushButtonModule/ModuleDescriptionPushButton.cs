namespace JsonForLabWorldProducts
{
    /// <summary>
    /// Describes the basic values of push-botton-modules.
    /// </summary>
    public class ModuleDescriptionPushButton : ModuleDescriptionBase, IToJsonAsPushButtonModule
    {
        public ModuleDescriptionPushButton()
        {
            ModuleId = 0;
            ModuleName = "";
            Type = "";
            DefaultType = 0;
            PreferedVisualisation = 0;
        }
    }
}
