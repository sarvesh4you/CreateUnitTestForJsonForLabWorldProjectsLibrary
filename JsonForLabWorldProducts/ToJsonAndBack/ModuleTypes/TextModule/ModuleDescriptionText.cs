namespace JsonForLabWorldProducts
{
    /// <summary>
    /// Describes the basic values of modules that contain text.
    /// This applies to device-modules, math-operator-modules and others.
    /// </summary>
    public class ModuleDescriptionText : ModuleDescriptionBase, IToJsonAsTextModule
    {
        /// <summary>
        /// Value of the Module. 
        /// </summary>
        public string Value { get; set; }

        //public ModuleDescriptionText(int id = 0, string name = "", string unit = "", string type = "", string value = "")
        //{
        //    ModuleId = id;
        //    ModuleName = name;
        //    Type = type;
        //    Value = value;
        //    DefaultType = 0;
        //    PreferedVisualisation = 0;
        //}
        public ModuleDescriptionText()
        {
            ModuleId = 0;
            ModuleName = "";
            Type = "";
            Value = "";
            DefaultType = 0;
            PreferedVisualisation = 0;
        }
    };
}