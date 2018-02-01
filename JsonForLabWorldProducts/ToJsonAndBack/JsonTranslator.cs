//using FullSerializer;
using LitJson;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace JsonForLabWorldProducts
{
    /// <summary>
    /// This class provides functions to translate modules and other server-data to json and to translate json back to data. 
    /// 
    /// Note:   It is bad design to have class that just holds functions (symtom: class-names that end with "...er"). 
    ///         Therefore, functionality might be integrated into another class in the long run.
    /// </summary>
    public class JsonTranslator
    {

        /// <summary>
        /// Creates a json-string in the format a server-answer should have.
        /// Note:   Not the fastest possible implementation, but will work well on a PC.
        /// </summary>
        /// <param name="Modules">A lit of modules. Might implement ITextModuleDescription, IModuleDescriptionBasic .</param>
        /// <returns></returns>
        public string CreateServerAnswer(List<object> Modules)
        {
            string doubleModules = string.Empty;
            string textModules = string.Empty;
            string pushButtonModules = string.Empty;

            foreach (object module in Modules)
            {
                if (module is IToJsonAsTextModule)
                {
                    if (textModules.Length > 0)
                        textModules += ",";
                    textModules += new JsonStructureText().ModuleToJsonString((IToJsonAsTextModule)module);
                }
                if (module is IToJsonAsDoubleModule)
                {
                    if (doubleModules.Length > 0)
                        doubleModules += ",";
                    doubleModules += new JsonStructureDouble().ModuleToJsonString((IToJsonAsDoubleModule)module);
                }
                if (module is IToJsonAsPushButtonModule)
                {
                    if (pushButtonModules.Length > 0)
                        pushButtonModules += ",";
                    pushButtonModules += new JsonStructurePushButton().ModuleToJsonString((IToJsonAsPushButtonModule)module);
                }
            }
            
            return new JsonStructureServerAnswer().AnswerToJsonString(doubleModules, textModules, pushButtonModules);
        }

        /// <summary>
        /// Translates a (json-)string that was send by the server to a ServerAnswerData-Object.
        /// </summary>
        /// <param name="serverAnswer"></param>
        /// <returns></returns>
        public ServerAnswerAsData ServerAnswerToData(string serverAnswer)
        {
            ServerAnswerAsData serverAnswerAsData = JsonMapper.ToObject<ServerAnswerAsData>(serverAnswer);
            return serverAnswerAsData;
        }
        /*
        /// <summary>
        /// Maps a single Module on a json-string.
        /// Note that 
        /// </summary>
        /// <param name="jsonString"></param>
        /// <returns></returns>
        protected ModuleDescriptionBase JsonStringToModuleDescription(string jsonString)
        {
            ModuleDescriptionBase moduleDescription = JsonMapper.ToObject<ModuleDescriptionBase>(jsonString);  
            return moduleDescription;
        }
        */
    }
}

