namespace JsonForLabWorldProducts
{
    /// <summary>
    /// Describes the basic values of most modules.
    /// 
    /// Note:   Curently, this interface is implemented by a simple struct.
    ///         But it can also be implemented by module-classes themselves.
    /// </summary>
    public interface IToJsonAsTextModule:IToJsonAsBaseModule
    {
        
        /// <summary>
        /// Text-Value of the Module.
        /// </summary>
        string Value { get; }

    }
}

