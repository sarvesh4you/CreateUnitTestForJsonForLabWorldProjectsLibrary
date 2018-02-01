

namespace JsonForLabWorldProducts
{
    internal class JsonStructureBase
    {
        static protected readonly string ID = "{0}";
        static protected readonly string DEFAULT_TYPE = "{1}";
        static protected readonly string TYPE = "{3}";
        static protected readonly string NAME = "{4}";
        static protected readonly string PREFERED_VISUALISATION = "{6}";

        protected  string JsonModuleInformation =
        "{\n" +
        "\t\t\"ModuleId\": " + ID + ",\n" +
        "\t\t\"DefaultType\": " + DEFAULT_TYPE + ",\n" +
        "\t\t\"Type\": \"" + TYPE + "\",\n" +
        "\t\t\"ModuleName\": \"" + NAME + "\",\n" +
        "\t\t\"PreferedVisualisation\": " + PREFERED_VISUALISATION + "\n" +
        "\t}";



        /// <summary>
        /// This function writes attributes of common modules in a json-string.
        /// </summary>
        /// <param name="baseTypeDescription">The module's values.</param>
        /// <returns></returns>
        public string ModuleToJsonString(IToJsonAsBaseModule baseTypeDescription)
        {
            string info = JsonModuleInformation;
            info = info.Replace(ID, baseTypeDescription.ModuleId.ToString());
            info = info.Replace(DEFAULT_TYPE, ((int)baseTypeDescription.DefaultType).ToString());
            info = info.Replace(TYPE, baseTypeDescription.Type);
            info = info.Replace(NAME, baseTypeDescription.ModuleName);
            info = info.Replace(PREFERED_VISUALISATION, ((int)baseTypeDescription.PreferedVisualisation).ToString());

            return info;
        }
    }
}

