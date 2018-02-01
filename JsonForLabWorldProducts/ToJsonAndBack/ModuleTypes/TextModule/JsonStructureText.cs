namespace JsonForLabWorldProducts
{
    internal class JsonStructureText : JsonStructureBase
    {

        static protected readonly string VALUE = "{10}";


        new protected string JsonModuleInformation =
        "{\n" +
        "\t\t\"ModuleId\": " + ID + ",\n" +
        "\t\t\"DefaultType\": " + DEFAULT_TYPE + ",\n" +
        "\t\t\"Type\": \"" + TYPE + "\",\n" +
        "\t\t\"ModuleName\": \"" + NAME + "\",\n" +
        "\t\t\"Value\": \"" + VALUE + "\",\n" +
        "\t\t\"PreferedVisualisation\": " + PREFERED_VISUALISATION + "\n" +
        "\t}";


        /// <summary>
        /// This function writes attributes of a module in a json-string.
        /// </summary>
        /// <param name="moduleDescription">The module's values.</param>
        /// <returns></returns>
        public string ModuleToJsonString(IToJsonAsTextModule moduleDescription)
        {
            string info = string.Empty;

            info = JsonModuleInformation;
            info = info.Replace(ID, moduleDescription.ModuleId.ToString());
            info = info.Replace(DEFAULT_TYPE, ((int)moduleDescription.DefaultType).ToString());
            info = info.Replace(TYPE, moduleDescription.Type);
            info = info.Replace(NAME, moduleDescription.ModuleName);
            info = info.Replace(VALUE, moduleDescription.Value);
            info = info.Replace(PREFERED_VISUALISATION, ((int)moduleDescription.PreferedVisualisation).ToString());

            return info;
        }



    }
}