namespace JsonForLabWorldProducts
{
    /// <summary>
    /// Describes the basic values of most modules.
    /// </summary>
    public class ModuleDescriptionBase : IToJsonAsBaseModule, IChangesToJsonAsBaseModule
    {
        /// <summary>
        /// The ID of any module as defined by LabWorldSoft.
        /// </summary>
        public int ModuleId { get; set; }
        /// <summary>
        /// The ModuleDefaultType indicates two things:
        /// 1: What kind of Value it should have (number, string, ect.)
        /// 2: A fallback option to visualize the Module if the Module-Type and PreferedVisualisation are not known.
        /// Note: might become unnecessary due to the use of interfaces and grouping of types in json-arrays.
        /// </summary>
        public ModuleDefaultType DefaultType { get; set; }
        
        /// <summary>
        /// The name of a certain module. 
        /// Unlike the type, the name might be displayed to the user.
        /// The name is not be used for identification, so changing or translating it during runtime should cause no problems.
        /// </summary>
        public string ModuleName { get; set; }
        /// <summary>
        /// The specific type of the module.
        /// Not used much, yet.
        /// </summary>
        public string Type { get; set; }
        
        /// <summary>
        /// The prefered visualisation indicate what kind of (graphical-) representation would be prefered by LabWorldSoft.
        /// The actual presentation (=visualisation) might differ, since the constraints and/or possibilities of a device 
        /// may call for a different kind of visualization.
        /// </summary>
        public PreferedVisualisation PreferedVisualisation { get; set; }

        public ModuleDescriptionBase(int moduleId = 0, string name = "", string type = "", double value = 0)
        {
            ModuleId = moduleId;
            ModuleName = name;
            Type = type;
            DefaultType = 0;
            PreferedVisualisation = 0;
        }
        public ModuleDescriptionBase()
        {
            ModuleId = 0;
            ModuleName = "";
            Type = "";
            DefaultType = 0;
            PreferedVisualisation = 0;
        }


        /// <summary>
        /// used for Unit-Tests
        /// </summary>
        public override bool Equals(object obj)
        {
            return Equals(obj as IToJsonAsBaseModule);
        }

        /// <summary>
        /// used for Unit-Tests
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public bool Equals(IToJsonAsBaseModule obj)
        {
            return
                obj != null &&
                obj.DefaultType == this.DefaultType &&
                obj.ModuleId == this.ModuleId &&
                obj.ModuleName == this.ModuleName &&
                obj.PreferedVisualisation == this.PreferedVisualisation &&
                obj.Type == this.Type
                
                ;
           // Or whatever you think qualifies as the objects being equal.
        }


    }

}