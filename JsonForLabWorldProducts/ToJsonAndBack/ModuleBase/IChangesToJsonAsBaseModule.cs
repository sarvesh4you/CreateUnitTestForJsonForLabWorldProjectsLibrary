
namespace JsonForLabWorldProducts
{
    /// <summary>
    /// Describes those values of most modules that will change while the experiment runs.
    /// Will be used to minimize network-trafic after the full Module has been described once.
    /// </summary>
    public interface IChangesToJsonAsBaseModule
    {
        /// <summary>
        /// The Id will not change, but is necessary to identify the module.
        /// </summary>
        int ModuleId { get; }
        
    }
}
