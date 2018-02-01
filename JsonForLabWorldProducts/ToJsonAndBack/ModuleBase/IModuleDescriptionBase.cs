

namespace JsonForLabWorldProducts
{
    /// <summary>
    /// Describes the basic values of most modules.
    /// </summary>
    public interface IToJsonAsBaseModule
    {
        /// <summary>
        /// The Ids in Labworldsoft are currently interger. We translate that to string here.
        /// </summary>
        int ModuleId { get; }
        /// <summary>
        /// The ModuleDefaultType indicates two things:
        /// 1: What kind of Value it should have (number, string, ect.)
        /// 2: A fallback option to visualize the Module if the Module-Type and PreferedVisualisation are not known.
        /// </summary>
        ModuleDefaultType DefaultType { get; }
        
        string ModuleName { get; }
        /// <summary>
        /// The specific type of the module.
        /// </summary>
        string Type { get; }
        
        /// <summary>
        /// The prefered visualisation indicate what kind of (graphical-) representation would be prefered by LabWorldSoft.
        /// The actual presentation (=visualisation) might differ, since the constraints and/or possibilities of a device 
        /// may call for a different kind of visualization.
        /// </summary>
        PreferedVisualisation PreferedVisualisation { get; }





    }
}

