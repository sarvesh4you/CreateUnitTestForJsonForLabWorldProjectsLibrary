namespace JsonForLabWorldProducts
{
    /// <summary>
    /// Describes classes that can be translated to json as a module with a double-value and perhaps a unit.
    /// </summary>
    public interface IToJsonAsDoubleModule : IToJsonAsBaseModule
    {

        /// <summary>
        /// Value of the Module. Often a Number. This attribute will need to be expanded uppon in the future.
        /// Note: Currently the Value is of type double. That might change.
        /// </summary>
        double ModuleShownValue { get; }

        /// <summary>
        /// A Unit, like "V" for "Volt" or more complicated things like "mA/m²".
        /// </summary>
        string ModuleShownUnit { get; }

    }
}
