using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JsonForLabWorldProducts
{
    /// <summary>
    /// use this class if you want the aswer of your Server as a big data-class.
    /// </summary>
    public class ServerAnswerAsData
    {
        /// <summary>
        /// All Modules that have a floating-point value and possibly a unit.
        /// Note: The name(!) of this list must be identical to the coresponding array in json.  
        /// </summary>
        public List<ModuleDescriptionDouble> ModulesDouble = new List<ModuleDescriptionDouble>();
        /// <summary>
        /// All Modules that only contain text.
        /// Note: The name(!) of this list must be identical to the coresponding array in json. 
        /// </summary>
        public List<ModuleDescriptionText> ModulesText = new List<ModuleDescriptionText>();
        /// <summary>
        /// All push-button modules.
        /// Note: The name(!) of this list must be identical to the coresponding array in json. 
        /// </summary>
        public List<ModuleDescriptionPushButton> ModulesPushButton = new List<ModuleDescriptionPushButton>();


        /// <summary>
        /// Not fast, only for unit-tests.
        /// </summary>
        /// <returns></returns>
        public List<object> combinedListOfAllModules()
        {
            List<object> result = new List<object>();
            result.AddRange(ModulesDouble.Cast<object>());
            result.AddRange(ModulesText.Cast<object>());
            result.AddRange(ModulesPushButton.Cast<object>());
            return result;
        }
    }
}
