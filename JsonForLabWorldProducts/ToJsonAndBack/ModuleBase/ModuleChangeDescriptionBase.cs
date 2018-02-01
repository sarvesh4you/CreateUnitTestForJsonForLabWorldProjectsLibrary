namespace JsonForLabWorldProducts
{
    /// <summary>
    /// Will be used to minimize network-trafic after the full Module has been described once.
    /// </summary>
    public struct ModuleChangeDescriptionBase : IChangesToJsonAsBaseModule
    {
        /// <summary>
        /// The Id will not change, but is necessary to identify the module.
        /// </summary>
        public int ModuleId { get; set; }
        /// <summary>
        /// Note: currently the Value is of type double. That might change.
        /// </summary>
        public double Value { get; set; }
    };
}