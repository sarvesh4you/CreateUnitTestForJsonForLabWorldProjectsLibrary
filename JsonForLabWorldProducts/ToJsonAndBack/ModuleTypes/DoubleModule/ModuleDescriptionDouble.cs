namespace JsonForLabWorldProducts
{
    /// <summary>
    /// Describes the values of any modules that have floating-point value and possibly a Unit (like "kg/m²").
    /// </summary>
    public class ModuleDescriptionDouble : ModuleDescriptionBase, IToJsonAsDoubleModule
    {
        /// <summary>
        /// Value of the Module. 
        /// </summary>
        public double ModuleShownValue { get; set; }

        /// <summary>
        /// A Unit, like "V" for "Volt" or more complicated things like "mA/m²".
        /// </summary>
        public string ModuleShownUnit { get; set; }

        public ModuleDescriptionDouble()
        {
            ModuleId = 0;
            ModuleName = "";
            ModuleShownUnit = "";
            Type = "";
            ModuleShownValue = 0;
            DefaultType = 0;
            PreferedVisualisation = 0;
        }
    };
}
