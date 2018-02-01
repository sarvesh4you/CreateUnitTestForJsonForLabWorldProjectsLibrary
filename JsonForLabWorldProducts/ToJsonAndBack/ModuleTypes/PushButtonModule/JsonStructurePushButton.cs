namespace JsonForLabWorldProducts
{
    internal class JsonStructurePushButton : JsonStructureBase
    {

        public string ModuleToJsonString(IToJsonAsPushButtonModule baseTypeDescription)
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
