namespace JsonForLabWorldProducts
{
    /// <summary>
    /// The ModuleDefaultType indicates two things:
    /// 1: What kind of Value it should have (number, string, ect.)
    /// 2: A fallback option to visualize the Module if the Module-Type and PreferedVisualisation are not known.
    /// </summary>
    public enum ModuleDefaultType
    {
        number,
        text,
        pushButton
    }

    /// <summary>
    /// The prefered visualisation indicate what kind of (graphical-) representation would be prefered.
    /// The actual presentation (=visualisation) might differ, since the constraints and/or possibilities of a device 
    /// may call for a different kind of visualization.
    /// </summary>
    public enum PreferedVisualisation
    {
        number,
        graph,
        timer,
        pushButton,
        text
    }
}

