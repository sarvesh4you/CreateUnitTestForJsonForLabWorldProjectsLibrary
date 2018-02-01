namespace JsonForLabWorldProducts
{
    /// <summary>
    /// The json-structure of the complete Server-Answer
    /// </summary>
    internal class JsonStructureServerAnswer
    {
        static protected readonly string MODULES_DOUBLE = "{0}";
        static protected readonly string MODULES_TEXT = "{1}";
        static protected readonly string MODULES_PUSH_BUTTON = "{3}";

        protected readonly string JsonAnswerStructure =
            "{\n" +
            "\"ModulesDouble\":[\n" +       MODULES_DOUBLE      + "\n],\n" +
            "\"ModulesText\":[\n" +         MODULES_TEXT        + "\n],\n" +
            "\"ModulesPushButton\":[\n" +   MODULES_PUSH_BUTTON + "\n]\n" +
            "\n}";
        public string AnswerToJsonString(string modulesDouble, string modulesText, string modulesPushButton)
        {
            string info = JsonAnswerStructure;
            info = info.Replace(MODULES_DOUBLE, modulesDouble);
            info = info.Replace(MODULES_TEXT, modulesText);
            info = info.Replace(MODULES_PUSH_BUTTON, modulesPushButton);

            return info;
        }
    }
}
