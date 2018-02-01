using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JsonForLabWorldProducts
{
    /// <summary>
    /// Describes the values of any push-button-modules. 
    /// Note: A "push-button" is a button that does not switch states, it simply can be pushed.
    /// </summary>
    public interface IToJsonAsPushButtonModule : IToJsonAsBaseModule
    {
        // no values beyond the base-class are needed. This interface is necessary never the less.
    }
}
