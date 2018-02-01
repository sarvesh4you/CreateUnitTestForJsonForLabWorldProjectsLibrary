namespace JsonForLabWorldProducts
{
    internal class JsonStructureDouble : JsonStructureBase
    {

        static protected readonly string VALUE = "{10}";
        static protected readonly string UNIT = "{11}";

        new protected string JsonModuleInformation =
        "{\n" +
        "\t\t\"ModuleId\": " + ID + ",\n" +
        "\t\t\"DefaultType\": " + DEFAULT_TYPE + ",\n" +
        "\t\t\"Type\": \"" + TYPE + "\",\n" +
        "\t\t\"ModuleName\": \"" + NAME + "\",\n" +
        "\t\t\"ModuleShownValue\": " + VALUE + ",\n" +
        "\t\t\"ModuleShownUnit\": \"" + UNIT + "\",\n" +
        "\t\t\"PreferedVisualisation\": " + PREFERED_VISUALISATION + "\n" +
        "\t}";


        /// <summary>
        /// This function writes attributes of a module in a json-string.
        /// </summary>
        /// <param name="moduleDescription">The module's values.</param>
        /// <returns></returns>
        public string ModuleToJsonString(IToJsonAsDoubleModule moduleDescription)
        {
            // Check if it works that way:
            // string info = base.ModuleToJsonString(moduleDescription);
            string info = "";
            info = JsonModuleInformation;
            info = info.Replace(ID, moduleDescription.ModuleId.ToString());
            info = info.Replace(DEFAULT_TYPE, ((int)moduleDescription.DefaultType).ToString());
            info = info.Replace(TYPE, moduleDescription.Type);
            info = info.Replace(NAME, moduleDescription.ModuleName);
            
            info = info.Replace(PREFERED_VISUALISATION, ((int)moduleDescription.PreferedVisualisation).ToString());


            info = info.Replace(VALUE, moduleDescription.ModuleShownValue.ToString());
            info = info.Replace(UNIT, moduleDescription.ModuleShownUnit);

            return info;
        }



    }
}
